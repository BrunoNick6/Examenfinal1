using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using examenparcial1.repository.PedidoCompra;

namespace examenparcial1.service
{
    public class PedidoCompraServicio
    {
        private readonly PedidoCompraRepositorio _pedidoCompraRepositorio;

        public PedidoCompraServicio(string connectionString)
        {
            _pedidoCompraRepositorio = new PedidoCompraRepositorio(connectionString);
        }

        public bool AgregarPedidoCompra(PedidoCompra pedidoCompra)
        {
           
            return _pedidoCompraRepositorio.AgregarPedidoCompra(pedidoCompra);
        }

        public bool ActualizarPedidoCompra(PedidoCompra pedidoCompra)
        {
       
            return _pedidoCompraRepositorio.ActualizarPedidoCompra(pedidoCompra);
        }

        public bool EliminarPedidoCompra(int id)
        {
        
            return _pedidoCompraRepositorio.EliminarPedidoCompra(id);
        }

        public PedidoCompra ObtenerPedidoCompraPorId(int id)
        {
          
            return _pedidoCompraRepositorio.ObtenerPedidoCompraPorId(id);
        }

        public IEnumerable<PedidoCompra> ListarPedidoCompras()
        {
          
            return _pedidoCompraRepositorio.ListarPedidoCompras();
        }
    }
}
