using PruebaTecnica.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace PruebaTecnica.Data
{
    public class EstudianteData
    {
        public static bool Registrar(Estudiante estudiante)
        {
            using (SqlConnection conexion = new SqlConnection(Conexion.rutaConexion))
            {

                SqlCommand cmd = new SqlCommand("est_registrar", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ccestu", estudiante.CCEstu);
                cmd.Parameters.AddWithValue("@nombreestu", estudiante.NombreEstu);
                cmd.Parameters.AddWithValue("@apellidoestu", estudiante.ApellidoEstu);
                cmd.Parameters.AddWithValue("@emailestu", estudiante.EmailEstu);

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
        public static bool Modificar(Estudiante estudiante)
        {
            using (SqlConnection conexion = new SqlConnection(Conexion.rutaConexion))
            {

                SqlCommand cmd = new SqlCommand("est_modificar", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idestudiante", estudiante.IdEstudiante);
                cmd.Parameters.AddWithValue("@ccestu", estudiante.CCEstu);
                cmd.Parameters.AddWithValue("@nombreestu", estudiante.NombreEstu);
                cmd.Parameters.AddWithValue("@apellidoestu", estudiante.ApellidoEstu);
                cmd.Parameters.AddWithValue("@emailestu", estudiante.EmailEstu);

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

        public static List<Estudiante> Listar()
        {
            List<Estudiante> lista = new List<Estudiante>();
            using (SqlConnection conexion = new SqlConnection(Conexion.rutaConexion))
            {
                SqlCommand cmd = new SqlCommand("est_listar", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                try
                {
                    conexion.Open();

                    using (SqlDataReader dreader = cmd.ExecuteReader())
                    {

                        while (dreader.Read())
                        {
                            lista.Add(new Estudiante()
                            {
                                IdEstudiante = Convert.ToInt32(dreader["IdEstudiante"]),
                                CCEstu = dreader["CCEstu"].ToString(),
                                NombreEstu = dreader["NombreEstu"].ToString(),
                                ApellidoEstu = dreader["ApellidoEstu"].ToString(),
                                EmailEstu = dreader["EmailEstu"].ToString(),
                                FechaRegistroEstu = Convert.ToDateTime(dreader["FechaRegistroEstu"].ToString())
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

        public static Estudiante Obtener (int idestudiante)
        {
            Estudiante est = new Estudiante();
            using (SqlConnection conexion = new SqlConnection(Conexion.rutaConexion))
            {
                SqlCommand cmd = new SqlCommand("est_obtener", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idestudiante", idestudiante);

                try
                {
                    conexion.Open();
                    cmd.ExecuteNonQuery();

                    using (SqlDataReader dreader = cmd.ExecuteReader())
                    {
                        while (dreader.Read())
                        {
                            est = new Estudiante()
                            {
                                IdEstudiante = Convert.ToInt32(dreader["IdEstudiante"]),
                                CCEstu = dreader["CCEstu"].ToString(),
                                NombreEstu = dreader["NombreEstu"].ToString(),
                                ApellidoEstu = dreader["ApellidoEstu"].ToString(),
                                EmailEstu = dreader["EmailEstu"].ToString(),
                                FechaRegistroEstu = Convert.ToDateTime(dreader["FechaRegistroEstu"].ToString())
                            };
                        }
                    }
                    return est;
                }
                catch (Exception ex) { 
                }
                return est;   
                
            }
        }

        public static bool Eliminar(int id)
        {
            using (SqlConnection conexion = new SqlConnection(Conexion.rutaConexion))
            {
                SqlCommand cmd = new SqlCommand("est_eliminar", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue ("@idestudiante", id);

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