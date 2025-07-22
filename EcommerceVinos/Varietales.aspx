<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Varietales.aspx.cs" Inherits="EcommerceVinos.Varietales" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Varietales</h2>
    <a href="FormularioVarietal.aspx?returnUrl=Varietales.aspx" class="btn btn-sm btn-primary mb-3">Agregar Varietal</a>

    <div class="row">
        <asp:GridView ID="gvVarietales" CssClass="table" DataKeyNames="Id" AutoGenerateColumns="false" runat="server">
            <Columns>
                <asp:BoundField HeaderText="Nombre" DataField="Nombre"/>
            </Columns>
        </asp:GridView>
    </div>
</asp:Content>
