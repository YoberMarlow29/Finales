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
    public partial class FrmModificarCliente : Form
    {
        private Cliente modificarCliente;
        public Cliente ModificarCliente
        {
            get { return modificarCliente; }
            set { modificarCliente = value; }
        }
        public FrmModificarCliente(Cliente clienteModificar)
        {
            InitializeComponent();
            modificarCliente = new Cliente();
            this.modificarCliente = clienteModificar;

        }
        private void FrmModificarCliente_Load(object sender, EventArgs e)
        {
            txtNombre.Text = modificarCliente.Nombre;
            txtApellido.Text = modificarCliente.Apellido;
            txtEdad.Text = modificarCliente.Edad.ToString();
            txtDni.Text = modificarCliente.Dni.ToString();
            cboNacionalidad.DataSource = Enum.GetValues(typeof(ENacionaliad));
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int edad;
            int dni;
            int.TryParse(this.txtEdad.Text, out edad);
            int.TryParse(this.txtDni.Text, out dni);

            modificarCliente.Nombre = txtNombre.Text;
            modificarCliente.Nombre = txtApellido.Text;
            modificarCliente.Edad = edad;
            modificarCliente.Dni = dni;
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();

        }


    }
}
