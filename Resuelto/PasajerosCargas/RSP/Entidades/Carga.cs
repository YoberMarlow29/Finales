using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Entidades
{
    public class Carga : ISerializador<Carga>
    {
        public int codigo;
        public string tipo;
        public double peso;

        public override string ToString()
        {
            return $"CÓDIGO:{this.codigo}-TIPO:{this.tipo}-PESO:{this.peso}";
        }

        public override bool Equals(object? obj)
        {
            if (obj is Carga otroCarga)
            {
                return codigo == otroCarga.codigo;
            }

            return false;
        }

        public bool Escribir(string path, Carga obj)
        {
            bool retorno = false;
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Carga));

                using (FileStream fileStream = new FileStream(path, FileMode.Create))
                {
                    serializer.Serialize(fileStream, obj);
                    retorno = true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al serializar la lista en formato XML y guardar en el archivo '" + path + "': " + ex.Message, ex);
                retorno = false;
            }
            return retorno;
        }

        public List<Carga> Leer(string path, Action<string> mensaje)
        {
            List<Carga> listaCargas = new List<Carga>();
            XmlSerializer serializer = new XmlSerializer(typeof(List<Carga>));
            try
            {
                if (File.Exists(path))
                {
                    using (TextReader reader = new StreamReader(path))
                    {
                        listaCargas = (List<Carga>)serializer.Deserialize(reader);
                    }
                }
                else
                {
                    mensaje?.Invoke($"El archivo '{path}' no existe.");
                }
            }
            catch (Exception ex)
            {
                mensaje?.Invoke($"Error al leer el archivo '{path}': {ex.Message}");
            }
            return listaCargas;
        }
    }
}
