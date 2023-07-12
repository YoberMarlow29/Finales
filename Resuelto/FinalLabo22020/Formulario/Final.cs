using Entidades;
using System.Windows.Forms;

namespace Formulario
{
    //Agregar manejo de excepciones en TODOS los lugares cr�ticos!!!
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
        //Persona (apellido:string; edad:Sbyte) - ToString():string (polimorfismo; reutilizar c�digo) 
        //Alumno (legajo: Short; nivel: ENivelDeEstudio) - ToString():string (polimorfismo; reutilizar c�digo)
        //AlumnoEgresado (promedio: float; promocion: Short) - ToString():string (polimorfismo; reutilizar c�digo) 
        //Todos los atributos de las clases son p�blicos y adem�s:
        //que todas las clases poseen un s�lo constructor (sin sobrecargas).
        //Realice los constructores de cada una de las clases, sabiendo:
        //que AlumnoEgresado hereda de Alumno, que Alumno hereda de Persona y que �ste �ltimo hereda de Humano.
        //EIdioma -> Ingl�s, Espa�ol, Portugu�s
        //ENivelDeEstudio -> Primaria, Secundaria, Terciaria, Universitaria
        private void btnPunto1_Click(object sender, EventArgs e)
        {
            Humano h = new Humano("Juan", EIdioma.Espa�ol);
            Persona p = new Persona("Brian", "Lopez", EIdioma.Portugu�s, 17);
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
        //    *pase por un constructor est�tico.
        //    *pase por un constructor que reciba 2 par�metros (privado).
        //    *pase por un constructor p�blico (default).
        //    *pase por una propiedad de s�lo escritura.
        //    *pase por una propiedad de s�lo lectra.
        //    *pase por un m�todo de instancia.
        //    *pase por un m�todo de clase.
        //NOTA: respetar el orden establecido.
        //NOTA: por cada lugar que pase, mostrar con un MessageBox.Show dicho lugar
        //NOTA: agregar la referencia a System.Windows.Form; para poder acceder a la clase MessageBox.
        //NOTA: NO MAS DE 2 LINEAS DE CODIGO POR METODO/PROPIEDAD/CONSTRUCTOR
        private void btnPunto2_Click(object sender, EventArgs e)
        {
            Constructores c = new Constructores();
        }

        //Implementar en AlumnoEgresado: ISerializar(Xml(string):bool) de forma impl�cita e 
        //IDeserializar(Xml(string, out AlumnoEgresado):bool) de forma expl�cita
        private void btnPunto3_Click(object sender, EventArgs e)
        {
            Persona p = new Persona("Juanfer", "Quintero", EIdioma.Espa�ol, 27);
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

        //Realizar el burbujeo de una excepci�n propia (MiException), comenzando en un m�todo de instancia
        //(de la clase Burbujeo), pasando por un m�todo de est�tico (de la misma clase *) y capturado 
        //por �ltima vez en el m�todo que lo inicio (manejador btnPunto4_Click). 
        //En cada paso, agregar en un �nico archivo de texto (burbujeo.log), en la carpeta 
        //'Mis documentos' del cliente, el lugar por donde se pas� junto con la hora, minuto y segundo de la acci�n. 
        //Atrapar la excepci�n y relanzarla en cada ocaci�n.
        private void btnPunto4_Click(object sender, EventArgs e)
        {
            try
            {
                Burbujeo.MetodoClase(); //* M�todo de inicio
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

            // Mostrar el cuadro de di�logo y obtener el resultado
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

        // Generar la clase gen�rico Sal�n. Contiene el atributo elementos:List del tipo gen�rico.
        // (este s�lo se podr� inicializar en el constructor por def�cto, que adem�s ser� privado)
        // y el atributo capacidad:int (generar un constructor p�blico que lo reciba como par�metro).
        // Sobrecarga en el operador +.
        // Al sumar un Sal�n con un elemento de tipo Persona, se deber� agregar a la lista de elementos
        // S�LO si el idioma de la persona es Espa�ol y a�n hay lugar en el salon.
        //Eventos
        //Agregar en la clase Sal�n que, si se llego al limite de capacidad, se lance un evento SalonLlenoEvent.
        //Esto mostrar� un mensaje en el manejador Salon_SalonLlenoEvent (realizarlo seg�n convenciones).
        //Agregar en la clase Salon que, si el idioma no es espa�ol, se lance un evento SalonNoEspa�olEvent.
        //Esto mostrar� un mensaje en el manejador Salon_SalonNoEspa�olEvent (realizarlo seg�n convenciones).
        private void Salon_SalonNoEspa�olEvent(object sender, EventArgs e)
        {
            // Manejar el evento SalonNoEspa�olEvent
            MessageBox.Show("El idioma no es espa�ol. No se puede agregar al sal�n.");
        }

        private void Salon_SalonLlenoEvent(object sender, EventArgs e)
        {
            // Manejar el evento SalonLlenoEvent
            MessageBox.Show("El sal�n ha alcanzado su capacidad m�xima. No se puede agregar m�s elementos.");
        }

        private void btnPunto5_Click(object sender, EventArgs e)
        {
            // Asociar manejadores de eventos aqu�

            // Asociar manejadores de eventos


            Salon<Persona> s = new Salon<Persona>(3);

            s.SalonNoEspa�olEvent += Salon_SalonNoEspa�olEvent;
            s.SalonLlenoEvent += Salon_SalonLlenoEvent;


            Persona p = new Persona("Jose", "Lopez", EIdioma.Ingl�s, 67);
            Persona p1 = new Persona("Pedro", "Gonzalez", EIdioma.Espa�ol, 47);
            Persona p2 = new Persona("Susana", "Gimenez", EIdioma.Espa�ol, 75);

            s += p;  // Deber�a lanzar el evento SalonNoEspa�olEvent
            s += p1;
            s += p2;
            s += p1; // Deber�a lanzar el evento SalonLlenoEvent
        }


        //Agregar m�todo de extensi�n (clase Extensora) en Persona MostrarBD():string.
        //MostrarBD retornar� una cadena (Apellido, Nombre y Edad) de todos los registros de la BD.
        //Tabla - personas { id(autoincremental - num�rico) - apellido(cadena) - edad(num�rico) - nombre(cadena) }.
        private void btnPunto6_Click(object sender, EventArgs e)
        {
            Persona p = new Persona("Pedro", "Falcao", EIdioma.Portugu�s, 25);

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

        //Agregar m�todo de extensi�n (clase Extensora) en Persona AgregarBD():bool.
        //AgregarBD retornar� un booleano indicando si se pudo agregar o no a la base de datos.
        private void btnPunto7_Click(object sender, EventArgs e)
        {
            Persona p = new Persona("Pedro", "Falcao", EIdioma.Portugu�s, 25);

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
            //Lanzar mediante un hilo el m�todo ProbarTodo.
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