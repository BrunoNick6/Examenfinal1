using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using examenparcial1.repository.Sucursal;
using Dapper;
using static examenparcial1.repository.Sucursal.sucursalrepositorio;

using System.Collections.Generic;


namespace examenparcial1.service
{
    public class SucursalServicio
    {
        private readonly sucursalrepositorio _sucursalRepositorio;

        public SucursalServicio(string connectionString)
        {
            _sucursalRepositorio = new sucursalrepositorio(connectionString);
        }

        public bool AgregarSucursal(Sucursal sucursal)
        {
         

            return _sucursalRepositorio.AgregarSucursal(sucursal);
        }

        public bool ActualizarSucursal(Sucursal sucursal)
        {
            

            return _sucursalRepositorio.Update(sucursal);
        }

        public bool EliminarSucursal(int id)
        {
         

            return _sucursalRepositorio.Delete(id);
        }

        public Sucursal ObtenerSucursalPorId(int id)
        {
         

            return _sucursalRepositorio.GetSucursalById(id);
        }

        public IEnumerable<Sucursal> ListarSucursales()
        {
            

            return _sucursalRepositorio.List();
        }
    }
}


