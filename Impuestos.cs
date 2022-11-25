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
    class Impuestos
    {
        int idImpuesto;
        string impuesto;
        double tasa;
        int idPais;
        /// <summary>
        /// Crea el constructor de la clase
        /// </summary>
        /// <param name="impuesto"></param>
        /// <param name="tasa"></param>
        /// <param name="idPais"></param>
        public Impuestos(string impuesto, double tasa, int idPais)
        {
            this.impuesto = impuesto;
            this.tasa = tasa;
            this.idPais = idPais;
        }
        /// <summary>
        /// metodo get y set
        /// </summary>
        public int IDIMPUESTO { get => idImpuesto; set => idImpuesto = value; }
        /// <summary>
        /// metodo get y set
        /// </summary>
        public string IMPUESTO { get => impuesto; set =>  impuesto= value; }
        /// <summary>
        /// metodo get y set
        /// </summary>
        public double TASA { get => tasa; set => tasa = value; }
        /// <summary>
        /// metodo get y set
        /// </summary>
        public int IDPAIS { get => idPais; set =>  idPais= value; }
        /// <summary>
        /// registra un impuesto con los datos ingresados
        /// </summary>
        /// <param name="imp">un objeto de la misma clase</param>
        public void registrarImpuesto(Impuestos imp)
        {
            MySqlCommand consulta = new MySqlCommand();
            consulta.Connection = Conexion.abrirConexion();
            consulta.CommandText = ($"INSERT INTO `clave5_grupo10db`.`tblimpuesto` (`idImpuesto`, `nombre`, `tasa`, `idPais`) VALUES ('0', '{imp.IMPUESTO}', '{imp.TASA}', '{imp.IDPAIS}');");
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
        /// Modifica los datos ingresados con los datos ingresados
        /// </summary>
        /// <param name="imp">un objeto de la misma clase</param>
        public void modificarImpuesto(Impuestos imp)
        {
            MySqlCommand consulta = new MySqlCommand();
            consulta.Connection = Conexion.abrirConexion();
            consulta.CommandText = ($"UPDATE `clave5_grupo10db`.`tblimpuesto` SET `nombre` = '{imp.IMPUESTO}', `tasa` = '{imp.TASA}', `idPais` = '{imp.IDPAIS}' WHERE (`idImpuesto` = '{imp.IDIMPUESTO}');");

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
                MessageBox.Show("elemento no se ingreso!");
            }
            finally
            {
                Conexion.cerrarConexion();
            }
        }

    }
}
