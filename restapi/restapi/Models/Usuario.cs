using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        [DisplayName("Numero")]
        public int id { get; set; }
        [DisplayName("Nombres")]
        public string nombre { get; set; }
        [DisplayName("Apellidos")]
        public string apellido { get; set; }
        [DisplayName("Telefono")]
        public string telefono { get; set; }
        [DisplayName("Rut")]
        public string rut { get; set; }
        [DisplayName("Fecha de Nacimiento")]
        public string fechaNacimiento { get; set; }
        [DisplayName("Dirección")]
        public Direccion direccion { get; set; }
        [DisplayName("Estado")]
        public int activo { get; set; }
    }
}