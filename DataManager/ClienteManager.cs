using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;


namespace DataManager
{
    public class ClienteManager
    {
        private AccesoDatos acceso;

        public ClienteManager()
        {
            acceso = new AccesoDatos();
        }

        public List<Cliente> ObtenerListaClientes()
        {
            List<Cliente> listaClientes = new List<Cliente>();
            try
            {
                acceso.SetearConsulta("SELECT Id, Cliente AS NombreCliente, Telefono, Correo FROM Clientes");
                acceso.EjecutarLectura();

                while (acceso.Lector.Read())
                {
                    Cliente cliente = new Cliente
                    {
                        ID = (int)acceso.Lector["ID"],
                        NombreCliente = acceso.Lector["NombreCliente"].ToString(), // Actualizado
                        Telefono = acceso.Lector["Telefono"].ToString(),
                        Correo = acceso.Lector["Correo"].ToString()
                    };
                    listaClientes.Add(cliente);
                }
            }
            catch (Exception ex)
            {
                // Manejo de excepciones
                throw ex;
            }
            finally
            {
                acceso.cerrarConexion();
            }

            return listaClientes;
        }
    }
}
