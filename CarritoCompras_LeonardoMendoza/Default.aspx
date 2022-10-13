<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CarritoCompras_LeonardoMendoza._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <asp:GridView runat="server" ID="dgvArticulos" CssClass="table-striped alert-warning table" AutoGenerateColumns ="true">  </asp:GridView>
 
</asp:Content>
