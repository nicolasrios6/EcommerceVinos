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
    public partial class FormularioBodega : System.Web.UI.Page
    {
        private BodegaNegocio bodegaNegocio = new BodegaNegocio();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                Bodega bodega = new Bodega();
                bodega.Nombre = txtNombre.Text;

                bodegaNegocio.Crear(bodega);

                string returnUrl = Request.QueryString["returnUrl"];
                if (!string.IsNullOrEmpty(returnUrl))
                {
                    Response.Redirect(returnUrl);
                }
                else
                {
                    Response.Redirect("Bodegas.aspx");
                }

                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}