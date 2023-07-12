using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Grupo
    {
        private List<Mascota> mascotas;
        private string nombre;
        private static TipoManada tipo = TipoManada.Única;

        public TipoManada Tipo { get { return tipo; } }
        public string Nombre { get { return nombre; } }

        private Grupo()
        {
            mascotas = new List<Mascota>();
        }

        public Grupo(string nombre)
            : this()
        {
            this.nombre = nombre;
        }

        public Grupo(string nombre, TipoManada tipo)
            : this(nombre)
        {
            Grupo.tipo = tipo;
        }

        public static Grupo operator +(Grupo grupo, Mascota mascota)
        {
            if (grupo.mascotas.Contains(mascota))
            {
                Console.WriteLine($"La mascota {mascota.ToString()} ya está en el grupo.");
            }
            else
            {
                grupo.mascotas.Add(mascota);
                Console.WriteLine($"Se agregó la mascota {mascota.ToString()} al grupo.");
            }

            return grupo;
        }

        public static Grupo operator -(Grupo grupo, Mascota mascota)
        {
            if (grupo.mascotas.Contains(mascota))
            {
                grupo.mascotas.Remove(mascota);
                Console.WriteLine($"Se quitó la mascota {mascota.ToString()} del grupo.");
            }
            else
            {
                Console.WriteLine($"La mascota {mascota.ToString()} no se encuentra en el grupo.");
            }

            return grupo;
        }

        public static implicit operator string(Grupo grupo)
        {
            string tipoManada = Enum.GetName(typeof(TipoManada), tipo);
            string info = $"Grupo: {grupo.nombre} - tipo: {tipoManada}\nIntegrantes ({grupo.mascotas.Count}):\n";

            foreach (Mascota mascota in grupo.mascotas)
            {
                info += mascota.ToString() + "\n";
            }

            return info;
        }
    }
}
