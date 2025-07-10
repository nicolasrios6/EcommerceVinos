<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Usuarios.aspx.cs" Inherits="EcommerceVinos.Usuarios" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container-xl">
        <h2>Lista de Usuarios</h2>
        <div class="row">
            <asp:GridView ID="gvUsuarios" runat="server" CssClass="table" DataKeyNames="Id" AutoGenerateColumns="false">
                <Columns>
                    <asp:BoundField HeaderText="Nombre" DataField="Nombre"/>
                    <asp:BoundField HeaderText="Email" DataField="Email"/>
                    <asp:BoundField HeaderText="Telefono" DataField="Telefono"/>
                    <asp:CheckBoxField HeaderText="Admin" DataField="EsAdmin" />
                </Columns>
            </asp:GridView>
        </div>
    </div>
</asp:Content>
