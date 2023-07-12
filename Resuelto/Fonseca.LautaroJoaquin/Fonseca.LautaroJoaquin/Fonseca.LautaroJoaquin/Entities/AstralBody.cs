using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Entities.Entities
{
    public abstract class AstralBody
    {
        protected int id;
        protected string name;
        protected double mass;
        protected double diameter;

        public AstralBody(int id, string name, double mass, double diameter)
        {
            this.Id = id;
            this.Name = name;
            this.Mass = mass;
            this.Diameter = diameter;
        }

        [JsonConstructor]
        public AstralBody(): this (0, string.Empty, 0, 0)
        {
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value;}
        }

        public double Mass
        {
            get { return mass; }
            set { mass = value; }
        }

        public double Diameter
        {
            get { return diameter; }
            set { diameter = value; }
        }

        protected virtual string AstralBodyInformation()
        {
            return $"Id: {this.id} - Nombre: {this.name} -  Masa: {this.mass}kg - Diametro: {this.diameter}m";
        }

        public abstract string SpecificInformation();

        public override string ToString()
        {
            return this.AstralBodyInformation();
        }

        public override bool Equals(object? obj)
        {
            return obj is AstralBody astralBody && this.id == astralBody.id;
        }

        public static bool operator ==(AstralBody first, AstralBody second)
        {
            return first.Equals(second);
        }

        public static bool operator !=(AstralBody first, AstralBody second)
        {
            return !( first == second);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(id);
        }
    }
}
