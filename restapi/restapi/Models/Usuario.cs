﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace restapi.Models
{
    public class Usuario
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string telefono { get; set; }
        public string rut { get; set; }
        public string fechaNacimiento { get; set; }
        public string calle { get; set; }
        public int numero { get; set; }
        public string direccion
        {
            get { return calle + " " + numero; }
        }
    }
}