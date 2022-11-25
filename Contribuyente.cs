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
    class Contribuyente
    {
        int idContribuyente;
        string dui;
        string nombres;
        string apellidos;
        string fechaNacimiento;
        int idPais;
        /// <summary>
        /// Creacion del constructor 
        /// </summary>
        /// <param name="dui"></param>
        /// <param name="nombres"></param>
        /// <param name="apellidos"></param>
        /// <param name="fechaNacimiento"></param>
        /// <param name="idPais"></param>
        public Contribuyente(string dui, string nombres, string apellidos, string fechaNacimiento, int idPais)
        {
            this.dui = dui;
            this.nombres = nombres;
            this.apellidos = apellidos;
            this.fechaNacimiento = fechaNacimiento;
            this.idPais = idPais;
        }
       /// <summary>
       /// metodo get y set
       /// </summary>
        public int IDCONTRIBUYENTE { get => idContribuyente; set => idContribuyente = value; }
        /// <summary>
        /// metodo get y set
        /// </summary>
        public string DUI { get => dui; set => dui = value; }
        /// <summary>
        /// metodo get y set
        /// </summary>
        public string NOMBRES  { get => nombres; set => nombres = value; }
        /// <summary>
        /// metodo get y set
        /// </summary>
        public string APELLIDOS  { get => apellidos; set => apellidos = value; }
        /// <summary>
        /// metodo get y set
        /// </summary>
        public string FECHANACIMIENTO { get => fechaNacimiento; set => fechaNacimiento = value; }
        /// <summary>
        /// metodo get y set
        /// </summary>
        public int IDPAIS { get => idPais; set => idPais = value; }

        /// <summary>
        /// Con los datos se agrega a un nuevo usuario
        /// </summary>
        public void registrarContribuyente(Contribuyente c)
        {
            MySqlCommand consulta = new MySqlCommand();

            consulta.Connection = Conexion.abrirConexion();
            consulta.CommandText = ($"insert into `clave5_grupo10db`.`tblcontribuyente` (`idContribuyente`, `dui`, `nombres`, `apellidos`, `fechaNacimiento`, `idPais`) values (null, '{c.DUI}', '{c.NOMBRES}', '{c.APELLIDOS}','{c.FECHANACIMIENTO}', {c.IDPAIS});");
            try
            {
                MySqlDataAdapter adaptadorMySQL = new MySqlDataAdapter();
                adaptadorMySQL.SelectCommand = consulta;
                DataTable tabla = new DataTable();
                adaptadorMySQL.Fill(tabla); //ejecutar el insert

                MessageBox.Show("elemento ingresado!!");
            }
            catch(Exception ex)
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
        /// Con los datos modifica el usuario registrado
        /// </summary>
        /// <param name="c"></param>
        public void modificarContribuyente(Contribuyente c)
        {
            MySqlCommand consulta = new MySqlCommand();
            consulta.Connection = Conexion.abrirConexion();
            consulta.CommandText = $"UPDATE `clave5_grupo10db`.`tblcontribuyente` SET `dui` = '{c.DUI}', `nombres` = '{c.NOMBRES}', `apellidos` = '{c.APELLIDOS}', `fechaNacimiento` = '{c.FECHANACIMIENTO}', `idPais` = '{c.IDPAIS}' WHERE (`idContribuyente` = '{c.IDCONTRIBUYENTE}');";

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
