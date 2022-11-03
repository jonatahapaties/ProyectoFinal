using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoFinal.Models
{
    public class ProductoDto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Espera { get; set; }
        public double Precio { get; set; }
        public string DescripcionCategoria { get; set; }
        public int Cantidad { get; set; }

    }
}