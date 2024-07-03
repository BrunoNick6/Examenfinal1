using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examenparcial1.repository.Productos
{
    
          public class Producto
        {
            public int Id { get; set; }
            public string Descripcion { get; set; }
            public int CantidadMinima { get; set; }
            public int CantidadStock { get; set; }
            public decimal PrecioCompra { get; set; }
            public decimal PrecioVenta { get; set; }
            public string Categoria { get; set; }
            public string Marca { get; set; }
            public bool Estado { get; set; }
        }
    }


