using EcommerceVinos.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EcommerceVinos
{
    public partial class Varietales : System.Web.UI.Page
    {
        private VarietalNegocio negocio = new VarietalNegocio();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Session.Add("listaVarietales", negocio.ObtenerTodos());
                gvVarietales.DataSource = Session["listaVarietales"];
                gvVarietales.DataBind();
            }
        }
    }
}