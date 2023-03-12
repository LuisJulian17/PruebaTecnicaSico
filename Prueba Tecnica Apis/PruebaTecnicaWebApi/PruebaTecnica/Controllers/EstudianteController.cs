using PruebaTecnica.Data;
using PruebaTecnica.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PruebaTecnica.Controllers
{
    public class EstudianteController : ApiController
    {

        public List<Estudiante> Get()
        {
            return EstudianteData.Listar();
        }

        public Estudiante Get(int id)
        {
            return EstudianteData.Obtener(id);
        }
        public bool Post([FromBody] Estudiante estudiante)
        {
            return EstudianteData.Registrar(estudiante);
        }
        public bool Put([FromBody] Estudiante estudiante)
        {
            return EstudianteData.Modificar(estudiante);
        }
        public bool Delete(int id)
        {
            return EstudianteData.Eliminar(id);
        }
    }
}