using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Dapper;
using examenparcial1.repository.BD;

namespace examenparcial1.repository.DetallePedido
{
    public class DetallePedidoRepositorio
    {
        private readonly IDbConnection _conexiondb;

        public DetallePedidoRepositorio(string connectionString)
        {
            _conexiondb = new Conexionbd(connectionString).OpenConnection();
        }

        public bool AgregarDetallePedido(DetallePedido detallePedido)
        {
            string sql = "INSERT INTO public.DetallePedido (Id_Pedido, Id_Producto, Cantidad_Producto, Subtotal) " +
                         "VALUES (@Id_Pedido, @Id_Producto, @Cantidad_Producto, @Subtotal)";
            _conexiondb.Execute(sql, detallePedido);
            return true;
        }

        public bool ActualizarDetallePedido(DetallePedido detallePedido)
        {
            string sql = "UPDATE public.DetallePedido SET Id_Pedido = @Id_Pedido, Id_Producto = @Id_Producto, " +
                         "Cantidad_Producto = @Cantidad_Producto, Subtotal = @Subtotal WHERE Id = @Id";
            _conexiondb.Execute(sql, detallePedido);
            return true;
        }

        public bool EliminarDetallePedido(int id)
        {
            string sql = "DELETE FROM public.DetallePedido WHERE Id = @Id";
            _conexiondb.Execute(sql, new { Id = id });
            return true;
        }

        public DetallePedido ObtenerDetallePedidoPorId(int id)
        {
            string sql = "SELECT * FROM public.DetallePedido WHERE Id = @Id";
            return _conexiondb.QuerySingleOrDefault<DetallePedido>(sql, new { Id = id });
        }

        public IEnumerable<DetallePedido> ListarDetallePedidos()
        {
            string sql = "SELECT * FROM public.DetallePedido";
            return _conexiondb.Query<DetallePedido>(sql);
        }
    }
}

