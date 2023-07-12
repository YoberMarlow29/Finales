using EntidadesRSP;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using System.IO;
using System.Xml.Serialization;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace WinFormsAppRSP
{
    /// Agregar manejo de excepciones en TODOS los lugares críticos!!!

    public partial class FrmPrincipal : Form
    {
        /// Crear en un proyecto de tipo class library (EntidadesRSP), las clases:
        /// Persona
        /// Atributos (todos privados)
        /// dni : int
        /// apellido : string
        /// nombre : string
        /// Propiedades públicas de lectura y escritura para todos sus atributos.
        /// Constructor que reciba parámetros para cada atributo
        /// Polimorfismo sobre ToString
        ///
        /// Alumno (deriva de Persona)
        /// Atributo
        /// nota : double
        /// Propiedad pública de lectura y escritura para su atributo.
        /// Constructor que reciba parámetro para cada atributo
        /// Polimorfismo sobre ToString
        /// Eventos (diseñados según convenciones vistas)
        /// Aprobar
        /// NoAprobar
        /// Promocionar
        /// Método de instancia (público)
        /// Clasificar() : void
        /// Si el atributo nota es menor a 4, lanzará el evento NoAprobar.
        /// Si el atributo nota es menor a 6 (y mayor o igual a 4), lanzará el evento Aprobar.
        /// Si el atributo nota es mayor o igual a 6, lanzará el evento Promocionar.
        ///
        /// AlumnoADO (hereda de Alumno)
        /// Atributos (estáticos)
        /// conexion : string
        /// connection : SqlConnection
        /// command : SqlCommand
        /// Constructor de clase que inicialice todos sus atributos
        /// Constructor que recibe un objeto de tipo Alumno cómo parámetro
        /// Métodos de instancia (públicos):
        /// ObtenerTodos() : List<Alumno> 
        /// Agregar() : bool
        /// Modificar() : bool -> se modifica a partir del dni
        /// Eliminar() : bool -> se elimina a partir del dni

        /// BASE DE DATOS
        /// Crear la BASE de DATOS utn_fra_alumnos y ejecutar el siguiente script:
        /// USE [utn_fra_alumnos]
        /// GO
        /// CREATE TABLE [dbo].[alumnos]
        /// (
        /// [dni] [int] NOT NULL,
        /// [apellido] [varchar](50) NOT NULL,
        /// [nombre] [varchar](50) NOT NULL,
        /// [nota] [float] NOT NULL,
        /// ) ON[PRIMARY]
        /// GO
        ///

        private List<Alumno> alumnos;
        public FrmPrincipal()
        {
            InitializeComponent();

            this.Text = "VasquezYober";
            MessageBox.Show(this.Text);

            this.CargarListados();

            /// Agregar los manejadores de eventos para: 
            /// btnAgregar, btnEliminar, btnModificar, btnSerializar, btnDeserializar y btnHilos
            ///
            this.btnAgregar.Click += new EventHandler(this.ManejadorAgregar);
            this.btnEliminar.Click += new EventHandler(this.ManejadorEliminar);
            this.btnModificar.Click += new EventHandler(this.ManejadorModificar);
            this.btnSerializar.Click += new EventHandler(this.ManejadorSerializar);
            this.btnDeserializar.Click += new EventHandler(this.ManejadorDeserializar);
            this.btnHilos.Click += new EventHandler(this.ManejadorHilos);

        }

        private void CargarListados()
        {
            this.lstAprobados.Items.Clear();
            this.lstDesaprobados.Items.Clear();
            this.lstPromocionados.Items.Clear();

            /// Utilizando la clase AlumnoADO, obtener y mostrar todos los productos
            ///
            this.alumnos = AlumnoADO.ObtenerTodos();
            this.lstTodos.DataSource = this.alumnos;


            foreach (Alumno item in this.alumnos)
            {
                /// Agregar, para los eventos
                /// Aprobar, NoAprobar y Promocionar, los manejadores
                /// AlumnoAprobado, AlumnoNoAprobado y AlumnoPromocionado, respectivamente
                ///
                item.NoAprobar += this.AlumnoNoAprobado;
                item.Aprobar += this.AlumnoAprobado;
                item.Promocionar += this.AlumnoPromocionado;

                item.Clasificar();

                /// Quitar los manejadores de eventos para:
                /// Aprobar, NoAprobar y Promocionar
                ///
                item.NoAprobar -= this.AlumnoNoAprobado;
                item.Aprobar -= this.AlumnoAprobado;
                item.Promocionar -= this.AlumnoPromocionado;
            }
        }

        private void ManejadorAgregar(object emisor, EventArgs argumentos)
        {
            /// Agregar un nuevo alumno a la base de datos
            /// Utilizar FrmAlumno.
            /// Si se pudo agregar, invocar al método CargarListados, caso contrario mostrar mensaje
            ///
            FrmAlumno frm = new FrmAlumno();
            frm.StartPosition = FormStartPosition.CenterScreen;

            if (frm.ShowDialog() == DialogResult.OK)
            {
                AlumnoADO ado = new AlumnoADO(frm.Alumno);
                if (ado.Agregar())
                {
                    this.CargarListados();
                }
                else
                {
                    MessageBox.Show("Error al agregar");
                }
            }

        }
        private void ManejadorModificar(object emisor, EventArgs argumentos)
        {
            /// Modificar el alumno seleccionado (el dni no se debe modificar, adecuar FrmAlumno)
            /// Se deben mostrar todos los datos en el formulario (adaptarlo)
            /// reutilizar FrmAlumno.
            /// Si se pudo modificar, invocar al método CargarListados, caso contrario mostrar mensaje
            ///
            Alumno alumno = this.alumnos[lstTodos.SelectedIndex];

            FrmAlumno frm = new FrmAlumno(alumno, false);
            frm.StartPosition = FormStartPosition.CenterScreen;

            if (frm.ShowDialog() == DialogResult.OK)
            {
                AlumnoADO ado = new AlumnoADO(frm.Alumno);
                if (ado.Modificar())
                {
                    this.CargarListados();
                }
                else
                {
                    MessageBox.Show("Error al modificar");
                }
            }

        }

        private void ManejadorEliminar(object emisor, EventArgs argumentos)
        {
            /// Eliminar el alumno seleccionado (el dni no se debe modificar, adecuar FrmAlumno)
            /// Se deben mostrar todos los datos en el formulario (adaptarlo)
            /// reutilizar FrmAlumno.
            /// Si se pudo eliminar, invocar al método CargarListados, caso contrario mostrar mensaje
            ///
            Alumno alumno = this.alumnos[lstTodos.SelectedIndex];

            FrmAlumno frm = new FrmAlumno(alumno, true);
            frm.StartPosition = FormStartPosition.CenterScreen;

            if (frm.ShowDialog() == DialogResult.OK)
            {
                AlumnoADO ado = new AlumnoADO(frm.Alumno);
                if (ado.Eliminar())
                {
                    this.CargarListados();
                }
                else
                {
                    MessageBox.Show("Error al eliminar");
                }
            }
        }

        private void ManejadorSerializar(object emisor, EventArgs argumentos)
        {
            /// Serializar a XML la lista de alumnos del formulario (this.alumnos)
            /// El archivo .xml guardarlo en el escritorio del cliente, 
            /// con el nombre formado con su apellido.nombre.alumnos.xml
            /// Ejemplo: Alumno Juan Pérez -> perez.juan.alumnos.xml
            /// Indicar si se pudo o no serializar la lista de alumnos
            ///

            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "vasquez.alumnos.json");
            if (this.alumnos.Count > 0)
            {
                try
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<Alumno>));
                    using (FileStream fileStream = new FileStream(path, FileMode.Create))
                    {
                        serializer.Serialize(fileStream, this.alumnos);
                    }
                    MessageBox.Show("Serialización exitosa");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al serializar la lista en formato XML y guardar en el archivo '{path}': {ex.Message}");
                }
                /*try
                {
                    string json = JsonConvert.SerializeObject(this.alumnos, Formatting.Indented);
                    File.WriteAllText(path, json);
                    MessageBox.Show("Serialización exitosa");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al serializar la lista en formato JSON y guardar en el archivo '{path}': {ex.Message}");
                }*/
            }
            else
            {
                MessageBox.Show("No hay alumnos para serializar");
            }
        }

        private void ManejadorDeserializar(object emisor, EventArgs argumentos)
        {
            /// Deserializar de XML a una lista de alumnos
            /// El archivo .xml tomarlo del escritorio del cliente, 
            /// con el nombre formado con su apellido.nombre.alumnos.xml
            /// Ejemplo: Alumno Juan Pérez -> perez.juan.alumnos.xml
            /// Si se pudo serializar, mostrar el listado completo en un MessageBox.
            /// Si no se pudo deserializar, mostrar los motivos
            ///

            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "vasquez.alumnos.json");

            try
            {
                if (File.Exists(path))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<Alumno>));
                    using (TextReader reader = new StreamReader(path))
                    {
                        List<Alumno> listaDeserializada = (List<Alumno>)serializer.Deserialize(reader);

                        string mensaje = "Alumnos Deserializados:\n\n";
                        foreach (Alumno alumno in listaDeserializada)
                        {
                            mensaje += $"DNI: {alumno.Dni}\n";
                            mensaje += $"Apellido: {alumno.Apellido}\n";
                            mensaje += $"Nombre: {alumno.Nombre}\n";
                            mensaje += $"Nota: {alumno.Nota}\n";
                            mensaje += "---------------------\n";
                        }

                        MessageBox.Show(mensaje);
                    }
                }
                else
                {
                    MessageBox.Show($"El archivo '{path}' no existe.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al deserializar el archivo '{path}': {ex.Message}");
            }
            /*try
            {
                if (File.Exists(path))
                {
                    string json = File.ReadAllText(path);
                    List<Alumno> listaDeserializada = JsonConvert.DeserializeObject<List<Alumno>>(json);

                    string mensaje = "Alumnos Deserializados:\n\n";
                    foreach (Alumno alumno in listaDeserializada)
                    {
                        mensaje += $"DNI: {alumno.Dni}\n";
                        mensaje += $"Apellido: {alumno.Apellido}\n";
                        mensaje += $"Nombre: {alumno.Nombre}\n";
                        mensaje += $"Nota: {alumno.Nota}\n";
                        mensaje += "---------------------\n";
                    }

                    MessageBox.Show(mensaje);
                }
                else
                {
                    MessageBox.Show($"El archivo '{path}' no existe.");
                }
            }
            catch (JsonException ex)
            {
                MessageBox.Show($"Error de deserialización en el archivo '{path}': {ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al leer el archivo '{path}': {ex.Message}");
            }*/
        }

        public void AlumnoNoAprobado(object alumni, EventArgs e)
        {
            /// Agregar el alumno al listado lstDesaprobados
            ///
            lstDesaprobados.Items.Add(((Alumno)alumni).ToString());
        }

        public void AlumnoAprobado(object alumni, EventArgs e)
        {
            /// Agregar el alumno al listado lstAprobados
            ///
            lstAprobados.Items.Add(((Alumno)alumni).ToString());
        }

        public void AlumnoPromocionado(object alumni, EventArgs e)
        {
            /// Agregar el alumno al listado lstPromocionados
            ///
            lstPromocionados.Items.Add(((Alumno)alumni).ToString());
        }

        private void ManejadorHilos(object emisor, EventArgs argumentos)
        {
            /// Iniciar una nueva tarea en segundo plano que, para lstDesaprobados:
            /// cambie el color de fondo (a rojo) y el color de la fuente (a blanco)
            /// y lo intercambie (fondo a blanco y fuente a rojo) 10 veces,
            /// agregando un retardo de 1 segundo por cada intercambio.
            ///
            /// NOTA: propiedades BackColor (fondo) y ForeColor (fuente)
            /// colores: 
            /// System.Drawing.Color.Red (rojo)
            /// System.Drawing.Color.White (blanco)

            Task t = Task.Run(() =>
            {
                for (int i = 0; i < 10; i++)
                {
                    // Cambiar el color de fondo y de fuente del ListBox lstDesaprobados
                    lstDesaprobados.Invoke(new Action(() =>
                    {
                        lstDesaprobados.BackColor = (lstDesaprobados.BackColor == Color.White) ? Color.Red : Color.White;
                        lstDesaprobados.ForeColor = (lstDesaprobados.ForeColor == Color.White) ? Color.Red : Color.White;
                    }));

                    // Esperar 1 segundo
                    Thread.Sleep(1000);
                }
            });
        }

    }
}
