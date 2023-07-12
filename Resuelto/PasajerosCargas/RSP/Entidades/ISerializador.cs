using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{

    ///Crear la interface genérica ISerializador<T> (en el proyecto Class Library), con los métodos: 
    ///Escribir(string, T) : bool
    ///-->El primer parámetro indica el path dónde se encuentra el archivo.
    ///-->El segundo parámetro es el objeto T a ser serializado.
    ///-->Retorna true si se pudo serializar, false, caso contrario.
    ///Leer(string, Action<String>) : List<T>
    ///-->El primer parámetro indica el path dónde se encuentra el archivo.
    ///-->El segundo parámetro es un Action que contendrá el mensaje de éxito o de fracazo, según se pueda
    ///o no deserializar. Los mensajes se deben mostrar en lblMensaje.
    ///-->Retorna una lista genérica con los objetos deserializados. Mostrarlos en lstVisor.
    ///
    public interface ISerializador<T>
    {
        public bool Escribir(string path, T obj);
        public List<T > Leer(string path,Action<string> mensaje);
    }
}
