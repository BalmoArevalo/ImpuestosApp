
namespace Clave5_Grupo10
{
    partial class Paises
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvPais = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPais = new System.Windows.Forms.TextBox();
            this.btnAgregarPais = new System.Windows.Forms.Button();
            this.txtIdPais = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTasa = new System.Windows.Forms.TextBox();
            this.cmbPais = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnLeerPais = new System.Windows.Forms.Button();
            this.btnEliminarPais = new System.Windows.Forms.Button();
            this.btnConexion = new System.Windows.Forms.Button();
            this.btnActualizarPais = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnAgregarImpuesto = new System.Windows.Forms.Button();
            this.dgvImpuesto = new System.Windows.Forms.DataGridView();
            this.btnActualizarImpuesto = new System.Windows.Forms.Button();
            this.btnLeerImpuesto = new System.Windows.Forms.Button();
            this.btnEliminarImpuesto = new System.Windows.Forms.Button();
            this.cmbImpuesto = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIdImpuesto = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPais)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImpuesto)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPais
            // 
            this.dgvPais.AllowUserToAddRows = false;
            this.dgvPais.AllowUserToDeleteRows = false;
            this.dgvPais.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPais.Location = new System.Drawing.Point(38, 361);
            this.dgvPais.Name = "dgvPais";
            this.dgvPais.ReadOnly = true;
            this.dgvPais.Size = new System.Drawing.Size(253, 239);
            this.dgvPais.TabIndex = 0;
            this.dgvPais.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPais_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pais";
            // 
            // txtPais
            // 
            this.txtPais.Location = new System.Drawing.Point(114, 33);
            this.txtPais.Name = "txtPais";
            this.txtPais.Size = new System.Drawing.Size(167, 20);
            this.txtPais.TabIndex = 2;
            // 
            // btnAgregarPais
            // 
            this.btnAgregarPais.Location = new System.Drawing.Point(114, 73);
            this.btnAgregarPais.Name = "btnAgregarPais";
            this.btnAgregarPais.Size = new System.Drawing.Size(167, 32);
            this.btnAgregarPais.TabIndex = 3;
            this.btnAgregarPais.Text = "Agregar país";
            this.btnAgregarPais.UseVisualStyleBackColor = true;
            this.btnAgregarPais.Click += new System.EventHandler(this.btnAgregarPais_Click);
            // 
            // txtIdPais
            // 
            this.txtIdPais.Location = new System.Drawing.Point(114, 210);
            this.txtIdPais.Name = "txtIdPais";
            this.txtIdPais.Size = new System.Drawing.Size(167, 20);
            this.txtIdPais.TabIndex = 4;
            this.txtIdPais.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(402, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tipo de impuesto";
            // 
            // txtTasa
            // 
            this.txtTasa.Location = new System.Drawing.Point(508, 85);
            this.txtTasa.Name = "txtTasa";
            this.txtTasa.Size = new System.Drawing.Size(162, 20);
            this.txtTasa.TabIndex = 8;
            // 
            // cmbPais
            // 
            this.cmbPais.FormattingEnabled = true;
            this.cmbPais.Location = new System.Drawing.Point(508, 28);
            this.cmbPais.Name = "cmbPais";
            this.cmbPais.Size = new System.Drawing.Size(162, 21);
            this.cmbPais.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(402, 31);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(27, 13);
            this.label11.TabIndex = 7;
            this.label11.Text = "Pais";
            // 
            // btnLeerPais
            // 
            this.btnLeerPais.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnLeerPais.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLeerPais.Location = new System.Drawing.Point(114, 117);
            this.btnLeerPais.Name = "btnLeerPais";
            this.btnLeerPais.Size = new System.Drawing.Size(80, 44);
            this.btnLeerPais.TabIndex = 8;
            this.btnLeerPais.Text = "Leer\r\nPaís";
            this.btnLeerPais.UseVisualStyleBackColor = false;
            this.btnLeerPais.Click += new System.EventHandler(this.btnLeer_Click);
            // 
            // btnEliminarPais
            // 
            this.btnEliminarPais.Location = new System.Drawing.Point(114, 167);
            this.btnEliminarPais.Name = "btnEliminarPais";
            this.btnEliminarPais.Size = new System.Drawing.Size(167, 37);
            this.btnEliminarPais.TabIndex = 9;
            this.btnEliminarPais.Text = "Eliminar";
            this.btnEliminarPais.UseVisualStyleBackColor = true;
            this.btnEliminarPais.Click += new System.EventHandler(this.btnEliminarPais_Click);
            // 
            // btnConexion
            // 
            this.btnConexion.BackColor = System.Drawing.Color.Lime;
            this.btnConexion.Location = new System.Drawing.Point(47, 297);
            this.btnConexion.Name = "btnConexion";
            this.btnConexion.Size = new System.Drawing.Size(200, 36);
            this.btnConexion.TabIndex = 10;
            this.btnConexion.Text = "Comprobar conexión";
            this.btnConexion.UseVisualStyleBackColor = false;
            this.btnConexion.Click += new System.EventHandler(this.btnConexion_Click);
            // 
            // btnActualizarPais
            // 
            this.btnActualizarPais.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnActualizarPais.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnActualizarPais.Location = new System.Drawing.Point(200, 117);
            this.btnActualizarPais.Name = "btnActualizarPais";
            this.btnActualizarPais.Size = new System.Drawing.Size(81, 44);
            this.btnActualizarPais.TabIndex = 11;
            this.btnActualizarPais.Text = "Actualizar\r\nPaís";
            this.btnActualizarPais.UseVisualStyleBackColor = false;
            this.btnActualizarPais.Click += new System.EventHandler(this.btnActualizarPais_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(302, 299);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(200, 36);
            this.btnRegresar.TabIndex = 12;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Crimson;
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSalir.Location = new System.Drawing.Point(547, 299);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(200, 34);
            this.btnSalir.TabIndex = 13;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnAgregarImpuesto
            // 
            this.btnAgregarImpuesto.Location = new System.Drawing.Point(508, 117);
            this.btnAgregarImpuesto.Name = "btnAgregarImpuesto";
            this.btnAgregarImpuesto.Size = new System.Drawing.Size(162, 44);
            this.btnAgregarImpuesto.TabIndex = 14;
            this.btnAgregarImpuesto.Text = "Agregar\r\nImpuestos";
            this.btnAgregarImpuesto.UseVisualStyleBackColor = true;
            this.btnAgregarImpuesto.Click += new System.EventHandler(this.btnAgregarImpuesto_Click);
            // 
            // dgvImpuesto
            // 
            this.dgvImpuesto.AllowUserToAddRows = false;
            this.dgvImpuesto.AllowUserToDeleteRows = false;
            this.dgvImpuesto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvImpuesto.Location = new System.Drawing.Point(311, 361);
            this.dgvImpuesto.Name = "dgvImpuesto";
            this.dgvImpuesto.ReadOnly = true;
            this.dgvImpuesto.Size = new System.Drawing.Size(477, 239);
            this.dgvImpuesto.TabIndex = 16;
            this.dgvImpuesto.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvImpuesto_CellDoubleClick);
            // 
            // btnActualizarImpuesto
            // 
            this.btnActualizarImpuesto.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnActualizarImpuesto.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnActualizarImpuesto.Location = new System.Drawing.Point(589, 173);
            this.btnActualizarImpuesto.Name = "btnActualizarImpuesto";
            this.btnActualizarImpuesto.Size = new System.Drawing.Size(81, 44);
            this.btnActualizarImpuesto.TabIndex = 18;
            this.btnActualizarImpuesto.Text = "Actualizar\r\nImpuesto";
            this.btnActualizarImpuesto.UseVisualStyleBackColor = false;
            this.btnActualizarImpuesto.Click += new System.EventHandler(this.btnActualizarImpuesto_Click);
            // 
            // btnLeerImpuesto
            // 
            this.btnLeerImpuesto.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnLeerImpuesto.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLeerImpuesto.Location = new System.Drawing.Point(508, 173);
            this.btnLeerImpuesto.Name = "btnLeerImpuesto";
            this.btnLeerImpuesto.Size = new System.Drawing.Size(80, 44);
            this.btnLeerImpuesto.TabIndex = 17;
            this.btnLeerImpuesto.Text = "Leer\r\nImpuesto";
            this.btnLeerImpuesto.UseVisualStyleBackColor = false;
            this.btnLeerImpuesto.Click += new System.EventHandler(this.btnLeerImpuesto_Click);
            // 
            // btnEliminarImpuesto
            // 
            this.btnEliminarImpuesto.Location = new System.Drawing.Point(508, 223);
            this.btnEliminarImpuesto.Name = "btnEliminarImpuesto";
            this.btnEliminarImpuesto.Size = new System.Drawing.Size(162, 37);
            this.btnEliminarImpuesto.TabIndex = 19;
            this.btnEliminarImpuesto.Text = "Eliminar";
            this.btnEliminarImpuesto.UseVisualStyleBackColor = true;
            this.btnEliminarImpuesto.Click += new System.EventHandler(this.btnEliminarImpuesto_Click);
            // 
            // cmbImpuesto
            // 
            this.cmbImpuesto.FormattingEnabled = true;
            this.cmbImpuesto.Items.AddRange(new object[] {
            "ISR",
            "IVA",
            "Tabaco",
            "Bebidas carbonatadas",
            "Alcohol",
            "Inmueble",
            "Vehiculo",
            "Ropa ",
            "Turismo"});
            this.cmbImpuesto.Location = new System.Drawing.Point(508, 55);
            this.cmbImpuesto.Name = "cmbImpuesto";
            this.cmbImpuesto.Size = new System.Drawing.Size(162, 21);
            this.cmbImpuesto.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(402, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Tasa del impuesto";
            // 
            // txtIdImpuesto
            // 
            this.txtIdImpuesto.Location = new System.Drawing.Point(335, 130);
            this.txtIdImpuesto.Name = "txtIdImpuesto";
            this.txtIdImpuesto.Size = new System.Drawing.Size(167, 20);
            this.txtIdImpuesto.TabIndex = 22;
            this.txtIdImpuesto.Visible = false;
            // 
            // Paises
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 612);
            this.Controls.Add(this.txtIdImpuesto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbImpuesto);
            this.Controls.Add(this.btnEliminarImpuesto);
            this.Controls.Add(this.btnActualizarImpuesto);
            this.Controls.Add(this.btnLeerImpuesto);
            this.Controls.Add(this.dgvImpuesto);
            this.Controls.Add(this.btnAgregarImpuesto);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTasa);
            this.Controls.Add(this.btnActualizarPais);
            this.Controls.Add(this.btnConexion);
            this.Controls.Add(this.btnEliminarPais);
            this.Controls.Add(this.btnLeerPais);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cmbPais);
            this.Controls.Add(this.txtIdPais);
            this.Controls.Add(this.btnAgregarPais);
            this.Controls.Add(this.txtPais);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvPais);
            this.Name = "Paises";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Paises";
            this.Load += new System.EventHandler(this.Paises_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPais)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImpuesto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPais;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPais;
        private System.Windows.Forms.Button btnAgregarPais;
        private System.Windows.Forms.TextBox txtIdPais;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTasa;
        private System.Windows.Forms.ComboBox cmbPais;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnLeerPais;
        private System.Windows.Forms.Button btnEliminarPais;
        private System.Windows.Forms.Button btnConexion;
        private System.Windows.Forms.Button btnActualizarPais;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnAgregarImpuesto;
        private System.Windows.Forms.DataGridView dgvImpuesto;
        private System.Windows.Forms.Button btnActualizarImpuesto;
        private System.Windows.Forms.Button btnLeerImpuesto;
        private System.Windows.Forms.Button btnEliminarImpuesto;
        private System.Windows.Forms.ComboBox cmbImpuesto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIdImpuesto;
    }
}