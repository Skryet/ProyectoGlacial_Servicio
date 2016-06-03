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
    public partial class frm_OrdenServicioBuscarArticulo : Form
    {
        public frm_OrdenServicioBuscarArticulo()
        {
            InitializeComponent();
        }

        private void productosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.glacial_almacenDataSet);

        }

        private void frm_OrdenServicioBuscarArticulo_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'glacial_almacenDataSet.productos' Puede moverla o quitarla según sea necesario.
            this.productosTableAdapter.Fill(this.glacial_almacenDataSet.productos);

        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            realizarBusqueda();
        }

        private void txt_buscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                realizarBusqueda();
            }
        }

        private void realizarBusqueda()
        {
            switch (cmb_busqueda.Text)
            {
                case "Código": //Búsqueda por Código
                    this.productosTableAdapter.FillByBuscarProductosPorCodigo(this.glacial_almacenDataSet.productos, "%" + txt_buscar.Text + "%");
                    break;
                case "Descripción": //Búsqueda por descripción
                    this.productosTableAdapter.FillByBuscarProductosPorDescripcion(this.glacial_almacenDataSet.productos, "%" + txt_buscar.Text + "%");
                    break;
            }
        }

        private void cmb_busqueda_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.productosTableAdapter.Fill(this.glacial_almacenDataSet.productos);
        }

        private void productosDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //Bandera de agregar True
            Program.puedeAgregar = true;
            //Obtener los valores del material para pasarlos a la orden de servicio
            Program.codigo = Convert.ToString(productosDataGridView.CurrentRow.Cells[0].Value);
            Program.unidadMedida = Convert.ToString(productosDataGridView.CurrentRow.Cells[2].Value);
            Program.descripcion = Convert.ToString(productosDataGridView.CurrentRow.Cells[3].Value);
            Program.precioUnitario = Convert.ToDouble(productosDataGridView.CurrentRow.Cells[4].Value);
            this.Close();
        }
       
    }
}
