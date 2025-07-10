using EcommerceVinos.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EcommerceVinos
{
	public partial class Usuarios : System.Web.UI.Page
	{
		private UsuarioNegocio negocio = new UsuarioNegocio();
		protected void Page_Load(object sender, EventArgs e)
		{
			if (!IsPostBack)
			{
				Session.Add("listaUsuarios", negocio.ObtenerTodos());
				gvUsuarios.DataSource = Session["listaUsuarios"];
				gvUsuarios.DataBind();
			}
		}
	}
}