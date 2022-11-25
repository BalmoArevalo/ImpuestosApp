using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clave5_Grupo10
{
    public partial class datosContribuyente : Form
    {
        public datosContribuyente()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Regresa al dashboard
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Form1 dashboard = new Form1();
            this.Hide();
            dashboard.Show();
        }
        /// <summary>
        /// Cierra la aplicacion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// Prueba la conexion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConexion_Click(object sender, EventArgs e)
        {
            try
            {
                Conexion.abrirConexion();
                MessageBox.Show("Conexión exitosa");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            finally
            {
                Conexion.cerrarConexion();
            }
        }
        /// <summary>
        /// Lee la base de datos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLeer_Click(object sender, EventArgs e)
        {
            MySqlCommand consulta = new MySqlCommand();
            consulta.Connection = Conexion.abrirConexion();
            consulta.CommandText = ("select tblcontribuyente.idContribuyente, tblcontribuyente.dui, tblcontribuyente.nombres, tblcontribuyente.apellidos, tblcontribuyente.fechaNacimiento, tblpais.nombre from tblcontribuyente inner join tblpais on tblcontribuyente.idPais = tblpais.idPais;");
            try
            {
                MySqlDataAdapter adaptadorMySQL = new MySqlDataAdapter();
                adaptadorMySQL.SelectCommand = consulta;
                DataTable tabla = new DataTable();
                adaptadorMySQL.Fill(tabla);
                dgvContribuyentes.DataSource = tabla;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            finally
            {
                Conexion.cerrarConexion();
            }
        }
        /// <summary>
        /// Agrega un contribuyente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string dui;
            string nombres;
            string apellidos;
            DateTime fechaNacimiento = new DateTime();
            string formatoFecha = "yyy-MM-dd";
            int idPais;
            try
            {
                dui = txtDUI.Text;
                while(dui.Length<10 || dui.Length > 10)
                {
                    MessageBox.Show("Su dui debe de ser de 10 digitos\nEjemplo: 01234567-8");
                    return;
                }
                nombres = txtNombres.Text;
                apellidos = txtApellidos.Text;
                fechaNacimiento = dtpFechaNacimiento.Value;
                idPais = cmbPais.SelectedIndex;
                bool b1 = validarCampoVacio(dui.ToString());
                bool b2 = validarCampoVacio(nombres.ToString());
                bool b3 = validarCampoVacio(apellidos.ToString());
                bool b4 = validarCampoVacio(fechaNacimiento.ToString());
                bool b5 = validarCampoVacio(idPais.ToString());
                if(b1 || b2 || b3 || b4 || b5)
                {
                    MessageBox.Show("Rellene todos los campos");
                }
                else
                {
                    //instanciar la clase
                    Contribuyente primerContribuyente = new Contribuyente(dui, nombres, apellidos, fechaNacimiento.ToString(formatoFecha),idPais);
                    primerContribuyente.registrarContribuyente(primerContribuyente);
                    limpiar();
                    leerBase();  
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex}");
            }
        }

        /// <summary>
        /// Se llena el cmbPais con los datos de la base de datos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void datosContribuyente_Load(object sender, EventArgs e)
        {
            seleccionarPaises(cmbPais);

        }
        /// <summary>
        /// Recorre los datos de la tabla de la base de datos y los guarda en un array de columnas
        /// </summary>
        /// <param name="cb">Recibe un combobox, en este caso cmbPais</param>
        public void seleccionarPaises(ComboBox cb)
        {
            cb.Items.Clear();
            MySqlCommand consulta = new MySqlCommand();
            consulta.Connection = Conexion.abrirConexion();
            consulta.CommandText = "select * from tblpais";
            try
            {
                MySqlDataAdapter adaptadorMySQL = new MySqlDataAdapter();
                adaptadorMySQL.SelectCommand = consulta;
                MySqlDataReader dr = consulta.ExecuteReader();
                while (dr.Read())
                {
                    cb.Items.Add(dr[1].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex}");
            }
        }
        /// <summary>
        /// Valida si el cambo seleccionado esta vacio o no
        /// </summary>
        /// <param name="txt">Recibe un parametro texto para comprobar su contenido</param>
        /// <returns>Retorna verdadero si esta vacio y retorna verdadero </returns>
        public bool validarCampoVacio(string txt)
        {
            return (string.IsNullOrEmpty(txt) || string.IsNullOrWhiteSpace(txt)) ? true : false;
        }
        /// <summary>
        /// Limpia el formulario
        /// </summary>
        public void limpiar()
        {
            txtDUI.Clear();
            txtNombres.Clear();
            txtApellidos.Clear();
            dtpFechaNacimiento.Value = DateTime.Today;
            cmbPais.Text = "";
        }
        /// <summary>
        /// Lee la base de datos con una consulta
        /// </summary>
        public void leerBase()
        {
            MySqlCommand consulta = new MySqlCommand();
            consulta.Connection = Conexion.abrirConexion();
            consulta.CommandText = ("select tblcontribuyente.idContribuyente, tblcontribuyente.dui, tblcontribuyente.nombres, tblcontribuyente.apellidos, tblcontribuyente.fechaNacimiento, tblpais.nombre from tblcontribuyente inner join tblpais on tblcontribuyente.idPais = tblpais.idPais;");
            try
            {
                //Inicializa una nueva instancia de la clase MySqlDataAdapter con
                // el MySqlCommand especificado como propiedad SelectCommand.
                MySqlDataAdapter adaptadorMySQL = new MySqlDataAdapter();
                adaptadorMySQL.SelectCommand = consulta;
                DataTable tabla = new DataTable();
                adaptadorMySQL.Fill(tabla);
                dgvContribuyentes.DataSource = tabla;
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            finally
            {
                Conexion.cerrarConexion();
            }
        }

        /// <summary>
        /// Toma los datos de los campos y actualiza en el id
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (txtIDcontribuyente.Text == null || txtIDcontribuyente.Text.Equals(""))
            {
                MessageBox.Show("Presione el botón leer, luego debe seleccionar un id");
                leerBase();
            }
            else
            {
                int idContribuyente;
                string dui;
                string nombres;
                string apellidos;
                DateTime fechaNacimiento = new DateTime();
                string formatoFecha = "yyy-MM-dd";
                int idPais;
                try
                {
                    idContribuyente = Convert.ToInt32(txtIDcontribuyente.Text);
                    dui = txtDUI.Text;
                    while (dui.Length < 10 || dui.Length > 10)
                    {
                        MessageBox.Show("Para modificar el dui este tiene que contar siempre con 10 digitos\nEjemplo: 01234567-8");
                        return;
                    }
                    nombres = txtNombres.Text;
                    apellidos = txtApellidos.Text;
                    fechaNacimiento = dtpFechaNacimiento.Value;
                    idPais = cmbPais.SelectedIndex+1;
                    bool b1 = validarCampoVacio(dui.ToString());
                    bool b2 = validarCampoVacio(nombres.ToString());
                    bool b3 = validarCampoVacio(apellidos.ToString());
                    bool b4 = validarCampoVacio(fechaNacimiento.ToString());
                    bool b5 = validarCampoVacio(idPais.ToString());
                    if (b1 || b2 || b3 || b4 || b5)
                    {
                        MessageBox.Show("Rellene todos los campos");
                    }
                    else
                    {
                        //instanciar la clase
                        Contribuyente modContribuyente = new Contribuyente(dui, nombres, apellidos, fechaNacimiento.ToString(formatoFecha), idPais);
                        modContribuyente.IDCONTRIBUYENTE = idContribuyente;
                        modContribuyente.modificarContribuyente(modContribuyente);
                        leerBase();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }

        /// <summary>
        /// Obtiene los datos de la fila seleccionada al dar doble click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvContribuyentes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //Obtener los valores de la dgv
                int idContribuyente = Convert.ToInt32(this.dgvContribuyentes.SelectedRows[0].Cells[0].Value);
                string dui = (this.dgvContribuyentes.SelectedRows[0].Cells[1].Value).ToString();
                string nombres = (this.dgvContribuyentes.SelectedRows[0].Cells[2].Value).ToString();
                string apellidos = (this.dgvContribuyentes.SelectedRows[0].Cells[3].Value).ToString();
                DateTime fechaNacimiento = new DateTime();
                fechaNacimiento = (DateTime)(this.dgvContribuyentes.SelectedRows[0].Cells[4].Value);
                string pais = (this.dgvContribuyentes.SelectedRows[0].Cells[5].Value).ToString();
                //Colocar los valores en los valores
                txtIDcontribuyente.Text = idContribuyente.ToString();
                txtDUI.Text = dui;
                txtNombres.Text = nombres;
                txtApellidos.Text = apellidos;
                dtpFechaNacimiento.Value = fechaNacimiento;
                cmbPais.Text = pais;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Seleccione la fila, no una celda para poder modificar los datos");
            }
        }
        /// <summary>
        /// Elimina un registro
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                eliminarCliente();
                leerBase();
            }
            catch
            {
                MessageBox.Show("Presione el botón leer primero para seleccionar un id");
            }
        }
        /// <summary>
        /// Elimina un registro de cliente
        /// </summary>
        public void eliminarCliente()
        {
            //Recuperas el id seleccionado a eliminar

            if (Convert.IsDBNull(dgvContribuyentes.Rows[0].Cells[0].FormattedValue))
            {
                MessageBox.Show("Presione el botón leer, luego debe seleccionar una fila");
            }
            else
            {
                try
                {
                    int idContribuyente = Convert.ToInt32(txtIDcontribuyente.Text); 
                    MySqlCommand consulta = new MySqlCommand();
                    consulta.Connection = Conexion.abrirConexion();
                    consulta.CommandText = "DELETE FROM tblcontribuyente WHERE idContribuyente = '" + idContribuyente + "'";

                    //---
                    MySqlDataAdapter adaptadorMySQL = new MySqlDataAdapter();
                    adaptadorMySQL.SelectCommand = consulta;
                    DataTable tabla = new DataTable();
                    adaptadorMySQL.Fill(tabla); //ejecutar el insert
                    MessageBox.Show("se elimino elemento de la base");
                    leerBase();
                    limpiar();
                }
                catch(Exception ex)
                {
                    MessageBox.Show($"Error {ex.Message}");
                }
                finally
                {
                    Conexion.cerrarConexion();
                }
            }


        } // fin metodo eliminar
    }
}
