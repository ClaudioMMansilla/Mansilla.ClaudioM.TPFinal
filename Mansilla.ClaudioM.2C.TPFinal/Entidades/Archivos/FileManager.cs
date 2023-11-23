using Entidades.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Archivos
{
    public static class FileManager<T>
    {
        private static string pathImport = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "JsonPaciente.json");
        private static string pathExport = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), $"Paciente_Exportado.json");


        public static T ImportarArchivo()
        {
            return JsonManager<T>.DeserializarJson(pathImport);   
        }

        public static void ExportarArchivo(T obj)
        {
            JsonManager<T>.SerializarJson(obj,pathExport);
        }

        public static string GetPathExport()
        {
            return pathExport;
        }
    }

}
