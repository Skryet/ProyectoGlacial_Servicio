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
    public partial class frm_OrdenServicioBuscar01 : Form
    {
        public frm_OrdenServicioBuscar01()
        {
            InitializeComponent();
        }

        private void clientesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.glacial_servicioDataSet);

        }

        private void frm_OrdenServicioBuscar01_Load(object sender, EventArgs e)
        {
            this.Location = new Point(300, 5);
            //Etiqueta de orden de servicio
            lbl_ordenServicio.Text = "No." + Program.id_ordenServicio.ToString("000#");
            //Buscar Orden De Servicio
            this.orden_servicio_infogeneralTableAdapter.BuscarOrdenPorID(this.glacial_servicioDataSet.orden_servicio_infogeneral, Program.id_ordenServicio);
            //Buscar Automovil
            this.automoviles_servicioTableAdapter.BuscarVehiculoPorID(this.glacial_servicioDataSet.automoviles_servicio,Program.id_vehiculo);
            //Buscar Cliente
            this.clientesTableAdapter.BuscarClientePorID(this.glacial_servicioDataSet.clientes,Program.id_cliente);

        }

        private void btn_siguiente_Click(object sender, EventArgs e)
        {
            this.Close();
            OrdenServicioBuscar.frm_OrdenServicioBuscar02 frm_Buscar_Orden02 = new OrdenServicioBuscar.frm_OrdenServicioBuscar02();
            frm_Buscar_Orden02.Show();
        }
    }
}
