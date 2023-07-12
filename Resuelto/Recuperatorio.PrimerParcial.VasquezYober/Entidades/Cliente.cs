using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cliente : Persona
    {
        private ENacionaliad nacionaliad;
        public ENacionaliad Nacionaliad { get => nacionaliad; set => nacionaliad = value; }
        public Cliente() 
        {
            
        }
        public Cliente(string nombre, string apellido, int edad, int dni, ENacionaliad nacionaliad):base(nombre,apellido,edad,dni)
        {
            this.nacionaliad = nacionaliad;
        }

        public string MostrarCliente() 
        {
            return $"{base.apellido}, {base.nombre} - DNI: {base.GetHashCode()}";

        }

        public override string ToString()
        {
            return MostrarCliente();
        }
        public override int GetHashCode()
        {
            return this.Dni;
        }
    }
}
