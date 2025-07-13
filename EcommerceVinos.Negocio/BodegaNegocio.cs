using EcommerceVinos.Datos;
using EcommerceVinos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceVinos.Negocio
{
	public class BodegaNegocio
	{
		private BodegaDatos datos = new BodegaDatos();

		public List<Bodega> ObtenerTodas()
		{
			return datos.ObtenerTodas();
		}
	}
}
