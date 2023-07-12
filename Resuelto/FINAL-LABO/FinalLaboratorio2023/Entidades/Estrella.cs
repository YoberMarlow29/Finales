using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /*
         CLASE Estrella (hereda de Astro):
    Atributos:
    (-)tipoEspectral: string
    Propiedad pública asociada a su atributo.
    Constructores: (REUTILIZAR)
    (+)Estrella(id: int, masa: double, nombre: string, diametro: double)
    (+)Estrella(id: int, diametro: double, tipoEspectral: string,nombre: string, masa: double)
    Método:
    (proteg)InformacionAstro(): string --> Aplicar polimorfismo.
    (+)ToString(): string --> expone información completa.
     */
    public class Estrella : Astro
    {
        private string tipoEspectral;

        public string TipoEspectral { get => tipoEspectral; set => tipoEspectral = value; }

        public Estrella(int id, string nombre, double masa, double diametro) : base(id, nombre, masa, diametro)
        {

        }

        public Estrella(int id, double diametro, string tipoEspectral, string nombre, double masa) : this(id, nombre, masa, diametro)
        { 
            this.tipoEspectral = tipoEspectral;
        }

        protected override string InformacionAstro()
        {
            return base.InformacionAstro() + $" - tipoEspectral:{this.tipoEspectral}";
        }

        public override string ToString()
        {
            return this.InformacionAstro();
        }
    }
}
