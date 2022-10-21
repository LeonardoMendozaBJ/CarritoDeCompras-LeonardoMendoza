<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CarritoCompra.aspx.cs" Inherits="CarritoCompras_LeonardoMendoza.CarritoCompra" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
  
    <h1>  CARRITO DE COMPRAS  </h1>
    <hr />
    
    <asp:Button ID = "lblContador" Text="Contador"  runat="server" class = "shadow-lg list-group-item-danger h5"   />
    <div>  
     <asp:GridView runat="server" ID="dgvArticulos" OnSelectedIndexChanged ="dgvArticulos_SelectedIndexChanged"  DataKeyNames="Id"  CssClass="table-striped alert-warning table" AutoGenerateColumns ="FALSE">
      <columns>
         <asp:BoundField HeaderText="ID" DataField = "ID" HeaderStyle-CssClass = "Oculto" ItemStyle-CssClass="oculto" />
          <asp:BoundField HeaderText="Codigo" DataField = "Codigo" />
         <asp:BoundField HeaderText="Nombre" DataField = "Nombre" />
     
         <asp:BoundField HeaderText="Precio" DataField = "Precio" />
         <asp:CommandField ShowSelectButton="true" SelectText="Eliminar" HeaderText="Acción"/>
    </columns> 

 </asp:GridView>
    </div>
     <div>
        <asp:Label Text="TOTAL" CssClass="card display-6" runat="server" ID="lblPrecio"/>


    </div>
</asp:Content>
