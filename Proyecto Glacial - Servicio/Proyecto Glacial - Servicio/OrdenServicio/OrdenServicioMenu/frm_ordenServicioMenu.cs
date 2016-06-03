using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Glacial___Servicio.OrdenServicio.OrdenServicioMenu
{
    public partial class frm_ordenServicioMenu : Form
    {
        
        
        public frm_ordenServicioMenu()
        {
            InitializeComponent();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
             Form frm_OrdenServicioAgregar01 = new OrdenServicio.frm_OrdenServicioAgregar01();
             frm_OrdenServicioAgregar01.Show();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            Form frm_BuscarOrdenesServicio = new OrdenServicioBuscar.frm_OrdenServicioBuscar00();
            frm_BuscarOrdenesServicio.ShowDialog();
        }

        private void frm_ordenServicioMenu_Load(object sender, EventArgs e)
        {
            this.Location = new Point(300, 30);
        }

        private void frm_ordenServicioMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm_menuSistema.ActiveForm.WindowState = FormWindowState.Maximized;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
