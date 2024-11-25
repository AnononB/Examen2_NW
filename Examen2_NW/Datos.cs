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

        public void actualiza(string query, List<object> values, List<string> parameterNames)
        {

            using (SqlConnection connection = new SqlConnection(cadenaConexion))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    for (int i = 0; i < values.Count; i++)
                    {
                        command.Parameters.AddWithValue(parameterNames[i], values[i] ?? DBNull.Value);
                    }

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }






        public void eliminar(string query, object primaryKeyValue)
        {
           
            using (SqlConnection connection = new SqlConnection(cadenaConexion))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@primaryKeyValue", primaryKeyValue);

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }

        public void insertar(string query, string usuario, string contraseña, string nombre)
        {
           

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

        public void insertarDinamico(string query, List<string> columns, List<string> values)
        {

            using (SqlConnection connection = new SqlConnection(cadenaConexion))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    for (int i = 0; i < columns.Count; i++)
                    {
                        command.Parameters.AddWithValue($"@{columns[i]}", values[i]);
                    }

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }

        public void insertarDinamico(string query, List<string> columns, List<object> values)
        {
            string cadenaConexion = @"Data Source=LAPTOP-FTQMBN1F;Integrated Security=true;initial catalog=Northwind";

            using (SqlConnection connection = new SqlConnection(cadenaConexion))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    for (int i = 0; i < columns.Count; i++)
                    {
                        command.Parameters.AddWithValue($"@{columns[i]}", values[i] ?? DBNull.Value);
                    }

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }

      public void insertarDinamicoConIdentityInsert(string tableName, List<string> columns, List<object> values)
{

    using (SqlConnection connection = new SqlConnection(cadenaConexion))
    {
        connection.Open();
        using (SqlTransaction transaction = connection.BeginTransaction())
        {
            try
            {
                string columnNames = string.Join(", ", columns);
                string valueParams = string.Join(", ", columns.Select(c => $"@{c}"));

                // Habilitar IDENTITY_INSERT solo si es necesario
                string setIdentityInsertOn = $"SET IDENTITY_INSERT {tableName} ON";
                string setIdentityInsertOff = $"SET IDENTITY_INSERT {tableName} OFF";
                
                bool identityInsertRequired = columns.Contains("EmployeeID"); // Ajusta esto según tu tabla

                if (identityInsertRequired)
                {
                    using (SqlCommand cmdOn = new SqlCommand(setIdentityInsertOn, connection, transaction))
                    {
                        cmdOn.ExecuteNonQuery();
                    }
                }

                string insertQuery = $"INSERT INTO {tableName} ({columnNames}) VALUES ({valueParams})";

                using (SqlCommand cmdInsert = new SqlCommand(insertQuery, connection, transaction))
                {
                    for (int i = 0; i < columns.Count; i++)
                    {
                        cmdInsert.Parameters.AddWithValue($"@{columns[i]}", values[i] ?? DBNull.Value);
                    }
                    cmdInsert.ExecuteNonQuery();
                }

                if (identityInsertRequired)
                {
                    using (SqlCommand cmdOff = new SqlCommand(setIdentityInsertOff, connection, transaction))
                    {
                        cmdOff.ExecuteNonQuery();
                    }
                }

                transaction.Commit();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                throw ex;
            }
        }
    }
}


















    }
}

