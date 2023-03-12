using ApiCursos.Data;
using ApiCursos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ApiCursos.Controllers
{
    public class ApiCursosController : ApiController
    {
        public List<Cursos> Get()
        {
            return CursosData.ListarCurso();
        }
        public Cursos Get(int id)
        {
            return CursosData.ObtenerCurso(id);
        }
        public bool Post([FromBody] Cursos cursos)
        {
            return CursosData.RegistrarCurso(cursos);
        }
        public bool Put([FromBody] Cursos cursos)
        {
            return CursosData.ModificarCurso(cursos);
        }
        public bool Delete(int id)
        {
            return CursosData.EliminarCurso(id);
        }
    }
}