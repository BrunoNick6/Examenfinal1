using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examenparcial1.repository.DetallePedido
{
    public class DetallePedido
    {
        public int Id { get; set; }
        public int Id_Pedido { get; set; }
        public int Id_Producto { get; set; }
        public int Cantidad_Producto { get; set; }
        public decimal Subtotal { get; set; }
    }
}

