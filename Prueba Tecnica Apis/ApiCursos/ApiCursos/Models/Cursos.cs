using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiCursos.Models
{
    public class Cursos
    {

        public int IdCurso { get; set; }

        public string Curso { get; set; }

        public string Horas { get; set;}

        public DateTime FechaRegistroEstu { get; set; }
    }
}