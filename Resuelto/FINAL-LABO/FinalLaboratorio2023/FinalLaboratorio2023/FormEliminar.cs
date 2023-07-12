using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalLaboratorio2023
{
    public partial class FormEliminar : FormAgregar
    {
        private Planeta planetaEliminar;

        public Planeta PlanetaEliminar { get => planetaEliminar; set => planetaEliminar = value; }

        public FormEliminar()
        {
            InitializeComponent();
        }


    }
}
