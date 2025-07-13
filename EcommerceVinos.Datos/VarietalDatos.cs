using EcommerceVinos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceVinos.Datos
{
	public class VarietalDatos
	{
		private AccesoDatos datos = new AccesoDatos();

		public List<Varietal> ObtenerTodos()
		{
			List<Varietal> listaVarietales = new List<Varietal>();

			try
			{
				datos.setConsulta("SELECT Id, Nombre FROM Varietal");
				datos.ejecutarLectura();

				while (datos.Lector.Read())
				{
					Varietal aux = new Varietal();
					aux.Id = (int)datos.Lector["Id"];
					aux.Nombre = datos.Lector["Nombre"].ToString();

					listaVarietales.Add(aux);
				}
				return listaVarietales;
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
