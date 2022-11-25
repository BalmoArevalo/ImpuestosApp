using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clave5_Grupo10
{
    class DetallePago
    {
        int iddetallepago;
        int idcontribuyente;
        int idimpuesto;
        string concepto;
        double cantidad;
        double total;
        int anio;
        /// <summary>
        /// Cosntructor de la calse
        /// </summary>
        /// <param name="idcontribuyente"></param>
        /// <param name="idimpuesto"></param>
        /// <param name="concepto"></param>
        /// <param name="cantidad"></param>
        /// <param name="total"></param>
        /// <param name="anio"></param>
        public DetallePago(int idcontribuyente, int idimpuesto, string concepto, double cantidad, double total, int anio)
        {
            this.idcontribuyente = idcontribuyente;
            this.idimpuesto = idimpuesto;
            this.concepto = concepto;
            this.cantidad = cantidad;
            this.total = total;
            this.anio = anio;
        }
        /// <summary>
        /// metodo get y set
        /// </summary>
        public int IDDETALLEPAGO { get => iddetallepago; set => iddetallepago = value; }
        /// <summary>
        /// metodo get y set
        /// </summary>
        public int IDCONTRIBUYENTE { get => idcontribuyente; set =>  idcontribuyente= value; }
        /// <summary>
        /// metodo get y set
        /// </summary>
        public int IDIMPUESTO { get => idimpuesto; set =>  idimpuesto= value; }
        /// <summary>
        /// metodo get y set
        /// </summary>
        public string CONCEPTO { get => concepto; set =>  concepto= value; }
        /// <summary>
        /// metodo get y set
        /// </summary>
        public double CANTIDAD { get => cantidad; set =>  cantidad= value; }
        /// <summary>
        /// metodo get y set
        /// </summary>
        public double TOTAL { get => total; set =>  total= value; }
        /// <summary>
        /// metodo get y set
        /// </summary>
        public int ANIO { get => anio; set =>  anio= value; }
        /// <summary>
        /// Ingresa el pago del detalle con los datos
        /// </summary>
        /// <param name="dp">un objeto de la misma clase</param>
        public void ingresarPago(DetallePago dp)
        {
            MySqlCommand consulta = new MySqlCommand();
            consulta.Connection = Conexion.abrirConexion();
            consulta.CommandText = ($"INSERT INTO `clave5_grupo10db`.`detallepago` (`iddetallepago`, `idcontribuyente`, `idimpuesto`, `sobreConcepto`, `cantidad`, `total`, `anio`) VALUES (null, '{dp.IDCONTRIBUYENTE}', '{dp.IDIMPUESTO}', '{dp.CONCEPTO}', '{dp.CANTIDAD}', '{dp.TOTAL}', '{dp.ANIO}');");

            try
            {
                MySqlDataAdapter adaptadorMySQL = new MySqlDataAdapter();
                adaptadorMySQL.SelectCommand = consulta;
                DataTable tabla = new DataTable();
                adaptadorMySQL.Fill(tabla); //ejecutar el insert

                MessageBox.Show("elemento ingresado!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("elemento no se ingreso!");
                MessageBox.Show($"{ex.Message}\nError: {ex.StackTrace}");
            }
            finally
            {
                Conexion.cerrarConexion();
            }
        }
        /// <summary>
        /// modifica los datos de pago con los datos ingresados
        /// </summary>
        /// <param name="dp">un objeto de la misma clase</param>
        public void modificarPago(DetallePago dp)
        {
            MySqlCommand consulta = new MySqlCommand();
            consulta.Connection = Conexion.abrirConexion();
            consulta.CommandText = ($"UPDATE `clave5_grupo10db`.`detallepago` SET `idcontribuyente` = '{dp.IDCONTRIBUYENTE}', `idimpuesto` = '{dp.IDIMPUESTO}', `sobreConcepto` = '{dp.CONCEPTO}', `cantidad` = '{dp.CANTIDAD}', `total` = '{dp.TOTAL}', `anio` = '{dp.ANIO}' WHERE (`iddetallepago` = '{dp.IDDETALLEPAGO}');");

            try
            {
                MySqlDataAdapter adaptadorMySQL = new MySqlDataAdapter();
                adaptadorMySQL.SelectCommand = consulta;
                DataTable tabla = new DataTable();
                adaptadorMySQL.Fill(tabla); //ejecutar el insert
                MessageBox.Show("elemento modificado!!");
            }
            catch
            {
                MessageBox.Show("el elemento no se ingreso!");
            }
            finally
            {
                Conexion.cerrarConexion();
            }
        }
    }
}
