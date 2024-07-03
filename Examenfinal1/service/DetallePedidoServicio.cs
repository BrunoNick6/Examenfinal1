using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections.Generic;
using examenparcial1.repository.DetallePedido;

namespace examenparcial1.service
{
    public class DetallePedidoServicio
    {
        private readonly DetallePedidoRepositorio _detallePedidoRepositorio;

        public DetallePedidoServicio(string connectionString)
        {
            _detallePedidoRepositorio = new DetallePedidoRepositorio(connectionString);
        }

        public bool AgregarDetallePedido(DetallePedido detallePedido)
        {
         
            return _detallePedidoRepositorio.AgregarDetallePedido(detallePedido);
        }

        public bool ActualizarDetallePedido(DetallePedido detallePedido)
        {
         
            return _detallePedidoRepositorio.ActualizarDetallePedido(detallePedido);
        }

        public bool EliminarDetallePedido(int id)
        {
  
            return _detallePedidoRepositorio.EliminarDetallePedido(id);
        }

        public DetallePedido ObtenerDetallePedidoPorId(int id)
        {
       
            return _detallePedidoRepositorio.ObtenerDetallePedidoPorId(id);
        }

        public IEnumerable<DetallePedido> ListarDetallePedidos()
        {
            
            return _detallePedidoRepositorio.ListarDetallePedidos();
        }
    }
}
