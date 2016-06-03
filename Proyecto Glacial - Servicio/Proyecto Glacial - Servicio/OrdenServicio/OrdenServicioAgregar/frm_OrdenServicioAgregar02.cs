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
    public partial class frm_OrdenServicioAgregar02 : Form
    {
        Clases.consultas consultas = new Clases.consultas();
        public frm_OrdenServicioAgregar02()
        {
            InitializeComponent();
        }

        private void frm_OrdenServicioAgregar02_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_siguiente_Click(object sender, EventArgs e)
        {
            if (agregarDetallesCarro())
            {
                this.Close();
                Form siguienteFormulario03 = new OrdenServicio.frm_OrdenServicioAgregar03();
                siguienteFormulario03.ShowDialog();
            }
        }

        private bool agregarDetallesCarro()
        {
            int tanqueGasolina = 0;
            if (!radio_Vacio.Checked && !radio_UnCuarto.Checked && !radio_UnMedio.Checked
                && !radio_TresCuartos.Checked && !radio_lleno.Checked)
            {
                MessageBox.Show("Selecciona el nivel del tanque de gasolina");
                return false;
            }            
            else if (radio_Vacio.Checked)
                tanqueGasolina = 0;
            else if (radio_UnCuarto.Checked)
                tanqueGasolina = 1;
            else if (radio_UnMedio.Checked)
                tanqueGasolina = 2;
            else if (radio_TresCuartos.Checked)
                tanqueGasolina = 3;
            else if (radio_lleno.Checked)
                tanqueGasolina = 4;
            

            this.automovil_inventarioTableAdapter.AgregarDetallesVehiculo(Program.id_vehiculo,
                Program.id_ordenServicio, check_unidadLuces.CheckState,check_CuartoLuces.CheckState, check_antena.CheckState
                , check_espejosLaterales.CheckState, check_cristales.CheckState, check_emblema.CheckState,
                check_llantas.CheckState, check_taponRuedas.CheckState, check_moldurasCompletas.CheckState,
                check_taponGasolina.CheckState, check_carroceriaGolpes.CheckState, check_bocinasClaxon.CheckState,
                check_limpiadores.CheckState, check_instrumentos.CheckState, check_calefaccion.CheckState, 
                check_radio_tipo.CheckState, check_bocinas.CheckState, check_encendedor.CheckState, 
                check_espejoRetrovisor.CheckState, check_ceniceros.CheckState, check_cinturones.CheckState,
                check_botonesInteriores.CheckState, check_manijasInteriores.CheckState, check_tapetes.CheckState,
                check_vestiduras.CheckState, check_gato.CheckState, check_maneralGato.CheckState,
                check_llaveRuedas.CheckState, check_estucheHerramientas.CheckState, check_trianguloSeguridad.CheckState,
                check_llantaRefaccion.CheckState, check_extinguidor.CheckState, check_claxon.CheckState,
                check_taponAceite.CheckState, check_taponRadiador.CheckState, check_varillaAceite.CheckState,
                check_filtroAire.CheckState, check_bateria.CheckState, tanqueGasolina, txt_observaciones.Text,txt_observacionesExteriores.Text,
                txt_observacionesInteriores.Text,txt_observacionesComponentesMecanicos.Text);
            return true;
        }

        private void frm_OrdenServicioAgregar02_Load_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Program.id_ordenServicio.ToString());
            var resultado = MessageBox.Show("Si cierra esta ventana se elimnará la Orden de Servicio actual, ¿Está seguro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                consultas.borrarUltimoRegistro("orden_servicio_infogeneral",Program.id_ordenServicio,"id_numero_orden");
                this.Close();
            }
        }
    }
}
