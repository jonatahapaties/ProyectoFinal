using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoFinal.Models
{
    public class PedidoWeb
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public int IdProducto { get; set; }
        public Nullable<int> IdMesa { get; set; }
        public string TiempoEspera { get; set; }
        public Nullable<int> cantidad { get; set; }
        public Nullable<System.DateTime> fecha { get; set; }
        public string tipo { get; set; }
        public string nickName { get; set; }
        public IEnumerable<ProductoDto> productoDto { get; set; }

    }
}








