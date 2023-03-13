using ApiAsignacion.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.EnterpriseServices.Internal;
using System.Linq;
using System.Web;

namespace ApiAsignacion.Data
{
    public class AsigCursosData
    {
        public static bool RegistrarAsig(AsignacionCursos asignacion)
        {
            using (SqlConnection conexion = new SqlConnection(Conexion.rutaConexion))
            {
                SqlCommand cmd = new SqlCommand("asig_curso", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idestudiante", asignacion.IdEstudiante);
                cmd.Parameters.AddWithValue("@ccestudiante", asignacion.CCEstudiante);
                cmd.Parameters.AddWithValue("@nombreestud", asignacion.NombreEstu);
                cmd.Parameters.AddWithValue("@apellidoestud", asignacion.ApellidoEstu);
                cmd.Parameters.AddWithValue("@emailestud", asignacion.EmailEstu);
                cmd.Parameters.AddWithValue("@idcurso", asignacion.IdCurso);
                cmd.Parameters.AddWithValue("@nomcurso", asignacion.NombreCurso);
                cmd.Parameters.AddWithValue("@horascurso", asignacion.HorasCurso);

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

        public static bool ModificarAsigo(AsignacionCursos asignacion)
        {
            using (SqlConnection conexion = new SqlConnection(Conexion.rutaConexion))
            {
                SqlCommand cmd = new SqlCommand("modi_curso", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idasignacion", asignacion.IdAsignacion);
                cmd.Parameters.AddWithValue("@idestudiante", asignacion.IdEstudiante);
                cmd.Parameters.AddWithValue("@ccestudiante", asignacion.CCEstudiante);
                cmd.Parameters.AddWithValue("@nombreestud", asignacion.NombreEstu);
                cmd.Parameters.AddWithValue("@apellidoestud", asignacion.ApellidoEstu);
                cmd.Parameters.AddWithValue("@emailestud", asignacion.EmailEstu);
                cmd.Parameters.AddWithValue("@idcurso", asignacion.IdCurso);
                cmd.Parameters.AddWithValue("@nomcurso", asignacion.NombreCurso);
                cmd.Parameters.AddWithValue("@horascurso", asignacion.HorasCurso);

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
        public static bool ModificarAsig(AsignacionCursos asignacion)
        {
            using (SqlConnection conexion = new SqlConnection(Conexion.rutaConexion))
            {
                SqlCommand cmd = new SqlCommand("modi_curso", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idasignacion", asignacion.IdAsignacion);
                cmd.Parameters.AddWithValue("@idestudiante", asignacion.IdEstudiante);
                cmd.Parameters.AddWithValue("@ccestudiante", asignacion.CCEstudiante);
                cmd.Parameters.AddWithValue("@nombreestud", asignacion.NombreEstu);
                cmd.Parameters.AddWithValue("@apellidoestud", asignacion.ApellidoEstu);
                cmd.Parameters.AddWithValue("@emailestud", asignacion.EmailEstu);
                cmd.Parameters.AddWithValue("@idcurso", asignacion.IdCurso);
                cmd.Parameters.AddWithValue("@nomcurso", asignacion.NombreCurso);
                cmd.Parameters.AddWithValue("@horascurso", asignacion.HorasCurso);

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
        public static List<AsignacionCursos> Listarcur()
        {
            List<AsignacionCursos> lista = new List<AsignacionCursos>();
            using (SqlConnection conexion = new SqlConnection(Conexion.rutaConexion))
            {
                SqlCommand cmd = new SqlCommand("listar_asig", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                try
                {
                    conexion.Open();

                    using (SqlDataReader dreader = cmd.ExecuteReader())
                    {

                        while (dreader.Read())
                        {
                            lista.Add(new AsignacionCursos()
                            {
                                IdAsignacion = Convert.ToInt32(dreader["IdAsignacion"]),
                                IdEstudiante = Convert.ToInt32(dreader["IdEstudiante"]),
                                CCEstudiante = dreader["CCEstudiante"].ToString(),
                                NombreEstu = dreader["NombreEstu"].ToString(),
                                ApellidoEstu = dreader["ApellidoEstu"].ToString(),
                                EmailEstu = dreader["EmailEstu"].ToString(),
                                IdCurso = Convert.ToInt32(dreader["IdCurso"]),
                                NombreCurso = dreader["NombreCurso"].ToString(),
                                HorasCurso = dreader["HorasCurso"].ToString(),
                                FechaRegistro = Convert.ToDateTime(dreader["FechaRegistro"].ToString())

                            });
                        }
                    }
                    return lista;
                }
                catch (Exception ex)
                {
                    return lista;
                }
            }
        }
        
        public static AsignacionCursos ObtenerRegistro(int idcurso)
        {
            AsignacionCursos asig = new AsignacionCursos();
            using (SqlConnection conexion = new SqlConnection(Conexion.rutaConexion))
            {
                SqlCommand cmd = new SqlCommand("obtener_asig", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idasignacion", idcurso);

                try
                {
                    conexion.Open();
                    cmd.ExecuteNonQuery();

                    using (SqlDataReader dreader = cmd.ExecuteReader())
                    {
                        while (dreader.Read())
                        {
                            asig = new AsignacionCursos()
                            {
                                IdAsignacion = Convert.ToInt32(dreader["IdAsignacion"]),
                                IdEstudiante = Convert.ToInt32(dreader["IdEstudiante"]),
                                CCEstudiante = dreader["CCEstudiante"].ToString(),
                                NombreEstu = dreader["NombreEstu"].ToString(),
                                ApellidoEstu = dreader["ApellidoEstu"].ToString(),
                                EmailEstu = dreader["EmailEstu"].ToString(),
                                IdCurso = Convert.ToInt32(dreader["IdCurso"]),
                                NombreCurso = dreader["NombreCurso"].ToString(),
                                HorasCurso = dreader["HorasCurso"].ToString(),
                                FechaRegistro = Convert.ToDateTime(dreader["FechaRegistro"].ToString())
                            };
                        }
                    }
                    return asig;
                }
                catch (Exception ex)
                {
                    return asig;
                }
            }
        }
        public static bool EliminarRegistro(int id)
        {
            using (SqlConnection conexion = new SqlConnection(Conexion.rutaConexion))
            {

                SqlCommand cmd = new SqlCommand("eliminar_asig", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idasignacion", id);

                try
                {
                    conexion.Open();
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (SqlException ex)
                {
                    return false;
                }
            }
        }
    }
}