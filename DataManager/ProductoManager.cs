using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace DataManager
{


    public class ProductoManager
    {
        //Alta, Baja y  Modificación de productos

        private AccesoDatos acceso; // Se crea un objeto de la clase AccesoDatos para poder acceder a la base de datos


        // Constructor de la clase
        public ProductoManager()
        {
            acceso = new AccesoDatos(); // Se instancia un objeto de la clase AccesoDatos
        }


        // Método que obtiene la lista de productos
        public List<Producto> ObtenerListaProductos()
        {
            List<Producto> listaProductos = new List<Producto>();
            try
            {
                acceso.SetearConsulta("SELECT Id, Nombre AS NombreProducto, Precio, Categoria FROM Productos");
                acceso.EjecutarLectura();

                while (acceso.Lector.Read())
                {
                    Producto producto = new Producto
                    {
                        Id = (int)acceso.Lector["Id"],
                        NombreProducto = acceso.Lector["NombreProducto"].ToString(),
                        Precio = Convert.ToSingle(acceso.Lector["Precio"]),
                        Categoria = acceso.Lector["Categoria"].ToString()
                  
                    };
                    listaProductos.Add(producto);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener la lista de productos", ex);
            }
            finally
            {
                acceso.cerrarConexion();
            }

            return listaProductos;
        }
    }
}
