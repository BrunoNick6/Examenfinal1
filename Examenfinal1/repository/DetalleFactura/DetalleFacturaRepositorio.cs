using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Dapper;
using examenparcial1.repository.BD;

namespace examenparcial1.repository.DetalleFactura
{
    public class DetalleFacturaRepositorio
    {
        private readonly IDbConnection _conexiondb;

        public DetalleFacturaRepositorio(string connectionString)
        {
            _conexiondb = new Conexionbd(connectionString).OpenConnection();
        }

        public bool AgregarDetalleFactura(DetalleFactura detalleFactura)
        {
            string sql = "INSERT INTO public.Detalle_factura (Id_Factura, Id_Producto, Cantidad_producto, Subtotal) " +
                         "VALUES (@IdFactura, @IdProducto, @CantidadProducto, @Subtotal)";
            _conexiondb.Execute(sql, detalleFactura);
            return true;
        }

        public bool ActualizarDetalleFactura(DetalleFactura detalleFactura)
        {
            string sql = "UPDATE public.Detalle_factura SET Id_Factura = @IdFactura, Id_Producto = @IdProducto, " +
                         "Cantidad_producto = @CantidadProducto, Subtotal = @Subtotal WHERE Id = @Id";
            _conexiondb.Execute(sql, detalleFactura);
            return true;
        }

        public bool EliminarDetalleFactura(int id)
        {
            string sql = "DELETE FROM public.Detalle_factura WHERE Id = @Id";
            _conexiondb.Execute(sql, new { Id = id });
            return true;
        }

        public DetalleFactura ObtenerDetalleFacturaPorId(int id)
        {
            string sql = "SELECT * FROM public.Detalle_factura WHERE Id = @Id";
            return _conexiondb.QuerySingleOrDefault<DetalleFactura>(sql, new { Id = id });
        }

        public IEnumerable<DetalleFactura> ListarDetalleFacturas()
        {
            string sql = "SELECT * FROM public.Detalle_factura";
            return _conexiondb.Query<DetalleFactura>(sql);
        }
    }
}

