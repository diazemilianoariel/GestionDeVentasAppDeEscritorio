using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataManager;
using Dominio;

namespace Front
{
    public partial class FRMProductos : Form
    {

        private ProductoManager productoManager;


        public FRMProductos()
        {
            InitializeComponent();
            productoManager = new ProductoManager(); // Se instancia un objeto de la clase ProductoManager
            this.Load += new EventHandler(FRMProducto_Load); // se dispara el evento cuando se carga el formulario
        }


        private void FRMProducto_Load(object sender, EventArgs e)
        {
            CargarProductos();
        }


        private void CargarProductos()
        {
            List<Producto> productos = productoManager.ObtenerListaProductos();
            dataGridView1.DataSource = productos;
        }
    }
}
