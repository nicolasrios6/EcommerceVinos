using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceVinos.Entidades
{
	public class DetallePedido
	{
		public int Id { get; set; }
		public int PedidoId { get; set; }
		public int ProductoId { get; set; }
		public int Cantidad { get; set; }
		public decimal PrecioUnitario { get; set; }
	}
}
