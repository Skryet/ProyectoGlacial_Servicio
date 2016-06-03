using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Glacial___Servicio.Clases
{
    class metodosOptimizar
    {
        //Método para validar campos
        public bool validarCampos(GroupBox GroupBox )
        {
            bool vacio = false;
            foreach (Control ctrl in GroupBox.Controls)
            {
                if (ctrl is TextBox && ctrl.Text == "")
                {
                    ctrl.BackColor = Color.Red;
                    vacio = true;
                }
            }
            return vacio;
        }

        //Deshabilitarcampos
        public bool deshabilitarCampos(GroupBox GroupBox)
        {
            bool vacio = false;
            foreach (Control ctrl in GroupBox.Controls)
            {
                if (ctrl is TextBox )
                    ctrl.Enabled = false;
            }
            return vacio;
        }

        //Habilitarcampos
        public bool habilitarCampo(GroupBox GroupBox)
        {
            bool vacio = false;
            foreach (Control ctrl in GroupBox.Controls)
            {
                if (ctrl is TextBox)
                    ctrl.Enabled = true;
            }
            return vacio;
        }

        //LimpiarCampos
        public bool limpiarCampos(GroupBox GroupBox)
        {
            bool vacio = false;
            foreach (Control ctrl in GroupBox.Controls)
            {
                if (ctrl is TextBox)
                    ctrl.Text = "";
            }
            return vacio;
        }

        //Validar si es char
        public void isChar(KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar) || Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        //Validar si es Decimal y Dígito
        public void isDecimalPoint(KeyPressEventArgs e)
        {

            if (Char.IsDigit(e.KeyChar) || e.KeyChar == '.' || Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
                e.Handled = true;
        }

        //Validar es dígito
        public void isDigit(KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }


    }
}
