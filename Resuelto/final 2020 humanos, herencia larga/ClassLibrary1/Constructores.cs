using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    //Crear la clase Constructores (en un class library) que al instanciarse:
    //    *pase por un constructor estático.
    //    *pase por un constructor que reciba 2 parámetros (privado).
    //    *pase por un constructor público (default).
    //    *pase por una propiedad de sólo escritura.
    //    *pase por una propiedad de sólo lectra.
    //    *pase por un método de instancia.
    //    *pase por un método de clase.
    //NOTA: respetar el orden establecido.
    //NOTA: por cada lugar que pase, mostrar con un MessageBox.Show dicho lugar
    //NOTA: agregar la referencia a System.Windows.Form; para poder acceder a la clase MessageBox.
    //NOTA: NO MAS DE 2 LINEAS DE CODIGO POR METODO/PROPIEDAD/CONSTRUCTOR

    public class Constructores
    {
        static Constructores()
        {
            // Constructor estático
        }

        private Constructores(int parametro1, int parametro2)
        {
            // Constructor privado que recibe 2 parámetros
        }

        public Constructores()
        {
            // Constructor público (default)
        }

        public int PropiedadSoloEscritura { get; set; }

        public int PropiedadSoloLectura { get; }

        public void MetodoInstancia()
        {
            // Método de instancia
        }

        public static void MetodoClase()
        {
            // Método de clase
        }

    }
}
