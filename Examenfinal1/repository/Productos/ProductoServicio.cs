using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections.Generic;
using examenparcial1.repository.Productos;
using examenparcial1.repository.Productos.examenparcial1.repository.Producto;

namespace examenparcial1.service
{
    public class ProductoServicio
    {
        private readonly ProductoRepositorio _productoRepositorio;

        public ProductoServicio(string connectionString)
        {
            _productoRepositorio = new ProductoRepositorio(connectionString);
        }

        public bool AgregarProducto(Producto producto)
        {
            // Lógica adicional antes de agregar el producto, si es necesario
            return _productoRepositorio.AgregarProducto(producto);
        }

        public bool ActualizarProducto(Producto producto)
        {
            // Lógica adicional antes de actualizar el producto, si es necesario
            return _productoRepositorio.ActualizarProducto(producto);
        }

        public bool EliminarProducto(int id)
        {
            // Lógica adicional antes de eliminar el producto, si es necesario
            return _productoRepositorio.EliminarProducto(id);
        }

        public Producto ObtenerProductoPorId(int id)
        {
            // Lógica adicional antes de obtener el producto, si es necesario
            return _productoRepositorio.ObtenerProductoPorId(id);
        }

        public IEnumerable<Producto> ListarProductos()
        {
            // Lógica adicional antes de listar los productos, si es necesario
            return _productoRepositorio.ListarProductos();
        }
    }
}

