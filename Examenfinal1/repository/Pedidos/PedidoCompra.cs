using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examenparcial1.repository.PedidoCompra
{
    public class PedidoCompra
    {
        public int Id { get; set; }
        public int Id_Proveedor { get; set; }
        public int Id_Sucursal { get; set; }
        public DateTime Fecha_Hora { get; set; }
        public decimal Total { get; set; }
    }
}

