using ApiCursos.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ApiCursos.Data
{
    public class CursosData
    {
        public static bool RegistrarCurso(Cursos curso)
        {
            using (SqlConnection conexion = new SqlConnection(Conexion.rutaConexion))
            {

                SqlCommand cmd = new SqlCommand("curso_registrar", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@curso", curso.Curso);
                cmd.Parameters.AddWithValue("@horas", curso.Horas);

                try
                {
                    conexion.Open();
                    cmd.ExecuteNonQuery();
                    return true;
            }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }

        public static bool ModificarCurso(Cursos curso)
        {
            using (SqlConnection conexion = new SqlConnection(Conexion.rutaConexion))
            {
                SqlCommand cmd = new SqlCommand("curso_modificar", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idcurso", curso.IdCurso);
                cmd.Parameters.AddWithValue("@curso", curso.Curso);
                cmd.Parameters.AddWithValue("@horas", curso.Horas);

                try
                {
                    conexion.Open();
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }

        public static List<Cursos> ListarCurso()
        {
            List<Cursos> listar = new List<Cursos>();
            using (SqlConnection conexion = new SqlConnection(Conexion.rutaConexion))
            {
                SqlCommand cmd = new SqlCommand("curso_listar", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                try
                {
                    conexion.Open();

                    using(SqlDataReader dreader = cmd.ExecuteReader())
                    {
                        while (dreader.Read())
                        {
                            listar.Add(new Cursos()
                            {
                                IdCurso = Convert.ToInt32(dreader["IdCurso"]),
                                Curso = dreader["Curso"].ToString(),
                                Horas = dreader["Horas"].ToString(),
                                FechaRegistroEstu = Convert.ToDateTime(dreader["FechaRegistroEstu"].ToString())

                            });
                        }
                    }
                    return listar;
                }
                catch (Exception ex)  
                {
                    return listar;
                }
            }
        }
        
        public static Cursos ObtenerCurso (int idcurso)
        {
            Cursos cur = new Cursos();
            using (SqlConnection conexion = new SqlConnection(Conexion.rutaConexion))
            {
                SqlCommand cmd = new SqlCommand("curso_obtener", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idcurso", idcurso);

                try
                {
                    conexion.Open();
                    cmd.ExecuteNonQuery();

                    using (SqlDataReader dreader = cmd.ExecuteReader())
                    {
                        while (dreader.Read())
                        {
                            cur = new Cursos()
                            {
                                IdCurso = Convert.ToInt32(dreader["IdCurso"]),
                                Curso = dreader["Curso"].ToString(),
                                Horas = dreader["Horas"].ToString(),
                                FechaRegistroEstu = Convert.ToDateTime(dreader["FechaRegistroEstu"].ToString())
                            };
                        }
                    }
                    return cur;
                }
                catch(Exception ex)
                {
                    return cur; 
                }
            }
        }

        public static bool EliminarCurso(int id)
        {
            using (SqlConnection conexion = new SqlConnection(Conexion.rutaConexion))
            {
                SqlCommand cmd = new SqlCommand("curso_eliminar", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idcurso", id);

                try
                {
                    conexion.Open();
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }

    }
}