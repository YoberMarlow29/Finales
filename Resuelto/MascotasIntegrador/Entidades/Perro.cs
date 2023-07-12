using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Perro : Mascota
    {
        private int edad;
        private bool esAlfa;

        public Perro(string nombre, string raza) : base(nombre, raza)
        {
            this.edad = 0;
            this.esAlfa = false;
        }

        public Perro(string nombre, string raza, int edad, bool esAlfa):this(nombre,raza)
        {
            this.edad = edad;
            this.esAlfa = esAlfa;
        }

        protected override string Ficha()
        {
            if (this.esAlfa == true)
            {
                return $"perro - {Nombre} - {Raza}, alfa de la manada, edad {edad}";
            }
            else 
            {
                return $"perro - {Nombre} - {Raza}, edad {edad}";
            }
        }

        public static bool operator ==(Perro p1, Perro p2)
        {
            return p1 is not null && p2 is not null && p1.Nombre == p2.Nombre && p1.Raza == p2.Raza && p1.edad == p2.edad;
        }
        public static bool operator !=(Perro p1, Perro p2)
        {
            return !(p1 == p2);
        }
        public static explicit operator int(Perro perro)
        {
            return perro.edad;
        }
        public override string ToString()
        {
            return base.DatosCompletos() + $"- Edad: {this.edad}";
        }

        public override bool Equals(object? obj)
        {
            bool ok = false;
            if (obj is Perro)
            {
                if (this == ((Perro)obj))
                {
                    ok = true;
                }
            }
            return ok;
        }
    }
}
