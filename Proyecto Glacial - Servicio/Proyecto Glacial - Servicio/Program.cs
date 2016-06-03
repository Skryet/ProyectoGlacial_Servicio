using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Glacial___Servicio
{
    
    static class Program
    {
        //Varables para OrdenServicio01
        public static int id_ordenServicio;
        public static int id_cliente;
        public static int id_vehiculo;
        public static int id_lista_orden_material;
        public static int id_presupuesto;

        //Variables para OrdenServicio04
        //MaterialNecesario
        public static string codigo;
        public static string unidadMedida;
        public static string descripcion;
        public static double precioUnitario;
        public static bool puedeAgregar = false;
        

        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frm_menuSistema());
        }
    }
}
