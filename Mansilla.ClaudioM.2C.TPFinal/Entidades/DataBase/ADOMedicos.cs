using System.Data.SqlClient;
using System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Excepciones;
using Entidades.Modelos;

namespace Entidades.DataBase
{
    public static class ADOMedicos
    {
        private static string stringConnection;
        private static SqlConnection connection;

        static ADOMedicos()
        {
            ADOMedicos.stringConnection = DBManager.StringConnection;
        }

        public static Medico GetMedicoByDni(int dni)
        {
            try
            {
                using (ADOMedicos.connection = new SqlConnection(ADOMedicos.stringConnection))
                {
                    string query = "SELECT * FROM medicos WHERE dni = @medico";
                    SqlCommand command = new SqlCommand(query, ADOMedicos.connection);
                    command.Parameters.AddWithValue("medico", dni);
                    ADOMedicos.connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        Medico medico = new Medico();
                        medico.Dni = reader.GetInt32("dni");
                        medico.Nombre = reader.GetString("nombre");
                        medico.Apellido = reader.GetString("apellido");
                        medico.FechaNac = reader.GetDateTime("fechaNac");
                        medico.Matricula = reader.GetInt32("matricula");
                        return medico;
                    }
                    throw new ReaderIsNullException("No se han encontrado resultados");
                }
            }
            catch (Exception ex)
            {
                throw new DBManagerException("Ha ocurrido un error", ex);
            }
        }

        public static List<Medico> GetAllMedicos()
        {
            try
            {
                using (ADOMedicos.connection = new SqlConnection(ADOMedicos.stringConnection))
                {
                    List<Medico> medicos = new List<Medico>();
                    string query = "SELECT dni, nombre, apellido, fechaNac, matricula FROM medicos";

                    SqlCommand command = new SqlCommand(query, ADOMedicos.connection);
                    ADOMedicos.connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Medico medico = new Medico();
                            medico.Dni = reader.GetInt32("dni");
                            medico.Nombre = reader.GetString("nombre");
                            medico.Apellido = reader.GetString("apellido");
                            medico.FechaNac = reader.GetDateTime("fechaNac");
                            medico.Matricula = reader.GetInt32("matricula");

                            medicos.Add(medico);
                        }
                        return medicos;
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

        public static Queue<Medico> GetMedicos()
        {
            try
            {
                using (ADOMedicos.connection = new SqlConnection(ADOMedicos.stringConnection))
                {
                    Queue<Medico> medicos = new Queue<Medico>();
                    string query = "SELECT dni, nombre, apellido, fechaNac, matricula FROM medicos";

                    SqlCommand command = new SqlCommand(query, ADOMedicos.connection);
                    ADOMedicos.connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Medico medico = new Medico();
                            medico.Dni = reader.GetInt32("dni");
                            medico.Nombre = reader.GetString("nombre");
                            medico.Apellido = reader.GetString("apellido");
                            medico.FechaNac = reader.GetDateTime("fechaNac");
                            medico.Matricula = reader.GetInt32("matricula");

                            medicos.Enqueue(medico);
                        }
                        return medicos;
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

        public static bool AddNewMedico(Medico m)
        {
            try
            {
                using (ADOMedicos.connection = new SqlConnection(ADOMedicos.stringConnection))
                {
                    string query = "INSERT INTO medicos (dni,nombre,apellido,fechaNac,matricula) " +
                        "values (@dni, @nombre, @apellido, @fecha, @matricula);";
                    SqlCommand command = new SqlCommand(query, ADOMedicos.connection);
                    command.Parameters.AddWithValue("dni", m.Dni);
                    command.Parameters.AddWithValue("nombre", m.Nombre);
                    command.Parameters.AddWithValue("apellido", m.Apellido);
                    command.Parameters.AddWithValue("fecha", m.FechaNac);
                    command.Parameters.AddWithValue("matricula", m.Matricula);
                    ADOMedicos.connection.Open();
                    int filasAfectadas = command.ExecuteNonQuery();
                    return filasAfectadas > 0;
                }
            }
            catch (Exception ex)
            {
                throw new DBManagerException("Ha ocurrido un error, no se pudo procesar alta del paciente", ex);
            }
        }

        public static bool DeleteMedico(Medico m)
        {
            try
            {
                using (ADOMedicos.connection = new SqlConnection(ADOMedicos.stringConnection))
                {
                    string query = "DELETE FROM pacientes WHERE dni=@dni;";
                    SqlCommand command = new SqlCommand(query, ADOMedicos.connection);
                    command.Parameters.AddWithValue("dni", m.Dni);
                    ADOMedicos.connection.Open();
                    int filasAfectadas = command.ExecuteNonQuery();
                    return filasAfectadas > 0;
                }
            }
            catch (Exception ex)
            {
                throw new DBManagerException("Ha ocurrido un error, no se pudo procesar alta del paciente", ex);
            }
        }

        public static bool DeleteMedico(int dni)
        {
            try
            {
                using (ADOMedicos.connection = new SqlConnection(ADOMedicos.stringConnection))
                {
                    string query = "DELETE FROM medicos WHERE dni=@dni;";
                    SqlCommand command = new SqlCommand(query, ADOMedicos.connection);
                    command.Parameters.AddWithValue("dni", dni);
                    ADOMedicos.connection.Open();
                    int filasAfectadas = command.ExecuteNonQuery();
                    return filasAfectadas > 0;
                }
            }
            catch (Exception ex)
            {
                throw new DBManagerException("Ha ocurrido un error, no se pudo procesar alta del paciente", ex);
            }
        }
    }
}
