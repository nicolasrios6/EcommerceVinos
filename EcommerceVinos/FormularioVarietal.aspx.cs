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
    public partial class FormularioVarietal : System.Web.UI.Page
    {
        private VarietalNegocio varietalNegocio = new VarietalNegocio();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                Varietal varietal = new Varietal();
                varietal.Nombre = txtNombre.Text;

                varietalNegocio.Crear(varietal);

                string returnUrl = Request.QueryString["returnUrl"];
                if (!string.IsNullOrEmpty(returnUrl))
                {
                    Response.Redirect(returnUrl);
                }
                else
                {
                    Response.Redirect("Varietales.aspx");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}