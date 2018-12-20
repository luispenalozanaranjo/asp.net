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
        public string nombre { get; set; }
        public string apellido { get; set; }
        [DisplayName("Nombre y Apellido(s)")]
        public string NombreCompleto { get { return string.Format("{0} {1}", nombre, apellido); } }
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