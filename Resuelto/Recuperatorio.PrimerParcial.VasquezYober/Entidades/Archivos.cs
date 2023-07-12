using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Entidades
{
    public static class Archivos
    {
        public static string pathClientes;
        public static string pathUsuarios;
        public static List<Cliente> listaDeClientes;
        public static List<Usuario> listaDeUsuarios;

        static Archivos() 
        {
            listaDeClientes = new List<Cliente>();
            listaDeUsuarios = new List<Usuario>();
            pathClientes = "clientes.json";
            pathUsuarios = "usuarios.xml";
            CargarClientes();
            CargarUsuarios();
        }
        private static void CargarClientes()
        {
            listaDeClientes = DeserializarListaJson<Cliente>(pathClientes);
        }
        private static void CargarUsuarios()
        {
            listaDeUsuarios = DeserializarListaXml<Usuario>(pathUsuarios);
        }
        public static void AltaUsuario(Usuario usuarioNuevo)
        {
            if (usuarioNuevo is not null)
            {
                listaDeUsuarios.Add(usuarioNuevo);
            }
        }
        public static void AltaCliente(Cliente clienteNuevo)
        {
            if (clienteNuevo is not null)
            {
                listaDeClientes.Add(clienteNuevo);
            }
        }
        public static void BajaDeCliente(Cliente bajaCliente)
        {
            if (bajaCliente is not null)
            {
                listaDeClientes.Remove(bajaCliente);
            }
        }
        public static List<T> DeserializarListaJson<T>(string path)
        {
            try
            {
                if (File.Exists(path))
                {
                    string json = File.ReadAllText(path);
                    List<T> lista = JsonConvert.DeserializeObject<List<T>>(json);
                    return lista;
                }
                else
                {
                    File.WriteAllText(path, string.Empty);
                    return new List<T>();
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

        /// <summary>
        /// Serializa una lista de objetos en formato JSON y guarda el resultado en el archivo especificado.
        /// </summary>
        /// <typeparam name="T">Tipo de objeto a serializar.</typeparam>
        /// <param name="lista">La lista de objetos a serializar.</param>
        /// <param name="path">Ruta del archivo JSON.</param>
        public static void SerializarListaJson<T>(List<T> lista, string path)
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

        /// <summary>
        /// Deserializa un archivo XML en una lista de objetos del tipo especificado.
        /// </summary>
        /// <typeparam name="T">Tipo de objeto a deserializar.</typeparam>
        /// <param name="path">Ruta del archivo XML.</param>
        /// <returns>La lista de objetos deserializados.</returns>
        public static List<T> DeserializarListaXml<T>(string path)
        {
            try
            {
                if (File.Exists(path))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<T>));

                    using (FileStream fileStream = new FileStream(path, FileMode.Open))
                    {
                        List<T> lista = (List<T>)serializer.Deserialize(fileStream);
                        return lista;
                    }
                }
                else
                {
                    File.WriteAllText(path, string.Empty);
                    return new List<T>();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al deserializar el archivo XML '" + path + "': " + ex.Message, ex);
            }
        }

        /// <summary>
        /// Serializa una lista de objetos en formato XML y guarda el resultado en el archivo especificado.
        /// </summary>
        /// <typeparam name="T">Tipo de objeto a serializar.</typeparam>
        /// <param name="lista">La lista de objetos a serializar.</param>
        /// <param name="path">Ruta del archivo XML.</param>
        public static void SerializarListaXml<T>(List<T> lista, string path)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<T>));

                using (FileStream fileStream = new FileStream(path, FileMode.Create))
                {
                    serializer.Serialize(fileStream, lista);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al serializar la lista en formato XML y guardar en el archivo '" + path + "': " + ex.Message, ex);
            }
        }
    }
}
