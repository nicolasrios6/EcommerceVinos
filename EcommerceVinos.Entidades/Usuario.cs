﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceVinos.Entidades
{
	public class Usuario
	{
		public int Id { get; set; }
		public string Nombre { get; set; }
		public string Email { get; set; }
		public string Password { get; set; }
		public string Telefono { get; set; }
		public bool EsAdmin { get; set; }
	}
}
