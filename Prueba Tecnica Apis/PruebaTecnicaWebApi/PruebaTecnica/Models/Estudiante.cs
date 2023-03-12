using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PruebaTecnica.Models
{
    public class Estudiante
    {
        public int IdEstudiante { get; set; }
        public string CCEstu { get; set; }
        public string  NombreEstu { get; set; }
        public string ApellidoEstu { get; set; }
        public string EmailEstu { get; set; }
        public DateTime FechaRegistroEstu { get; set; }
    }
}