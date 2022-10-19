<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CarritoCompras_LeonardoMendoza._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
   <%-- <style>
        .oculto{
            display: none;
        }

    </style>
    <asp:GridView runat="server" ID="dgvArticulos" DataKeyNames="Id" OnSelectedIndexChanged="dgvArticulos_SelectedIndexChanged" CssClass="table-striped alert-warning table" AutoGenerateColumns ="FALSE">
      <columns>
         <asp:BoundField HeaderText="ID" DataField = "ID" HeaderStyle-CssClass ="Oculto" ItemStyle-CssClass="oculto" />
         <asp:BoundField HeaderText="Nombre" DataField = "Nombre" />
         <asp:Boundfield HeaderText="Descripcion" DataField = "Descripcion" />
         <asp:BoundField HeaderText="Marca" DataField = "Marca" />
         <asp:BoundField HeaderText="Categoria" DataField = "Categoria" />
         <asp:BoundField HeaderText="Precio" DataField = "Precio" />
         <asp:CommandField ShowSelectButton="true" SelectText="Seleccionar" HeaderText="Acción"/>
    </columns> 
 </asp:GridView>--%>

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
    <a href="#" class="btn btn-primary btn-warning">Ver Detalle</a>
      <a href="#" class="btn btn-primary btn-success">Agregar a Carrito</a>
  </div>
</div>
          <%--  </div>--%>
           </div>   
    </ItemTemplate>
        </asp:Repeater>
     </div>
   
    
</asp:Content>
