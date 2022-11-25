
namespace Clave5_Grupo10
{
    partial class datosContribuyente
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
            this.dgvContribuyentes = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.cmbPais = new System.Windows.Forms.ComboBox();
            this.txtIDcontribuyente = new System.Windows.Forms.TextBox();
            this.btnConexion = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnLeer = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.txtDUI = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContribuyentes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvContribuyentes
            // 
            this.dgvContribuyentes.AllowUserToAddRows = false;
            this.dgvContribuyentes.AllowUserToDeleteRows = false;
            this.dgvContribuyentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContribuyentes.Location = new System.Drawing.Point(36, 325);
            this.dgvContribuyentes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvContribuyentes.Name = "dgvContribuyentes";
            this.dgvContribuyentes.ReadOnly = true;
            this.dgvContribuyentes.RowHeadersWidth = 51;
            this.dgvContribuyentes.Size = new System.Drawing.Size(884, 202);
            this.dgvContribuyentes.TabIndex = 0;
            this.dgvContribuyentes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvContribuyentes_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 98);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "DUI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 145);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombres";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 188);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Apellidos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 228);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Fecha de Nacimiento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 283);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "País";
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(253, 137);
            this.txtNombres.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(265, 22);
            this.txtNombres.TabIndex = 7;
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(253, 180);
            this.txtApellidos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(265, 22);
            this.txtApellidos.TabIndex = 8;
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(253, 220);
            this.dtpFechaNacimiento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(265, 22);
            this.dtpFechaNacimiento.TabIndex = 9;
            // 
            // cmbPais
            // 
            this.cmbPais.FormattingEnabled = true;
            this.cmbPais.Location = new System.Drawing.Point(257, 273);
            this.cmbPais.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbPais.Name = "cmbPais";
            this.cmbPais.Size = new System.Drawing.Size(261, 24);
            this.cmbPais.TabIndex = 11;
            // 
            // txtIDcontribuyente
            // 
            this.txtIDcontribuyente.Location = new System.Drawing.Point(253, 30);
            this.txtIDcontribuyente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIDcontribuyente.Name = "txtIDcontribuyente";
            this.txtIDcontribuyente.Size = new System.Drawing.Size(265, 22);
            this.txtIDcontribuyente.TabIndex = 12;
            this.txtIDcontribuyente.Visible = false;
            // 
            // btnConexion
            // 
            this.btnConexion.BackColor = System.Drawing.Color.LimeGreen;
            this.btnConexion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConexion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnConexion.Location = new System.Drawing.Point(665, 20);
            this.btnConexion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnConexion.Name = "btnConexion";
            this.btnConexion.Size = new System.Drawing.Size(255, 42);
            this.btnConexion.TabIndex = 13;
            this.btnConexion.Text = "Comprobar Conexión";
            this.btnConexion.UseVisualStyleBackColor = false;
            this.btnConexion.Click += new System.EventHandler(this.btnConexion_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAgregar.Location = new System.Drawing.Point(665, 81);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(100, 36);
            this.btnAgregar.TabIndex = 14;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnLeer
            // 
            this.btnLeer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeer.Location = new System.Drawing.Point(665, 139);
            this.btnLeer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLeer.Name = "btnLeer";
            this.btnLeer.Size = new System.Drawing.Size(100, 34);
            this.btnLeer.TabIndex = 15;
            this.btnLeer.Text = "Leer";
            this.btnLeer.UseVisualStyleBackColor = true;
            this.btnLeer.Click += new System.EventHandler(this.btnLeer_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(820, 137);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(100, 37);
            this.btnEliminar.TabIndex = 16;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnActualizar.Location = new System.Drawing.Point(820, 81);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(100, 37);
            this.btnActualizar.TabIndex = 17;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Crimson;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSalir.Location = new System.Drawing.Point(665, 244);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(255, 42);
            this.btnSalir.TabIndex = 18;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.Location = new System.Drawing.Point(665, 188);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(255, 37);
            this.btnRegresar.TabIndex = 19;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // txtDUI
            // 
            this.txtDUI.Location = new System.Drawing.Point(256, 90);
            this.txtDUI.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDUI.Name = "txtDUI";
            this.txtDUI.Size = new System.Drawing.Size(263, 22);
            this.txtDUI.TabIndex = 20;
            // 
            // datosContribuyente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 544);
            this.Controls.Add(this.txtDUI);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnLeer);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnConexion);
            this.Controls.Add(this.txtIDcontribuyente);
            this.Controls.Add(this.cmbPais);
            this.Controls.Add(this.dtpFechaNacimiento);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.txtNombres);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvContribuyentes);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "datosContribuyente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Datos del Contribuyente";
            this.Load += new System.EventHandler(this.datosContribuyente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContribuyentes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvContribuyentes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.ComboBox cmbPais;
        private System.Windows.Forms.TextBox txtIDcontribuyente;
        private System.Windows.Forms.Button btnConexion;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnLeer;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.TextBox txtDUI;
    }
}