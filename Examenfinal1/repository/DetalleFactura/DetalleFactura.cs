using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examenparcial1.repository.DetalleFactura
{
    public class DetalleFactura
    {
        public int Id { get; set; }
        public int IdFactura { get; set; }
        public int IdProducto { get; set; }
        public int CantidadProducto { get; set; }
        public decimal Subtotal { get; set; }
    }
}

}
