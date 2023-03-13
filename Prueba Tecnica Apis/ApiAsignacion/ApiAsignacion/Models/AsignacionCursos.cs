using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiAsignacion.Models
{
    public class AsignacionCursos
    {
        public int IdAsignacion { get; set; }
        public int IdEstudiante { get; set; }
        public string CCEstudiante { get; set; }
        public string NombreEstu { get; set; }
        public string ApellidoEstu { get; set; }
        public string EmailEstu { get; set; }
        public int IdCurso { get; set; }
        public string NombreCurso { get; set; }
        public string HorasCurso { get; set; }
        public DateTime FechaRegistro { get; set; }

    }
}