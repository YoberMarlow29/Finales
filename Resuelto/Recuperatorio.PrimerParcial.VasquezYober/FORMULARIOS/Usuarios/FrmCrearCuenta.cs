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

namespace FORMULARIOS
{
    public partial class FrmCrearCuenta : Form
    {
        private Usuario nuevoUsuario;
        public Usuario NuevoUsuario
        {
            get { return nuevoUsuario; }
            set { nuevoUsuario = value; }
        }
        public FrmCrearCuenta()
        {
            InitializeComponent();
        }

        private void FrmCrearCuenta_Load(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            this.nuevoUsuario = new Usuario(txtNombre.Text, txtApellido.Text,txtCorreo.Text,txtClave.Text);
            txtApellido.Text = "";
            txtNombre.Text = "";
            txtCorreo.Text = "";
            txtClave.Text = "";
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
