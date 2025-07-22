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

		public Producto ObtenerPorId(int id)
		{
			try
			{
				datos.setProcedimiento("Producto_ObtenerPorId");
				datos.setParametro("@Id", id);
				datos.ejecutarLectura();

				if(datos.Lector.Read())
				{
					Producto producto = new Producto();
					producto.Id = (int)datos.Lector["Id"];
					producto.Nombre = datos.Lector["Nombre"].ToString();
					producto.Descripcion = datos.Lector["Descripcion"].ToString();
					producto.ImagenUrl = datos.Lector["ImagenUrl"].ToString();
					producto.Anio = (int)datos.Lector["Anio"];
					producto.TamanioMl = (int)datos.Lector["TamanioMl"];
					producto.Precio = (decimal)datos.Lector["Precio"];
					producto.Stock = (int)datos.Lector["Stock"];
					producto.Activo = (bool)datos.Lector["Activo"];
					producto.BodegaId = (int)datos.Lector["BodegaId"];
					producto.NombreBodega = datos.Lector["NombreBodega"].ToString();
					producto.VarietalId = (int)datos.Lector["VarietalId"];
					producto.NombreVarietal = datos.Lector["NombreVarietal"].ToString();

					return producto;
				}
				return null;
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

		public void Inactivar(int id, bool activo = false)
		{
			try
			{
				datos.setConsulta("UPDATE Producto SET Activo = @activo WHERE Id = @id");
				datos.setParametro("@id", id);
				datos.setParametro("@activo", activo);
				datos.ejecutarAccion();
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		public void Modificar(Producto producto)
		{
			try
			{
				datos.setProcedimiento("Producto_Modificar");
				datos.setParametro("@Id", producto.Id);
                datos.setParametro("@Nombre", producto.Nombre);
                datos.setParametro("@Descripcion", producto.Descripcion);
                datos.setParametro("@ImagenUrl", producto.ImagenUrl);
                datos.setParametro("@Precio", producto.Precio);
                datos.setParametro("@Stock", producto.Stock);
                datos.setParametro("@Activo", producto.Activo);
                datos.setParametro("@Anio", producto.Anio);
                datos.setParametro("@TamanioMl", producto.TamanioMl);
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
