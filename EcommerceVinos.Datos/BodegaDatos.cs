using EcommerceVinos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceVinos.Datos
{
	public class BodegaDatos
	{
		private AccesoDatos datos = new AccesoDatos();

		public List<Bodega> ObtenerTodas()
		{
			List<Bodega> listaBodegas = new List<Bodega>();

			try
			{
				datos.setConsulta("SELECT Id, Nombre FROM Bodega");
				datos.ejecutarLectura();

				while(datos.Lector.Read())
				{
					Bodega aux = new Bodega();
					aux.Id = (int)datos.Lector["Id"];
					aux.Nombre = datos.Lector["Nombre"].ToString();

					listaBodegas.Add(aux);
				}
				return listaBodegas;
			}
			catch (Exception ex)
			{
				throw ex;
			} finally
			{
				datos.cerrarConexion();
			}
		}

		public void Crear(Bodega bodega)
		{
			try
			{
				datos.setProcedimiento("Bodega_Crear");
				datos.setParametro("@Nombre", bodega.Nombre);
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
