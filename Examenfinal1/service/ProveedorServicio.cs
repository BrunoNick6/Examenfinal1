using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using examenparcial1.repository.Proveedor;

namespace examenparcial1.service
{
    public class ProveedorServicio
    {
        private readonly ProveedorRepositorio _proveedorRepositorio;

        public ProveedorServicio(string connectionString)
        {
            _proveedorRepositorio = new ProveedorRepositorio(connectionString);
        }

        public bool AgregarProveedor(Proveedor proveedor)
        {
            // Lógica adicional antes de agregar el proveedor, si es necesario
            return _proveedorRepositorio.AgregarProveedor(proveedor);
        }

        public bool ActualizarProveedor(Proveedor proveedor)
        {
            // Lógica adicional antes de actualizar el proveedor, si es necesario
            return _proveedorRepositorio.ActualizarProveedor(proveedor);
        }

        public bool EliminarProveedor(int id)
        {
            // Lógica adicional antes de eliminar el proveedor, si es necesario
            return _proveedorRepositorio.EliminarProveedor(id);
        }

        public Proveedor ObtenerProveedorPorId(int id)
        {
            // Lógica adicional antes de obtener el proveedor, si es necesario
            return _proveedorRepositorio.ObtenerProveedorPorId(id);
        }

        public IEnumerable<Proveedor> ListarProveedores()
        {
            // Lógica adicional antes de listar los proveedores, si es necesario
            return _proveedorRepositorio.ListarProveedores();
        }
    }
}

