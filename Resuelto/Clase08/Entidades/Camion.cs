using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Camion : Vehiculo
    {
        protected float tara;

        public Camion(float tara, string patente, byte cantRuedas, EMarcas marca) : base(patente, cantRuedas, marca)
        {
            this.tara = tara;
        }
        protected override string Mostrar()
        {
            StringBuilder mensaje = new StringBuilder();
            mensaje.Append(base.Mostrar());
            mensaje.AppendLine($"Tara: {this.tara}");
            return mensaje.ToString();
        }

        public override string ToString()
        {
            return this.Mostrar();
        }

    }
}
