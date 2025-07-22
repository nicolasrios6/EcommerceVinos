using EcommerceVinos.Datos;
using EcommerceVinos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceVinos.Negocio
{
	public class VarietalNegocio
	{
		private VarietalDatos datos = new VarietalDatos();

		public List<Varietal> ObtenerTodos()
		{
			return datos.ObtenerTodos();
		}

		public void Crear(Varietal varietal)
		{
			datos.Crear(varietal);
		}
	}
}
