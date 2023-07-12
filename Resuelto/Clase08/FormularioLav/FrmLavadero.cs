using Entidades;

namespace FormularioLav
{
    public partial class FrmLavadero : Form
    {
        public FrmLavadero()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void FrmLavadero_Load(object sender, EventArgs e)
        {
            UpdateDataGrid(dgtLavadero);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmAltaLavadero lavaderoModificacion = new FrmAltaLavadero();
            lavaderoModificacion.ShowDialog();

            if (lavaderoModificacion.DialogResult == DialogResult.OK)
            {
                Vehiculo vehiculoNuevo = lavaderoModificacion.Vehiculo;
                Archivos.AgregarVehiculo(vehiculoNuevo);
                UpdateDataGrid(dgtLavadero);
            }
            Archivos.GuardarVehiculo();
        }
        public void UpdateDataGrid(DataGridView dataGridVuelos)
        {
            if (Archivos.ObtenerLavaderojson().Vehiculos.Count > 0)
            {
                dgtLavadero.DataSource = null;
                dgtLavadero.DataSource = Archivos.ObtenerLavaderojson().Vehiculos;
                dgtLavadero.Visible = true;
            }
            else
            {
                dgtLavadero.Visible = false;
            }
        }
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            //this.lstVehiculos.Items.Remove(this.lstVehiculos.SelectedItem);
        }

        private void btnOrdenarPatente_Click(object sender, EventArgs e)
        {
            /*this.vehiculos.Sort(Lavadero.OrdenarVehiculosPorPatente);
            this.lstVehiculos.Items.Clear();

            foreach (Vehiculo vehiculo in this.vehiculos)
            {
                this.lstVehiculos.Items.Add(vehiculo.ToString());
            }*/
        }

        private void btnOrdenarMarca_Click(object sender, EventArgs e)
        {
            /*this.vehiculos.Sort(Lavadero.OrdenarVehiculoPorMarca);
            this.lstVehiculos.Items.Clear();

            foreach (Vehiculo vehiculo in this.vehiculos)
            {
                this.lstVehiculos.Items.Add(vehiculo.ToString());
            }*/
        }
    }
}