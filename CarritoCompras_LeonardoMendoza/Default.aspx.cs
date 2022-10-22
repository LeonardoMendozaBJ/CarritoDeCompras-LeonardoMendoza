using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;

namespace CarritoCompras_LeonardoMendoza
{
    public partial class _Default : System.Web.UI.Page
    {
        public List<Articulo> ListaArticulos { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();

            if (Session["filtro"] != null)
            {
                string campo = Session["campo"].ToString();
                string criterio = Session["criterio"].ToString();
                string filtro = Session["filtro"].ToString();

                ListaArticulos = negocio.filtrar(campo, criterio, filtro);

            }
            else { ListaArticulos = negocio.listar(); }


            if (!IsPostBack)
            {
                repRepetidor.DataSource = ListaArticulos;
                repRepetidor.DataBind();
                ddlCampo.Items.Add("Precio");
                ddlCampo.Items.Add("Nombre");
                ddlCampo.Items.Add("Descripcion");
                ddlCampo.Items.Add("Marca");
                ddlCampo.Items.Add("Categoria");
                ddlCriterio.Items.Add("Precio Mayor a");
                ddlCriterio.Items.Add("Precio Menor a");
                ddlCriterio.Items.Add("Comienza con");
                ddlCriterio.Items.Add("Termina con");

            }



            int contador = 0;
            if (Session["ListaCarrito"] == null)
            {
                ArtCarritoNegocio negocioCarrito = new ArtCarritoNegocio();
                Session.Add("ListaCarrito", negocioCarrito.listar());
                lblContador.Text = "UNIDADES EN CARRITO DE COMPRAS: " + contador.ToString();

            }
            List<ArtCarrito> listaSession = new List<ArtCarrito>();
            listaSession = (List<ArtCarrito>)Session["ListaCarrito"];
            foreach (var item in listaSession)
            {

                contador++;
            }
            lblContador.Text = "UNIDADES EN CARRITO DE COMPRAS: " + contador.ToString();

  

        }

        protected void dgvArticulos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }




        protected void btnAgregarCarrito_Click(object sender, EventArgs e)
        {
            ArtCarrito nuevo = new ArtCarrito();
            int Id = int.Parse(((Button)sender).CommandArgument);

            Articulo art = new Articulo();
            ArticuloNegocio ArtNegocio = new ArticuloNegocio();
            List<Articulo> lista = ArtNegocio.listar();

            foreach (var item in lista)
            {
                if (item.Id == Id)
                {
                    nuevo.Id = item.Id;
                    nuevo.Codigo = item.Codigo;
                    nuevo.Nombre = item.Nombre;
                    nuevo.Precio = item.Precio;
                }
            }
            /*List<ArtCarrito> ListaCarrito = (List<ArtCarrito>)Session["ListaCarrito"]; */
            List<ArtCarrito> ListaCarrito = ListaSessionCarrito();
            ListaCarrito.Add(nuevo);
           Response.Redirect("Default.aspx");
            



        }
        private List<ArtCarrito> ListaSessionCarrito()
        {
            List<ArtCarrito> artCarritos = Session["ListaCarrito"] != null ?
              (List<ArtCarrito>)Session["ListaCarrito"] : new List<ArtCarrito>();
            return artCarritos;
        }

        protected void btnVerDetalle_Click(object sender, EventArgs e)
        {
            int Id = int.Parse(((Button)sender).CommandArgument);
            Response.Redirect("Detalle.aspx?Id=" + Id);
        }

        protected void btnFiltro_Click(object sender, EventArgs e)
        {

            if (txtFiltro.Text != null)
            {
                string filtro = txtFiltro.Text;
                string campo = ddlCampo.SelectedValue.ToString();
                string criterio = ddlCriterio.SelectedValue.ToString();
                Session.Add("filtro", filtro);
                Session.Add("campo", campo);
                Session.Add("criterio", criterio);
            }

            /*Response.Redirect("Default.aspx", false);*/
        }

        protected void lblContador_Click(object sender, EventArgs e)
        {
            Response.Redirect("CarritoCompra.aspx");
        }
    }
}