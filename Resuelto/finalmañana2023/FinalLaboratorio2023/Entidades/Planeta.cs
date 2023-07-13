using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /*
        CLASE Planeta (hereda de Astro):
        Atributos:
        (-)satelites: int
        Propiedad pública asociada a su atributo.
        Constructores: (REUTILIZAR)
        (+)Planeta(id: int, nombre: string, masa: double, diametro: double)
        (+)Planeta(id: int, masa: double, diametro: double, nombre: string, satelites: int)
        Método:
        (proteg)InformacionAstro(): string --> Aplicar polimorfismo.
        (+)ToString(): string --> expone información completa.
     */
    public class Planeta : Astro
    {
        private int satelites;

        public int Satelites { get => satelites; set => satelites = value; }
        public Planeta() : base(0, "", 0, 0)
        { }

        public Planeta(int id, string nombre, double masa, double diametro):this() //: base(id, nombre, masa, diametro)
        {

        }
        public Planeta(int id, string nombre, double masa, double diametro,int satelites) : this(id, nombre, masa, diametro)
        {
            this.satelites = satelites;
        }

        protected override string InformacionAstro() 
        {
            return base.InformacionAstro() + $" - satelites:{this.satelites}";
        }

        public override string ToString()
        {
            return this.InformacionAstro();
        }

    }
}
