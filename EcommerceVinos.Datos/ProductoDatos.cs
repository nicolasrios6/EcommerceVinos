using EcommerceVinos.Entidades;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceVinos.Datos
{
	public class ProductoDatos
	{
		private AccesoDatos datos = new AccesoDatos();

		public List<Producto> ObtenerTodos()
		{
			List<Producto> listaProductos = new List<Producto>();

			try
			{
				datos.setProcedimiento("Producto_ObtenerTodos");
				datos.ejecutarLectura();

				while (datos.Lector.Read())
				{
					Producto aux = new Producto();
					aux.Id = (int)datos.Lector["Id"];
					aux.Nombre = datos.Lector["Nombre"].ToString();
					aux.Descripcion = datos.Lector["Descripcion"].ToString();
					aux.ImagenUrl = datos.Lector["ImagenUrl"].ToString();
					aux.Precio = (decimal)datos.Lector["Precio"];
					aux.Stock = (int)datos.Lector["Stock"];
					aux.Activo = (bool)datos.Lector["Activo"];
					aux.Anio = (int)datos.Lector["Anio"];
					aux.TamanioMl = (int)datos.Lector["TamanioML"];
					aux.BodegaId = (int)datos.Lector["BodegaId"];
					aux.VarietalId = (int)datos.Lector["VarietalId"];
					aux.NombreBodega = datos.Lector["NombreBodega"].ToString();
					aux.NombreVarietal = datos.Lector["NombreVarietal"].ToString();

					listaProductos.Add(aux);
				}
				return listaProductos;
			}
			catch (Exception ex)
			{
				throw ex;
			} finally
			{
				datos.cerrarConexion();
			}
		}

		public void Crear(Producto producto)
		{
			try
			{
				datos.setProcedimiento("Producto_Crear");
				datos.setParametro("@Nombre", producto.Nombre);
				datos.setParametro("@Descripcion", producto.Descripcion);
				datos.setParametro("@ImagenUrl", producto.ImagenUrl);
				datos.setParametro("@Anio", producto.Anio);
				datos.setParametro("@TamanioML", producto.TamanioMl);
				datos.setParametro("@Precio", producto.Precio);
				datos.setParametro("@Stock", producto.Stock);
				datos.setParametro("@Activo", producto.Activo);
				datos.setParametro("@BodegaId", producto.BodegaId);
				datos.setParametro("@VarietalId", producto.VarietalId);

				datos.ejecutarAccion();
			}
			catch (Exception ex)
			{
				throw ex;
			} finally
			{
				datos.cerrarConexion();
			}
		}
	}
}
