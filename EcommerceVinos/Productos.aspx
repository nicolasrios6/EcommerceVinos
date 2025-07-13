<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Productos.aspx.cs" Inherits="EcommerceVinos.Productos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Lista de Vinos</h2>
    <a class="btn btn-sm btn-primary mb-3" href="FromularioProducto.aspx">Crear Vino</a>
<div class="row">
    <asp:GridView ID="gvProductos" runat="server" CssClass="table" DataKeyNames="Id" AutoGenerateColumns="false">
        <Columns>
            <asp:BoundField HeaderText="Nombre" DataField="Nombre"/>
            <asp:BoundField HeaderText="Descripcion" DataField="Descripcion"/>
            <asp:BoundField HeaderText="Precio" DataField="Precio"/>
            <asp:BoundField HeaderText="Stock" DataField="Stock"/>
            <asp:BoundField HeaderText="Anio" DataField="Anio"/>
            <asp:CheckBoxField HeaderText="Activo" DataField="Activo" />
            <asp:BoundField HeaderText="Tamanio(ml)" DataField="TamanioML"/>
            <asp:BoundField HeaderText="Bodega" DataField="NombreBodega"/>
            <asp:BoundField HeaderText="Varietal" DataField="NombreVarietal"/>
        </Columns>
    </asp:GridView>
</div>
</asp:Content>
