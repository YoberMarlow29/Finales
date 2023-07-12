using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Transporte<T>
    {
        protected int capacidad;
        protected List<T> items;

        public event EventHandler CapacidadCompleta;
        public event EventHandler ElementoRepetido;


        public List<T> Items { get => items; }

        private Transporte(int capacidad)
        {
            this.capacidad = capacidad;
            items = new List<T>();
        }

        public override string ToString()
        {
            return $"CAPACIDAD: {capacidad} - ELEMENTOS: {items.Count}";
        }

        public override bool Equals(object obj)
        {
            if (obj is T)
            {
                T item = (T)obj;
                return items.Contains(item);
            }
            return false;
        }

        public static implicit operator Transporte<T>(int capacidad)
        {
            return new Transporte<T>(capacidad);
        }

        public static bool operator ==(Transporte<T> transporte, T elemento)
        {
            if (transporte is null || transporte.items is null)
            {
                return false;
            }

            return transporte.items.Contains(elemento);
        }

        public static bool operator !=(Transporte<T> transporte, T elemento)
        {
            return !(transporte == elemento);
        }

        public static Transporte<T> operator +(Transporte<T> transporte, T elemento)
        {
            if (transporte is null)
            {
                throw new ArgumentNullException(nameof(transporte));
            }

            if (transporte.items is null)
            {
                transporte.items = new List<T>();
            }

            if (!transporte.items.Contains(elemento) && transporte.items.Count < transporte.capacidad)
            {
                transporte.items.Add(elemento);
            }

            return transporte;
        }
    }
}
