using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Entities.Entities
{
    public class Planet : AstralBody
    {
        private bool hasRings;
        private int satellites;

        public Planet(int id, string name, double mass, double diameter, bool hasRings, int satellites) : base(id, name, mass, diameter)
        {
            this.HasRings = hasRings;
            this.Satellites = satellites;
        }

        public Planet(int id, string name, double mass, double diameter)
            : this(id, name, mass, diameter, false, 0)
        {
        }

        public Planet(int id, double diameter, bool hasRings, string name)
            : this(id, name, 1000, diameter, hasRings, 0)
        {
        }

        public Planet() : this(0, 0, false,string.Empty)
        {
        }

        public bool HasRings 
        {
            get { return hasRings; }
            set { hasRings = value; }
        }

        public int Satellites
        {
            get { return satellites; }
            set { satellites = value; }
        }

        private new string AstralBodyInformation()
        {
            return $"{base.AstralBodyInformation()} - {SpecificInformation()}";
        }

        public override string SpecificInformation()
        {
            return $"Tiene Anillos: {hasRings} - Satelites: {satellites}";
        }

        public static explicit operator string(Planet planet)
        {
            return planet.AstralBodyInformation();
        }

        public override string ToString()
        {
            return this.AstralBodyInformation();
        }
    }
}
