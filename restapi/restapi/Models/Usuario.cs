using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace restapi.Models
{
    public class Direccion
    {
        public string calle { get; set; }
        public int numero { get; set; }
        public string comuna { get; set; }
    }

    public class Usuario
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string telefono { get; set; }
        public string rut { get; set; }
        public string fechaNacimiento { get; set; }

        public Direccion direccion { get; set; }
        public int activo { get; set; }
    }
}