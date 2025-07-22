<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="EcommerceVinos._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>
        <h2>Catálogo</h2>
        <div class="row row-cols-1 row-cols-md-3 g-4">
            <asp:Repeater ID="repProductos" runat="server">
                <ItemTemplate>
                    <div class="col">
                        <div class="card w-75 text-center">
                            <img src="<%# Eval("ImagenUrl") %>" class="card-img-top w-100" alt="...">
                            <div class="card-body">
                                <h5 class="card-title"><%#Eval("Nombre") %></h5>
                                <p class="card-text m-0"><%#Eval("NombreVarietal") %></p>
                                <p class="card-text"><%#Eval("NombreBodega") %></p>
                                <p class="card-text my-2 fw-semibold fs-5">$<%# string.Format("{0:N2}", Eval("Precio")) %></p>
                                <a href="#" class="btn btn-sm btn-primary">Comprar</a>
                            </div>
                        </div>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
        </div>
    </main>

</asp:Content>
