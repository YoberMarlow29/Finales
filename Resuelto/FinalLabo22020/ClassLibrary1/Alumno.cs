using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    //Alumno (legajo: Short; nivel: ENivelDeEstudio) - ToString():string (polimorfismo; reutilizar código)

    public class Alumno : Persona
    {
        private short legajo;
        private ENivelDeEstudio enivel;
        public short Legajo { get => legajo; set => legajo = value; }
        public ENivelDeEstudio Enivel { get => enivel; set => enivel = value; }


        public Alumno(Persona p,short legajo,ENivelDeEstudio enivel) : base(p.Nombre,p.Apellido,p.EIdioma,p.Edad)
        {
            this.legajo = legajo;
            this.enivel = enivel;
        }

        public override string ToString()
        {
            return base.ToString()+$"legajo:{this.legajo}-Nivel de Estudio:{this.enivel}";
        }


    }
}
