namespace Entidades
{
    //Humano (nombre:string;  idioma:EIdioma;) - ToString():string

    public class Humano
    {
        private string nombre;
        private EIdioma eIdioma;

        public Humano(string nombre, EIdioma eIdioma)
        {
            this.nombre = nombre;
            this.eIdioma = eIdioma;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public EIdioma EIdioma { get => eIdioma; set => eIdioma = value; }

        public override string ToString()
        {
            return $"nombre:{this.nombre}-Idioma{this.eIdioma}";
        }
    }
}