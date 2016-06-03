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
    public partial class frm_OrdenServicioBuscar04 : Form
    {

        NumeroLetra convertir = new NumeroLetra();
        public frm_OrdenServicioBuscar04()
        {
            InitializeComponent();
        }

        private void orden_servicio_infogeneralBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.orden_servicio_infogeneralBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.glacial_servicioDataSet);

        }

        private void frm_OrdenServicioBuscar04_Load(object sender, EventArgs e)
        {
            this.Location = new Point(300, 20);

            // TODO: esta línea de código carga datos en la tabla 'glacial_servicioDataSet.orden_servicio_infogeneral' Puede moverla o quitarla según sea necesario.
            this.orden_servicio_infogeneralTableAdapter.BuscarOrdenPorID(this.glacial_servicioDataSet.orden_servicio_infogeneral,Program.id_ordenServicio);
            // TODO: esta línea de código carga datos en la tabla 'glacial_servicioDataSet.orden_material' Puede moverla o quitarla según sea necesario.
            this.orden_materialTableAdapter.BuscarListaPorIDLista(this.glacial_servicioDataSet.orden_material, Convert.ToInt32(txt_lista_orden_material.Text));
            txt_totalLetra.Text = convertir.enletras(totalTextBox.Text);
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
            frm_OrdenServicioBuscar00.ActiveForm.WindowState = FormWindowState.Normal;
        }

        private void frm_OrdenServicioBuscar04_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}
