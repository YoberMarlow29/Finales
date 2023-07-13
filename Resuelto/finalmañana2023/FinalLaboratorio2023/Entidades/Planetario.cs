using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Entidades
{
    /*
         CLASE Planetario: Se encargará de conectarse y hacer las consultas a la base de datos.
    Atributos:
    (-) conexion: SqlConnection;
    Constructor:
    (+)Planetario() --> Configurar conexión.
    Métodos:
    (+)Insertar(Planeta p):bool --> Inserta planeta en base de datos.
    (+)Modificar(Planeta p):bool --> Modifica planeta en base de datos.
    (+)Eliminar(Planeta p):bool --> Elimina planeta en base de datos.
    (+)ObtenerPlanetas(): List<Planeta> --> Obtiene todos los planetas de la base de datos.
     */
    public class Planetario
    {
        private static string cadena_conexion;
        private SqlConnection conexion;
        private SqlCommand comando;
        private SqlDataReader lector;

        static Planetario()
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = @".";
            builder.IntegratedSecurity = true;
            //builder.UserID = "usuario";
            //builder.Password = "clave";
            builder.InitialCatalog = "FinalLabo2";

            Planetario.cadena_conexion = builder.ConnectionString;

            //AccesoDatos.cadena_conexion = @"Server=.;Database=Test;Trusted_Connection=True;";

        }

        public Planetario()
        {
            // CREO UN OBJETO SQLCONECTION
            this.conexion = new SqlConnection(Planetario.cadena_conexion);
        }

        public bool Insertar(Planeta param)
        {
            bool rta = true;

            try
            {
                string sql = "INSERT INTO planetas (id, nombre, masa, diametro, satelites) VALUES (";
                sql += "'" + param.Id.ToString() + "', ";
                sql += "'" + param.Nombre + "', ";
                sql += param.Masa.ToString() + ", ";
                sql += param.Diametro.ToString() + ", ";
                sql += param.Satelites.ToString() + ")";

                this.comando = new SqlCommand();
                this.comando.CommandType = CommandType.Text;
                this.comando.CommandText = sql;
                this.comando.Connection = this.conexion;

                this.conexion.Open();
                int filasAfectadas = this.comando.ExecuteNonQuery();

                if (filasAfectadas == 0)
                {
                    rta = false;
                }
            }
            catch (Exception e)
            {
                rta = false;
            }
            finally
            {
                if (this.conexion.State == ConnectionState.Open)
                {
                    this.conexion.Close();
                }
            }

            return rta;
        }

        public bool Modificar(Planeta param)
        {
            bool rta = true;

            try
            {
                this.comando = new SqlCommand();

                this.comando.Parameters.AddWithValue("@id", param.Id);
                this.comando.Parameters.AddWithValue("@nombre", param.Nombre);
                this.comando.Parameters.AddWithValue("@masa", param.Masa);
                this.comando.Parameters.AddWithValue("@diametro", param.Diametro);
                this.comando.Parameters.AddWithValue("@satelites", param.Satelites);


                string sql = "UPDATE planetas ";
                sql += "SET nombre = @nombre, masa = @masa, diametro = @diametro, satelites = @satelites ";
                sql += "WHERE id = @id";

                this.comando.CommandType = CommandType.Text;
                this.comando.CommandText = sql;
                this.comando.Connection = this.conexion;

                this.conexion.Open();

                int filasAfectadas = this.comando.ExecuteNonQuery();

                if (filasAfectadas == 0)
                {
                    rta = false;
                }

            }
            catch (Exception)
            {
                rta = false;
            }
            finally
            {
                if (this.conexion.State == ConnectionState.Open)
                {
                    this.conexion.Close();
                }
            }

            return rta;
        }

        public bool Eliminar(Planeta param)
        {
            bool rta = true;

            try
            {
                this.comando = new SqlCommand();

                this.comando.Parameters.AddWithValue("@id", param.Id);

                string sql = "DELETE FROM planetas ";
                sql += "WHERE id = @id";

                this.comando.CommandType = CommandType.Text;
                this.comando.CommandText = sql;
                this.comando.Connection = this.conexion;

                this.conexion.Open();

                int filasAfectadas = this.comando.ExecuteNonQuery();

                if (filasAfectadas == 0)
                {
                    rta = false;
                }

            }
            catch (Exception)
            {
                rta = false;
            }
            finally
            {
                if (this.conexion.State == ConnectionState.Open)
                {
                    this.conexion.Close();
                }
            }

            return rta;
        }

        public List<Planeta> ObtenerPlanetas()
        {
            List<Planeta> lista = new List<Planeta>();

            try
            {
                this.comando = new SqlCommand();

                this.comando.CommandType = CommandType.Text;
                this.comando.CommandText = "SELECT id, nombre, masa, diametro, satelites FROM planetas";
                this.comando.Connection = this.conexion;

                this.conexion.Open();

                this.lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Planeta item = new Planeta((int)lector["id"], lector[2].ToString(), (double)lector["masa"], (double)lector["diametro"], (int)lector["satelites"]);

                    /*
                     reader["dni"].ToString()),
                        reader["apellido"].ToString(),
                        reader["nombre"].ToString(),
                        double.Parse(reader["nota"].ToString())
                     */

                    lista.Add(item);
                }

                lector.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                if (this.conexion.State == ConnectionState.Open)
                {
                    this.conexion.Close();
                }
            }

            return lista;
        }
    }
}
