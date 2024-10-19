using System;
using System.Collections.Generic;

using System.Windows.Forms;
using System.Configuration;
using Dominio;
using DataManager;

namespace Front
{
    public partial class FRMVentas : Form
    {

        VentaManager ventaManager = new VentaManager();



        public FRMVentas()
        {
            InitializeComponent();

            // aca tenes qyue llamar a listarprueba
            //ListarPrueba();
            ventaManager = new VentaManager();
            this.Load += new EventHandler(FRMVenta_Load); // Evento que se dispara cuando se carga el formulario

        }

        private void FRMVenta_Load(object sender, EventArgs e)
        {
            CargarVentas();
        }

        private void CargarVentas()
        {
            // aca tenes que llamar a listar
            List<Venta> ventas = ventaManager.ObtenerListaVentas();
            dataGridView1.DataSource = ventas;
        }




        private void ListarPrueba()
        {
            List<Venta> ventas = new List<Venta>(); // Corregir el tipo 'Ventas' a 'Venta' y eliminar la asignación innecesaria


            ventas.Add(new Venta { Id = 1, IdCliente = 1, Fecha = DateTime.Now,  Total = 100 });
            ventas.Add(new Venta { Id = 2, IdCliente = 2, Fecha = DateTime.Now,  Total = 200 });
            ventas.Add(new Venta { Id = 3, IdCliente = 3, Fecha = DateTime.Now,  Total = 300 });

            dataGridView1.DataSource = ventas;
        }

    }
}
