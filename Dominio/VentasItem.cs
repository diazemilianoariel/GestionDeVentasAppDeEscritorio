using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    internal class VentasItem
    {

        //ID
        public int Id { get; set; }
        public int IdVenta { get; set; }
        
        public int IdProducto { get; set; }

        public float PrecioUnitario { get; set; }

        public int Cantidad { get; set; }

        public float PrecioTotal { get; set; }
    }
}
