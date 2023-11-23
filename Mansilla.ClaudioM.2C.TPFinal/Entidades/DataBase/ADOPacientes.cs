using Entidades.Excepciones;
using Entidades.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.DataBase
{
    public class ADOPacientes
    {
        private static string stringConnection;
        private static SqlConnection connection;

        static ADOPacientes()
        {
            ADOPacientes.stringConnection = DBManager.StringConnection;
        }

        public static Paciente GetPacienteByDni (int dni)
        {
            try
            {
                using (ADOPacientes.connection = new SqlConnection(ADOPacientes.stringConnection))
                {
                    string query = "SELECT * FROM pacientes WHERE dni = @paciente";
                    SqlCommand command = new SqlCommand(query, ADOPacientes.connection);
                    command.Parameters.AddWithValue("paciente", dni);
                    ADOPacientes.connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows && reader.Read())
                    {
                        Paciente paciente = new Paciente();
                        paciente.Dni = reader.GetInt32("dni");
                        paciente.Nombre = reader.GetString("nombre");
                        paciente.Apellido = reader.GetString("apellido");
                        paciente.FechaNac = reader.GetDateTime("fechaNac");
                        paciente.SangreGrupo = reader.GetString("sangreGrupo");
                        paciente.SangreFactor = reader.GetString("sangreFactor");
                        return paciente;
                    }
                    else
                    {
                        throw new ReaderIsNullException("No se han encontrado resultados");
                    }
                }
            }
            catch (Exception ex)
            {
                throw new DBManagerException($"Ha ocurrido un error: {ex.Message}", ex);
            }
        }

        public static List<Paciente> GetAllPacientes()
        {
            try
            {
                using (ADOPacientes.connection = new SqlConnection(ADOPacientes.stringConnection))
                {
                    List<Paciente> pacientes = new List<Paciente>();
                    string query = "SELECT * FROM pacientes";
                    SqlCommand command = new SqlCommand(query, ADOPacientes.connection);
                    ADOPacientes.connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if(reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Paciente paciente = new Paciente();
                            paciente.Dni = reader.GetInt32("dni");
                            paciente.Nombre = reader.GetString("nombre");
                            paciente.Apellido = reader.GetString("apellido");
                            paciente.FechaNac = reader.GetDateTime("fechaNac");
                            paciente.SangreGrupo = reader.GetString("sangreGrupo");
                            paciente.SangreFactor = reader.GetString("sangreFactor");
                            pacientes.Add(paciente);
                        }
                        return pacientes;
                    }
                    else
                    {
                        throw new ReaderIsNullException("No se han encontrado resultados");
                    }
                }
            }
            catch (Exception ex)
            {
                throw new DBManagerException("Ha ocurrido un error", ex);
            }
        }

        public static List<Paciente> GetAllPacientesByEstado(int estado)
        {
            try
            {
                using (ADOPacientes.connection = new SqlConnection(ADOPacientes.stringConnection))
                {
                    List<Paciente> pacientes = new List<Paciente>();
                    string query = "SELECT dni, nombre, apellido, fechaNac," +
                        "sangreGrupo, sangreFactor, causaHerida " +
                        "FROM pacientes AS P INNER JOIN emergencias AS E ON P.dni = E.dniPaciente WHERE E.inQueue=@estado";

                    SqlCommand command = new SqlCommand(query, ADOPacientes.connection);
                    command.Parameters.AddWithValue("estado", estado);
                    ADOPacientes.connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Paciente paciente = new Paciente();
                            paciente.Dni = reader.GetInt32("dni");
                            paciente.Nombre = reader.GetString("nombre");
                            paciente.Apellido = reader.GetString("apellido");
                            paciente.FechaNac = reader.GetDateTime("fechaNac");
                            paciente.SangreGrupo = reader.GetString("sangreGrupo");
                            paciente.SangreFactor = reader.GetString("sangreFactor");
                            paciente.CausaHerida = reader.GetString("causaHerida");
                            pacientes.Add(paciente);
                        }
                        return pacientes;
                    }
                    else
                    {
                        throw new ReaderIsNullException("No se han encontrado resultados");
                    }
                }
            }
            catch (Exception ex)
            {
                throw new DBManagerException($"Ha ocurrido un error: {ex.Message}", ex);
            }
        }

        public static Queue<Paciente> GetQueuePacientes(int estado)
        {
            try
            {
                using (ADOPacientes.connection = new SqlConnection(ADOPacientes.stringConnection))
                {
                    Queue<Paciente> pacientes = new Queue<Paciente>();
                    string query = "SELECT dni, nombre, apellido, fechaNac," +
                        "sangreGrupo, sangreFactor, causaHerida " +
                        "FROM pacientes AS P INNER JOIN emergencias AS E ON P.dni = E.dniPaciente WHERE E.inQueue=@estado";

                    SqlCommand command = new SqlCommand(query, ADOPacientes.connection);
                    command.Parameters.AddWithValue("estado", estado);
                    ADOPacientes.connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Paciente paciente = new Paciente();
                            paciente.Dni = reader.GetInt32("dni");
                            paciente.Nombre = reader.GetString("nombre");
                            paciente.Apellido = reader.GetString("apellido");
                            paciente.FechaNac = reader.GetDateTime("fechaNac");
                            paciente.SangreGrupo = reader.GetString("sangreGrupo");
                            paciente.SangreFactor = reader.GetString("sangreFactor");
                            paciente.CausaHerida = reader.GetString("causaHerida");
                            pacientes.Enqueue(paciente);
                        }
                        return pacientes;
                    }
                    else
                    {
                        throw new ReaderIsNullException("No se han encontrado resultados");
                    }
                }
            }
            catch (Exception ex)
            {
                throw new DBManagerException($"Ha ocurrido un error: {ex.Message}", ex);
            }
        }

        public static bool InsertPaciente(Paciente p)
        {
            try
            {
                using (ADOPacientes.connection = new SqlConnection(ADOPacientes.stringConnection))
                {
                    string query = "INSERT INTO pacientes (dni,nombre,apellido,fechaNac,sangreGrupo,sangreFactor) " +
                        "values (@dni, @nombre, @apellido, @fecha, @sangreG, @sangreF);";
                    SqlCommand command = new SqlCommand(query, ADOPacientes.connection);
                    command.Parameters.AddWithValue("dni", p.Dni);
                    command.Parameters.AddWithValue("nombre", p.Nombre);
                    command.Parameters.AddWithValue("apellido", p.Apellido);
                    command.Parameters.AddWithValue("fecha", p.FechaNac);
                    command.Parameters.AddWithValue("sangreG", p.SangreGrupo);
                    command.Parameters.AddWithValue("sangreF", p.SangreFactor);
                    ADOPacientes.connection.Open();
                    int filasAfectadas = command.ExecuteNonQuery();
                    return filasAfectadas > 0;
                }
            }
            catch (Exception ex)
            {
                throw new DBManagerException($"Ha ocurrido un error: {ex.Message}", ex);
            }
        }

        public static bool UpdatePaciente(Paciente p)
        {
            try
            {
                using (ADOPacientes.connection = new SqlConnection(ADOPacientes.stringConnection))
                {
                    string query = "UPDATE pacientes set nombre=@nombre, apellido=@apellido, fechaNac =@fecha, sangreGrupo=@sangreG, sangreFactor=@sangreF" +
                        " WHERE dni=@dni;";
                    SqlCommand command = new SqlCommand(query, ADOPacientes.connection);
                    command.Parameters.AddWithValue("dni", p.Dni);
                    command.Parameters.AddWithValue("nombre", p.Nombre);
                    command.Parameters.AddWithValue("apellido", p.Apellido);
                    command.Parameters.AddWithValue("fecha", p.FechaNac);
                    command.Parameters.AddWithValue("sangreG", p.SangreGrupo);
                    command.Parameters.AddWithValue("sangreF", p.SangreFactor);
                    ADOPacientes.connection.Open();
                    int filasAfectadas = command.ExecuteNonQuery();
                    return filasAfectadas > 0;
                }
            }
            catch (Exception ex)
            {
                throw new DBManagerException($"Ha ocurrido un error: {ex.Message}", ex);
            }
        }

        public static bool DeletePaciente(Paciente p)
        {
            try
            {
                using (ADOPacientes.connection = new SqlConnection(ADOPacientes.stringConnection))
                {
                    string query = "DELETE FROM pacientes WHERE dni=@dni;";
                    SqlCommand command = new SqlCommand(query, ADOPacientes.connection);
                    command.Parameters.AddWithValue("dni", p.Dni);
                    ADOPacientes.connection.Open();
                    int filasAfectadas = command.ExecuteNonQuery();
                    return filasAfectadas > 0;
                }
            }
            catch (Exception ex)
            {
                throw new DBManagerException("Ha ocurrido un error, no se pudo procesar alta del paciente", ex);
            }
        }

        public static bool DeletePaciente(int dni)
        {
            try
            {
                using (ADOPacientes.connection = new SqlConnection(ADOPacientes.stringConnection))
                {
                    string query = "DELETE FROM pacientes WHERE dni=@dni;";
                    SqlCommand command = new SqlCommand(query, ADOPacientes.connection);
                    command.Parameters.AddWithValue("dni", dni);
                    ADOPacientes.connection.Open();
                    int filasAfectadas = command.ExecuteNonQuery();
                    return filasAfectadas > 0;
                }
            }
            catch (Exception ex)
            {
                throw new DBManagerException($"Ha ocurrido un error: {ex.Message}", ex);
            }
        }
    }
}
