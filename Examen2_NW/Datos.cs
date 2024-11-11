﻿using System;
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
       
            String cadenaConexion = @"Data Source=LAPTOP-I6D75RA8;
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


        }
    }
