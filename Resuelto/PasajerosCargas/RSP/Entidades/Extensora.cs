using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Entidades
{
    ///Agregar en el proyecto de tipo Class Library, la clase estática Extensora, la cual tendrá:
    ///atributo privado: conexion : string
    ///constructor que inicializará al atributo con la cadena de conexión adecuada para conectarse
    ///con la base de datos 'pasajeros_db' (provista en el parcial)
    ///Método público: ObtenerTodosBD() : List<Pasajero>
    ///este método debe ser un método de extensión para la clase Pasajero.
    ///
    public static class Extensora
    {
        private static string cadenaConexion;

        static Extensora()
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = ".";
            builder.IntegratedSecurity = true;
            builder.InitialCatalog = "pasajeros_db";
            cadenaConexion = builder.ConnectionString;
        }

        public static List<Pasajero> ObtenerTodosBD(this Pasajero pasajero)
        {
            List<Pasajero> lista = new List<Pasajero>();

            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                try
                {
                    SqlCommand comando = new SqlCommand();
                    comando.CommandType = CommandType.Text;
                    comando.CommandText = "SELECT * FROM Pasajeros";
                    comando.Connection = conexion;

                    conexion.Open();

                    SqlDataReader lector = comando.ExecuteReader();

                    while (lector.Read())
                    {
                        Pasajero item = new Pasajero();
                        item.dni = (int)lector["dni"];
                        item.nombre = lector["nombre"].ToString();
                        item.equipaje = (int)lector["equipaje"];
                        lista.Add(item);
                    }

                    lector.Close();
                }
                catch (Exception)
                {
                    return null;
                }
            }

            return lista;
        }

        public static bool AgregarBD(this Pasajero pasajero)
        {
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                try
                {
                    SqlCommand comando = new SqlCommand();
                    comando.CommandType = CommandType.Text;
                    comando.CommandText = "INSERT INTO Pasajeros (dni, nombre, equipaje) VALUES (@dni, @nombre, @equipaje)";
                    comando.Connection = conexion;

                    comando.Parameters.AddWithValue("@dni", pasajero.dni);
                    comando.Parameters.AddWithValue("@nombre", pasajero.nombre);
                    comando.Parameters.AddWithValue("@equipaje", pasajero.equipaje);

                    conexion.Open();
                    comando.ExecuteNonQuery();

                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }
        public static bool ModificarBD(this Pasajero pasajero)
        {
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                try
                {
                    SqlCommand comando = new SqlCommand();
                    comando.CommandType = CommandType.Text;
                    comando.CommandText = "UPDATE Pasajeros SET nombre = @nombre, equipaje = @equipaje WHERE dni = @dni";
                    comando.Connection = conexion;

                    comando.Parameters.AddWithValue("@nombre", pasajero.nombre);
                    comando.Parameters.AddWithValue("@equipaje", pasajero.equipaje);
                    comando.Parameters.AddWithValue("@dni", pasajero.dni);

                    conexion.Open();
                    comando.ExecuteNonQuery();

                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        public static bool EliminarBD(this Pasajero pasajero)
        {
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                try
                {
                    SqlCommand comando = new SqlCommand();
                    comando.CommandType = CommandType.Text;
                    comando.CommandText = "DELETE FROM Pasajeros WHERE dni = @dni";
                    comando.Connection = conexion;

                    comando.Parameters.AddWithValue("@dni", pasajero.dni);

                    conexion.Open();
                    comando.ExecuteNonQuery();

                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }
    }
}
