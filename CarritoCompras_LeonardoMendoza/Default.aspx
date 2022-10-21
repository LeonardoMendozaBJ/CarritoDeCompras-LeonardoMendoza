<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CarritoCompras_LeonardoMendoza._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

   <%-- <style>
        .oculto{
            display: none;
        }

    </style>
   --%>

<div class="row row-cols-1 row-cols-md-3 g-4 offcanvas-header">
    
    <asp:Repeater runat="server" ID ="repRepetidor">
        <ItemTemplate>
    <div class ="col well">
   <div class="card"> 
  <img src="<%#Eval("ImagenURL") %>" class="card-img-top" width="200"  alt="">
  <div class="card-body jumbotron center-block">
    <h5 class="card-title h3"><%#Eval("Nombre") %></h5>
    <p class="card-text"><%#Eval("Descripcion") %></p>
      <p class="card-text h3"><%#Eval("Precio") %></p>
    
      <asp:Button ID="btnVerDetalle" Text="Ver Detalle" runat="server" OnClick="btnVerDetalle_Click" class="btn btn-primary btn-warning" CommandArgument='<%#Eval("Id") %>' CommandName="ArtId"/>
      <asp:Button ID="btnAgregarCarrito" Text="Agregar a Carrito" runat="server" OnClick="btnAgregarCarrito_Click" class="btn btn-primary btn-success" CommandArgument='<%#Eval("Id") %>' CommandName="ArtId"/>

  </div>
</div>
          <%--  </div>--%>
           </div>   
    </ItemTemplate>
        </asp:Repeater>
     </div>
   
    
</asp:Content>
