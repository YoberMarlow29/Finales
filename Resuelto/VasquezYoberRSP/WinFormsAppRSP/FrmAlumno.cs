using EntidadesRSP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAppRSP
{
    public partial class FrmAlumno : Form
    {
        private Alumno alumno;

        public Alumno Alumno
        {
            get { return alumno; }
        }

        public FrmAlumno()
        {
            InitializeComponent();
        }

        public FrmAlumno(Alumno alumno) : this()
        {
            txtDNI.Text = alumno.Dni.ToString();
            txtApellido.Text = alumno.Apellido;
            txtNombre.Text = alumno.Nombre;
            txtNota.Text = alumno.Nota.ToString();
            txtDNI.Enabled = false;
        }

        public FrmAlumno(Alumno alumno, bool eliminar) : this(alumno)
        {
            if (eliminar == true)
            {
                txtApellido.Enabled = false;
                txtNombre.Enabled = false;
                txtNota.Enabled = false;
                this.Text = "Eliminar alumno";
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int dni;
            float nota;

            if (Int32.TryParse(txtDNI.Text, out dni) &&
                float.TryParse(txtNota.Text, out nota) &&
                txtApellido.Text != "" &&
                txtNombre.Text != "" &&
                txtDNI.Text != "" &&
                txtNota.Text != "")
            {
                alumno = new Alumno(dni, txtApellido.Text, txtNombre.Text, nota);

                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Campos erróneos");
                this.DialogResult = DialogResult.Cancel;
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
