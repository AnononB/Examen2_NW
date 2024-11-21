using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen2_NW
{
    internal class Datos
    {
       
            String cadenaConexion = @"Data Source=LAPTOP-FTQMBN1F;
            Integrated Security=true;initial catalog=Northwind";

            SqlConnection conexion;

            private SqlConnection abrirConexion()
            {
                try
                {
                    conexion = new SqlConnection(cadenaConexion);
                    conexion.Open();

                    return conexion;
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex);
                    return null;
                }
            }
            private void cerrarConexion()
            {
                try
                {
                    if (conexion != null)
                    {
                        conexion.Close();
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex);
                }

            }
            public bool ejecutarABC(String comando)
            {
                try
                {
                    SqlCommand command = new SqlCommand(comando, abrirConexion());
                    command.ExecuteNonQuery();
                    cerrarConexion();
                    return true;
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex);
                    return false;
                }
            }
            public DataSet consulta(String comando)
            {
                try
                {
                    DataSet ds = new DataSet();
                    SqlDataAdapter da = new SqlDataAdapter(comando, abrirConexion());
                    da.Fill(ds);
                    cerrarConexion();
                    return ds;
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex);
                    return null;
                }
            }

        public void actualiza(string query, object newValue, object primaryKeyValue)
        {

            string cadenaConexion = @"Data Source=LAPTOP-FTQMBN1F;Integrated Security=true;
                                    initial catalog=Northwind";

            using (SqlConnection connection = new SqlConnection(cadenaConexion))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    //
                    command.Parameters.AddWithValue("@newValue", newValue);
                    command.Parameters.AddWithValue("@primaryKeyValue", primaryKeyValue);

                    //
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }

        public void eliminar(string query, object primaryKeyValue)
        {
            // Define tu cadena de conexión
            string cadenaConexion = @"Data Source=LAPTOP-FTQMBN1F;Integrated Security=true;initial catalog=Northwind";

            // Usar la conexión para ejecutar la consulta de eliminación
            using (SqlConnection connection = new SqlConnection(cadenaConexion))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Agregar parámetro a la consulta para evitar SQL Injection
                    command.Parameters.AddWithValue("@primaryKeyValue", primaryKeyValue);

                    // Abrir la conexión, ejecutar la consulta y cerrar la conexión
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }

        public void insertar(string query, string usuario, string contraseña, string nombre)
        {
            string cadenaConexion = @"Data Source=LAPTOP-FTQMBN1F;Integrated Security=true;
                                    initial catalog=Northwind";

            using (SqlConnection connection = new SqlConnection(cadenaConexion))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@usuario", usuario);
                    command.Parameters.AddWithValue("@contraseña", contraseña);
                    command.Parameters.AddWithValue("@nombre", nombre);

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }

        public bool verificarUsuario(string query, string usuario, string contraseña)
        {
            string cadenaConexion = @"Data Source=LAPTOP-FTQMBN1F;Integrated Security=true;initial catalog=Northwind";

            using (SqlConnection connection = new SqlConnection(cadenaConexion))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@usuario", usuario);
                    command.Parameters.AddWithValue("@contraseña", contraseña);

                    connection.Open();
                    int count = (int)command.ExecuteScalar();
                    connection.Close();

                    return count > 0;
                }
            }
        }







    }
}

