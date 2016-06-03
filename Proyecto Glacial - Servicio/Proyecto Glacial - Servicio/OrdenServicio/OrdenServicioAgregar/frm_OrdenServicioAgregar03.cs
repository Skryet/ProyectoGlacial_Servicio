using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Glacial___Servicio.OrdenServicio
{
    
    public partial class frm_OrdenServicioAgregar03 : Form
    {
        Clases.consultas consultas = new Clases.consultas();
        public frm_OrdenServicioAgregar03()
        {
            InitializeComponent();
        }

        private void btn_siguiente_Click(object sender, EventArgs e)
        {
            this.danos_vehiculoTableAdapter.AgregarDanosVehiculo(
                ch1_1.CheckState, ch1_2.CheckState, ch1_3.CheckState, ch1_4.CheckState, ch1_5.CheckState, ch1_6.CheckState, ch1_7.CheckState, ch1_8.CheckState, ch1_9.CheckState, ch1_10.CheckState, ch1_11.CheckState, ch1_12.CheckState, ch1_13.CheckState, ch1_14.CheckState,
                ch2_1.CheckState, ch2_2.CheckState, ch2_3.CheckState, ch2_4.CheckState, ch2_5.CheckState, ch2_6.CheckState, ch2_7.CheckState, ch2_8.CheckState, ch2_9.CheckState, ch2_10.CheckState, ch2_11.CheckState,
                ch3_1.CheckState, ch3_2.CheckState, ch3_3.CheckState, ch3_4.CheckState, ch3_5.CheckState, ch3_6.CheckState, ch3_7.CheckState, ch3_8.CheckState, ch3_9.CheckState, ch3_10.CheckState, ch3_11.CheckState, ch3_12.CheckState, ch3_13.CheckState,
                Program.id_ordenServicio,txt_observaciones.Text);
            Form frm_Orden04 = new OrdenServicio.frm_OrdenServicioAgregar04();
            this.Close();
            frm_Orden04.ShowDialog();
        }

        private void frm_OrdenServicioAgregar03_Load(object sender, EventArgs e)
        {
            this.Location = new Point(300, 20);
        }

        private void danos_vehiculoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.danos_vehiculoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.glacial_servicioDataSet);

        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show("Si cierra esta ventana se elimnará la Orden de Servicio actual, ¿Está seguro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                consultas.borrarUltimoRegistro("orden_servicio_infogeneral", Program.id_ordenServicio, "id_numero_orden");
                consultas.borrarUltimoRegistro("automovil_inventario", consultas.obtenerUltimoID("id_automovil_inventario", "automovil_inventario"), "id_automovil_inventario");
                this.Close();
            }
        }
    }
}
