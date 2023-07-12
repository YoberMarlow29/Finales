using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ADO
    {
        private static string cadena_conexion;
        private SqlConnection conexion;
        private SqlCommand comando;
        private SqlDataReader lector; //==> usar cuando el metoodo obtener no estatico

        public delegate void ColorExistenteDelegado(object sender, EventArgs e);
        public event ColorExistenteDelegado ColorExistente;

        static ADO()
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = ".";
            builder.IntegratedSecurity = true;
            //builder.UserID = "usuario";
            //builder.Password = "clave";
            builder.InitialCatalog = "concesionaria";
            ADO.cadena_conexion = builder.ConnectionString;
        }

        public ADO()
        {
            // CREO UN OBJETO SQLCONECTION
            this.conexion = new SqlConnection(ADO.cadena_conexion);
        }

        public static List<Auto> ObtenerTodos()
        {
            List<Auto> lista = new List<Auto>();

            try
            {
                SqlConnection conexion = new SqlConnection(ADO.cadena_conexion);  // Crear una nueva instancia de SqlConnection

                SqlCommand comando = new SqlCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "SELECT * FROM autos";
                comando.Connection = conexion;

                conexion.Open();

                SqlDataReader lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Auto item = new Auto();

                    item.Marca = lector["marca"].ToString();
                    item.Modelo = lector["modelo"].ToString();
                    item.Kms = (int)lector["kms"];
                    item.Color = lector["color"].ToString();
                    item.Patente = lector["patente"].ToString();

                    lista.Add(item);
                }

                lector.Close();
            }
            catch (Exception)
            {
                return null;
            }

            return lista;
        }
        public static List<Auto> ObtenerTodos(string color)
        {
            List<Auto> lista = new List<Auto>();

            try
            {
                SqlConnection conexion = new SqlConnection(ADO.cadena_conexion);  // Crear una nueva instancia de SqlConnection

                SqlCommand comando = new SqlCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "SELECT * FROM autos WHERE color = @color";
                comando.Parameters.AddWithValue("@color", color);
                comando.Connection = conexion;

                conexion.Open();

                SqlDataReader lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Auto item = new Auto();

                    item.Marca = lector["marca"].ToString();
                    item.Modelo = lector["modelo"].ToString();
                    item.Kms = (int)lector["kms"];
                    item.Color = lector["color"].ToString();
                    item.Patente = lector["patente"].ToString();

                    lista.Add(item);
                }

                lector.Close();
            }
            catch (Exception)
            {
                return null;
            }

            return lista;
        }
        public bool Agregar(Auto param)
        {
            bool rta = true;

            try
            {
                bool patenteExistente = ExistePatente(param.Patente, out Auto autoExistente);
                if (patenteExistente)
                {
                    throw new PatenteExistenteException(autoExistente);
                }


                string sql = "INSERT INTO autos (marca, modelo, kms, color, patente) VALUES (@marca, @modelo, @kms, @color, @patente)";

                this.comando = new SqlCommand();

                this.comando.CommandType = CommandType.Text;
                this.comando.CommandText = sql;
                this.comando.Connection = this.conexion;

                this.comando.Parameters.AddWithValue("@marca", param.Marca);
                this.comando.Parameters.AddWithValue("@modelo", param.Modelo);
                this.comando.Parameters.AddWithValue("@kms", param.Kms);
                this.comando.Parameters.AddWithValue("@color", param.Color);
                this.comando.Parameters.AddWithValue("@patente", param.Patente);

                this.conexion.Open();

                int filasAfectadas = this.comando.ExecuteNonQuery();

                this.ColorExistente(ObtenerTodos(param.Color), EventArgs.Empty);

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
                CerrarConexion();
            }

            return rta;
        }
        public bool Modificar(Auto param)
        {
            bool rta = true;

            try
            {
                this.comando = new SqlCommand();

                this.comando.Parameters.AddWithValue("@marca", param.Marca);
                this.comando.Parameters.AddWithValue("@modelo", param.Modelo);
                this.comando.Parameters.AddWithValue("@kms", param.Kms);
                this.comando.Parameters.AddWithValue("@color", param.Color);
                this.comando.Parameters.AddWithValue("@patente", param.Patente);

                string sql = "UPDATE autos ";
                sql += "SET marca = @marca, modelo = @modelo, kms = @kms, color = @color ";
                sql += "WHERE patente = @patente";

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
                CerrarConexion();
            }
            return rta;
        }
        public bool Eliminar(Auto param)
        {
            bool rta = true;

            try
            {
                this.comando = new SqlCommand();

                this.comando.Parameters.AddWithValue("@patente", param.Patente);

                string sql = "DELETE FROM autos ";
                sql += "WHERE patente = @patente";

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
                CerrarConexion();
            }

            return rta;
        }
        public bool ExistePatente(string patente, out Auto autoEncontrado)
        {
            autoEncontrado = null;

            try
            {
                this.comando = new SqlCommand();

                this.comando.Parameters.AddWithValue("@patente", patente);

                string sql = "SELECT * FROM autos WHERE patente = @patente";

                this.comando.CommandType = CommandType.Text;
                this.comando.CommandText = sql;
                this.comando.Connection = this.conexion;

                this.conexion.Open();

                this.lector = comando.ExecuteReader();

                if (lector.Read())
                {
                    autoEncontrado = new Auto();
                    autoEncontrado.Marca = lector["marca"].ToString();
                    autoEncontrado.Modelo = lector["modelo"].ToString();
                    autoEncontrado.Kms = (int)lector["kms"];
                    autoEncontrado.Color = lector["color"].ToString();
                    autoEncontrado.Patente = lector["patente"].ToString();

                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                CerrarConexion();
            }

            return false;
        }
        public void CerrarConexion()
        {
            if (this.conexion.State == ConnectionState.Open)
            {
                this.conexion.Close();
            }
        }
    }
}
