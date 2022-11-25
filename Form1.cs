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
    /// Autor Emerson Arévalo, Fernando Guzmán, José Lemus 5/11/2022
    /// </summary>
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Cierra la aplicacion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// Inicia el formulario para registrar un contribuyente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnContribuyente_Click(object sender, EventArgs e)
        {
            datosContribuyente formRegistrar = new datosContribuyente();
            this.Hide();
            formRegistrar.Show();
        }
        /// <summary>
        /// Inicia el formulario para registrar paises e imupuestos de los paises
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPais_Click(object sender, EventArgs e)
        {
            Paises formPaises = new Paises();
            this.Hide();
            formPaises.Show();
        }
        /// <summary>
        /// Inicia el formulario para registrar la orden de pago
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPago_Click(object sender, EventArgs e)
        {
            pagoImpuesto formPago = new pagoImpuesto();
            this.Hide();
            formPago.Show();
        }

        /// <summary>
        /// Genera el informe de la cosnsulta de todas las tablas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            MySqlCommand consulta = new MySqlCommand();
            consulta.Connection = Conexion.abrirConexion();
            consulta.CommandText = ("select tblcontribuyente.idContribuyente as NIT, tblcontribuyente.nombres as Nombre, tblcontribuyente.apellidos as Apellidos, detallepago.iddetallepago as \"No.Pago\", tblimpuesto.nombre as Impuesto, tblimpuesto.tasa as Tasa, detallepago.sobreConcepto as \"Sobre Concepto\", detallepago.cantidad as \"Cantidad vendida\", detallepago.total as \"Total\", detallepago.anio as Año, tblpais.nombre as País from tblcontribuyente inner join detallepago on tblcontribuyente.idContribuyente = detallepago.idcontribuyente inner join tblimpuesto on detallepago.idimpuesto = tblimpuesto.idImpuesto inner join tblpais on tblimpuesto.idPais = tblpais.idPais;");
            try
            {
                //Inicializa una nueva instancia de la clase MySqlDataAdapter con
                // el MySqlCommand especificado como propiedad SelectCommand.
                MySqlDataAdapter adaptadorMySQL = new MySqlDataAdapter();
                adaptadorMySQL.SelectCommand = consulta;
                DataTable tabla = new DataTable();
                adaptadorMySQL.Fill(tabla);
                dgvRegistros.DataSource = tabla;
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
    }
}
