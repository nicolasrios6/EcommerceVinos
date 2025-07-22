using System;
using System.Collections.Generic;
using System.Globalization;
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
			//txtId.Enabled = true;

			if(!IsPostBack)
			{
				cargarVarietales();
				cargarBodegas();

				if (Request.QueryString["id"] != null)
				{
					int id = int.Parse(Request.QueryString["id"]);
					Producto producto = productoNegocio.ObtenerPorId(id);

					if(producto != null)
					{
                        //txtId.Text = producto.Id.ToString();
                        txtNombre.Text = producto.Nombre;
                        txtTamanio.Text = producto.TamanioMl.ToString();
                        txtAnio.Text = producto.Anio.ToString();
                        txtPrecio.Text = producto.Precio.ToString("N0", new CultureInfo("es-AR"));
                        txtStock.Text = producto.Stock.ToString();
                        txtDescripcion.Text = producto.Descripcion;
                        txtImagenUrl.Text = producto.ImagenUrl;
                        imgProducto.ImageUrl = producto.ImagenUrl;

                        ddlBodega.SelectedValue = producto.BodegaId.ToString();
                        ddlVarietal.SelectedValue = producto.VarietalId.ToString();

                        // Guardamos el ID en Session por si lo necesitamos luego
                        Session["IdProductoEditar"] = producto.Id;

						Session["productoSeleccionado"] = producto;

						btnInactivar.Text = producto.Activo ? "Inactivar" : "Activar";
                    }
				}

                // Restaurar si venís de agregar varietal/bodega
                if (Session["ProductoEnCarga"] != null)
                {
                    Producto producto = (Producto)Session["ProductoEnCarga"];

                    txtNombre.Text = producto.Nombre;
                    txtTamanio.Text = producto.TamanioMl.ToString();
                    txtAnio.Text = producto.Anio.ToString();
                    txtPrecio.Text = producto.Precio.ToString("N0", new CultureInfo("es-AR"));
                    txtStock.Text = producto.Stock.ToString();
                    txtDescripcion.Text = producto.Descripcion;
                    txtImagenUrl.Text = producto.ImagenUrl;
                    imgProducto.ImageUrl = producto.ImagenUrl;

                    if (producto.BodegaId > 0)
                        ddlBodega.SelectedValue = producto.BodegaId.ToString();

                    if (producto.VarietalId > 0)
                        ddlVarietal.SelectedValue = producto.VarietalId.ToString();
                }
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

                CultureInfo culturaAR = new CultureInfo("es-AR");

                Producto producto = new Producto();
				producto.Nombre = txtNombre.Text;
				producto.TamanioMl = int.Parse(txtTamanio.Text);
				producto.Anio = int.Parse(txtAnio.Text);
                string precioTexto = txtPrecio.Text.Replace(".", "").Replace(",", ".");
                producto.Precio = decimal.Parse(precioTexto, CultureInfo.InvariantCulture);
                producto.Stock = int.Parse(txtStock.Text);
				producto.VarietalId = int.Parse(ddlVarietal.SelectedValue);
				producto.BodegaId = int.Parse(ddlBodega.SelectedValue);
				producto.Descripcion = txtDescripcion.Text;
				producto.ImagenUrl = txtImagenUrl.Text;
				producto.Activo = true;

				if (Session["IdProductoEditar"] != null)
				{
					producto.Id = (int)Session["IdProductoEditar"];
					productoNegocio.Modificar(producto);
					Session.Remove("IdProductoEditar");
				} else
				{
					productoNegocio.Crear(producto);
				}

				Response.Redirect("Productos.aspx", false);
			}
			catch (Exception ex)
			{
				throw ex;
			} finally
			{
                Session.Remove("ProductoEnCarga");
            }
		}

		private void GuardarDatosEnSession()
		{
			Producto producto = new Producto();
            producto.Nombre = txtNombre.Text;
            producto.TamanioMl = string.IsNullOrEmpty(txtTamanio.Text) ? 0 : int.Parse(txtTamanio.Text);
            producto.Anio = string.IsNullOrEmpty(txtAnio.Text) ? 0 : int.Parse(txtAnio.Text);
            string precioTexto = txtPrecio.Text.Replace(".", "").Replace(",", ".");
            producto.Precio = string.IsNullOrEmpty(precioTexto) ? 0 : decimal.Parse(precioTexto, CultureInfo.InvariantCulture);
            producto.Stock = string.IsNullOrEmpty(txtStock.Text) ? 0 : int.Parse(txtStock.Text);
            producto.VarietalId = string.IsNullOrEmpty(ddlVarietal.SelectedValue) ? 0 : int.Parse(ddlVarietal.SelectedValue);
            producto.BodegaId = string.IsNullOrEmpty(ddlBodega.SelectedValue) ? 0 : int.Parse(ddlBodega.SelectedValue);
            producto.Descripcion = txtDescripcion.Text;
            producto.ImagenUrl = txtImagenUrl.Text;

            Session["ProductoEnCarga"] = producto;
        }

        protected void btnNuevoVarietal_Click(object sender, EventArgs e)
        {
			GuardarDatosEnSession();
			Response.Redirect("FormularioVarietal.aspx?returnUrl=FormularioProducto.aspx");
        }

        protected void btnNuevaBodega_Click(object sender, EventArgs e)
        {
			GuardarDatosEnSession();
			Response.Redirect("FormularioBodega.aspx?returnUrl=FormularioProducto.aspx");
        }

        protected void btnInactivar_Click(object sender, EventArgs e)
        {
			try
			{
                Producto seleccionado = (Producto)Session["productoSeleccionado"];

                if (seleccionado != null)
                {
                    bool nuevoEstado = !seleccionado.Activo;
                    productoNegocio.Inactivar(seleccionado.Id, nuevoEstado);

                    // Limpiar session
                    Session.Remove("productoSeleccionado");
                    Session.Remove("IdProductoEditar");

                    Response.Redirect("Productos.aspx");
                }
            }
			catch (Exception ex)
			{
				throw ex;
			}
        }
    }
}