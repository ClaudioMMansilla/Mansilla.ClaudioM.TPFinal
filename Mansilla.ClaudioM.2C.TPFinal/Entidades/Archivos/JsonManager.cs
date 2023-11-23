using System;
using Entidades.Modelos;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using Entidades.Excepciones;

namespace Entidades.Archivos
{
    public static class JsonManager<T>
    {
        public static void SerializarJson(T obj, string path)
        {
            using (StreamWriter sw = new StreamWriter(path))
            {
                JsonSerializerOptions options = new JsonSerializerOptions();
                options.WriteIndented = true;

                string jsonFile = JsonSerializer.Serialize(obj, options);
                sw.WriteLine(jsonFile);
            }
        }

        public static T DeserializarJson(string path)
        {
            using (StreamReader sr = new StreamReader(path))
            {
                try
                {
                    string json = sr.ReadToEnd();
                    if (json != null)
                    {
                        return JsonSerializer.Deserialize<T>(json);
                    }
                }
                catch (OutOfMemoryException ex) { throw new FileManagerException("Sin memoria suficiente", ex); }
                catch (IOException ex) { throw new FileManagerException("Input Output error", ex); }
                catch (JsonException ex) { throw new FileManagerException(ex.Message, ex); }
                catch (Exception ex) { }
            }
            return default(T);
        }
    }
}
