using Entidades;
namespace FinalLaboratorio2023
{
    public partial class Form1 : Form
    {
        Planetario conexion;
        public Form1()
        {
            InitializeComponent();
            this.btnAgregar.Click += new EventHandler(this.btnAgregar_Click);
            this.btnModificar.Click += new EventHandler(this.btnModificar_Click);
            this.btnEliminar.Click += new EventHandler(this.btnEliminar_Click);
            this.btnObtenerPlanetas.Click += new EventHandler(this.btnObtenerPlanetas_Click);
            this.btnMostrarEnHilos.Click += new EventHandler(this.btnMostrarEnHilos_Click);
            this.btnSerializar.Click += new EventHandler(this.btnSerializar_Click);
            this.btnDeserializar.Click += new EventHandler(this.btnDeserializar_Click);
            conexion = new Planetario();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FormAgregar frmAgregar = new FormAgregar();

            if (frmAgregar.ShowDialog() == DialogResult.OK)
            {
                if (conexion.Insertar(frmAgregar.NuevoPlaneta))
                {
                    MessageBox.Show("se agrego con exito");

                }
                else
                {
                    MessageBox.Show("no agrego");

                }
            }
            else 
            {
                MessageBox.Show("Cancelado");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            FormAgregar frmAgregar = new FormAgregar();

            if (frmAgregar.ShowDialog() == DialogResult.OK)
            {
                if (conexion.Modificar(frmAgregar.NuevoPlaneta))
                {
                    MessageBox.Show("se modifico con exito");

                }
                else
                {
                    MessageBox.Show("no modifico");

                }
            }
            else
            {
                MessageBox.Show("Cancelado");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            FormEliminar frmAgregar = new FormEliminar();

            if (frmAgregar.ShowDialog() == DialogResult.OK)
            {
                if (conexion.Eliminar(frmAgregar.NuevoPlaneta))
                {
                    MessageBox.Show("se elimino con exito");

                }
                else
                {
                    MessageBox.Show("no elimino");

                }
            }
            else
            {
                MessageBox.Show("Cancelado");
            }
        }

        private void btnObtenerPlanetas_Click(object sender, EventArgs e)
        {
            List<Planeta> listaPlanetas = conexion.ObtenerPlanetas();
            string mensaje = "Planetas Obtenidos:\n\n";

            foreach (Planeta planeta in listaPlanetas) 
            {
                    mensaje += $"id: {planeta.Id}\n";
                    mensaje += $"nombre: {planeta.Nombre}\n";
                    mensaje += $"masa: {planeta.Masa}\n";
                    mensaje += $"diametro: {planeta.Diametro}\n";
                    mensaje += $"satelites: {planeta.Satelites}\n";

                    mensaje += "---------------------\n";                
            }
            MessageBox.Show(mensaje);

        }

        private void btnMostrarEnHilos_Click(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                // Ejecutar el código en un hilo secundario utilizando Task.Run
                while (true)
                {
                    // Mostrar algo en el hilo secundario (puedes reemplazar esto con tu lógica específica)
                    MessageBox.Show("Mensaje mostrado en el hilo secundario");

                    // Pausar la ejecución durante 3 segundos utilizando Thread.Sleep
                    Thread.Sleep(3000);
                }
            });
        }

        private void btnSerializar_Click(object sender, EventArgs e)
        {
            List<Astro> listaAstro = new List<Astro>();
            Planeta p1 = new Planeta(5, "Cata", 345, 232, 2);
            Planeta p2 = new Planeta(6, "Lino", 45, 787, 6);
            Estrella e1 = new Estrella(1, 32, "asa", "cato", 311);
            Estrella e2 = new Estrella(7, 54, "gdxc", "cato", 311);

            listaAstro.Add(p1);
            listaAstro.Add(p2);
            listaAstro.Add(e1);
            listaAstro.Add(e2);

            Serializadora<Astro> serializadora = new Serializadora<Astro>();
            bool serializacionExitosa = serializadora.Serializar(listaAstro);

            if (serializacionExitosa)
            {
                MessageBox.Show("Serialización exitosa. Los astros han sido guardados en el archivo.");
            }
            else
            {
                MessageBox.Show("Error en la serialización. No se pudieron guardar los astros en el archivo.");
            }
        }

        private void btnDeserializar_Click(object sender, EventArgs e)
        {
            Serializadora<Astro> serializadora = new Serializadora<Astro>();
            List<Astro> listaAstro = null;

            try
            {
                listaAstro = serializadora.Deserializar();

                if (listaAstro != null)
                {
                    string mensaje = "Astros deserializados:\n\n";
                    foreach (Astro astro in listaAstro)
                    {
                        mensaje += astro.ToString() + "\n";
                    }
                    MessageBox.Show(mensaje);
                }
                else
                {
                    MessageBox.Show("No se encontraron astros deserializados.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al deserializar los astros: {ex.Message}");
            }
        }

   
    }
}