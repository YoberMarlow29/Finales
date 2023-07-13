using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesRSP
{
    ///Alumno (deriva de Persona)
    ///Atributo
    ///nota : double
    ///Propiedad pública de lectura y escritura para su atributo.
    ///Constructor que reciba parámetro para cada atributo
    ///Polimorfismo sobre ToString
    ///Eventos (diseñados según convenciones vistas)
    ///Aprobar
    ///NoAprobar
    ///Promocionar
    ///Método de instancia (público)
    ///Clasificar() : void
    ///Si el atributo nota es menor a 4, lanzará el evento NoAprobar.
    ///Si el atributo nota es menor a 6 (y mayor o igual a 4), lanzará el evento Aprobar.
    ///Si el atributo nota es mayor o igual a 6, lanzará el evento Promocionar.
    ///
    /// 

    public delegate void EventoNota(object sender, EventArgs e);

    public class Alumno : Persona
    {
        private double nota;

        public Alumno() : base(0, "", "")
        {
            this.nota = 0;

        }
        public Alumno(int dni,string apellido,string nombre, double nota):this()
        {
            this.nota = nota;
        }

        public double Nota { get => nota; set => nota = value; }

        public event EventoNota Aprobar;
        public event EventoNota NoAprobar;
        public event EventoNota Promocionar;

        public override string ToString()
        {
            return $"{base.ToString()} - Nota: {this.nota}";
        }

        public void Clasificar()
        {
            if (this.nota < 4 && this.NoAprobar is not null)
            {
                this.NoAprobar.Invoke(this, EventArgs.Empty);
            }
            else if (this.nota < 6 && this.Aprobar is not null)
            {
                this.Aprobar.Invoke(this, EventArgs.Empty);
            }
            else
            {
                if (this.Promocionar is not null)
                {
                    this.Promocionar.Invoke(this, EventArgs.Empty);
                }
            }
        }
    }
}
