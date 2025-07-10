using EcommerceVinos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceVinos.Datos
{
	public class UsuarioDatos
	{
		private AccesoDatos datos = new AccesoDatos();

		public List<Usuario> ObtenerTodos()
		{
			List<Usuario> listaUsuarios = new List<Usuario>();

			try
			{
				datos.setProcedimiento("Usuario_ObtenerTodos");
				datos.ejecutarLectura();

				while(datos.Lector.Read())
				{
					Usuario aux = new Usuario();
					aux.Id = (int)datos.Lector["Id"];
					aux.Nombre = datos.Lector["Nombre"].ToString();
					aux.Email = datos.Lector["Email"].ToString();
					aux.Telefono = datos.Lector["Telefono"].ToString();
					aux.EsAdmin = (bool)datos.Lector["EsAdmin"];

					listaUsuarios.Add(aux);
				}
				
				return listaUsuarios;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
