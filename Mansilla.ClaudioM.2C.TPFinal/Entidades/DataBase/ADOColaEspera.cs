using Entidades.Enum;
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
    public class ADOColaEspera
    {
        private static string stringConnection;
        private static SqlConnection connection;

        static ADOColaEspera()
        {
            ADOColaEspera.stringConnection = DBManager.StringConnection;
        }

        public static bool EnqueuePaciente(Paciente p)
        {
            try
            {
                using (ADOColaEspera.connection = new SqlConnection(ADOColaEspera.stringConnection))
                {
                    string query = "INSERT INTO emergencias (dniPaciente,causaHerida,inQueue)" +
                        "values (@dniPaciente,@causaHerida, @inQueue);";

                    SqlCommand command = new SqlCommand(query, ADOColaEspera.connection);
                    command.Parameters.AddWithValue("dniPaciente", p.Dni);
                    command.Parameters.AddWithValue("causaHerida", p.CausaHerida);
                    command.Parameters.AddWithValue("inQueue", (int)EEstadoAtencion.Pendiente);
                    connection.Open();
                    int filasAfectadas = command.ExecuteNonQuery();
                    return filasAfectadas > 0;
                }
            }
            catch (Exception ex)
            {
                throw new DBManagerException("Ha ocurrido un error", ex);
            }
        }

        public static bool DequeuePaciente(Paciente p, Medico m)
        {
            try
            {
                using (ADOColaEspera.connection = new SqlConnection(ADOColaEspera.stringConnection))
                {
                    string query = "UPDATE emergencias SET tratamiento =@tratamiento, dniMedico =@dniM, inQueue =@inQueue " +
                        "WHERE dniPaciente = @dniP;";

                    SqlCommand command = new SqlCommand(query, ADOColaEspera.connection);
                    command.Parameters.AddWithValue("tratamiento", p.Tratamiento);
                    command.Parameters.AddWithValue("dniM", m.Dni);
                    command.Parameters.AddWithValue("inQueue", (int)EEstadoAtencion.Atendido);
                    command.Parameters.AddWithValue("dniP", p.Dni);
                    connection.Open();
                    int filasAfectadas = command.ExecuteNonQuery();
                    return filasAfectadas > 0;
                }
            }
            catch (Exception ex)
            {
                throw new DBManagerException("Ha ocurrido un error", ex);
            }
        }

    }
}
