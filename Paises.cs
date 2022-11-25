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
    /// <summary>
    /// Registra paises e impuestos
    /// </summary>
    public partial class Paises : Form
    {
        public Paises()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Regresa a Dashboard
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
            leerBDPais();
        }

        /// <summary>
        /// Mientras carga el formulario llena el cmb con los paises registrados 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Paises_Load(object sender, EventArgs e)
        {
            seleccionarPaises(cmbPais);
        }
        /// <summary>
        /// Recorre los datos de la tabla y los guarda en un array de columnas
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
        /// Agrega un pais y regresa al dashboard
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregarPais_Click(object sender, EventArgs e)
        {
            string pais;
            try
            {
                pais = txtPais.Text;
                if (validarCampo(pais))
                {
                    MessageBox.Show("Ingrese el nombre de un nuevo país");
                }
                else
                {
                    //Instanciar clase
                    Pais nuevoPais = new Pais(pais);
                    nuevoPais.registrarPais(nuevoPais);
                    Form1 dashboard = new Form1();
                    this.Hide();
                    dashboard.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex}");
            }
        }
        /// <summary>
        /// Valida que no este vacio
        /// </summary>
        /// <param name="txt"></param>
        /// <returns></returns>
        public bool validarCampo(string txt)
        {
            return (string.IsNullOrEmpty(txt) || string.IsNullOrWhiteSpace(txt)) ? true : false;
        }
        /// <summary>
        /// Actualiza un pais y regresa al dashboard
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnActualizarPais_Click(object sender, EventArgs e)
        {

            if (txtPais.Text == null || txtPais.Text.Equals(""))
            {
                MessageBox.Show("Presione el botón leer, luego debe seleccionar una fila");
                leerBDPais();
            }
            try
            {
                string pais = txtPais.Text;
                int idPais = Convert.ToInt32(txtIdPais.Text);
                if (validarCampo(pais))
                {
                    MessageBox.Show("No dejar el campo vacio");
                }
                else
                {
                    //Instanciar clase
                    Pais modPais = new Pais(pais);
                    modPais.IDPAIS = idPais;
                    modPais.modificarPais(modPais);
                    leerBDPais();
                    Form1 dashboard = new Form1();
                    this.Hide();
                    dashboard.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex}");
            }
        }
        /// <summary>
        /// Muestra los datos en el dataGrid
        /// </summary>
        public void leerBDPais()
        {
            MySqlCommand consulta = new MySqlCommand();
            consulta.Connection = Conexion.abrirConexion();
            consulta.CommandText = ("select * from tblPais;");
            try
            {
                MySqlDataAdapter adaptadorMySQL = new MySqlDataAdapter();
                adaptadorMySQL.SelectCommand = consulta;
                DataTable tabla = new DataTable();
                adaptadorMySQL.Fill(tabla);
                dgvPais.DataSource = tabla;
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
        /// Obtiene los datos de la fila al hacer doble click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvPais_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //Obtener los valores de la dgv
                int idPais = Convert.ToInt32(this.dgvPais.SelectedRows[0].Cells[0].Value);
                string pais = (this.dgvPais.SelectedRows[0].Cells[1].Value).ToString();

                //Colocar los valores en el txt
                txtIdPais.Text = idPais.ToString();
                txtPais.Text = pais;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Seleccione la fila, no una celda para poder modificar los datos");
            }
        }
        /// <summary>
        /// Elimina un pais
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEliminarPais_Click(object sender, EventArgs e)
        {
            try
            {
                eliminarPais();
                leerBDPais();
            }
            catch
            {
                MessageBox.Show("Presione el botón leer primero para seleccionar un id");
            }
        }
        /// <summary>
        /// Elimina el pais
        /// </summary>
        private void eliminarPais()
        {
            if (Convert.IsDBNull(dgvPais.Rows[0].Cells[0].FormattedValue))
            {
                MessageBox.Show("Presione el botón leer, luego debe seleccionar una fila");
            }
            else
            {
                try
                {
                    int idPais = Convert.ToInt32(txtIdPais.Text);
                    MySqlCommand consulta = new MySqlCommand();
                    consulta.Connection = Conexion.abrirConexion();
                    consulta.CommandText = "DELETE FROM tblpais WHERE idPais = '" + idPais + "'";

                    //---
                    MySqlDataAdapter adaptadorMySQL = new MySqlDataAdapter();
                    adaptadorMySQL.SelectCommand = consulta;
                    DataTable tabla = new DataTable();
                    adaptadorMySQL.Fill(tabla); //ejecutar el insert
                    MessageBox.Show("se elimino elemento de la base");
                    limpiar();
                    Form1 dashboard = new Form1();
                    this.Hide();
                    dashboard.Show();

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error {ex.Message}");
                }
                finally
                {
                    Conexion.cerrarConexion();
                }
            }
        }
        /// <summary>
        /// Limpia el formulario
        /// </summary>
        public void limpiar()
        {
            txtIdPais.Text = "";
            txtPais.Text = "";
            cmbPais.Text = "";
            cmbImpuesto.Text = "";
            txtTasa.Text = "";
            ;
        }
        /// <summary>
        /// Agrega un impuesto a partir de los datos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregarImpuesto_Click(object sender, EventArgs e)
        {
            string impuesto;
            double tasa;
            int idPais;
            try
            {
                idPais = cmbPais.SelectedIndex + 1;
                impuesto = cmbImpuesto.Text;
                tasa = Convert.ToDouble(txtTasa.Text);
                bool b1 = validarCampo(idPais.ToString());
                bool b2 = validarCampo(impuesto);
                bool b3 = validarCampo(tasa.ToString());
                if (b1 && b2 && b3)
                {
                    MessageBox.Show("Para ingresar un impuesto, debe seleccionar un pais de la lista, el tipo y asignar un valor");
                }
                else
                {
                    Impuestos nuevoImpuesto = new Impuestos(impuesto, tasa, idPais);
                    nuevoImpuesto.registrarImpuesto(nuevoImpuesto);
                    leerBDImpuesto();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
        /// <summary>
        /// lee la base de datos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLeerImpuesto_Click(object sender, EventArgs e)
        {
            leerBDImpuesto();
        }
        /// <summary>
        /// lee la base de datos y lo muestra en el data grid
        /// </summary>
        public void leerBDImpuesto()
        {
            MySqlCommand consulta = new MySqlCommand();
            consulta.Connection = Conexion.abrirConexion();
            consulta.CommandText = ("select tblimpuesto.idImpuesto, tblimpuesto.nombre, tblimpuesto.tasa, tblpais.nombre  from tblimpuesto inner join tblpais on tblimpuesto.idPais = tblpais.idPais;");
            try
            {
                MySqlDataAdapter adaptadorMySQL = new MySqlDataAdapter();
                adaptadorMySQL.SelectCommand = consulta;
                DataTable tabla = new DataTable();
                adaptadorMySQL.Fill(tabla);
                dgvImpuesto.DataSource = tabla;
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
        /// obtiene los datos del data grid al seleccionar la fila con doble click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvImpuesto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //Obtener los valores de la dgv
                 int idImpuesto = Convert.ToInt32(this.dgvImpuesto.SelectedRows[0].Cells[0].Value);
                string impuesto = this.dgvImpuesto.SelectedRows[0].Cells[1].Value.ToString();
                double tasa = Convert.ToDouble(this.dgvImpuesto.SelectedRows[0].Cells[2].Value);
                string idPais = (this.dgvImpuesto.SelectedRows[0].Cells[3].Value).ToString();

                //Colocar los valores en el txt
                cmbPais.Text = idPais;
                cmbImpuesto.Text = impuesto;
                txtTasa.Text = tasa.ToString();
                txtIdImpuesto.Text = idImpuesto.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Seleccione la fila, no una celda para poder modificar los datos");
                MessageBox.Show($"{ex.Message}\n{ex.StackTrace}");
            }
        }
        /// <summary>
        /// Actualiza el impuesto seleccionado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnActualizarImpuesto_Click(object sender, EventArgs e)
        {
            if ((cmbPais.Text == null || cmbPais.Text.Equals("")) && (cmbImpuesto.Text == null || cmbImpuesto.Text.Equals("")))
            {
                MessageBox.Show("Presione el botón leer, luego debe seleccionar una fila");
                leerBDImpuesto();
            }
            try
            {
                int idImpuesto = Convert.ToInt32(txtIdImpuesto.Text);
                int idPais = cmbPais.SelectedIndex + 1;
                string impuesto = cmbImpuesto.Text;
                double tasa = Convert.ToDouble(txtTasa.Text);
                bool b1 = validarCampo(idPais.ToString());
                bool b2 = validarCampo(impuesto);
                bool b3 = validarCampo(tasa.ToString());
                if (b1 && b2 && b3)
                {
                    MessageBox.Show("Para ingresar un impuesto, debe seleccionar un pais de la lista, el tipo y asignar un valor");
                }
                else
                {
                    Impuestos modImpuesto = new Impuestos(impuesto, tasa, idPais);
                    modImpuesto.IDIMPUESTO = idImpuesto;
                    modImpuesto.modificarImpuesto(modImpuesto);
                    leerBDImpuesto();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex}");
            }
        }
        /// <summary>
        /// Elimina un impuesto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEliminarImpuesto_Click(object sender, EventArgs e)
        {

            try
            {
                eliminarImpuesto();
                leerBDImpuesto();
            }
            catch
            {
                MessageBox.Show("Presione el botón leer primero para seleccionar un id");
            }
        }
        /// <summary>
        /// Elimina el impuesto
        /// </summary>
        private void eliminarImpuesto()
        {
            if (Convert.IsDBNull(dgvImpuesto.Rows[0].Cells[0].FormattedValue))
            {
                MessageBox.Show("Presione el botón leer, luego debe seleccionar una fila");
            }
            else
            {
                try
                {
                    int idImpuesto = Convert.ToInt32(txtIdImpuesto.Text);
                    MySqlCommand consulta = new MySqlCommand();
                    consulta.Connection = Conexion.abrirConexion();
                    consulta.CommandText = "DELETE FROM tblimpuesto WHERE idImpuesto = '" + idImpuesto + "'";

                    //---
                    MySqlDataAdapter adaptadorMySQL = new MySqlDataAdapter();
                    adaptadorMySQL.SelectCommand = consulta;
                    DataTable tabla = new DataTable();
                    adaptadorMySQL.Fill(tabla); //ejecutar el insert
                    MessageBox.Show("se elimino elemento de la base");
                    leerBDImpuesto();
                    limpiar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error {ex.Message}");
                }
                finally
                {
                    Conexion.cerrarConexion();
                }
            }
        }
    }
}