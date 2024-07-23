using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace EscuelaFutbol
{
    internal class AlumnoDAL
    {
        public static int AgregarAlumno(Alumnos alumno)
        {
            int retorna = 0;

            using (SqlConnection connection = ConexionBD.obtenerConexion())
            {
                string query = "spAgregarAlumno";
                using (SqlCommand comando = new SqlCommand(query, connection))
                {
                    comando.CommandType = System.Data.CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@Nombre", alumno.Nombre);
                    comando.Parameters.AddWithValue("@Apellido", alumno.Apellido);
                    comando.Parameters.AddWithValue("@DNI", alumno.DNI);
                    comando.Parameters.AddWithValue("@FechaNacimiento", alumno.FechaNacimiento);
                    comando.Parameters.AddWithValue("@CategoriaID", alumno.CategoriaID);
                    comando.Parameters.AddWithValue("@PuestoPrincipalID", alumno.PuestoPrincipalID);
                    comando.Parameters.AddWithValue("@PuestoEspecificoID", alumno.PuestoEspecificoID);

                    try
                    {
                        connection.Open();
                        retorna = Convert.ToInt32(comando.ExecuteScalar());
                    }
                    catch (Exception ex)
                    {
                        throw new ApplicationException("Error al agregar el alumno: " + ex.Message);
                    }
                    finally
                    {
                        if (connection.State == System.Data.ConnectionState.Open)
                        {
                            connection.Close();
                        }
                    }
                }
            }
            return retorna;
        }

        public static int ActualizarAlumno(Alumnos alumno)
        {
            int filasAfectadas = 0;

            using (SqlConnection connection = ConexionBD.obtenerConexion())
            {
                string query = "spActualizarAlumno";
                using (SqlCommand comando = new SqlCommand(query, connection))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@AlumnoID", alumno.AlumnoID);
                    comando.Parameters.AddWithValue("@Nombre", alumno.Nombre);
                    comando.Parameters.AddWithValue("@Apellido", alumno.Apellido);
                    comando.Parameters.AddWithValue("@DNI", alumno.DNI);
                    comando.Parameters.AddWithValue("@FechaNacimiento", alumno.FechaNacimiento);
                    comando.Parameters.AddWithValue("@CategoriaID", alumno.CategoriaID);
                    comando.Parameters.AddWithValue("@PuestoPrincipalID", alumno.PuestoPrincipalID);
                    comando.Parameters.AddWithValue("@PuestoEspecificoID", alumno.PuestoEspecificoID);

                    // Parámetro de retorno
                    SqlParameter returnValue = new SqlParameter("@Return_Value", SqlDbType.Int);
                    returnValue.Direction = ParameterDirection.ReturnValue;
                    comando.Parameters.Add(returnValue);

                    try
                    {
                        connection.Open();
                        comando.ExecuteNonQuery();
                        filasAfectadas = (int)returnValue.Value;
                    }
                    catch (Exception ex)
                    {
                        throw new ApplicationException("Error al actualizar el alumno: " + ex.Message + "\n" + ex.StackTrace);
                    }
                    finally
                    {
                        if (connection.State == ConnectionState.Open)
                        {
                            connection.Close();
                        }
                    }
                }
            }
            return filasAfectadas;
        }

        public static List<Alumnos> ListarAlumnos()
        {
            List<Alumnos> listaAlumnos = new List<Alumnos>();

            using (SqlConnection connection = ConexionBD.obtenerConexion())
            {
                string query = "spListarAlumnos";
                using (SqlCommand comando = new SqlCommand(query, connection))
                {
                    comando.CommandType = CommandType.StoredProcedure;

                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = comando.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Alumnos alumno = new Alumnos
                                {
                                    AlumnoID = reader.GetInt32(reader.GetOrdinal("AlumnoID")),
                                    Nombre = reader.GetString(reader.GetOrdinal("Nombre")),
                                    Apellido = reader.GetString(reader.GetOrdinal("Apellido")),
                                    DNI = reader.GetString(reader.GetOrdinal("DNI")),
                                    FechaNacimiento = reader.GetDateTime(reader.GetOrdinal("FechaNacimiento")),
                                    Activo = reader.GetBoolean(reader.GetOrdinal("Activo")),
                                    CategoriaID = reader.IsDBNull(reader.GetOrdinal("CategoriaID")) ? (int?)null : reader.GetInt32(reader.GetOrdinal("CategoriaID")),
                                    PuestoPrincipalID = reader.IsDBNull(reader.GetOrdinal("PuestoPrincipalID")) ? (int?)null : reader.GetInt32(reader.GetOrdinal("PuestoPrincipalID")),
                                    PuestoEspecificoID = reader.IsDBNull(reader.GetOrdinal("PuestoEspecificoID")) ? (int?)null : reader.GetInt32(reader.GetOrdinal("PuestoEspecificoID"))
                                };
                                listaAlumnos.Add(alumno);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        throw new ApplicationException("Error al listar los alumnos: " + ex.Message + "\n" + ex.StackTrace);
                    }
                    finally
                    {
                        if (connection.State == ConnectionState.Open)
                        {
                            connection.Close();
                        }
                    }
                }
            }
            return listaAlumnos;
        }

        public static int EliminarAlumno(int alumnoID)
        {
            int filasAfectadas = 0;

            using (SqlConnection connection = ConexionBD.obtenerConexion())
            {
                string query = "spEliminarAlumno";
                using (SqlCommand comando = new SqlCommand(query, connection))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@AlumnoID", alumnoID);

                    // Parámetro de retorno
                    SqlParameter returnValue = new SqlParameter("@Return_Value", SqlDbType.Int);
                    returnValue.Direction = ParameterDirection.ReturnValue;
                    comando.Parameters.Add(returnValue);

                    try
                    {
                        connection.Open();
                        comando.ExecuteNonQuery();
                        filasAfectadas = (int)returnValue.Value;
                    }
                    catch (Exception ex)
                    {
                        throw new ApplicationException("Error al eliminar el alumno: " + ex.Message + "\n" + ex.StackTrace);
                    }
                    finally
                    {
                        if (connection.State == ConnectionState.Open)
                        {
                            connection.Close();
                        }
                    }
                }
            }
            return filasAfectadas;
        }


    }
}