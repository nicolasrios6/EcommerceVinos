using EcommerceVinos.Entidades;
using EcommerceVinos.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EcommerceVinos
{
    public partial class _Default : Page
    {
        private ProductoNegocio productoNegocio = new ProductoNegocio();
        public List<Producto> ListaProductos { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            ListaProductos = productoNegocio.ObtenerTodos();

            var activos = ListaProductos.Where(p => p.Activo).ToList();
            if (!IsPostBack)
            {
                repProductos.DataSource = activos;
                repProductos.DataBind();
            }
        }
    }
}