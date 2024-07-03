using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using examenparcial1.repository.DetalleFactura;

namespace examenparcial1.service
{
    public class DetalleFacturaServicio
    {
        private readonly DetalleFacturaRepositorio _detalleFacturaRepositorio;

        public DetalleFacturaServicio(string connectionString)
        {
            _detalleFacturaRepositorio = new DetalleFacturaRepositorio(connectionString);
        }

        public bool AgregarDetalleFactura(DetalleFactura detalleFactura)
        {
            
            return _detalleFacturaRepositorio.AgregarDetalleFactura(detalleFactura);
        }

        public bool ActualizarDetalleFactura(DetalleFactura detalleFactura)
        {
        
            return _detalleFacturaRepositorio.ActualizarDetalleFactura(detalleFactura);
        }

        public bool EliminarDetalleFactura(int id)
        {
           
            return _detalleFacturaRepositorio.EliminarDetalleFactura(id);
        }

        public DetalleFactura ObtenerDetalleFacturaPorId(int id)
        {
 
            return _detalleFacturaRepositorio.ObtenerDetalleFacturaPorId(id);
        }

        public IEnumerable<DetalleFactura> ListarDetalleFacturas()
        {
           
            return _detalleFacturaRepositorio.ListarDetalleFacturas();
        }
    }
}

