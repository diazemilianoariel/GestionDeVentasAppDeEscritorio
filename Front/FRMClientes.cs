using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using DataManager;


namespace Front
{

    
public partial class FRMClientes : Form
    {
        private ClienteManager clienteManager; // esta variable es para poder acceder a los metodos de la clase ClienteManager

        public FRMClientes()
        {
            InitializeComponent();
            clienteManager = new ClienteManager();
            this.Load += new EventHandler(FRMClientes_Load); // Evento que se dispara cuando se carga el formulario
        }

        private void FRMClientes_Load(object sender, EventArgs e)
        {
            CargarClientes();
        }

        private void CargarClientes()
        {
            List<Cliente> clientes = clienteManager.ObtenerListaClientes();
            dataGridView1.DataSource = clientes;
        }
    }
}
