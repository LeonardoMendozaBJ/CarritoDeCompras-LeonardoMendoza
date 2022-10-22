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
    public partial class CarritoCompra : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["ListaCarrito"] == null)
            {
                ArtCarritoNegocio negocio = new ArtCarritoNegocio();
                Session.Add("ListaCarrito", negocio.listar());

            }


            dgvArticulos.DataSource = Session["ListaCarrito"];
            dgvArticulos.DataBind();

            List<ArtCarrito> listaSession = new List<ArtCarrito>();
            listaSession = (List<ArtCarrito>)Session["ListaCarrito"];
            decimal total = 0;
            lblPrecio.Text = "TOTAL: $" + total;

        }

        protected void dgvArticulos_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = (int)dgvArticulos.SelectedDataKey.Value;

            List<ArtCarrito> listaSession = new List<ArtCarrito>();

            listaSession = (List<ArtCarrito>)Session["ListaCarrito"];
            ArtCarrito Seleccionado = listaSession.Find(x => x.Id == id);

            listaSession.Remove(Seleccionado);
            Session["ListaCarrito"] = listaSession;

            dgvArticulos.DataSource = Session["ListaCarrito"];
            dgvArticulos.DataBind();
            decimal total = 0;
            int contador = 0;
            foreach (var item in listaSession)
            {
                total += item.Precio;
                contador++;
            }
            lblPrecio.Text = "TOTAL: $" + total;

        }
    }
}