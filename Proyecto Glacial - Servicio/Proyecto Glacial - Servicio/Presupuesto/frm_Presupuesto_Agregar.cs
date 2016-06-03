using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Glacial___Servicio.Presupuesto
{
    public partial class frm_Presupuesto_Agregar : Form
    {
        Clases.consultas consultas = new Clases.consultas();
        public frm_Presupuesto_Agregar()
        {
            InitializeComponent();
        }

        private void btn_finalizarCompra_Click(object sender, EventArgs e)
        {            
            this.presupuesto_generalTableAdapter.InsertarPresupuestoGeneral(Program.id_ordenServicio
                , Program.id_cliente, Program.id_vehiculo, 0, txt_observaciones.Text, txt_tecnico.Text,
                Convert.ToDouble(txt_subtotal.Text), Convert.ToDouble(txt_IVA.Text), Convert.ToDouble(txt_total.Text));
            Program.id_presupuesto = consultas.obtenerUltimoID("id_presupuesto", "presupuesto_general");
            double total = 0;
            string descripcion;
            double importe;

            //Crear la lista detallada y guardarla
            for (int i = 0; i < dataGridView_descripcion.Rows.Count - 1; i++)
            {
                descripcion = dataGridView_descripcion.Rows[i].Cells["descripcionTrabajo"].Value.ToString();
                importe = Convert.ToDouble(dataGridView_descripcion.Rows[i].Cells["importe"].Value);
                total += importe;
                //Agrega a la tabla de lista_presupuesteo
                lista_presupuestoTableAdapter.InsertarListaPresupuesto(descripcion,importe, Program.id_presupuesto);
            }

        }

        private void presupuesto_generalBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.presupuesto_generalBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.glacial_servicioDataSet);

        }

        private void frm_Presupuesto_Agregar_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'glacial_servicioDataSet.automoviles_servicio' Puede moverla o quitarla según sea necesario.
            this.automoviles_servicioTableAdapter.BuscarVehiculoPorID(this.glacial_servicioDataSet.automoviles_servicio,Program.id_vehiculo);
            // TODO: esta línea de código carga datos en la tabla 'glacial_servicioDataSet.clientes' Puede moverla o quitarla según sea necesario.
            this.clientesTableAdapter.BuscarClientePorID(this.glacial_servicioDataSet.clientes,Program.id_cliente);
            // TODO: esta línea de código carga datos en la tabla 'glacial_servicioDataSet.orden_servicio_infogeneral' Puede moverla o quitarla según sea necesario.
            this.orden_servicio_infogeneralTableAdapter.BuscarOrdenPorID(this.glacial_servicioDataSet.orden_servicio_infogeneral,Program.id_ordenServicio);

        }

        private void dataGridView_descripcion_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            double total = 0;
            //Crear la lista detallada y guardarla
            for (int i = 0; i < dataGridView_descripcion.Rows.Count - 1; i++)
            {
                total += Convert.ToDouble(dataGridView_descripcion.Rows[i].Cells["importe"].Value);
                txt_subtotal.Text = total.ToString();
            }
            txt_IVA.Text = (Convert.ToDouble(txt_subtotal.Text) * .16).ToString();
            txt_total.Text = (Convert.ToDouble(txt_subtotal.Text) + Convert.ToDouble(txt_IVA.Text)).ToString();
        }

        private void dataGridView_descripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                double total = 0;
                //Crear la lista detallada y guardarla
                for (int i = 0; i < dataGridView_descripcion.Rows.Count - 1; i++)
                {
                    total += Convert.ToDouble(dataGridView_descripcion.Rows[i].Cells["importe"].Value);
                    txt_subtotal.Text = total.ToString();
                }
                txt_IVA.Text = (Convert.ToDouble(txt_subtotal.Text) * .16).ToString();
                txt_total.Text = (Convert.ToDouble(txt_subtotal.Text) + Convert.ToDouble(txt_IVA.Text)).ToString();
            }
        }
    }
}
