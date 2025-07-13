using EcommerceVinos.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EcommerceVinos
{
	public partial class Productos : System.Web.UI.Page
	{
		private ProductoNegocio negocio = new ProductoNegocio();
		protected void Page_Load(object sender, EventArgs e)
		{
			if (!IsPostBack)
			{
				Session.Add("listaProductos", negocio.ObtenerTodos());
				gvProductos.DataSource = Session["listaProductos"];
				gvProductos.DataBind();
			}
		}
	}
}