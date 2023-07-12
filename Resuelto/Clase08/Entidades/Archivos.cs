using Newtonsoft.Json;
using System.Xml.Serialization;

namespace Entidades
{
    public static class Archivos
    {
        private static string pathJsonLavadero= "lavadero.json";

        private static Lavadero lavaderoJson;

        static Archivos()
        {
            lavaderoJson = new Lavadero(400, 600, 200);

            CargarLavaderoJson();
        }

        private static void CargarLavaderoJson()
        {
            lavaderoJson = DeserializarJson(pathJsonLavadero);
        }
        public static void AgregarVehiculo(Vehiculo vehiculo)
        {
            lavaderoJson +=vehiculo;
        }

        public static Lavadero ObtenerLavaderojson() 
        {
            return lavaderoJson;
        }

        public static void GuardarVehiculo() 
        {
            SerializarJson(lavaderoJson,pathJsonLavadero);
        }

        public static Lavadero DeserializarJson(string path)
        {
            try
            {
                if (File.Exists(path))
                {
                    string json = File.ReadAllText(path);
                    Lavadero lista = JsonConvert.DeserializeObject<Lavadero>(json);
                    return lista;
                }
                else
                {
                    File.WriteAllText(path, string.Empty);
                    return new Lavadero();
                }
            }
            catch (JsonSerializationException ex)
            {
                throw new JsonSerializationException("Error de deserialización en el archivo '" + path + "': " + ex.Message, ex);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al deserializar el archivo '" + path + "': " + ex.Message, ex);
            }
        }
        public static void SerializarJson(Lavadero lista, string path)
        {
            string json = JsonConvert.SerializeObject(lista, Formatting.Indented);
            try
            {
                File.WriteAllText(path, json);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al serializar el archivo '" + path + "': " + ex.Message, ex);
            }
        }        
    }
}
