using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuario :Persona
    {
        private int legajo;
        private string correo;
        private string clave;
        public int Legajo { get => legajo; set => legajo = value; }
        public string Correo { get => correo; set => correo = value; }
        public string Clave { get => clave; set => clave = value; }

        public Usuario() 
        {
        
        }

        public Usuario(string nombre,string apellido, string correo, string clave):base(nombre,apellido)
        {
            this.correo = correo;
            this.clave = clave;
        }
        public static bool operator ==(Usuario u1, Usuario u2)
        {
            return u1 is not null && u2 is not null && u1.correo == u2.correo && u1.clave == u2.clave;
        }
        public static bool operator !=(Usuario u1, Usuario u2)
        {
            return !(u1 == u2);
        }
        public override bool Equals(object? obj)
        {
            bool ok = false;
            if (obj is Usuario)
            {
                if (this == (Usuario)obj)
                {
                    ok = true;
                }
            }
            return ok;
        }
        public override int GetHashCode()
        {
            return this.Dni;
        }


    }
}
