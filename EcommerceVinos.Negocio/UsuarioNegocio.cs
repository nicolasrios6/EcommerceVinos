using EcommerceVinos.Datos;
using EcommerceVinos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceVinos.Negocio
{
	public class UsuarioNegocio
	{
		private UsuarioDatos datos = new UsuarioDatos();

		public List<Usuario> ObtenerTodos()
		{
			return datos.ObtenerTodos();
		}
	}
}
