using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Threading;

namespace Proyecto_Glacial___Servicio.OrdenServicio
{
    public partial class frm_OrdenServicioAgregar01 : Form
    {
        List<string> DatosDelCliente = new List<string>();
        List<string> DatosDelVehiculo = new List<string>();
        DateTime fechaIngreso;

        Clases.metodosOptimizar optimizar = new Clases.metodosOptimizar();
        Clases.consultas consultas = new Clases.consultas();
        public frm_OrdenServicioAgregar01()
        {
            InitializeComponent();
        }

        private void frm_OrdenServicioAgregar_Load(object sender, EventArgs e)
        {
            //Mostrar la Orden de Servicio Actual
            Program.id_ordenServicio = consultas.obtenerUltimaOrdenServicio() + 1;
            lbl_ordenServicio.Text = "N°" + Program.id_ordenServicio.ToString("#0000");

            //Formato de Hora
            date_hora_entrega.Format = DateTimePickerFormat.Custom;
            date_hora_entrega.CustomFormat = "HH:mm tt";

            AutoCompleteStringCollection combData = new AutoCompleteStringCollection();
            #region Cargar los nombres en el Combo Cliente
            cmb_nombre.AutoCompleteMode = AutoCompleteMode.Suggest;
            cmb_nombre.AutoCompleteSource = AutoCompleteSource.CustomSource;
            combData = new AutoCompleteStringCollection();
            consultas.buscarTodosClientes(combData); //Llamo a la funcion para obtener los Datos
            cmb_nombre.AutoCompleteCustomSource = combData;
            #endregion

            #region Cargar los nombres en el Combo vehiculo
            cmb_numeroDeSerie.AutoCompleteMode = AutoCompleteMode.Suggest;
            cmb_numeroDeSerie.AutoCompleteSource = AutoCompleteSource.CustomSource;
            combData = new AutoCompleteStringCollection();
            consultas.buscarTodosVehiculos(combData); //Llamo a la funcion para obtener los Datos
            cmb_numeroDeSerie.AutoCompleteCustomSource = combData;
            #endregion

            this.Location = new Point(200, 20);

            #region asignar Fecha y hora actual
            var fecha = DateTime.Now;
            fechaIngreso = fecha;
            string resultado = string.Format("{0:f}", fecha); ;
            txt_fechaIngreso.Text = resultado;
            #endregion
        }

        private void btn_siguiente_Click(object sender, EventArgs e)
        {
                #region guardar en tabla ORDEN_SERVICIO_INFOGENERAL
                string fechaTemp = date_fechaEntrega.Value.ToShortDateString();
                DateTime fechaEntrega = Convert.ToDateTime(fechaTemp);
                this.orden_servicio_infogeneralTableAdapter.AgregarOrdenServicio(
                Program.id_cliente, Program.id_vehiculo, fechaIngreso,
                fechaEntrega, date_hora_entrega.Value.ToShortTimeString(), 0, "pruebaResponsable", 0);
                #endregion
                this.Close();
                Form siguienteFormulario02 = new OrdenServicio.frm_OrdenServicioAgregar02();
                siguienteFormulario02.ShowDialog();
                this.WindowState = FormWindowState.Minimized;
        }

        private void despintarTexto(object sender, EventArgs e)
        {
            TextBox limpiar = (TextBox)sender;
            limpiar.BackColor = Color.White;
        }

        private void cmb_nombre_Leave(object sender, EventArgs e)
        {
            llenarCamposCliente();
        }

        private void grupo_datosCliente_Leave(object sender, EventArgs e)
        {
            #region validarDatosCliente
            //Validar datos de cliente
            if(DatosDelCliente.Count == 0)
            { 
                if (!optimizar.validarCampos(grupo_datosCliente))
                {
                    this.clientesTableAdapter.AgregarCliente(cmb_nombre.Text, txt_direccion.Text, txt_colonia.Text, txt_ciudad.Text,
                        txt_cp.Text, txt_telefono.Text, txt_rfc.Text, txt_contacto.Text, txt_correo.Text, txt_telefonoMovil.Text,
                        txt_telefonoOficina.Text);
                    optimizar.deshabilitarCampos(grupo_datosCliente);
                    Program.id_cliente = consultas.obtenerUltimoID("id_cliente", "clientes");
                }
                else
                    MessageBox.Show("Faltan Campos por llenar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    #endregion
                }
        }

        private void grupo_datosVehiculo_Leave(object sender, EventArgs e)
        {
            #region validarDatosVehiculos
            if(DatosDelVehiculo.Count == 0)
            { 
                //Validar datos de vehículo
                if (!optimizar.validarCampos(grupo_datosVehiculo))
                {
                    this.automoviles_servicioTableAdapter.AgregarVehiculo(txt_modelo.Text, txt_tipo.Text,
                        txt_marca.Text, txt_color.Text, txt_placas.Text, cmb_numeroDeSerie.Text,
                        Convert.ToInt32(txt_kms.Text));
                    optimizar.deshabilitarCampos(grupo_datosVehiculo);
                    Program.id_vehiculo = consultas.obtenerUltimoID("id_automovil_servicio", "automoviles_servicio");
                }
                else
                    MessageBox.Show("Faltan Campos por llenar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    #endregion
            }
        }


        private void llenarCamposCliente()
        {
            DatosDelCliente.Clear();
            DatosDelCliente = consultas.obtenerDatosCliente(cmb_nombre.Text);
            if (DatosDelCliente.Count == 0)
            {
                optimizar.habilitarCampo(grupo_datosCliente); //Habilitar campos
                optimizar.limpiarCampos(grupo_datosCliente);//LimpiarCampos
            }
            else
            {
                //Si se encuentra se bloquearan los demas campos
                #region relacionar campos con datos Cliente
                Program.id_cliente = Convert.ToInt32(DatosDelCliente[0]);
                txt_direccion.Text = DatosDelCliente[1];
                txt_colonia.Text = DatosDelCliente[2];
                txt_ciudad.Text = DatosDelCliente[3];
                txt_cp.Text = DatosDelCliente[4];
                txt_telefono.Text = DatosDelCliente[5];
                txt_rfc.Text = DatosDelCliente[6];
                txt_contacto.Text = DatosDelCliente[7];
                txt_correo.Text = DatosDelCliente[8];
                txt_telefonoMovil.Text = DatosDelCliente[9];
                txt_telefonoOficina.Text = DatosDelCliente[10];
                optimizar.deshabilitarCampos(grupo_datosCliente); //DeshabilitarCampos
                #endregion
            }
        }

        private void llenarCamposVehiculo()
        {
            DatosDelVehiculo.Clear();
            DatosDelVehiculo = consultas.obtenerDatosVehiculo(cmb_numeroDeSerie.Text);
            if (DatosDelVehiculo.Count == 0)
            {
                optimizar.habilitarCampo(grupo_datosVehiculo); //Habilitar campos
                optimizar.limpiarCampos(grupo_datosVehiculo);//LimpiarCampos
            }
            else
            {
                //Si se encuentra se bloquearan los demas campos
                #region relacionar campos con datos Vehiculos
                Program.id_vehiculo = Convert.ToInt32(DatosDelVehiculo[0]);
                txt_modelo.Text = DatosDelVehiculo[1];
                txt_tipo.Text = DatosDelVehiculo[2];
                txt_marca.Text = DatosDelVehiculo[3];
                txt_color.Text = DatosDelVehiculo[4];
                txt_placas.Text = DatosDelVehiculo[5];
                txt_kms.Text = DatosDelVehiculo[6];           
                optimizar.deshabilitarCampos(grupo_datosVehiculo); //DeshabilitarCampos
                #endregion
            }
        }

        private void cmb_numeroDeSerie_Leave(object sender, EventArgs e)
        {
            llenarCamposVehiculo();
        }

        private void txt_kms_KeyPress(object sender, KeyPressEventArgs e)
        {
            optimizar.isDigit(e);
        }


        private void btn_salir_Click(object sender, EventArgs e)
        {

            this.Close();
            frm_menuSistema.ActiveForm.WindowState = FormWindowState.Normal;
        }
    }
}
