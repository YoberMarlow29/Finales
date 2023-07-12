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
    public partial class FrmBienvenida : Form
    {
        public FrmBienvenida()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.ShowDialog();
            frmLogin.Close();
        }

        private void btnCrearCuenta_Click(object sender, EventArgs e)
        {
            FrmCrearCuenta frm = new FrmCrearCuenta();
            frm.Owner = this;
            DialogResult respuesta = frm.ShowDialog();
            if (respuesta == DialogResult.OK)
            {
                Usuario nuevoUsuario = frm.NuevoUsuario;
                Archivos.AltaUsuario(nuevoUsuario);
            }
            Archivos.SerializarListaXml(Archivos.listaDeUsuarios, Archivos.pathUsuarios);

        }

        private void FrmBienvenida_Load(object sender, EventArgs e)
        {

        }
    }
}
