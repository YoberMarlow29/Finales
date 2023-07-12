using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    public class Star: AstralBody
    {
        private string spectralType;

        public Star(int id, string name, double mass, double diameter, string spectralType)
            : base(id, name, mass, diameter)
        {
            this.SpectralType = spectralType;
        }

        public Star(int id, string name, double mass, double diameter)
            : this(id, name, mass, diameter, "Rojo")
        {
        }

        public Star(): this(0,string.Empty, 0, 0)
        {
        }

        public string SpectralType
        {
            get { return spectralType; }
            set { spectralType = value; }
        }

        private new string AstralBodyInformation()
        {
            return $"{base.AstralBodyInformation()} - {SpecificInformation()}";
        }

        public override string SpecificInformation()
        {
            return $"Tipo Espectral: {this.spectralType}";
        }

        public static implicit operator string(Star star)
        {
            return star.ToString();
        }

        public override string ToString()
        {
            return this.AstralBodyInformation();
        }
    }
}
