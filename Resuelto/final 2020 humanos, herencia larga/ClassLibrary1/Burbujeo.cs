using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Burbujeo
    {
        public void MetodoInstancia()
        {
            try
            {
                // Lanzar la excepción MiException
                throw new MiException("Excepción en el método de instancia");
            }
            catch (MiException ex)
            {
                // Registrar el lugar en el archivo de log
                RegistrarEnLog("Método de instancia: " + ex.Message);
                // Relanzar la excepción
                throw;
            }
        }

        public static void MetodoClase()
        {
            try
            {
                Burbujeo burbujeo = new Burbujeo();
                // Llamar al método de instancia
                burbujeo.MetodoInstancia();
            }
            catch (MiException ex)
            {
                // Registrar el lugar en el archivo de log
                RegistrarEnLog("Método estático: " + ex.Message);
                // Relanzar la excepción
                throw;
            }
        }

        private static void RegistrarEnLog(string mensaje)
        {
            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "burbujeo.log");
            string logEntry = $"{DateTime.Now}: {mensaje}";

            File.AppendAllText(path, logEntry + Environment.NewLine);
        }
    }
}
