namespace EscuelaFutbol
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtAlumnoID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnGuardarAlu = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.dtpFechaNaci = new System.Windows.Forms.DateTimePicker();
            this.txtPprincipal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPespecifico = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.cboPuestoPrincipal = new System.Windows.Forms.ComboBox();
            this.cboPuestoEspecifico = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAlumnoID
            // 
            this.txtAlumnoID.Location = new System.Drawing.Point(194, 10);
            this.txtAlumnoID.Name = "txtAlumnoID";
            this.txtAlumnoID.Size = new System.Drawing.Size(100, 20);
            this.txtAlumnoID.TabIndex = 18;
            this.txtAlumnoID.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombres";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellidos";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "DNI";
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(194, 40);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(181, 20);
            this.txtNombres.TabIndex = 3;
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(194, 72);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(181, 20);
            this.txtApellidos.TabIndex = 4;
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(194, 105);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(181, 20);
            this.txtDNI.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(416, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(417, 226);
            this.dataGridView1.TabIndex = 6;
            // 
            // btnGuardarAlu
            // 
            this.btnGuardarAlu.Location = new System.Drawing.Point(81, 300);
            this.btnGuardarAlu.Name = "btnGuardarAlu";
            this.btnGuardarAlu.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarAlu.TabIndex = 7;
            this.btnGuardarAlu.Text = "Guardar";
            this.btnGuardarAlu.UseVisualStyleBackColor = true;
            this.btnGuardarAlu.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Fecha de Nacimiento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(62, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Categoria";
            // 
            // txtCategoria
            // 
            this.txtCategoria.Location = new System.Drawing.Point(194, 172);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(181, 20);
            this.txtCategoria.TabIndex = 11;
            // 
            // dtpFechaNaci
            // 
            this.dtpFechaNaci.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaNaci.Location = new System.Drawing.Point(194, 140);
            this.dtpFechaNaci.Name = "dtpFechaNaci";
            this.dtpFechaNaci.Size = new System.Drawing.Size(124, 20);
            this.dtpFechaNaci.TabIndex = 12;
            // 
            // txtPprincipal
            // 
            this.txtPprincipal.Location = new System.Drawing.Point(194, 209);
            this.txtPprincipal.Name = "txtPprincipal";
            this.txtPprincipal.Size = new System.Drawing.Size(181, 20);
            this.txtPprincipal.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(62, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Puesto Principal";
            // 
            // txtPespecifico
            // 
            this.txtPespecifico.Location = new System.Drawing.Point(194, 246);
            this.txtPespecifico.Name = "txtPespecifico";
            this.txtPespecifico.Size = new System.Drawing.Size(181, 20);
            this.txtPespecifico.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(62, 249);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Puesto Específico";
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(194, 299);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 17;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(300, 299);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 19;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // cboCategoria
            // 
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Location = new System.Drawing.Point(401, 281);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(121, 21);
            this.cboCategoria.TabIndex = 20;
            // 
            // cboPuestoPrincipal
            // 
            this.cboPuestoPrincipal.FormattingEnabled = true;
            this.cboPuestoPrincipal.Location = new System.Drawing.Point(559, 281);
            this.cboPuestoPrincipal.Name = "cboPuestoPrincipal";
            this.cboPuestoPrincipal.Size = new System.Drawing.Size(121, 21);
            this.cboPuestoPrincipal.TabIndex = 21;
            // 
            // cboPuestoEspecifico
            // 
            this.cboPuestoEspecifico.FormattingEnabled = true;
            this.cboPuestoEspecifico.Location = new System.Drawing.Point(703, 281);
            this.cboPuestoEspecifico.Name = "cboPuestoEspecifico";
            this.cboPuestoEspecifico.Size = new System.Drawing.Size(121, 21);
            this.cboPuestoEspecifico.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 358);
            this.Controls.Add(this.cboPuestoEspecifico);
            this.Controls.Add(this.cboPuestoPrincipal);
            this.Controls.Add(this.cboCategoria);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.txtAlumnoID);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.txtPespecifico);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPprincipal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtpFechaNaci);
            this.Controls.Add(this.txtCategoria);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnGuardarAlu);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtDNI);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.txtNombres);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Registro de Alumno";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnGuardarAlu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.DateTimePicker dtpFechaNaci;
        private System.Windows.Forms.TextBox txtPprincipal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPespecifico;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.TextBox txtAlumnoID;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.ComboBox cboCategoria;
        private System.Windows.Forms.ComboBox cboPuestoPrincipal;
        private System.Windows.Forms.ComboBox cboPuestoEspecifico;
    }
}

