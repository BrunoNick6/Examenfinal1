using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Dapper;
using examenparcial1.repository.BD;

namespace examenparcial1.repository.Proveedor
{
    public class ProveedorRepositorio
    {
        private readonly IDbConnection _conexiondb;

        public ProveedorRepositorio(string connectionString)
        {
            _conexiondb = new Conexionbd(connectionString).OpenConnection();
        }

        public bool AgregarProveedor(Proveedor proveedor)
        {
            string sql = "INSERT INTO public.Proveedor (RazonSocial, TipoDocumento, NumeroDocumento, Direccion, Mail, Celular, Estado) " +
                         "VALUES (@RazonSocial, @TipoDocumento, @NumeroDocumento, @Direccion, @Mail, @Celular, @Estado)";
            _conexiondb.Execute(sql, proveedor);
            return true;
        }

        public bool ActualizarProveedor(Proveedor proveedor)
        {
            string sql = "UPDATE public.Proveedor SET RazonSocial = @RazonSocial, TipoDocumento = @TipoDocumento, " +
                         "NumeroDocumento = @NumeroDocumento, Direccion = @Direccion, Mail = @Mail, Celular = @Celular, " +
                         "Estado = @Estado WHERE Id = @Id";
            _conexiondb.Execute(sql, proveedor);
            return true;
        }

        public bool EliminarProveedor(int id)
        {
            string sql = "DELETE FROM public.Proveedor WHERE Id = @Id";
            _conexiondb.Execute(sql, new { Id = id });
            return true;
        }

        public Proveedor ObtenerProveedorPorId(int id)
        {
            string sql = "SELECT * FROM public.Proveedor WHERE Id = @Id";
            return _conexiondb.QuerySingleOrDefault<Proveedor>(sql, new { Id = id });
        }

        public IEnumerable<Proveedor> ListarProveedores()
        {
            string sql = "SELECT * FROM public.Proveedor";
            return _conexiondb.Query<Proveedor>(sql);
        }
    }
}

