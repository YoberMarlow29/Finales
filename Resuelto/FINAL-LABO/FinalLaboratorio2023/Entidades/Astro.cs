namespace Entidades
{
    /*
        Clase Astro: -->abstracta
        Atributos
        (proteg)id: int
        (proteg)nombre: string
        (proteg)masa: double
        (proteg)diametro: double
        Propiedades públicas asociadas a sus atributos.
        Constructor:
        (+)Astro(id: int,nombre: string, masa: double, diametro: double)
        Métodos:
        (proteg)InformacionAstro(): string
     */
    public abstract class Astro
    {
        protected int id;
        protected string nombre;
        protected double masa;
        protected double diametro;

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public double Masa { get => masa; set => masa = value; }
        public double Diametro { get => diametro; set => diametro = value; }

        public Astro(int id, string nombre, double masa, double diametro)
        {
            this.id = id;
            this.nombre = nombre;
            this.masa = masa;
            this.diametro = diametro;
        }

        protected virtual string InformacionAstro() 
        {
            return $"id:{this.id} - nombre:{this.nombre} - masa:{this.masa} - diametro:{this.diametro}";
        }
    }
}