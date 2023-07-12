using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formularios
{
    public partial class FrmAuto : Form
    {
        private Auto auto;

        public Auto AutoDelFormulario
        {
            get { return this.auto; }
        }

        public FrmAuto()
        {
            InitializeComponent();

        }
        public FrmAuto(Auto a, bool esEliminar) : this()
        {
            this.txtMarca.Text = a.Marca;
            this.txtModelo.Text = a.Modelo;
            this.txtKms.Text = a.Kms.ToString();
            this.txtColor.Text = a.Color;
            this.txtPatente.Text = a.Patente;
            this.txtPatente.ReadOnly = true;

            if (esEliminar)
            {
                this.txtMarca.ReadOnly = true;
                this.txtModelo.ReadOnly = true;
                this.txtKms.ReadOnly = true;
                this.txtColor.ReadOnly = true;
                this.txtPatente.ReadOnly = true;
            }
        }

        /// Crar una instancia de tipo Auto
        /// Establecer como valor del atributo auto
        private void btnAceptar_Click(object sender, System.EventArgs e)
        {
            int kms = int.Parse(this.txtKms.Text);
            auto = new Auto(txtColor.Text, kms, txtMarca.Text, txtModelo.Text, txtPatente.Text);

            this.DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, System.EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
