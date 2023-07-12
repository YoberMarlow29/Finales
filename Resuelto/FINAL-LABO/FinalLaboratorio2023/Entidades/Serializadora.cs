using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Serializadora<T> : ISerializable<T> where T : class
    {

        public bool Serializar(List<T> datos)
        {
            bool retorno = false;
            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "vasquez.json");

            try
            {
                string json = JsonConvert.SerializeObject(datos, Formatting.Indented);
                File.WriteAllText(path, json);
                retorno = true;
            }
            catch (Exception ex)
            {
                retorno = false;
            }
            return retorno;
        }
        public List<T> Deserializar()
        {

            #region
            //Deserializa una lista generica no abastracta
            /*string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "vasquez.json");

            try
            {
                if (File.Exists(path))
                {
                    string json = File.ReadAllText(path);
                    List<T> listaDeserializada = JsonConvert.DeserializeObject<List<T>>(json);
                    return listaDeserializada;
                }
                else
                {
                    throw new($"El archivo '{path}' no existe.");
                }
            }
            catch (Exception ex)
            {
                throw new($"Error al leer el archivo '{path}': {ex.Message}");
            }*/
            #endregion
            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "vasquez.json");

            try
            {
                if (File.Exists(path))
                {
                    string json = File.ReadAllText(path);
                    JArray jsonArray = JArray.Parse(json);
                    List<T> listaDeserializada = new List<T>();

                    foreach (JObject jsonObject in jsonArray)
                    {
                        int id = jsonObject["Id"].Value<int>();
                        string nombre = jsonObject["Nombre"].Value<string>();
                        double masa = jsonObject["Masa"].Value<double>();
                        double diametro = jsonObject["Diametro"].Value<double>();

                        if (jsonObject.ContainsKey("Satelites"))
                        {
                            int satelites = jsonObject["Satelites"].Value<int>();
                            Planeta planeta = new Planeta(id, nombre, masa, diametro, satelites);
                            listaDeserializada.Add(planeta as T);
                        }
                        else if (jsonObject.ContainsKey("TipoEspectral"))
                        {
                            string tipoEspectral = jsonObject["TipoEspectral"].Value<string>();
                            Estrella estrella = new Estrella(id, diametro, tipoEspectral, nombre, masa);
                            listaDeserializada.Add(estrella as T);
                        }
                    }

                    return listaDeserializada;
                }
                else
                {
                    throw new FileNotFoundException($"El archivo '{path}' no existe.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al leer el archivo '{path}': {ex.Message}");
            }
        }


    }
}
