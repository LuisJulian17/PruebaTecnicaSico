using ApiAsignacion.Data;
using ApiAsignacion.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ApiAsignacion.Controllers
{
    public class AsigCursoController : ApiController
    {
        public List<AsignacionCursos> Get()
        
        {
            return AsigCursosData.Listarcur();
        }
        public AsignacionCursos Get(int id)
        {
            return AsigCursosData.ObtenerRegistro(id);
        }
        public bool Post([FromBody] AsignacionCursos asigcurso)
        {
            return AsigCursosData.RegistrarAsig(asigcurso);
        }
        public bool Put([FromBody] AsignacionCursos asigcurso)
        {
            return AsigCursosData.ModificarAsig(asigcurso);
        }
        public bool Delete(int id)
        {
            return AsigCursosData.EliminarRegistro(id);
        }
    }
}