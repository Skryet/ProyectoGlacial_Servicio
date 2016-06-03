using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Glacial___Servicio.OrdenServicio.OrdenServicioBuscar
{
    public partial class frm_OrdenServicioBuscar03 : Form
    {
        public frm_OrdenServicioBuscar03()
        {
            InitializeComponent();
        }

        private void frm_OrdenServicioBuscar03_Load(object sender, EventArgs e)
        {
            this.Location = new Point(600, 30);
            // TODO: esta línea de código carga datos en la tabla 'glacial_servicioDataSet.danos_vehiculo' Puede moverla o quitarla según sea necesario.
            this.danos_vehiculoTableAdapter.BuscarPorID(this.glacial_servicioDataSet.danos_vehiculo, Program.id_ordenServicio);

        }

        private void btn_siguiente_Click(object sender, EventArgs e)
        {
            OrdenServicioBuscar.frm_OrdenServicioBuscar04 frm_Orden_Buscar04 = new OrdenServicioBuscar.frm_OrdenServicioBuscar04();
            this.Close();
            frm_Orden_Buscar04.Show();
        }
    }
}
