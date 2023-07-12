using System.Text;

namespace Entidades
{
    public abstract class Vehiculo
    {
        protected string patente;
        protected Byte cantRuedas;
        protected EMarcas marca;

        public Vehiculo() 
        {
            this.patente = "";
            this.cantRuedas = 0;
            this.marca = EMarcas.Ninguna;
        }
        public Vehiculo(string patente, byte cantRuedas, EMarcas marca):this()
        {
            this.patente = patente;
            this.cantRuedas = cantRuedas;
            this.marca = marca;
        }

        public string Patente
        {
            get { return this.patente; }
        }

        public Enum Marca
        {
            get { return this.marca; }
        }

        public static bool operator ==(Vehiculo vehiculo1, Vehiculo vehiculo2)
        {
            return vehiculo1.patente == vehiculo2.patente && vehiculo1.marca == vehiculo2.marca;
        }

        public static bool operator !=(Vehiculo vehiculo1, Vehiculo vehiculo2)
        {
            return !(vehiculo1 == vehiculo2);
        }

        protected virtual string Mostrar()
        {
            StringBuilder mensaje = new StringBuilder();
            mensaje.AppendLine($"Patente: {this.patente}");
            mensaje.AppendLine($"Cantidad de ruedas: {this.cantRuedas}");
            mensaje.AppendLine($"Marca: {this.marca}");
            return mensaje.ToString();
        }

        public override string ToString()
        {
            return this.Mostrar();
        }

        //public override bool Equals(object? obj)
        //{
        //    bool retorno = false;
            
        //    if(obj is Vehiculo)
        //    {
        //        retorno = this == ((Vehiculo)obj);
        //    }
        //    return retorno;
        //}

        //public override int GetHashCode()
        //{
        //    return base.GetHashCode();
        //}
    }
}