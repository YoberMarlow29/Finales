using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalLaboratorio2023
{
    public partial class FormAgregar : Form
    {
        private Planeta nuevoPlaneta;

        public Planeta NuevoPlaneta { get => nuevoPlaneta; set => nuevoPlaneta = value; }

        public FormAgregar()
        {
            InitializeComponent();
        }


        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int id;
            float masa;
            float diametro;
            int satelites;
            int.TryParse(this.txtId.Text, out id);
            float.TryParse(this.txtMasa.Text, out masa);
            float.TryParse(this.txtDiametro.Text, out diametro);
            int.TryParse(this.txtSatelites.Text, out satelites);

            this.NuevoPlaneta = new(id, txtNombre.Text, masa, diametro, satelites);

            this.DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
