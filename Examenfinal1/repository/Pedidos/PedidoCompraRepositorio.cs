using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Dapper;
using examenparcial1.repository.BD;

namespace examenparcial1.repository.PedidoCompra
{
    public class PedidoCompraRepositorio
    {
        private readonly IDbConnection _conexiondb;

        public PedidoCompraRepositorio(string connectionString)
        {
            _conexiondb = new Conexionbd(connectionString).OpenConnection();
        }

        public bool AgregarPedidoCompra(PedidoCompra pedidoCompra)
        {
            string sql = "INSERT INTO public.PedidoCompra (Id_Proveedor, Id_Sucursal, Fecha_Hora, Total) " +
                         "VALUES (@Id_Proveedor, @Id_Sucursal, @Fecha_Hora, @Total)";
            _conexiondb.Execute(sql, pedidoCompra);
            return true;
        }

        public bool ActualizarPedidoCompra(PedidoCompra pedidoCompra)
        {
            string sql = "UPDATE public.PedidoCompra SET Id_Proveedor = @Id_Proveedor, Id_Sucursal = @Id_Sucursal, " +
                         "Fecha_Hora = @Fecha_Hora, Total = @Total WHERE Id = @Id";
            _conexiondb.Execute(sql, pedidoCompra);
            return true;
        }

        public bool EliminarPedidoCompra(int id)
        {
            string sql = "DELETE FROM public.PedidoCompra WHERE Id = @Id";
            _conexiondb.Execute(sql, new { Id = id });
            return true;
        }

        public PedidoCompra ObtenerPedidoCompraPorId(int id)
        {
            string sql = "SELECT * FROM public.PedidoCompra WHERE Id = @Id";
            return _conexiondb.QuerySingleOrDefault<PedidoCompra>(sql, new { Id = id });
        }

        public IEnumerable<PedidoCompra> ListarPedidoCompras()
        {
            string sql = "SELECT * FROM public.PedidoCompra";
            return _conexiondb.Query<PedidoCompra>(sql);
        }
    }
}

