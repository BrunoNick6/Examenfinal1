using examenparcial1.repository.BD;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Npgsql;

namespace examenparcial1.repository.Productos
{
       

namespace examenparcial1.repository.Producto
    {
        public class ProductoRepositorio
        {
            private readonly IDbConnection conexiondb;

            public ProductoRepositorio(string connectionString)
            {
                conexiondb = new Conexionbd(connectionString).OpenConnection();
            }

            public bool AgregarProducto(Producto producto)
            {
                string sql = "INSERT INTO public.Productos (Descripcion, Cantidad_minima, Cantidad_stock, Precio_compra, Precio_venta, Categoria, Marca, Estado) " +
                             "VALUES (@Descripcion, @CantidadMinima, @CantidadStock, @PrecioCompra, @PrecioVenta, @Categoria, @Marca, @Estado)";
                conexiondb.Execute(sql, producto);
                return true;
            }

            public bool ActualizarProducto(Producto producto)
            {
                string sql = "UPDATE public.Productos SET Descripcion = @Descripcion, Cantidad_minima = @CantidadMinima, Cantidad_stock = @CantidadStock, " +
                             "Precio_compra = @PrecioCompra, Precio_venta = @PrecioVenta, Categoria = @Categoria, Marca = @Marca, Estado = @Estado " +
                             "WHERE Id = @Id";
                conexiondb.Execute(sql, producto);
                return true;
            }

            public bool EliminarProducto(int id)
            {
                string sql = "DELETE FROM public.Productos WHERE Id = @Id";
                conexiondb.Execute(sql, new { Id = id });
                return true;
            }

            public Producto ObtenerProductoPorId(int id)
            {
                string sql = "SELECT * FROM public.Productos WHERE Id = @Id";
                return conexiondb.QuerySingleOrDefault<Producto>(sql, new { Id = id });
            }

            public IEnumerable<Producto> ListarProductos()
            {
                string sql = "SELECT * FROM public.Productos";
                return conexiondb.Query<Producto>(sql);
            }
        }
    }

}
}
