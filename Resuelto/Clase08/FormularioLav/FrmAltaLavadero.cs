using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace FormularioLav
{
    public partial class FrmAltaLavadero : Form
    {
        private Vehiculo vehiculo;
        public string vehiculoSeleccionado;

        public Vehiculo Vehiculo { get => vehiculo; set => vehiculo = value; }

        public FrmAltaLavadero()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        public FrmAltaLavadero(string titulo, string texto, string textoBoton) : this()
        {
            this.Text = titulo;
            this.txtVehiculo.Text = texto;
            this.btnAceptar.Text = textoBoton;
        }

        private void LavaderoModificacion_Load(object sender, EventArgs e)
        {
            this.cboTipo.Items.Add("Auto");
            this.cboTipo.Items.Add("Camion");
            this.cboTipo.Items.Add("Moto");
            this.cboTipo.Text = "Seleccione";
            this.lblMarca.Visible = false;
            this.cboMarca.Visible = false;

        }

        private void cboTipo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            this.lblMarca.Visible = true;
            this.cboMarca.Visible = true;
            this.vehiculoSeleccionado = (string)this.cboTipo.SelectedItem;
            this.cboMarca.DataSource = Enum.GetValues(typeof(EMarcas));
            this.cboMarca.Text = "Seleccione";
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtVehiculo.Text == "" || cboMarca.SelectedItem is null || cboTipo is null)
            {
                MessageBox.Show("Ingrese todos los datos");
            }
            else
            {
                EMarcas marcas = (EMarcas)this.cboMarca.SelectedValue;
                if (this.vehiculoSeleccionado == "Auto")
                {
                    this.vehiculo = new Auto(4, txtVehiculo.Text, 4, marcas);
                }
                else if (this.vehiculoSeleccionado == "Moto")
                {
                    this.vehiculo = new Moto(250, txtVehiculo.Text, 2, marcas);
                }
                else
                {
                    this.vehiculo = new Camion(95000, txtVehiculo.Text, 6, marcas);
                }
            }
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
