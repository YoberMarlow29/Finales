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

namespace Formulario
{
    public partial class FrmPasajeroTask : Form
    {
        Task cargaPasajeros;
        CancellationTokenSource cts;
        List<Pasajero> listaPasajeros;

        public FrmPasajeroTask()
        {
            InitializeComponent();

            cts = new CancellationTokenSource();
            cargaPasajeros = new Task(this.ComenzarCarga);
            listaPasajeros = new List<Pasajero>();
        }

        ///Diseñar el método ComenzarCarga que mostrará la lista de pasajeros (de la BD) mediante un Task.
        ///Dicho método realizará las siguientes tareas:
        /// * Agregar un pasajero a la lista
        /// * Actualizar el ListBox lstVisorTask con la lista de pasajeros
        /// * Repetirá este proceso cada 2 segundos hasta que se cancele la tarea o se finalice la carga.

        private void ComenzarCarga()
        {
             while (!cts.Token.IsCancellationRequested)
             {
                 // Obtener los pasajeros de la base de datos
                 List<Pasajero> nuevosPasajeros = new Pasajero().ObtenerTodosBD();

                 // Actualizar la lista de pasajeros
                 lock (listaPasajeros)
                 {
                     listaPasajeros = nuevosPasajeros;
                 }

                 // Actualizar el ListBox en el hilo principal de la interfaz de usuario
                 Invoke(new Action(() =>
                 {
                     lstVisorTask.Items.Clear();
                     foreach (Pasajero item in listaPasajeros)
                     {
                         lstVisorTask.Items.Add(item.ToString());
                     }
                 }));

                 // Esperar 2 segundos antes de la siguiente iteración
                 Thread.Sleep(2000);
             }

        }

        private void btnIniciarTask_Click(object sender, System.EventArgs e)
        {
            this.cargaPasajeros.Start();
            MessageBox.Show("Se inicia la tarea.");
        }

        private void btnCancelarTask_Click(object sender, System.EventArgs e)
        {
            this.cts.Cancel();
            MessageBox.Show("Se cancela la tarea.");
        }
    }
}
