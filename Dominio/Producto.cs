﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public   class Producto
    {
        //ID
        public int Id { get; set; }
        public  string NombreProducto { get; set; }
        public float Precio { get; set; }
        public  string Categoria { get; set; }
    }
}
