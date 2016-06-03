using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Glacial___Servicio.Clases
{
    class consultas
    {
        #region Abrir y cerrar conexión
        private static MySqlConnection conexion = new MySqlConnection("server=glacialcolima.ddns.net;user id=SGAglacial;password=Glacial_MASTER16;persistsecurityinfo=True;database=glacial_servicio");

            bool estadoConexion = false;

            /// <summary>
            /// Abrir conexion con el servidor
            /// </summary>
            /// 
            public void abrirConexion()
            {
                try
                {
                    if (estadoConexion == false)
                    {
                        conexion.Open();
                        estadoConexion = true;
                    }
                }
                catch (MySqlException e)
                {
                    MessageBox.Show("Error: " + e.ToString(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            /// <summary>
            /// Cerrar conexion con el servidor
            /// </summary>
            public void cerrarConexion()
            {
                try
                {
                    if (estadoConexion == true)
                    {
                        conexion.Close();
                        estadoConexion = false;
                    }
                }
                catch (MySqlException e)
                {
                    MessageBox.Show("Error: " + e.ToString(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            /// <summary>
            /// Obtener  cadena de conexion
            /// </summary>
            public static MySqlConnection obtenerConexion { get { return conexion; } }
        #endregion

        public void buscarTodosClientes(AutoCompleteStringCollection dataCollection) //Buscar todos los clientes
        {
            //Obtener todos los nombres que existen actualmente
            string connetionString = null;
            MySqlConnection connection;
            MySqlCommand command;
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataSet ds = new DataSet();
            connetionString = "server = glacialcolima.ddns.net; user id = SGAglacial; password = Glacial_MASTER16; database = glacial_servicio; persistsecurityinfo = False";
            string sql = "SELECT DISTINCT nombre FROM clientes";
            connection = new MySqlConnection(connetionString);
            try
            {
                connection.Open();
                command = new MySqlCommand(sql, connection);
                adapter.SelectCommand = command;
                adapter.Fill(ds);
                adapter.Dispose();
                command.Dispose();
                connection.Close();
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    dataCollection.Add(row[0].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! ");
            }
        }

        public void buscarTodosVehiculos(AutoCompleteStringCollection dataCollection) //Buscar todos los clientes
        {
            //Obtener todos los nombres que existen actualmente
            string connetionString = null;
            MySqlConnection connection;
            MySqlCommand command;
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataSet ds = new DataSet();
            connetionString = "server = glacialcolima.ddns.net; user id = SGAglacial; password = Glacial_MASTER16; database = glacial_servicio; persistsecurityinfo = False";
            string sql = "SELECT DISTINCT num_serie FROM automoviles_servicio";
            connection = new MySqlConnection(connetionString);
            try
            {
                connection.Open();
                command = new MySqlCommand(sql, connection);
                adapter.SelectCommand = command;
                adapter.Fill(ds);
                adapter.Dispose();
                command.Dispose();
                connection.Close();
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    dataCollection.Add(row[0].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! ");
            }
        }
        public List<string> obtenerDatosCliente(string nombreCliente)
        {
            
            List<string> datosCliente = new List<string>();
            datosCliente.Clear();
            abrirConexion();
            MySqlCommand consulta = conexion.CreateCommand();

            consulta.CommandText = ("SELECT * FROM clientes WHERE nombre = @nombre");
            consulta.Parameters.AddWithValue("@nombre", nombreCliente);
            
            try
            {
                MySqlDataReader lector = consulta.ExecuteReader();
                while (lector.Read())
                {
                    datosCliente.Add(lector.GetString(0));
                    datosCliente.Add(lector.GetString(1));
                    datosCliente.Add(lector.GetString(2));
                    datosCliente.Add(lector.GetString(3));
                    datosCliente.Add(lector.GetString(4));
                    datosCliente.Add(lector.GetString(5));
                    datosCliente.Add(lector.GetString(6));
                    datosCliente.Add(lector.GetString(7));
                    datosCliente.Add(lector.GetString(8));
                    datosCliente.Add(lector.GetString(9));
                    datosCliente.Add(lector.GetString(10));
                    datosCliente.Add(lector.GetString(11));      
                }

            }
            catch (MySqlException e)
            {
                MessageBox.Show("Error: " + e.ToString(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            cerrarConexion();
            return datosCliente;
        }

        public List<string> obtenerDatosVehiculo(string numeroSerie)
        {

            List<string> datosVehiculo = new List<string>();
            datosVehiculo.Clear();
            abrirConexion();
            MySqlCommand consulta = conexion.CreateCommand();

            consulta.CommandText = ("SELECT * FROM automoviles_servicio WHERE num_serie = @numSerie");
            consulta.Parameters.AddWithValue("@numSerie", numeroSerie);

            try
            {
                MySqlDataReader lector = consulta.ExecuteReader();
                while (lector.Read())
                {
                    datosVehiculo.Add(lector.GetString(0));
                    datosVehiculo.Add(lector.GetString(3));
                    datosVehiculo.Add(lector.GetString(4));
                    datosVehiculo.Add(lector.GetString(5));
                    datosVehiculo.Add(lector.GetString(6));
                    datosVehiculo.Add(lector.GetString(7));
                    datosVehiculo.Add(lector.GetString(8));
                    datosVehiculo.Add(lector.GetString(9));
                }

            }
            catch (MySqlException e)
            {
                MessageBox.Show("Error: " + e.ToString(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            cerrarConexion();
            return datosVehiculo;
        }

        public int obtenerUltimoID(string campo, string tabla)
        {
            int ultimoID = 0;
            abrirConexion();
            MySqlCommand consulta = conexion.CreateCommand();
            consulta.CommandText = ("SELECT MAX(" + campo + ") from "+ tabla);



            try
            {
                MySqlDataReader lector = consulta.ExecuteReader();
                while (lector.Read())
                {
                    if (lector.GetValue(0).ToString() == "")
                    {
                        cerrarConexion();
                        return 1;
                    }
                    else
                    {
                        ultimoID = lector.GetInt32(0);
                        cerrarConexion();
                        return ultimoID;
                    }
                }

            }
            catch (MySqlException e)
            {
                MessageBox.Show("Error: " + e.ToString(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            cerrarConexion();


            return 0;
        }
        public int obtenerUltimaOrdenServicio()
        {
            int ultimaOrdenServicio = 0;
            abrirConexion();
            MySqlCommand consulta = conexion.CreateCommand();
            consulta.CommandText = ("SELECT MAX(id_numero_orden) FROM orden_servicio_infogeneral");

            try
            {
                MySqlDataReader lector = consulta.ExecuteReader();
                while (lector.Read())
                {
                    if (lector.GetValue(0).ToString() == "")
                    {
                        cerrarConexion();
                        return 1;
                    }
                    else
                    {
                        ultimaOrdenServicio =  lector.GetInt32(0);
                        cerrarConexion();
                        return ultimaOrdenServicio;
                    }
                }

            }
            catch (MySqlException e)
            {
                MessageBox.Show("Error: " + e.ToString(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            cerrarConexion();


            return 0;
        }

        public int obtenerTanqueGasolna(int ordenServicio)
        {
            int tanqueGasolina = 0;
            abrirConexion();
            MySqlCommand consulta = conexion.CreateCommand();
            consulta.CommandText = ("SELECT tanque_gasolina FROM automovil_inventario WHERE id_orden_servicio =" + ordenServicio);

            try
            {
                MySqlDataReader lector = consulta.ExecuteReader();
                while (lector.Read())
                {
                    if (lector.GetValue(0).ToString() == "")
                    {
                        cerrarConexion();
                        return 1;
                    }
                    else
                    {
                        tanqueGasolina = lector.GetInt32(0);
                        cerrarConexion();
                        return tanqueGasolina;
                    }
                }

            }
            catch (MySqlException e)
            {
                MessageBox.Show("Error: " + e.ToString(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            cerrarConexion();


            return 0;
        }

        public void borrarUltimoRegistro(string tabla, int ID, string campoID)
        {
            abrirConexion();
            MySqlCommand consulta = conexion.CreateCommand();
            consulta.CommandText = ("DELETE FROM " + tabla + " WHERE " + campoID + " =" + ID);
            try
            {
                consulta.ExecuteNonQuery();
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Error: " + e.ToString(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //Re acomodar índices
            consulta.CommandText = ("ALTER TABLE " + tabla + " AUTO_INCREMENT =" + ID);
            try
            {
                consulta.ExecuteNonQuery();
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Error: " + e.ToString(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            cerrarConexion();
        }

    }
 }


