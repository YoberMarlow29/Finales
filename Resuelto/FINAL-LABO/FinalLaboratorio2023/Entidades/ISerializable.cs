using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /*
    INTERFACE ISerializable<T>:
    Métodos:
    (+)Serializar(List<T>):bool --> Serializa en JSON en el escritorio.
    (+)Deserializar():List<T> --> Deserializa JSON desde el escritorio.
     */
    public interface ISerializable<T> where T : class
    {
        bool Serializar(List<T> datos);
        List<T> Deserializar();

    }
}
