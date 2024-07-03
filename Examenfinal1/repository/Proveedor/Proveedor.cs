using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace examenparcial1.repository.Proveedor
{
    public class Proveedor
    {
        public int Id { get; set; }
        public string RazonSocial { get; set; }
        public string TipoDocumento { get; set; }
        public string NumeroDocumento { get; set; }
        public string Direccion { get; set; }
        public string Mail { get; set; }
        public string Celular { get; set; }
        public bool Estado { get; set; }
    }
}



