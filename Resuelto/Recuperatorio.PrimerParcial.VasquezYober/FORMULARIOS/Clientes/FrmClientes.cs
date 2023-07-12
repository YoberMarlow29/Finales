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
    public partial class FrmClientes : Form
    {
        public FrmClientes()
        {
            InitializeComponent();
        }
        private void FrmClientes_Load(object sender, EventArgs e)
        {
            UpdateDataGrid(dataGridClientes);
        }
        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            FrmAltaCliente frm = new FrmAltaCliente();
            DialogResult respuesta = frm.ShowDialog();
            if (respuesta == DialogResult.OK)
            {
                Cliente nuevoPasajero = frm.NuevoCliente;
                Archivos.AltaCliente(nuevoPasajero);//añadir lista
                UpdateDataGrid(dataGridClientes);
            }
            Archivos.SerializarListaJson<Cliente>(Archivos.listaDeClientes, Archivos.pathClientes);
        }

        private void btnBajaCliente_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show($"¿Esta seguro que quiere eliminar el cliente {dataGridClientes.CurrentRow.DataBoundItem}?{Environment.NewLine} Esta accion es inrreversible", "Dar Baja Aeronave", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            if (respuesta == DialogResult.Yes)
            {
                Archivos.BajaDeCliente((Cliente)dataGridClientes.CurrentRow.DataBoundItem);
                UpdateDataGrid(dataGridClientes);
            }
            Archivos.SerializarListaJson<Cliente>(Archivos.listaDeClientes, Archivos.pathClientes);
        }

        private void btnModificarCliente_Click(object sender, EventArgs e)
        {
            Cliente pasajeroSeleccionado = (Cliente)dataGridClientes.CurrentRow.DataBoundItem;

            FrmModificarCliente frmModificar = new FrmModificarCliente(pasajeroSeleccionado);
            DialogResult respuesta = frmModificar.ShowDialog();

            if (respuesta == DialogResult.OK)
            {
                Cliente nuevoPasajero = frmModificar.ModificarCliente;

                int index = Archivos.listaDeClientes.IndexOf(pasajeroSeleccionado);
                Archivos.listaDeClientes[index] = nuevoPasajero;

                UpdateDataGrid(dataGridClientes);
            }

            Archivos.SerializarListaJson<Cliente>(Archivos.listaDeClientes, Archivos.pathClientes);

        }
        public void UpdateDataGrid(DataGridView dataGridAeronave)
        {
            if (Archivos.listaDeClientes.Count > 0)
            {
                dataGridAeronave.DataSource = null;
                dataGridAeronave.DataSource = Archivos.listaDeClientes;
                dataGridAeronave.Visible = true;
            }
            else
            {
                dataGridAeronave.Visible = false;
            }
        }

    }
}
