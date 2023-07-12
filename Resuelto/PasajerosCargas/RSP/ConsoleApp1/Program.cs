//using System.Xml;
using Entidades;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pasajero pasajero = new Pasajero();
            List<Pasajero> lista = pasajero.ObtenerTodosBD();
            Console.WriteLine(lista.ToString());


            Console.ReadLine();
        }
    }
}
