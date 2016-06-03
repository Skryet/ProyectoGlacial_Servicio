using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Glacial___Servicio
{
    public partial class frm_menuSistema : Form
    {
        public frm_menuSistema()
        {
            InitializeComponent();
        }

        private void btn_ordenesServicio_Click(object sender, EventArgs e)
        {
            Form formOrdenServicioMenu = new OrdenServicio.OrdenServicioMenu.frm_ordenServicioMenu();
            formOrdenServicioMenu.Show();
            this.WindowState = FormWindowState.Minimized;

        }

        private void frm_menuSistema_Load(object sender, EventArgs e)
        {
            this.Location = new Point(500, 100);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
