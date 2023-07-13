using Entidades;
using System.Windows.Forms;

namespace Formulario
{
    //Agregar manejo de excepciones en TODOS los lugares críticos!!!
    public partial class Final : Form
    {
        public Final()
        {
            InitializeComponent();
        }

        //Cambiar por su apellido y nombre
        private void Final_Load(object sender, EventArgs e)
        {
            this.Text = "Apellido y nombre";
            MessageBox.Show(this.Text);
        }

        //Desarrollar la siguiente jerarquia de clases, en un class library:
        //Humano (nombre:string;  idioma:EIdioma;) - ToString():string
        //Persona (apellido:string; edad:Sbyte) - ToString():string (polimorfismo; reutilizar código) 
        //Alumno (legajo: Short; nivel: ENivelDeEstudio) - ToString():string (polimorfismo; reutilizar código)
        //AlumnoEgresado (promedio: float; promocion: Short) - ToString():string (polimorfismo; reutilizar código) 
        //Todos los atributos de las clases son públicos y además:
        //que todas las clases poseen un sólo constructor (sin sobrecargas).
        //Realice los constructores de cada una de las clases, sabiendo:
        //que AlumnoEgresado hereda de Alumno, que Alumno hereda de Persona y que éste último hereda de Humano.
        //EIdioma -> Inglés, Español, Portugués
        //ENivelDeEstudio -> Primaria, Secundaria, Terciaria, Universitaria
        private void btnPunto1_Click(object sender, EventArgs e)
        {
            Humano h = new Humano("Juan", EIdioma.Español);
            Persona p = new Persona("Brian", "Lopez", EIdioma.Portugués, 17);
            Alumno a = new Alumno(p, 123, ENivelDeEstudio.Primaria);
            AlumnoEgresado ae = new AlumnoEgresado(a, 4.5f, 2020);

            List<Humano> lista = new List<Humano>();
            lista.Add(h);
            lista.Add(p);
            lista.Add(a);
            lista.Add(ae);

            foreach (Humano item in lista)
            {
                MessageBox.Show(item.ToString());
            }

        }

        //Crear la clase Constructores (en un class library) que al instanciarse:
        //    *pase por un constructor estático.
        //    *pase por un constructor que reciba 2 parámetros (privado).
        //    *pase por un constructor público (default).
        //    *pase por una propiedad de sólo escritura.
        //    *pase por una propiedad de sólo lectra.
        //    *pase por un método de instancia.
        //    *pase por un método de clase.
        //NOTA: respetar el orden establecido.
        //NOTA: por cada lugar que pase, mostrar con un MessageBox.Show dicho lugar
        //NOTA: agregar la referencia a System.Windows.Form; para poder acceder a la clase MessageBox.
        //NOTA: NO MAS DE 2 LINEAS DE CODIGO POR METODO/PROPIEDAD/CONSTRUCTOR
        private void btnPunto2_Click(object sender, EventArgs e)
        {
            Constructores c = new Constructores();
        }

        //Implementar en AlumnoEgresado: ISerializar(Xml(string):bool) de forma implícita e 
        //IDeserializar(Xml(string, out AlumnoEgresado):bool) de forma explícita
        private void btnPunto3_Click(object sender, EventArgs e)
        {
            Persona p = new Persona("Juanfer", "Quintero", EIdioma.Español, 27);
            AlumnoEgresado a = new AlumnoEgresado(new Alumno(p, 123, ENivelDeEstudio.Primaria), 8.8f, 2001);
            AlumnoEgresado aux = null;

            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string path = Path.Combine(desktopPath, "alumno.xml");


            if (a.Xml(path))
            {
                MessageBox.Show("Serializado OK");
            }
            else
            {
                MessageBox.Show("NO Serializado");
            }

            if (((IDeserializar)a).Xml(path, out aux))
            {
                MessageBox.Show("Deserializado OK");
                MessageBox.Show(aux.ToString());
            }
            else
            {
                MessageBox.Show("NO Deserializado");
            }

        }

        //Realizar el burbujeo de una excepción propia (MiException), comenzando en un método de instancia
        //(de la clase Burbujeo), pasando por un método de estático (de la misma clase *) y capturado 
        //por última vez en el método que lo inicio (manejador btnPunto4_Click). 
        //En cada paso, agregar en un único archivo de texto (burbujeo.log), en la carpeta 
        //'Mis documentos' del cliente, el lugar por donde se pasó junto con la hora, minuto y segundo de la acción. 
        //Atrapar la excepción y relanzarla en cada ocación.
        private void btnPunto4_Click(object sender, EventArgs e)
        {
            try
            {
                Burbujeo.MetodoClase(); //* Método de inicio
            }
            catch (MiException ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        //Crear y configurar un OpenFileDialog, para poder seleccionar el log de excepciones
        private void btnVerLog_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Abrir archivo de excepciones";
            openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            openFileDialog1.Filter = "Archivos de log (*.log)|*.log";
            openFileDialog1.DefaultExt = ".log";
            openFileDialog1.FileName = "burbujeo";

            // Mostrar el cuadro de diálogo y obtener el resultado
            DialogResult result = openFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                // Obtener el nombre del archivo seleccionado
                string fileName = openFileDialog1.FileName;

                // Leer el archivo seleccionado y mostrarlo en txtVisorLogs
                string logText = File.ReadAllText(fileName);
                txtVisorExcepciones.Text = logText;
            }

        }

        // Generar la clase genérico Salón. Contiene el atributo elementos:List del tipo genérico.
        // (este sólo se podrá inicializar en el constructor por defécto, que además será privado)
        // y el atributo capacidad:int (generar un constructor público que lo reciba como parámetro).
        // Sobrecarga en el operador +.
        // Al sumar un Salón con un elemento de tipo Persona, se deberá agregar a la lista de elementos
        // SÓLO si el idioma de la persona es Español y aún hay lugar en el salon.
        //Eventos
        //Agregar en la clase Salón que, si se llego al limite de capacidad, se lance un evento SalonLlenoEvent.
        //Esto mostrará un mensaje en el manejador Salon_SalonLlenoEvent (realizarlo según convenciones).
        //Agregar en la clase Salon que, si el idioma no es español, se lance un evento SalonNoEspañolEvent.
        //Esto mostrará un mensaje en el manejador Salon_SalonNoEspañolEvent (realizarlo según convenciones).
        private void Salon_SalonNoEspañolEvent(object sender, EventArgs e)
        {
            // Manejar el evento SalonNoEspañolEvent
            MessageBox.Show("El idioma no es español. No se puede agregar al salón.");
        }

        private void Salon_SalonLlenoEvent(object sender, EventArgs e)
        {
            // Manejar el evento SalonLlenoEvent
            MessageBox.Show("El salón ha alcanzado su capacidad máxima. No se puede agregar más elementos.");
        }

        private void btnPunto5_Click(object sender, EventArgs e)
        {
            // Asociar manejadores de eventos aquí

            // Asociar manejadores de eventos


            Salon<Persona> s = new Salon<Persona>(3);

            s.SalonNoEspañolEvent += Salon_SalonNoEspañolEvent;
            s.SalonLlenoEvent += Salon_SalonLlenoEvent;


            Persona p = new Persona("Jose", "Lopez", EIdioma.Inglés, 67);
            Persona p1 = new Persona("Pedro", "Gonzalez", EIdioma.Español, 47);
            Persona p2 = new Persona("Susana", "Gimenez", EIdioma.Español, 75);

            s += p;  // Debería lanzar el evento SalonNoEspañolEvent
            s += p1;
            s += p2;
            s += p1; // Debería lanzar el evento SalonLlenoEvent
        }


        //Agregar método de extensión (clase Extensora) en Persona MostrarBD():string.
        //MostrarBD retornará una cadena (Apellido, Nombre y Edad) de todos los registros de la BD.
        //Tabla - personas { id(autoincremental - numérico) - apellido(cadena) - edad(numérico) - nombre(cadena) }.
        private void btnPunto6_Click(object sender, EventArgs e)
        {
            Persona p = new Persona("Pedro", "Falcao", EIdioma.Portugués, 25);

            string registrosBD = p.MostrarBD();

            if (registrosBD != null)
            {
                this.txtVisorBD.Text = registrosBD;
            }
            else
            {
                this.txtVisorBD.Text = "Error al obtener los registros de la base de datos.";
            }
        }

        //Agregar método de extensión (clase Extensora) en Persona AgregarBD():bool.
        //AgregarBD retornará un booleano indicando si se pudo agregar o no a la base de datos.
        private void btnPunto7_Click(object sender, EventArgs e)
        {
            Persona p = new Persona("Pedro", "Falcao", EIdioma.Portugués, 25);

            if (p.AgregarBD())
            {
                this.txtVisorBD.Text = p.MostrarBD();
            }
            else
            {
                MessageBox.Show("No se pudo agregar a la BD");
            }

        }

        //Threads
        //Iniciar un nuevo hilo que ejecute todos los manejadores de eventos de los botones del formulario
        //(Final_Load, btnPunto1_Click, y btnPunto2_Click)
        private void btnPunto8_Click(object sender, EventArgs e)
        {
            //Lanzar mediante un hilo el método ProbarTodo.
            Task.Run(ProbarTodo);

        }
        private void ProbarTodo()//para el thread
        {
            Final_Load(this, EventArgs.Empty);
            btnPunto1_Click(this, EventArgs.Empty);
            btnPunto2_Click(this, EventArgs.Empty);
        }


    }
}