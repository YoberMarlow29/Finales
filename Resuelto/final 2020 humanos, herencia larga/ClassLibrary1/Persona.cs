using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    //Persona (apellido:string; edad:Sbyte) - ToString():string (polimorfismo; reutilizar código) 

    public class Persona : Humano
    {
        private string apellido;
        private int edad;

        public string Apellido { get => apellido; set => apellido = value; }
        public int Edad { get => edad; set => edad = value; }

        public Persona(string nombre, string apellido, EIdioma eIdioma, int edad):base(nombre,eIdioma) 
        {
            this.apellido = apellido;
            this.edad = edad;
        }

        public override string ToString()
        {
            return base.ToString()+$"apellido:{this.apellido}-edad:{this.edad}";
        }
    }
}
