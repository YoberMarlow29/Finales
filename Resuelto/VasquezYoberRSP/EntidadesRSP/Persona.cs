namespace EntidadesRSP
{
    ///Crear en un proyecto de tipo class library (EntidadesRSP), las clases:
    ///Persona
    ///Atributos (todos privados)
    ///dni : int
    ///apellido : string
    ///nombre : string
    ///Propiedades públicas de lectura y escritura para todos sus atributos.
    ///Constructor que reciba parámetros para cada atributo
    ///Polimorfismo sobre ToString
    ///
    public class Persona
    {
        private int dni;
        private string apellido;
        private string nombre;
        public int Dni { get => dni; set => dni = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public Persona() 
        {
            this.dni = 0;
            this.apellido = "";
            this.nombre = "";
        }
        public Persona(int dni, string apellido, string nombre):this()
        {
            this.dni = dni;
            this.apellido = apellido;
            this.nombre = nombre;
        }

        public override string ToString()
        {
            return $"dni:{this.dni}-apellido:{this.apellido}-nombre:{this.nombre}";
        }
    }
}