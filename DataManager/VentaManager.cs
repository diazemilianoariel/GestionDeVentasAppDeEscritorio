using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace DataManager
{
    public class VentaManager
    {
        /*Alta, Baja y Modificación  de ventas de uno o más productos, indicando por  ítem de venta cantidad, 
         precio unitario y precio  total del ítem. Finalmente sumar los totales y mostrar el Total General.*/

        private AccesoDatos acceso;

        public VentaManager()
        {
            acceso = new AccesoDatos();
        }

        // Método para obtener la lista de ventas
        public List<Venta> ObtenerListaVentas()
        {
            List<Venta> listaVentas = new List<Venta>();
            try
            {
                acceso.SetearConsulta("SELECT Id, IdCliente, Fecha, Total FROM Ventas");
                acceso.EjecutarLectura();

                while (acceso.Lector.Read())
                {
                    Venta venta = new Venta
                    {
                        Id = (int)acceso.Lector["Id"],
                        IdCliente = (int)acceso.Lector["IdCliente"],
                        Fecha = (DateTime)acceso.Lector["Fecha"],   
                        Total = (float)Convert.ToDouble(acceso.Lector["Total"])
                    };
                    listaVentas.Add(venta);
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

            return listaVentas;
        }
    }
}
