<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FromularioProducto.aspx.cs" Inherits="EcommerceVinos.FromularioProducto" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Formulario de Producto</h2>

    <div class="row">
        <div class="col-6">
            <div class="mb-3">
                <label for="txtId" class="form-label">Id</label>
                <asp:TextBox ID="txtId" runat="server" CssClass="form-control" ReadOnly="true"></asp:TextBox>
            </div>
            <div class="mb-3">
                <label for="txtNombre" class="form-label">Nombre</label>
                <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="mb-3">
                <label for="txtTamanio" class="form-label">Tamaño (ml)</label>
                <asp:TextBox ID="txtTamanio" runat="server" CssClass="form-control" TextMode="Number"></asp:TextBox>
            </div>
            <div class="mb-3">
                <label for="txtAnio" class="form-label">Año</label>
                <asp:TextBox ID="txtAnio" runat="server" CssClass="form-control" TextMode="Number"></asp:TextBox>
            </div>
            <div class="mb-3">
                <label for="txtPrecio" class="form-label">Precio</label>
                <asp:TextBox ID="txtPrecio" runat="server" CssClass="form-control" TextMode="Number"></asp:TextBox>
            </div>
            <div class="mb-3">
                <label for="txtStock" class="form-label">Stock</label>
                <asp:TextBox ID="txtStock" runat="server" CssClass="form-control" TextMode="Number"></asp:TextBox>
            </div>
            <div class="mb-3">
                <label for="ddlVarietal" class="form-label">Varietal</label>
                <asp:DropDownList ID="ddlVarietal" runat="server" CssClass="form-select"></asp:DropDownList>
                <asp:HyperLink ID="lnkNuevoVarietal" runat="server" NavigateUrl="~/VarietalNuevo.aspx">+ Nuevo varietal</asp:HyperLink>
            </div>
            <div class="mb-3">
                <label for="ddlBodega" class="form-label">Bodega</label>
                <asp:DropDownList ID="ddlBodega" runat="server" CssClass="form-select"></asp:DropDownList>
                <asp:HyperLink ID="lnkNuevaBodega" runat="server" NavigateUrl="~/BodegaNueva.aspx">+ Nueva bodega</asp:HyperLink><br />
            </div>
        </div>

        <div class="col-6">
            <div class="mb-3">
                <label for="txtDescripcion" class="form-label">Descripción</label>
                <asp:TextBox ID="txtDescripcion" runat="server" TextMode="MultiLine" CssClass="form-control"></asp:TextBox>
            </div>
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                    <div class="mb-3">
                        <label for="txtImagenUrl" class="form-label">Imagen (url)</label>
                        <asp:TextBox ID="txtImagenUrl" runat="server" AutoPostBack="true" CssClass="form-control" OnTextChanged="txtImagenUrl_TextChanged"></asp:TextBox>
                    </div>
                    <asp:Image ID="imgProducto" runat="server" 
                        ImageUrl="https://grupoact.com.ar/wp-content/uploads/2020/04/placeholder.png" Width="60%" />
                </ContentTemplate>
            </asp:UpdatePanel>
        </div>
        <div class="col-3">
            <asp:Button Text="Aceptar" ID="btnAceptar" CssClass="btn btn-sm btn-primary" OnClick="btnAceptar_Click" runat="server" />
            <a class="btn btn-sm btn-secondary" href="Productos.aspx">Cancelar</a>
            <asp:Button Text="Inactivar" CssClass="btn btn-sm btn-warning" runat="server" />
        </div>
    </div>
</asp:Content>
