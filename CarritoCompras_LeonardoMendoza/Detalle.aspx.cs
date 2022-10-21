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
    public partial class Detalle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Request.QueryString["id"] != null)
            {
                int id = int.Parse(Request.QueryString["id"].ToString());
                ArticuloNegocio negocio = new ArticuloNegocio();

                Articulo Seleccionado = negocio.listar().Find(x => x.Id == id);

                ImagenURL.ImageUrl = Seleccionado.ImagenURL;
                lblId.Text = "ID de Articulo: " + Seleccionado.Id.ToString();
                lblcodigo.Text = "Codigo de Articulo: " + Seleccionado.Codigo;
                lblNombre.Text = "Nombre: " + Seleccionado.Nombre;
                lblDescripcion.Text = "Descripción: " + Seleccionado.Descripcion;
                lblMarca.Text = "Marca: " + Seleccionado.Marca.Descripcion;
                lblCategoria.Text = "Categoria: " + Seleccionado.Categoria.Descripcion;
                lblPrecio.Text = "Precio: " + Seleccionado.Precio.ToString();
            }


        }
    }
}