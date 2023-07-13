using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Auto
    {
        protected string color;
        protected int kms;
        protected string marca;
        protected string modelo;
        protected string patente;

        public string Color { get => color; set => color = value; }
        public int Kms { get => kms; set => kms = value; }
        public string Marca { get => marca; set => marca = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public string Patente { get => patente; set => patente = value; }
        public Auto() 
        {
            this.marca = "";
            this.modelo = "";
            this.patente = "";
            this.kms = 0;
            this.color = "";

        }
        public Auto(string color, int kms, string marca, string modelo, string patente):this()
        {
            this.color = color;
            this.kms = kms;
            this.marca = marca;
            this.modelo = modelo;
            this.patente = patente;
        }
        public override string ToString()
        {
            return $"Marca:{this.marca}-Modelo:{this.modelo}-Kms:{this.kms}-Color:{this.color}-Patente:{this.patente}";
        }
    }
}
