using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EcommerceVinos.Datos;
using EcommerceVinos.Entidades;
using EcommerceVinos.Negocio;

namespace EcommerceVinos
{
	public partial class FromularioProducto : System.Web.UI.Page
	{
		private VarietalNegocio varietalNegocio= new VarietalNegocio();
		private BodegaNegocio bodegaNegocio = new BodegaNegocio();
		private ProductoNegocio productoNegocio = new ProductoNegocio();
		protected void Page_Load(object sender, EventArgs e)
		{
			txtId.Enabled = true;

			if(!IsPostBack)
			{
				cargarVarietales();
				cargarBodegas();
			}
		}

		private void cargarVarietales()
		{
			var lista = varietalNegocio.ObtenerTodos();
			ddlVarietal.DataSource = lista;
			ddlVarietal.DataTextField = "Nombre";
			ddlVarietal.DataValueField = "Id";
			ddlVarietal.DataBind();

			ddlVarietal.Items.Insert(0, new ListItem("-- Seleccione --", ""));
		}

		private void cargarBodegas()
		{
			var lista = bodegaNegocio.ObtenerTodas();
			ddlBodega.DataSource = lista;
			ddlBodega.DataTextField = "Nombre";
			ddlBodega.DataValueField = "Id";
			ddlBodega.DataBind();

			ddlBodega.Items.Insert(0, new ListItem("-- Seleccione --", ""));
		}

		protected void txtImagenUrl_TextChanged(object sender, EventArgs e)
		{
			imgProducto.ImageUrl = txtImagenUrl.Text;
		}

		protected void btnAceptar_Click(object sender, EventArgs e)
		{
			try
			{
				Producto nuevo = new Producto();
				nuevo.Nombre = txtNombre.Text;
				nuevo.TamanioMl = int.Parse(txtTamanio.Text);
				nuevo.Anio = int.Parse(txtAnio.Text);
				nuevo.Precio = decimal.Parse(txtPrecio.Text);
				nuevo.Stock = int.Parse(txtStock.Text);
				nuevo.VarietalId = int.Parse(ddlVarietal.SelectedValue);
				nuevo.BodegaId = int.Parse(ddlBodega.SelectedValue);
				nuevo.Descripcion = txtDescripcion.Text;
				nuevo.ImagenUrl = txtImagenUrl.Text;

				productoNegocio.Crear(nuevo);

				Response.Redirect("Productos.aspx", false);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}