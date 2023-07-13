using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesRSP
{
    ///AlumnoADO (hereda de Alumno)
    ///Atributos (estáticos)
    ///conexion : string
    ///connection : SqlConnection
    ///command : SqlCommand
    ///Constructor de clase que inicialice todos sus atributos
    ///Constructor que recibe un objeto de tipo Alumno cómo parámetro
    ///Métodos de instancia (públicos):
    ///ObtenerTodos() : List<Alumno> 
    ///Agregar() : bool
    ///Modificar() : bool -> se modifica a partir del dni
    ///Eliminar() : bool -> se elimina a partir del dni
    public class AlumnoADO : Alumno
    {
        static string conexion;
        static SqlConnection connection;
        static SqlCommand command;


        static AlumnoADO() 
        {
            AlumnoADO.conexion = @"Server=localhost;Database=utn_fra_alumnos;Trusted_Connection=True;";
            connection = new SqlConnection(AlumnoADO.conexion);
        }

        public AlumnoADO(Alumno alumno) : base(alumno.Dni, alumno.Apellido, alumno.Nombre, alumno.Nota) { }


        public static List<Alumno> ObtenerTodos()
        {
            List<Alumno> lista = new List<Alumno>();

            SqlDataReader reader;

            try
            {
                command = new SqlCommand();

                command.CommandText = "SELECT * FROM dbo.alumnos";
                command.CommandType = CommandType.Text;
                command.Connection = connection;

                connection.Open();

                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Alumno alumno = new Alumno(
                        int.Parse(reader["dni"].ToString()),
                        reader["apellido"].ToString(),
                        reader["nombre"].ToString(),
                        double.Parse(reader["nota"].ToString()));

                    lista.Add(alumno);
                }

                reader.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }

            return lista;
        }

        public bool Agregar()
        {
            bool retorno;

            try
            {
                connection.Open();

                command.Parameters.Clear();
                command.Parameters.AddWithValue("@dni", this.Dni);
                command.Parameters.AddWithValue("@apellido", this.Apellido);
                command.Parameters.AddWithValue("@nombre", this.Nombre);
                command.Parameters.AddWithValue("@nota", this.Nota);

                command.CommandText = "INSERT INTO dbo.alumnos " +
                                      "VALUES(@dni, @apellido, @nombre, @nota) ";
                command.CommandType = CommandType.Text;
                command.Connection = connection;

                command.ExecuteNonQuery();

                retorno = true;
            }

            catch (Exception)
            {
                retorno = false;
            }

            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }

            return retorno;
        }

        public bool Modificar()
        {
            bool retorno;

            try
            {
                connection.Open();

                command.Parameters.Clear();
                command.Parameters.AddWithValue("@dni", this.Dni);
                command.Parameters.AddWithValue("@apellido", this.Apellido);
                command.Parameters.AddWithValue("@nombre", this.Nombre);
                command.Parameters.AddWithValue("@nota", this.Nota);

                string sql = "UPDATE dbo.productos ";
                sql += "SET marca = @marca, tipo = @tipo, precio = @precio ";
                sql += "WHERE codigo = @codigo";

                command.CommandType = CommandType.Text;
                command.CommandText = "UPDATE dbo.alumnos " +
                                      "SET apellido = @apellido, nombre = @nombre, nota = @nota " +
                                      "WHERE dni = @dni";
                command.Connection = connection;

                command.ExecuteNonQuery();

                retorno = true;
            }
            catch (Exception)
            {
                retorno = false;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
            return retorno;
        }

        public bool Eliminar()
        {
            bool retorno;

            try
            {
                connection.Open();

                command.Parameters.Clear();
                command.Parameters.AddWithValue("@dni", this.Dni);

                command.CommandText = "DELETE FROM dbo.alumnos " +
                                      "WHERE dni = @dni";
                command.CommandType = CommandType.Text;
                command.Connection = connection;


                command.ExecuteNonQuery();

                retorno = true;
            }
            catch (Exception)
            {
                retorno = false;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
            return retorno;
        }
    }
}
