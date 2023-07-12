using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Auto : Vehiculo
    {
        protected int cantidadAsientos;    
        public Auto(int cantidadAsientos,string patente, byte cantRuedas, EMarcas marca):base(patente,cantRuedas,marca)
        {
            this.cantidadAsientos = cantidadAsientos;
        }

        protected override string Mostrar()
        {
            StringBuilder mensaje = new StringBuilder();
            mensaje.Append(base.Mostrar());
            mensaje.AppendLine($"cantidadAsientos: {this.cantidadAsientos}");
            return mensaje.ToString();
        }

        public override string ToString()
        {
            return this.Mostrar();
        }
    }
}
