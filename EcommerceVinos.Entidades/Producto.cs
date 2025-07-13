using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceVinos.Entidades
{
	public class Producto
	{
		public int Id { get; set; }
		public string Nombre { get; set; }
		public string Descripcion { get; set; }
		public string ImagenUrl { get; set; }
		public int Anio { get; set; }
		public int TamanioMl { get; set; }
		public decimal Precio { get; set; }
		public int Stock { get; set; }
		public bool Activo { get; set; }
		public int BodegaId { get; set; }
		public int VarietalId { get; set; }
		public string NombreBodega { get; set; }
		public string NombreVarietal { get; set; }

	}
}
