<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FormularioBodega.aspx.cs" Inherits="EcommerceVinos.FormularioBodega" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Formulario Bodega</h2>

    <div class="row">
    <div class="col-10">
        <div class="mb-3">
            <label for="txtNombre" class="form-label">Nombre</label>
            <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
    </div>
    <div class="col-3">
        <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" CssClass="btn btn-sm btn-primary" OnClick="btnAceptar_Click"/>
        <a href="Bodegas.aspx" class="btn btn-sm btn-secondary">Cancelar</a>
    </div>
</div>
</asp:Content>
