namespace Entidades
{
   public abstract class Mascota
    {
        private string nombre;
        private string raza;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Raza { get => raza; set => raza = value; }
        public Mascota(string nombre, string raza)
        {
            this.nombre = nombre;
            this.raza = raza;
        }

        protected abstract string Ficha();

        protected virtual string DatosCompletos() 
        {
            return $"Nombre: {this.Nombre} - Raza: {this.Raza}";
        }

        public static bool operator ==(Mascota p1, Mascota p2)
        {
            return p1 is not null && p2 is not null && p1.Nombre == p2.Nombre && p1.Raza == p2.Raza;
        }
        public static bool operator !=(Mascota p1, Mascota p2)
        {
            return !(p1 == p2);
        }
    }
}