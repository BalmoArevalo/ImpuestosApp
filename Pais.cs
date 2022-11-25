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
    class Pais
    {
        int idPais;
        string nombre;
        /// <summary>
        /// Crea el constructor
        /// </summary>
        /// <param name="nombre"></param>
        public Pais(string nombre)
        {
            //ID
            this.nombre = nombre;
        }
        /// <summary>
        /// metodo get y set
        /// </summary>
        public int IDPAIS { get => idPais; set => idPais = value; }
        /// <summary>
        /// metodo get y set
        /// </summary>
        public string NOMBRE { get => nombre; set => nombre = value; }

        /// <summary>
        /// Registra el pais con los datos ingresados
        /// </summary>
        /// <param name="p">un objeto de la misma clase</param>
        public void registrarPais(Pais p)
        {
            MySqlCommand consulta = new MySqlCommand();
            consulta.Connection = Conexion.abrirConexion();
            consulta.CommandText = ($"insert into tblpais (idPais, nombre) values (null, '{p.NOMBRE}'); ");

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
        /// Modifica los datos del pais con los datos ingresados
        /// </summary>
        /// <param name="p">un objeto de la misma clase</param>
        public void modificarPais(Pais p)
        {
            MySqlCommand consulta = new MySqlCommand();
            consulta.Connection = Conexion.abrirConexion();
            consulta.CommandText = ($"UPDATE `clave5_grupo10db`.`tblpais` SET `nombre` = '{p.NOMBRE}' WHERE (`idPais` = '{p.IDPAIS}');");

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
