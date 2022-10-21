<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Detalle.aspx.cs" Inherits="CarritoCompras_LeonardoMendoza.Detalle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <h1> -- Detalle De Articulo -- </h1>
    <hr /> 
        <div>
        <asp:Image ImageUrl="imageurl" runat="server" ID ="ImagenURL" />
        </div>
    <div>
        <asp:Label Text="ID" runat="server" ID ="lblId" />
    </div>
    <div>
        <asp:Label Text="Codigo" runat="server" ID="lblcodigo"/>
    </div>
        <div>
        <asp:Label Text="Nombre" runat="server" ID="lblNombre" />
            </div>
        <div>
        <asp:Label Text="Descripcion" runat="server" ID="lblDescripcion" />
            </div>
        <div>
        <asp:Label Text="Marca" runat="server" ID ="lblMarca" />
            </div>  
        <div>
        <asp:Label Text="Categoria" runat="server" ID ="lblCategoria" />
             </div>  
        <div>
        <asp:Label Text="Precio" runat="server" ID="lblPrecio"/>

            <hr />  
    </div>

</asp:Content>
