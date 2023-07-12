using System.Text;

namespace Entidades
{
    public abstract class Persona
    {
        protected string nombre;
        protected string apellido;
        protected int edad;
        protected int dni;

        public string Nombre 
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Apellido
        { 
            get { return apellido; }
            set { apellido = value; }
        }
        public int Edad 
        {
            get { return edad; }
            set { edad = value; }   
        }
        public int Dni
        {
            get { return dni; }
            set { dni = value; }
        }
        protected Persona() 
        {
            this.nombre = "";
            this.apellido = "";
            this.edad = 0;
            this.dni = 0;
        }
        protected Persona(string nombre, string apellido):this() 
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }
        protected Persona(string nombre, string apellido, int edad,int dni):this(nombre,apellido) 
        {
            this.edad = edad;
            this.dni = dni;
        }
        protected string Mostrar() 
        {
            StringBuilder cadena = new StringBuilder();
            cadena.AppendLine($"El nombre es: {this.Nombre} ");
            cadena.AppendLine($"El apellido es: {this.Apellido}");
            cadena.AppendLine($"Edad: {this.Edad}");
            cadena.AppendLine($"Dni: {this.Dni}");
            return cadena.ToString();
        }
        public static bool operator ==(Persona p1, Persona p2)
        {
            return p1 is not null && p2 is not null && p1.Dni == p2.Dni;
        }
        public static bool operator !=(Persona p1, Persona p2)
        {
            return !(p1 == p2);
        }

        public override string ToString()
        {
            return this.Mostrar();
        }
        public override int GetHashCode()
        {
            return this.Dni;
        }
        public override bool Equals(object? obj)
        {
            bool ok = false;
            if (obj is Persona)
            {
                if (this == ((Persona)obj))
                {
                    ok = true;
                }
            }
            return ok;
        }
    }
}