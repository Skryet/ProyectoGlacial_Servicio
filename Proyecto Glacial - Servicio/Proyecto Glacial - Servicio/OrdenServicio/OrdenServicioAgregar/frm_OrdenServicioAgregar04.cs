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
    
    public partial class frm_OrdenServicioAgregar04 : Form
    {

        NumeroLetra NumeroLetra = new NumeroLetra();
        Clases.consultas Consultas = new Clases.consultas();
        //Formulario de Búsqueda
        Form frm_BuscarMaterial = new OrdenServicio.frm_OrdenServicioBuscarArticulo();

        public frm_OrdenServicioAgregar04()
        {
            InitializeComponent();
        }

        private void frm_OrdenServicioAgregar03_Load(object sender, EventArgs e)
        {            
            this.Activate();
            

        }

        private void btn_siguiente_Click(object sender, EventArgs e)
        {
            this.orden_servicio_infogeneralTableAdapter.ActualizarOrdenServicioTotalPreguntasETC(
                Convert.ToDouble(txt_total.Text), check_consumidor_autoriza.CheckState, check_suministra_partes.CheckState
                , txt_descripcionServicio.Text, txt_diagnostico_servicio.Text, Program.id_lista_orden_material,Program.id_ordenServicio);
                MessageBox.Show("Orden De Servicio registrada con éxito");
            this.Close();
            Form frm_presupuestoFinal = new Presupuesto.frm_Presupuesto_Agregar();
            frm_presupuestoFinal.ShowDialog();
            //OrdenServicioMenu.frm_ordenServicioMenu.ActiveForm.WindowState = FormWindowState.Normal;
        }

        private void table_piezasNecesitadas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_borrarRegistro.Enabled = true;
            btn_guardar.Enabled = true;
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                frm_BuscarMaterial.ShowDialog();
            }
        }

        private void frm_OrdenServicioAgregar04_Activated(object sender, EventArgs e)
        {
            if (Program.puedeAgregar)
            {
                int rowEscribir = table_piezasNecesitadas.Rows.Count - 1;
                table_piezasNecesitadas.Rows.Add(1);

                for (int i = 0; i < 5; i++)
                {
                    table_piezasNecesitadas.Rows[rowEscribir].Cells[0].Value = Program.codigo;
                    table_piezasNecesitadas.Rows[rowEscribir].Cells[3].Value = Program.unidadMedida;
                    table_piezasNecesitadas.Rows[rowEscribir].Cells[4].Value = Program.descripcion;
                    table_piezasNecesitadas.Rows[rowEscribir].Cells[5].Value = Program.precioUnitario;
                    table_piezasNecesitadas.Rows[rowEscribir].Cells[6].Value = Program.precioUnitario;
                    Program.puedeAgregar = false;
                }
                //Codigo que agregue a la tabla
            }

        }

        private void btn_borrarRegistro_Click(object sender, EventArgs e)
        {
            if (table_piezasNecesitadas.CurrentRow.Cells.Count > 0)
            {
                bool rowIsEmpty = true;

                foreach (DataGridViewCell cell in table_piezasNecesitadas.CurrentRow.Cells)
                {
                    if (cell.Value != null)
                    {
                        rowIsEmpty = false;
                        break;
                    }
                }

                if (!rowIsEmpty)
                    table_piezasNecesitadas.Rows.RemoveAt(table_piezasNecesitadas.CurrentRow.Index);
            }

        }

        private void txt_subtotal_Leave(object sender, EventArgs e)
        {
            if (txt_subtotal.Text != "")
            { 
                txt_IVA.Text = (Convert.ToDouble(txt_subtotal.Text) * .16).ToString("#.#0");
                txt_total.Text = (Convert.ToDouble(txt_subtotal.Text) + Convert.ToDouble(txt_IVA.Text)).ToString("#.#0");
                txt_subtotal.Text = Convert.ToDouble(txt_subtotal.Text).ToString("#.#0");
                txt_cantidadLetra.Text = NumeroLetra.enletras(txt_total.Text);
            }

        }

        private void txt_descuento_Leave(object sender, EventArgs e)
        {
            if (txt_descuento.Text != "")
            { 
                txt_descuentoNumero.Text = (Convert.ToDouble(txt_subtotal.Text) * Convert.ToDouble(txt_descuento.Text) / 100).ToString("-#.#0");
                txt_total.Text = ((Convert.ToDouble(txt_subtotal.Text) + Convert.ToDouble(txt_IVA.Text)) + Convert.ToDouble(txt_descuentoNumero.Text)).ToString("#.#0");
                txt_cantidadLetra.Text = NumeroLetra.enletras(txt_total.Text);
            }
            else
            { 
                txt_total.Text = (Convert.ToDouble(txt_subtotal.Text) + Convert.ToDouble(txt_IVA.Text)).ToString("#.#0");
                txt_descuentoNumero.Text = "";
                txt_cantidadLetra.Text = NumeroLetra.enletras(txt_total.Text);
            }

        }

        private void txt_subtotal_TextChanged(object sender, EventArgs e)
        {
            if (txt_subtotal.Text != "")
                txt_descuento.Enabled = true;
            else
                txt_descuento.Enabled = false;
        }

        private void frm_OrdenServicioAgregar04_FormClosed(object sender, FormClosedEventArgs e)
        {
            OrdenServicioMenu.frm_ordenServicioMenu frm_OrdenServicioMenu = new OrdenServicioMenu.frm_ordenServicioMenu();
            frm_OrdenServicioMenu.Show();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show("Los datos ya no serán modificables, ¿Está de acuerdo?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                btn_siguiente.Enabled = true;
                //Crear la Lista general y guardarla
                this.lista_orden_materialTableAdapter.InsertarListaDeMateriales(Program.id_ordenServicio, 0);


                //Obtener ultimo ID agregado
                Program.id_lista_orden_material = Consultas.obtenerUltimoID("id_lista_orden_material", "lista_orden_material");

                //Variables de la lista de materiales
                string codigoTemp = "";
                int cantidadTemp = 0;
                string unidadTemp = "";
                string descripcionTemp = "";
                double precioUnitarioTemp = 0;
                double precioTotalTemp = 0;
                double precioTotalFinalTemp = 0;

                //Crear la lista detallada y guardarla
                for (int i = 0; i < table_piezasNecesitadas.Rows.Count - 1; i++)
                {
                    codigoTemp = table_piezasNecesitadas.Rows[i].Cells["codigo"].Value.ToString();
                    cantidadTemp = Convert.ToInt32(table_piezasNecesitadas.Rows[i].Cells["cantidad"].Value);
                    unidadTemp = table_piezasNecesitadas.Rows[i].Cells["unidad"].Value.ToString();
                    descripcionTemp = table_piezasNecesitadas.Rows[i].Cells["descripcion"].Value.ToString();
                    precioUnitarioTemp = Convert.ToDouble(table_piezasNecesitadas.Rows[i].Cells["precioUnitario"].Value);
                    precioTotalTemp = Convert.ToDouble(table_piezasNecesitadas.Rows[i].Cells["precioTotal"].Value);
                    precioTotalFinalTemp += precioTotalTemp;

                    //Agrega a la tabla de orden_material
                    orden_materialTableAdapter.Insertar_orden_material(Program.id_lista_orden_material, codigoTemp,
                        cantidadTemp, unidadTemp, descripcionTemp, precioUnitarioTemp, precioTotalTemp);
                }

                //Acualizar a la tabla de lista_orden_material
                this.lista_orden_materialTableAdapter.ActualizarTotalListaMateriales(precioTotalFinalTemp, Program.id_lista_orden_material);

                //Deshabilitar
                this.table_piezasNecesitadas.Enabled = false;
                grupo_materiales.BackColor = Color.DimGray;
                grupo_precio.Enabled = true;
                
            }




        }


        private void table_piezasNecesitadas_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            table_piezasNecesitadas.CurrentRow.Cells["precioTotal"].Value = Convert.ToDouble(table_piezasNecesitadas.CurrentRow.Cells["cantidad"].Value) * Convert.ToDouble(table_piezasNecesitadas.CurrentRow.Cells["precioUnitario"].Value);
        }

        private void table_piezasNecesitadas_KeyPress(object sender, KeyPressEventArgs e)
        {
            btn_guardar.Enabled = true;
            btn_borrarRegistro.Enabled = true;
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show("Si cierra esta ventana se elimnará la Orden de Servicio actual, ¿Está seguro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                Consultas.borrarUltimoRegistro("orden_servicio_infogeneral", Program.id_ordenServicio, "id_numero_orden");
                Consultas.borrarUltimoRegistro("automovil_inventario", Consultas.obtenerUltimoID("id_automovil_inventario", "automovil_inventario"), "id_automovil_inventario");
                Consultas.borrarUltimoRegistro("danos_vehiculo", Consultas.obtenerUltimoID("id_danos_vehiculo", "danos_vehiculo"), "id_danos_vehiculo");
                this.Close();
            }
        }
    }
}
