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

            repRepetidor.DataSource = ListaArticulos;
            repRepetidor.DataBind();


        }

        protected void dgvArticulos_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}