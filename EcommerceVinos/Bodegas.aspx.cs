using EcommerceVinos.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EcommerceVinos
{
    public partial class Bodegas : System.Web.UI.Page
    {
        private BodegaNegocio negocio = new BodegaNegocio();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Session.Add("listaBodegas", negocio.ObtenerTodas());
                gvBodegas.DataSource = Session["listaBodegas"];
                gvBodegas.DataBind();
            }
        }
    }
}