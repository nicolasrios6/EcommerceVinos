<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Bodegas.aspx.cs" Inherits="EcommerceVinos.Bodegas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Bodegas</h2>
    <a href="FormularioBodega.aspx" class="btn btn-sm btn-primary mb-3">Agregar Bodega</a>

    <div class="row">
        <asp:GridView ID="gvBodegas" CssClass="table" runat="server" DataKeyNames="Id" AutoGenerateColumns="false">
            <Columns>
                <asp:BoundField HeaderText="Nombre" DataField="Nombre" />
            </Columns>
        </asp:GridView>
    </div>
</asp:Content>
