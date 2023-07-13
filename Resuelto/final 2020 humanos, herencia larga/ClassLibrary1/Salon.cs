using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    // Generar la clase genérico Salón. Contiene el atributo elementos:List del tipo genérico.
    // (este sólo se podrá inicializar en el constructor por defécto, que además será privado)
    // y el atributo capacidad:int (generar un constructor público que lo reciba como parámetro).
    // Sobrecarga en el operador +.
    // Al sumar un Salón con un elemento de tipo Persona, se deberá agregar a la lista de elementos
    // SÓLO si el idioma de la persona es Español y aún hay lugar en el salon.
    //Eventos
    //Agregar en la clase Salón que, si se llego al limite de capacidad, se lance un evento SalonLlenoEvent.
    //Esto mostrará un mensaje en el manejador Salon_SalonLlenoEvent (realizarlo según convenciones).
    //Agregar en la clase Salon que, si el idioma no es español, se lance un evento SalonNoEspañolEvent.
    //Esto mostrará un mensaje en el manejador Salon_SalonNoEspañolEvent (realizarlo según convenciones).

    public class Salon<T>
    {
        private List<T> elementos;
        private int capacidad;

        public event EventHandler SalonLlenoEvent;
        public event EventHandler SalonNoEspañolEvent;

        public Salon(int capacidad)
        {
            elementos = new List<T>();
            this.capacidad = capacidad;
        }

        public static Salon<T> operator +(Salon<T> salon, T elemento)
        {
            if (elemento is Persona persona)
            {
                if (persona.EIdioma != EIdioma.Español)
                {
                    salon.SalonNoEspañolEvent?.Invoke(salon, EventArgs.Empty);
                }
                else if (salon.elementos.Count >= salon.capacidad)
                {
                    salon.SalonLlenoEvent?.Invoke(salon, EventArgs.Empty);
                }
                else
                {
                    salon.elementos.Add(elemento);
                }
            }

            return salon;
        }

    }
}
