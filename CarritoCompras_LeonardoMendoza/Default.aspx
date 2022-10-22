<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CarritoCompras_LeonardoMendoza._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <%-- <style>
        .oculto{
            display: none;
        }

    </style>
    --%>
    <h1>-- LISTADO DE PRODUCTOS --  </h1>
    <hr />
    <asp:Button ID="lblContador" Text="Contador" runat="server" OnClick="lblContador_Click" class="shadow-lg list-group-item-danger h5" />
    <div>
        <asp:Label Text="Filtro: " runat="server" class ="offcanvas-header h3" />
        
        <asp:Label Text="Campo: " runat="server" class ="offcanvas-header h5"  />
        <asp:DropDownList  ID="ddlCampo" runat="server" class="form-select offcanvas-header btn-secondary">
        </asp:DropDownList>
        </div>
        <div>  
            <asp:Label Text="Criterio: " runat="server" class ="offcanvas-header h5" />
         <asp:DropDownList  ID="ddlCriterio" runat="server" class="form-select offcanvas-header btn-secondary">
        </asp:DropDownList>
            <br />
            <div>   
            <asp:TextBox ID="txtFiltro" runat="server" CssClass=" offcanvas-header " />  
            </div>
            <br />
            <div>
            <asp:Button ID="btnFiltro" Text="FILTRAR" runat="server" Onclick="btnFiltro_Click" CommandArgument='<%#Eval("filtro") %>' CommandName="ArtFiltro" class="offcanvas-header btn btn-primary btn-warning"/>
          </div>
        </div>
    <hr />

    <div class="row row-cols-1 row-cols-md-3 g-4 offcanvas-header">

        <asp:Repeater runat="server" ID="repRepetidor">
            <ItemTemplate>
                <div class="col well">
                    <div class="card">
                        <img src="<%#Eval("ImagenURL") %>" class="card-img-top" width="200" alt="">
                        <div class="card-body jumbotron center-block">
                            <h5 class="card-title h3"><%#Eval("Nombre") %></h5>
                            <p class="card-text"><%#Eval("Descripcion") %></p>
                            <p class="card-text h3"><%#Eval("Precio") %></p>

                            <asp:Button ID="btnVerDetalle" Text="Ver Detalle" runat="server" OnClick="btnVerDetalle_Click" class="btn btn-primary btn-warning" CommandArgument='<%#Eval("Id") %>' CommandName="ArtId" />
                            <asp:Button ID="btnAgregarCarrito" Text="Agregar a Carrito" runat="server" OnClick="btnAgregarCarrito_Click" class="btn btn-primary btn-success" CommandArgument='<%#Eval("Id") %>' CommandName="ArtId" />

                        </div>
                    </div>
                    <%--  </div>--%>
                </div>
            </ItemTemplate>
        </asp:Repeater>
    </div>


</asp:Content>
