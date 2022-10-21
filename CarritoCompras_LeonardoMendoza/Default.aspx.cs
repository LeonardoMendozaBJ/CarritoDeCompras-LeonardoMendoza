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
         
            ListaArticulos = negocio.listar();

            if (!IsPostBack)
            {
                repRepetidor.DataSource = ListaArticulos;
                repRepetidor.DataBind();

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
                Response.Redirect("CarritoCompra.aspx");
            


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

     
    }
}