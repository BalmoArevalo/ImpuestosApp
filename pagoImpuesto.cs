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
    public partial class pagoImpuesto : Form
    {
        public pagoImpuesto()
        {
            InitializeComponent();
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
        /// Regresa al Dashboard
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
        /// Llena el cmbContribuyente solo con los contribuyentes ingresados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pagoImpuesto_Load(object sender, EventArgs e)
        {
            seleccionarContribuyente(cmbContribuyente);
        }
        /// <summary>
        /// Guarda los contribuyentes en el combobox
        /// </summary>
        /// <param name="cbx"></param>
        public void seleccionarContribuyente(ComboBox cbx)
        {
            cbx.Items.Clear();
            MySqlCommand consulta = new MySqlCommand();
            consulta.Connection = Conexion.abrirConexion();
            consulta.CommandText = "select * from tblcontribuyente";
            try
            {
                MySqlDataAdapter adaptadorMySQL = new MySqlDataAdapter();
                adaptadorMySQL.SelectCommand = consulta;
                MySqlDataReader dr = consulta.ExecuteReader();
                while (dr.Read())
                {
                    cbx.Items.Add(dr[0].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex}");
            }
        }
        /// <summary>
        /// Seleccione el impuesto a partir del pais que pertenesca el contribuyente
        /// </summary>
        /// <param name="cbx"></param>
        public void seleccionarImpuesto(ComboBox cbx)
        {
            cbx.Items.Clear();
            int idContribuyente = Convert.ToInt32(cmbContribuyente.Text);
            MySqlCommand consulta = new MySqlCommand();
            consulta.Connection = Conexion.abrirConexion();
            consulta.CommandText = $"select tblimpuesto.idImpuesto from tblImpuesto inner join tblpais on tblImpuesto.idPais=tblpais.idPais inner join tblcontribuyente on tblpais.idPais = tblcontribuyente.idPais where tblcontribuyente.idContribuyente={idContribuyente};";
            try
            {
                MySqlDataAdapter adaptadorMySQL = new MySqlDataAdapter();
                adaptadorMySQL.SelectCommand = consulta;
                MySqlDataReader dr = consulta.ExecuteReader();
                while (dr.Read())
                {
                    cbx.Items.Add(dr[0].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex}");
            }
        }
        /// <summary>
        /// Selecciona la tasa a partir del impuesto a pagar
        /// </summary>
        /// <param name="cbx"></param>
        public void seleccionarTasa(TextBox cbx)
        {
            cbx.Clear();
            int idimpuesto = cmbImpuesto.SelectedIndex + 1;
            MySqlCommand consulta = new MySqlCommand();
            consulta.Connection = Conexion.abrirConexion();
            consulta.CommandText = $"select tasa from tblImpuesto where idImpuesto={idimpuesto}; ";
            try
            {
                MySqlDataAdapter adaptadorMySQL = new MySqlDataAdapter();
                adaptadorMySQL.SelectCommand = consulta;
                MySqlDataReader dr = consulta.ExecuteReader();
                while (dr.Read())
                {
                    cbx.Text = (dr[0].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex}");
            }
        }
        /// <summary>
        /// Agrega un registro de pago
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int idContribuyente, anio, idimpuesto;
            string concepto;
            double cantidad, total, impuesto;
            try
            {
                idContribuyente = cmbContribuyente.SelectedIndex + 1;
                idimpuesto = cmbImpuesto.SelectedIndex + 1;
                impuesto = Convert.ToDouble(txtTasa.Text);
                concepto = cmbConcepto.Text;
                cantidad = Convert.ToDouble(txtCantidad.Text);
                total = cantidad * impuesto;
                txtTotal.Text = total.ToString();
                anio = Convert.ToInt32(txtAnio.Text);
                bool b1 = validarCampo(idContribuyente.ToString());
                bool b2 = validarCampo(idimpuesto.ToString());
                bool b3 = validarCampo(impuesto.ToString());
                bool b4 = validarCampo(concepto);
                bool b5 = validarCampo(cantidad.ToString());
                bool b6 = validarCampo(anio.ToString());
                if (b1 && b2 && b3 && b4 && b5 && b6)
                {
                    MessageBox.Show("Rellene todos los campos");
                }
                else
                {
                    DetallePago nuevoDetalle = new DetallePago(idContribuyente, idimpuesto, concepto, cantidad, total, anio);
                    nuevoDetalle.ingresarPago(nuevoDetalle);
                    leerBDpagoImpuesto();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex}");
            }
        }
        /// <summary>
        /// Valida que el campo no este vacio
        /// </summary>
        /// <param name="txt"></param>
        /// <returns></returns>
        public bool validarCampo(string txt)
        {
            return (string.IsNullOrEmpty(txt) || string.IsNullOrWhiteSpace(txt)) ? true : false;
        }
        /// <summary>
        /// Lee la base de datos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLeer_Click(object sender, EventArgs e)
        {
            leerBDpagoImpuesto();
        }
        public void leerBDpagoImpuesto()
        {
            MySqlCommand consulta = new MySqlCommand();
            consulta.Connection = Conexion.abrirConexion();
            consulta.CommandText = ("select * from detallepago;");
            try
            {
                MySqlDataAdapter adaptadorMySQL = new MySqlDataAdapter();
                adaptadorMySQL.SelectCommand = consulta;
                DataTable tabla = new DataTable();
                adaptadorMySQL.Fill(tabla);
                dgvDetallePago.DataSource = tabla;
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
        /// Mientras cambie el cmbx llena la tasa automaticamente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbImpuesto_SelectedIndexChanged(object sender, EventArgs e)
        {
            seleccionarTasa(txtTasa);
        }
        /// <summary>
        /// mientras seleccione un contribuyente, llena los impuestos para su pais automaticamente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void cmbContribuyente_SelectedIndexChanged(object sender, EventArgs e)
        {
            seleccionarImpuesto(cmbImpuesto);
        }
        /// <summary>
        /// Al realizar doble click en la fila obtiene los datos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvDetallePago_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //Obtener los valores de la dgv
                int iddetallepago = Convert.ToInt32(this.dgvDetallePago.SelectedRows[0].Cells[0].Value);
                string contribuyente = (this.dgvDetallePago.SelectedRows[0].Cells[1].Value).ToString();
                string impuesto = (this.dgvDetallePago.SelectedRows[0].Cells[2].Value).ToString();
                string concepto = (this.dgvDetallePago.SelectedRows[0].Cells[3].Value).ToString();
                double cantidad = Convert.ToDouble(this.dgvDetallePago.SelectedRows[0].Cells[4].Value);
                double total = Convert.ToDouble(this.dgvDetallePago.SelectedRows[0].Cells[5].Value);
                int anio = Convert.ToInt32(this.dgvDetallePago.SelectedRows[0].Cells[6].Value);
                //Colocar los valores en el txt
                txtIdDetallePago.Text = iddetallepago.ToString();
                cmbContribuyente.Text = contribuyente;
                cmbImpuesto.Text = impuesto;
                cmbConcepto.Text = concepto;
                txtCantidad.Text = cantidad.ToString(); ;
                txtTotal.Text = total.ToString();
                txtAnio.Text = anio.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Seleccione la fila, no una celda para poder modificar los datos");
            }
        }
        /// <summary>
        /// Modifica un detalle de pago
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModificar_Click(object sender, EventArgs e)
        {
            int idContribuyente = cmbContribuyente.SelectedIndex + 1;
            int idimpuesto = cmbImpuesto.SelectedIndex + 1;
            double impuesto = Convert.ToDouble(txtTasa.Text);
            string concepto = cmbConcepto.Text;
            double cantidad = Convert.ToDouble(txtCantidad.Text);
            double total = cantidad * impuesto;
            txtTotal.Text = total.ToString();
            int anio = Convert.ToInt32(txtAnio.Text);
            bool b1 = validarCampo(idContribuyente.ToString());
            bool b2 = validarCampo(idimpuesto.ToString());
            bool b3 = validarCampo(impuesto.ToString());
            bool b4 = validarCampo(concepto);
            bool b5 = validarCampo(cantidad.ToString());
            bool b6 = validarCampo(anio.ToString());
            if (b1 && b2 && b3 && b4 && b5 && b6)
            {
                MessageBox.Show("Presione el botón leer, luego debe seleccionar una fila");
                leerBDpagoImpuesto();
            }
            try
            {
                int iddetallepago = Convert.ToInt32(txtIdDetallePago.Text);
                if (validarCampo(iddetallepago.ToString()))
                {
                    MessageBox.Show("No dejar el campo vacio");
                }
                else
                {
                    //Instanciar clase
                    DetallePago modPago = new DetallePago(idContribuyente, idimpuesto, concepto, cantidad, total, anio);
                    modPago.IDDETALLEPAGO = iddetallepago;
                    modPago.modificarPago(modPago);
                    leerBDpagoImpuesto();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex}");
            }
        }
        /// <summary>
        /// Elimina un detalle de pago
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                eliminarPago();
                leerBDpagoImpuesto();
            }
            catch
            {
                MessageBox.Show("Presione el botón leer primero para seleccionar un id");
            }
        }
        /// <summary>
        /// Elimina un registro
        /// </summary>
        public void eliminarPago()
        {
            if (Convert.IsDBNull(dgvDetallePago.Rows[0].Cells[0].FormattedValue))
            {
                MessageBox.Show("Presione el botón leer, luego debe seleccionar una fila");
            }
            else
            {
                try
                {
                    int iddetallepago = Convert.ToInt32(txtIdDetallePago.Text);
                    MySqlCommand consulta = new MySqlCommand();
                    consulta.Connection = Conexion.abrirConexion();
                    consulta.CommandText = "DELETE FROM detallepago WHERE idPais = '" + iddetallepago + "'";

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
        /// limpia todos los campos del formulario
        /// </summary>
        public void limpiar()
        {
            txtIdDetallePago.Text = "";
            cmbContribuyente.Text = "";
            cmbImpuesto.Text = "";
            cmbConcepto.Text = "";
            txtCantidad.Text = "";
            txtTasa.Text = "";
            txtTotal.Text = "";
            txtAnio.Text = "";
        }
    }
}
