using EcommerceVinos.Datos;
using EcommerceVinos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceVinos.Negocio
{
	public class ProductoNegocio
	{
		private ProductoDatos datos = new ProductoDatos();

		public List<Producto> ObtenerTodos()
		{
			return datos.ObtenerTodos();
		}

		public void Crear(Producto producto)
		{
			datos.Crear(producto);
		}
	}
}
