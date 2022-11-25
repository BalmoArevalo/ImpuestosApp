
namespace Clave5_Grupo10
{
    partial class pagoImpuesto
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
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnConexion = new System.Windows.Forms.Button();
            this.cmbContribuyente = new System.Windows.Forms.ComboBox();
            this.cmbImpuesto = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDetallePago = new System.Windows.Forms.DataGridView();
            this.txtIdDetallePago = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbConcepto = new System.Windows.Forms.ComboBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAnio = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnLeer = new System.Windows.Forms.Button();
            this.txtTasa = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetallePago)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(381, 176);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(217, 42);
            this.btnRegresar.TabIndex = 0;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Crimson;
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSalir.Location = new System.Drawing.Point(381, 224);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(217, 42);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnConexion
            // 
            this.btnConexion.BackColor = System.Drawing.Color.Lime;
            this.btnConexion.Location = new System.Drawing.Point(381, 29);
            this.btnConexion.Name = "btnConexion";
            this.btnConexion.Size = new System.Drawing.Size(217, 42);
            this.btnConexion.TabIndex = 2;
            this.btnConexion.Text = "Probar conexion";
            this.btnConexion.UseVisualStyleBackColor = false;
            this.btnConexion.Click += new System.EventHandler(this.btnConexion_Click);
            // 
            // cmbContribuyente
            // 
            this.cmbContribuyente.FormattingEnabled = true;
            this.cmbContribuyente.Location = new System.Drawing.Point(149, 44);
            this.cmbContribuyente.Name = "cmbContribuyente";
            this.cmbContribuyente.Size = new System.Drawing.Size(183, 21);
            this.cmbContribuyente.TabIndex = 3;
            this.cmbContribuyente.SelectedIndexChanged += new System.EventHandler(this.cmbContribuyente_SelectedIndexChanged);
            // 
            // cmbImpuesto
            // 
            this.cmbImpuesto.FormattingEnabled = true;
            this.cmbImpuesto.Location = new System.Drawing.Point(149, 80);
            this.cmbImpuesto.Name = "cmbImpuesto";
            this.cmbImpuesto.Size = new System.Drawing.Size(183, 21);
            this.cmbImpuesto.TabIndex = 4;
            this.cmbImpuesto.SelectedIndexChanged += new System.EventHandler(this.cmbImpuesto_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Contribuyente";
            // 
            // dgvDetallePago
            // 
            this.dgvDetallePago.AllowUserToAddRows = false;
            this.dgvDetallePago.AllowUserToDeleteRows = false;
            this.dgvDetallePago.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetallePago.Location = new System.Drawing.Point(29, 297);
            this.dgvDetallePago.Name = "dgvDetallePago";
            this.dgvDetallePago.ReadOnly = true;
            this.dgvDetallePago.Size = new System.Drawing.Size(585, 215);
            this.dgvDetallePago.TabIndex = 6;
            this.dgvDetallePago.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetallePago_CellDoubleClick);
            // 
            // txtIdDetallePago
            // 
            this.txtIdDetallePago.Location = new System.Drawing.Point(153, 6);
            this.txtIdDetallePago.Name = "txtIdDetallePago";
            this.txtIdDetallePago.Size = new System.Drawing.Size(179, 20);
            this.txtIdDetallePago.TabIndex = 7;
            this.txtIdDetallePago.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Impuesto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Concepto";
            // 
            // cmbConcepto
            // 
            this.cmbConcepto.FormattingEnabled = true;
            this.cmbConcepto.Items.AddRange(new object[] {
            "Salario",
            "Venta"});
            this.cmbConcepto.Location = new System.Drawing.Point(149, 115);
            this.cmbConcepto.Name = "cmbConcepto";
            this.cmbConcepto.Size = new System.Drawing.Size(183, 21);
            this.cmbConcepto.TabIndex = 10;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(149, 152);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(183, 20);
            this.txtCantidad.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Cantidad ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Tasa";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(59, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Total";
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(149, 225);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(183, 20);
            this.txtTotal.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(59, 265);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Año";
            // 
            // txtAnio
            // 
            this.txtAnio.Location = new System.Drawing.Point(149, 262);
            this.txtAnio.Name = "txtAnio";
            this.txtAnio.Size = new System.Drawing.Size(183, 20);
            this.txtAnio.TabIndex = 18;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAgregar.Location = new System.Drawing.Point(381, 80);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(109, 42);
            this.btnAgregar.TabIndex = 19;
            this.btnAgregar.Text = "Agregar pago";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(381, 128);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(109, 42);
            this.btnModificar.TabIndex = 20;
            this.btnModificar.Text = "Modificar pago";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(496, 128);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(102, 42);
            this.btnEliminar.TabIndex = 21;
            this.btnEliminar.Text = "Eliminar pago";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnLeer
            // 
            this.btnLeer.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnLeer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLeer.Location = new System.Drawing.Point(496, 80);
            this.btnLeer.Name = "btnLeer";
            this.btnLeer.Size = new System.Drawing.Size(102, 42);
            this.btnLeer.TabIndex = 23;
            this.btnLeer.Text = "Leer pago";
            this.btnLeer.UseVisualStyleBackColor = false;
            this.btnLeer.Click += new System.EventHandler(this.btnLeer_Click);
            // 
            // txtTasa
            // 
            this.txtTasa.Enabled = false;
            this.txtTasa.Location = new System.Drawing.Point(149, 187);
            this.txtTasa.Name = "txtTasa";
            this.txtTasa.Size = new System.Drawing.Size(183, 20);
            this.txtTasa.TabIndex = 24;
            // 
            // pagoImpuesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 537);
            this.Controls.Add(this.txtTasa);
            this.Controls.Add(this.btnLeer);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtAnio);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.cmbConcepto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIdDetallePago);
            this.Controls.Add(this.dgvDetallePago);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbImpuesto);
            this.Controls.Add(this.cmbContribuyente);
            this.Controls.Add(this.btnConexion);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnRegresar);
            this.MaximizeBox = false;
            this.Name = "pagoImpuesto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalle del pago de impuestos";
            this.Load += new System.EventHandler(this.pagoImpuesto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetallePago)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnConexion;
        private System.Windows.Forms.ComboBox cmbContribuyente;
        private System.Windows.Forms.ComboBox cmbImpuesto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDetallePago;
        private System.Windows.Forms.TextBox txtIdDetallePago;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbConcepto;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAnio;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnLeer;
        private System.Windows.Forms.TextBox txtTasa;
    }
}