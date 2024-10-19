using System;

using System.Windows.Forms;


namespace Front
{
    public partial class PantallaPrincipal : Form
    {
        public PantallaPrincipal()
        {
            InitializeComponent();

        }

        private void BtnVentas_Click(object sender, EventArgs e)
        {
            FRMVentas ventas = new FRMVentas();
            ventas.Show();

        }

        private void BtnClientes_Click(object sender, EventArgs e)
        {
            FRMClientes clientes = new FRMClientes();
            clientes.Show();

        }

        private void BtnProductos_Click(object sender, EventArgs e)
        {
            FRMProductos producto = new FRMProductos();
            producto.Show();


        }
    }
}
