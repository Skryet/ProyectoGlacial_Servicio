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
    public partial class frm_OrdenServicioBuscar02 : Form
    {

        Clases.consultas consultas = new Clases.consultas();
        public frm_OrdenServicioBuscar02()
        {
            InitializeComponent();
        }


        private void frm_OrdenServicioBuscar02_Load(object sender, EventArgs e)
        {
            this.Location = new Point(200, 5);
            this.automovil_inventarioTableAdapter.BuscarInventarioPorID(this.glacial_servicioDataSet.automovil_inventario, Program.id_ordenServicio);
            int tanqueGasolina = consultas.obtenerTanqueGasolna(Program.id_ordenServicio);
            #region llenar tanque gasolina
            if (tanqueGasolina == 0)
                radio_Vacio.Checked = true;
            else if (tanqueGasolina == 1)
                radio_UnCuarto.Checked = true;
            else if (tanqueGasolina == 2)
                radio_UnMedio.Checked = true;
            else if (tanqueGasolina == 3)
                radio_TresCuartos.Checked = true;
            else if (tanqueGasolina == 4)
                radio_lleno.Checked = true;
            #endregion



        }

        private void btn_siguiente_Click(object sender, EventArgs e)
        {
            this.Close();
            OrdenServicioBuscar.frm_OrdenServicioBuscar03 frm_OrdenServicoBuscar03 = new OrdenServicioBuscar.frm_OrdenServicioBuscar03();
            frm_OrdenServicoBuscar03.Show();
        }
    }
}
