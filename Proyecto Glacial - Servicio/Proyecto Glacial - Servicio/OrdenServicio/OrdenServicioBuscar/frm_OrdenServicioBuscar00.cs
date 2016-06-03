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
    public partial class frm_OrdenServicioBuscar00 : Form
    {
        string fechaInicio;
        string fechaFin;
        Clases.metodosOptimizar optimizar = new Clases.metodosOptimizar();
        public frm_OrdenServicioBuscar00()
        {
            InitializeComponent();
        }

        private void orden_servicio_infogeneralBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.orden_servicio_infogeneralBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.glacial_servicioDataSet);

        }

        private void frm_OrdenServicioBuscar00_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'glacial_servicioDataSet.listar_ordenes_servicio' Puede moverla o quitarla según sea necesario.
            this.listar_ordenes_servicioTableAdapter.Fill(this.glacial_servicioDataSet.listar_ordenes_servicio);
            

        }

        private void listar_ordenes_servicioDataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
             fechaInicio = dtp_fechaInicio.Value.Date.ToString("yyyy-MM-dd");
             fechaFin = dtp_fechaFin.Value.Date.ToString("yyyy-MM-dd");
            funcionBuscar(); 
        }

        private void cmb_seleccionarTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.listar_ordenes_servicioTableAdapter.Fill(this.glacial_servicioDataSet.listar_ordenes_servicio);
            btn_buscar.Enabled = true;
            if (cmb_seleccionarTipo.Text == "Rango de Fechas")
            {
                dtp_fechaFin.Enabled = true;
                dtp_fechaInicio.Enabled = true;
                txt_buscar.Text = "Seleccione el rango de fechas";
                txt_buscar.Enabled = false;
            }
            else if (cmb_seleccionarTipo.Text == "Número de Orden")
            { 
                txt_buscar.Enabled = true;
                txt_buscar.Text = "";
            }

        }

        private void txt_buscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                funcionBuscar();               
            }
        }

        private void listar_ordenes_servicioDataGridView_DoubleClick(object sender, EventArgs e)
        {
            Program.id_ordenServicio = Convert.ToInt32(listar_ordenes_servicioDataGridView.SelectedRows[0].Cells[0].Value);
            Program.id_cliente = Convert.ToInt32(listar_ordenes_servicioDataGridView.SelectedRows[0].Cells[1].Value);
            Program.id_vehiculo = Convert.ToInt32(listar_ordenes_servicioDataGridView.SelectedRows[0].Cells[2].Value);
            Form frm_BuscarOrden01 = new OrdenServicioBuscar.frm_OrdenServicioBuscar01();
            frm_BuscarOrden01.Show();
        }

        private void funcionBuscar()
        {
            switch (cmb_seleccionarTipo.Text)
            {
                case "Rango de Fechas":
                    this.listar_ordenes_servicioTableAdapter.BuscarOrdenPorFechas(this.glacial_servicioDataSet.listar_ordenes_servicio, fechaInicio, fechaFin);
                    break;
                case "Número de Orden":
                    this.listar_ordenes_servicioTableAdapter.BuscarOrdenesPorID(this.glacial_servicioDataSet.listar_ordenes_servicio, Convert.ToInt32(txt_buscar.Text));
                    break;
                case "Nombre/Razón Social":
                    this.listar_ordenes_servicioTableAdapter.BuscarOrdenPorNombre(this.glacial_servicioDataSet.listar_ordenes_servicio, "%" + (txt_buscar.Text) + "%");
                    break;
                case "Placas":
                    this.listar_ordenes_servicioTableAdapter.BuscarOrdenPorPlacas(this.glacial_servicioDataSet.listar_ordenes_servicio, (txt_buscar.Text));
                    break;
                case "No. de Serie":
                    this.listar_ordenes_servicioTableAdapter.BuscarOrdenPorSerie(this.glacial_servicioDataSet.listar_ordenes_servicio, (txt_buscar.Text));
                    break;
            }
        }
    }
}
