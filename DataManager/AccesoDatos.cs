﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DataManager
{
    public class AccesoDatos
    {
        private SqlConnection conexion;
        private SqlCommand comando;
        private SqlDataReader lector;

        public SqlDataReader Lector
        {
            get { return lector; }
        }


        //defino el constructor
        public AccesoDatos()
        {
            conexion = new SqlConnection("server=.\\SQLEXPRESS; database=pruebademo; integrated security=true");
            comando = new SqlCommand();
        }

        public void SetearConsulta(string query)
        {
            comando.CommandType= System.Data.CommandType.Text;
            comando.CommandText= query;
        }

        public void EjecutarLectura()
        {
            comando.Connection= conexion;
            try
            {
                conexion.Open();
                lector = comando.ExecuteReader();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ejecutarAccion()
        {
            comando.Connection = conexion;
            try
            {
                conexion.Open();
                comando.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                cerrarConexion();
            }
        }


        public object ejecutarEscalar()
        {
            comando.Connection = conexion;
            try
            {
                conexion.Open();
                return comando.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                cerrarConexion();
            }
        }




        public void setearParametro(string parametro,object valor)
        {
            comando.Parameters.AddWithValue(parametro, valor);
        }
        public void cerrarConexion()
        {
            if (lector != null)
                lector.Close();
            conexion.Close();
        }

    }
}
