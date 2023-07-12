using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Gato : Mascota
    {
        public Gato(string nombre, string raza) : base(nombre, raza)
        {
        }

        protected override string Ficha()
        {
            return base.DatosCompletos();
        }

        public static bool operator ==(Gato p1, Gato p2)
        {
            return p1 is not null && p2 is not null && p1.Nombre == p2.Nombre && p1.Raza == p2.Raza;
        }
        public static bool operator !=(Gato p1, Gato p2)
        {
            return !(p1 == p2);
        }

        public override string ToString()
        {
            return "gato-"+base.DatosCompletos();
        }

        public override bool Equals(object? obj)
        {
            bool ok = false;
            if (obj is Gato)
            {
                if (this == ((Gato)obj))
                {
                    ok = true;
                }
            }
            return ok;
        }
    }
}
