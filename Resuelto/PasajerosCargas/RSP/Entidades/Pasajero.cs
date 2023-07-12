using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Pasajero : ISerializador<Pasajero>
    {
        public int dni;
        public string nombre;
        public int equipaje;

        public override string ToString()
        {
            return $"DNI:{this.dni}-NOMBRE:{this.nombre}- EQUIPAJE:{this.equipaje}";
        }

        public override bool Equals(object? obj)
        {
            if (obj is Pasajero otroPasajero)
            {
                return dni == otroPasajero.dni;
            }

            return false;
        }

        bool ISerializador<Pasajero>.Escribir(string path, Pasajero obj)
        {
            string json = JsonConvert.SerializeObject(obj, Formatting.Indented);
            bool retorno;
            try
            {
                File.WriteAllText(path, json);
                retorno = true;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al serializar el archivo '" + path + "': " + ex.Message, ex);
                retorno = false;
            }

            return retorno;
        }

        List<Pasajero> ISerializador<Pasajero>.Leer(string path, Action<string> mensaje)
        {
            List<Pasajero> listaPasajeros = new List<Pasajero>();
            try
            {
                if (File.Exists(path))
                {
                    string json = File.ReadAllText(path);
                    listaPasajeros = JsonConvert.DeserializeObject<List<Pasajero>>(json);
                }
                else
                {
                    mensaje?.Invoke($"El archivo '{path}' no existe.");
                }
            }
            catch (JsonException ex)
            {
                mensaje?.Invoke($"Error de deserialización en el archivo '{path}': {ex.Message}");
            }
            catch (Exception ex)
            {
                mensaje?.Invoke($"Error al leer el archivo '{path}': {ex.Message}");
            }
            return listaPasajeros;
        }
    }
}
