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

namespace Formularios
{
    public partial class FrmListado : Form
    {
        List<Auto> lista;
        ADO conexion;
        Auto autoColorRepetido;


        public FrmListado()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;
            conexion = new ADO();
            autoColorRepetido = new Auto();
            conexion.ColorExistente += Manejador_colorExistente;

        }

        ///
        /// Punto 3 - Obtener y mostrar todos los autos de la BD
        ///
        private void FrmListado_Load(object sender, EventArgs e)
        {
            this.lista = ADO.ObtenerTodos();
            this.lstListado.DataSource = this.lista;
        }

        ///
        /// Punto 4 - Agregar un nuevo auto a la BD. Utilizar FrmAuto
        ///
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmAuto frmaAuto = new FrmAuto();
            try
            {
                if (frmaAuto.ShowDialog() == DialogResult.OK)
                {
                    autoColorRepetido.Color = frmaAuto.AutoDelFormulario.Color;
                    conexion.Agregar(frmaAuto.AutoDelFormulario);
                    MessageBox.Show("Se agregó el auto con éxito.");
                }
                else
                {
                    MessageBox.Show("Ocurrió un error al agregar el auto");
                }
            }
            catch (PatenteExistenteException ex)
            {
                MessageBox.Show("La patente ya existe en la base de datos. Detalles del auto existente:\n" + ex.AutoExistente.ToString());
                MessageBox.Show("No se agregó el auto.");
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrió un error al agregar el auto");
            }

        }
        ///
        /// Punto 5 - Modificar auto seleccionado en la BD. Reutilizar FrmAuto
        ///
        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (lstListado.SelectedItem is Auto auto)
            {
                FrmAuto frmAuto = new FrmAuto(auto, false);
                if (frmAuto.ShowDialog() == DialogResult.OK && frmAuto.AutoDelFormulario is not null)
                {
                    conexion.Modificar(frmAuto.AutoDelFormulario);
                    MessageBox.Show("Se modificó el auto.");
                }
                else
                {
                    MessageBox.Show("No se pudo modificar el auto.");
                }
            }
        }

        ///
        /// Punto 6 - Eliminar auto seleccionado de la BD. Reutilizar FrmAuto.
        ///
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (lstListado.SelectedItem is Auto auto)
            {
                FrmAuto frmAuto = new FrmAuto(auto, true);
                if (frmAuto.ShowDialog() == DialogResult.OK && frmAuto.AutoDelFormulario is not null)
                {
                    conexion.Eliminar(frmAuto.AutoDelFormulario);
                    MessageBox.Show("Se eliminó el auto.");
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar el auto.");
                }
            }
        }

        ///
        /// Punto 8-b - Capturar evento ColorExiste y escribir en log
        ///
        private void Manejador_colorExistente(object sender, EventArgs e)
        {
            bool todoOK = false;

            if (autoColorRepetido.Color != null)
            {
                todoOK = ManejadoraTexto.EscribirArchivo(ADO.ObtenerTodos(autoColorRepetido.Color));//Reemplazar por la llamada al método de clase ManejadoraTexto.EscribirArchivo
            }


            MessageBox.Show("Color repetido!!!");

            if (todoOK)
            {
                MessageBox.Show("Se escribió correctamente!!!");
            }
            else
            {
                MessageBox.Show("No se pudo escribir!!!");
            }
        }
    }
}
