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
    public partial class FrmAltaCliente : Form
    {
        private Cliente nuevoCliente;
        public Cliente NuevoCliente
        {
            get { return nuevoCliente; }
            set { nuevoCliente = value; }
        }
        public FrmAltaCliente()
        {
            InitializeComponent();
        }
        private void FrmAltaCliente_Load(object sender, EventArgs e)
        {
            this.cboNacionalidad.DataSource = Enum.GetValues(typeof(ENacionaliad));

        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int dni;
            int edad;
            int.TryParse(this.txtDni.Text, out dni);
            int.TryParse(this.txtEdad.Text, out edad);
            ENacionaliad nacionaliadad = (ENacionaliad)this.cboNacionalidad.SelectedValue;
            this.nuevoCliente = new Cliente(txtNombre.Text, txtApellido.Text, edad,dni, nacionaliadad);
            txtApellido.Text = "";
            txtNombre.Text = "";
            txtEdad.Text = "";
            txtDni.Text = "";
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
