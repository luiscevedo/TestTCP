using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TESTTCP
{
    //tabla SQL
    public class Clients
    {
        public int ID { get; set; }
        public string RazonSocial { get; set; }
        public string Cuit { get; set; }
        public string Direccion { get; set; }
        public bool Deshabilitado { get; set; }

    }
}
