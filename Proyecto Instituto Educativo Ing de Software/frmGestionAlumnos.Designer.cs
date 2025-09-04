namespace Proyecto_Instituto_Educativo_Ing_de_Software
{
    partial class frmGestionAlumnos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblTelefonoGA = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblDireccionGA = new System.Windows.Forms.Label();
            this.dtpNacimiento = new System.Windows.Forms.DateTimePicker();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnModificarGA = new System.Windows.Forms.Button();
            this.btnAgregarAlumnoGA = new System.Windows.Forms.Button();
            this.btnEliminarGA = new System.Windows.Forms.Button();
            this.lblNombreGA = new System.Windows.Forms.Label();
            this.lblApellidoGA = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.lblDniGA = new System.Windows.Forms.Label();
            this.dgvAlumnos = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscarDNI = new System.Windows.Forms.TextBox();
            this.lblBuscarDniGA = new System.Windows.Forms.Label();
            this.btnRestablecer = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTelefono);
            this.groupBox1.Controls.Add(this.lblTelefonoGA);
            this.groupBox1.Controls.Add(this.txtDireccion);
            this.groupBox1.Controls.Add(this.lblDireccionGA);
            this.groupBox1.Controls.Add(this.dtpNacimiento);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.btnModificarGA);
            this.groupBox1.Controls.Add(this.btnAgregarAlumnoGA);
            this.groupBox1.Controls.Add(this.btnEliminarGA);
            this.groupBox1.Controls.Add(this.lblNombreGA);
            this.groupBox1.Controls.Add(this.lblApellidoGA);
            this.groupBox1.Controls.Add(this.txtApellido);
            this.groupBox1.Controls.Add(this.txtDNI);
            this.groupBox1.Controls.Add(this.lblDniGA);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(31, 111);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(283, 312);
            this.groupBox1.TabIndex = 67;
            this.groupBox1.TabStop = false;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(106, 201);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(100, 28);
            this.txtTelefono.TabIndex = 67;
            // 
            // lblTelefonoGA
            // 
            this.lblTelefonoGA.AutoSize = true;
            this.lblTelefonoGA.Location = new System.Drawing.Point(27, 204);
            this.lblTelefonoGA.Name = "lblTelefonoGA";
            this.lblTelefonoGA.Size = new System.Drawing.Size(77, 21);
            this.lblTelefonoGA.TabIndex = 66;
            this.lblTelefonoGA.Text = "Telefono";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(106, 167);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(100, 28);
            this.txtDireccion.TabIndex = 65;
            // 
            // lblDireccionGA
            // 
            this.lblDireccionGA.AutoSize = true;
            this.lblDireccionGA.Location = new System.Drawing.Point(27, 170);
            this.lblDireccionGA.Name = "lblDireccionGA";
            this.lblDireccionGA.Size = new System.Drawing.Size(81, 21);
            this.lblDireccionGA.TabIndex = 64;
            this.lblDireccionGA.Text = "Direccion";
            // 
            // dtpNacimiento
            // 
            this.dtpNacimiento.Location = new System.Drawing.Point(30, 133);
            this.dtpNacimiento.Name = "dtpNacimiento";
            this.dtpNacimiento.Size = new System.Drawing.Size(200, 28);
            this.dtpNacimiento.TabIndex = 63;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(106, 31);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 28);
            this.txtNombre.TabIndex = 46;
            // 
            // btnModificarGA
            // 
            this.btnModificarGA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarGA.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarGA.ForeColor = System.Drawing.Color.Gray;
            this.btnModificarGA.Location = new System.Drawing.Point(98, 258);
            this.btnModificarGA.Name = "btnModificarGA";
            this.btnModificarGA.Size = new System.Drawing.Size(93, 32);
            this.btnModificarGA.TabIndex = 62;
            this.btnModificarGA.Text = "Modificar";
            this.btnModificarGA.UseVisualStyleBackColor = true;
            this.btnModificarGA.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAgregarAlumnoGA
            // 
            this.btnAgregarAlumnoGA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarAlumnoGA.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarAlumnoGA.ForeColor = System.Drawing.Color.Gray;
            this.btnAgregarAlumnoGA.Location = new System.Drawing.Point(6, 258);
            this.btnAgregarAlumnoGA.Name = "btnAgregarAlumnoGA";
            this.btnAgregarAlumnoGA.Size = new System.Drawing.Size(93, 32);
            this.btnAgregarAlumnoGA.TabIndex = 44;
            this.btnAgregarAlumnoGA.Text = "Cargar";
            this.btnAgregarAlumnoGA.UseVisualStyleBackColor = true;
            this.btnAgregarAlumnoGA.Click += new System.EventHandler(this.btnAgregarAlumno_Click);
            // 
            // btnEliminarGA
            // 
            this.btnEliminarGA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarGA.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarGA.ForeColor = System.Drawing.Color.Gray;
            this.btnEliminarGA.Location = new System.Drawing.Point(188, 258);
            this.btnEliminarGA.Name = "btnEliminarGA";
            this.btnEliminarGA.Size = new System.Drawing.Size(78, 32);
            this.btnEliminarGA.TabIndex = 61;
            this.btnEliminarGA.Text = "Eliminar";
            this.btnEliminarGA.UseVisualStyleBackColor = true;
            this.btnEliminarGA.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblNombreGA
            // 
            this.lblNombreGA.AutoSize = true;
            this.lblNombreGA.Location = new System.Drawing.Point(27, 34);
            this.lblNombreGA.Name = "lblNombreGA";
            this.lblNombreGA.Size = new System.Drawing.Size(73, 21);
            this.lblNombreGA.TabIndex = 45;
            this.lblNombreGA.Text = "Nombre";
            // 
            // lblApellidoGA
            // 
            this.lblApellidoGA.AutoSize = true;
            this.lblApellidoGA.Location = new System.Drawing.Point(26, 68);
            this.lblApellidoGA.Name = "lblApellidoGA";
            this.lblApellidoGA.Size = new System.Drawing.Size(72, 21);
            this.lblApellidoGA.TabIndex = 47;
            this.lblApellidoGA.Text = "Apellido";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(106, 65);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 28);
            this.txtApellido.TabIndex = 48;
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(106, 99);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(100, 28);
            this.txtDNI.TabIndex = 55;
            // 
            // lblDniGA
            // 
            this.lblDniGA.AutoSize = true;
            this.lblDniGA.Location = new System.Drawing.Point(27, 102);
            this.lblDniGA.Name = "lblDniGA";
            this.lblDniGA.Size = new System.Drawing.Size(40, 21);
            this.lblDniGA.TabIndex = 54;
            this.lblDniGA.Text = "DNI";
            // 
            // dgvAlumnos
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvAlumnos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAlumnos.BackgroundColor = System.Drawing.Color.White;
            this.dgvAlumnos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAlumnos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlumnos.EnableHeadersVisualStyles = false;
            this.dgvAlumnos.GridColor = System.Drawing.Color.LightGray;
            this.dgvAlumnos.Location = new System.Drawing.Point(329, 111);
            this.dgvAlumnos.Name = "dgvAlumnos";
            this.dgvAlumnos.ReadOnly = true;
            this.dgvAlumnos.Size = new System.Drawing.Size(641, 290);
            this.dgvAlumnos.TabIndex = 66;
            this.dgvAlumnos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAlumnos_CellClick);
            this.dgvAlumnos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAlumnos_CellContentClick);
            // 
            // btnBuscar
            // 
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.Gray;
            this.btnBuscar.Location = new System.Drawing.Point(520, 407);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(93, 32);
            this.btnBuscar.TabIndex = 68;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBuscarDNI
            // 
            this.txtBuscarDNI.Location = new System.Drawing.Point(414, 413);
            this.txtBuscarDNI.Name = "txtBuscarDNI";
            this.txtBuscarDNI.Size = new System.Drawing.Size(100, 20);
            this.txtBuscarDNI.TabIndex = 68;
            // 
            // lblBuscarDniGA
            // 
            this.lblBuscarDniGA.AutoSize = true;
            this.lblBuscarDniGA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarDniGA.Location = new System.Drawing.Point(320, 413);
            this.lblBuscarDniGA.Name = "lblBuscarDniGA";
            this.lblBuscarDniGA.Size = new System.Drawing.Size(91, 20);
            this.lblBuscarDniGA.TabIndex = 68;
            this.lblBuscarDniGA.Text = "Buscar DNI";
            // 
            // btnRestablecer
            // 
            this.btnRestablecer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestablecer.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestablecer.ForeColor = System.Drawing.Color.Gray;
            this.btnRestablecer.Location = new System.Drawing.Point(629, 407);
            this.btnRestablecer.Name = "btnRestablecer";
            this.btnRestablecer.Size = new System.Drawing.Size(106, 32);
            this.btnRestablecer.TabIndex = 69;
            this.btnRestablecer.Text = "Restablecer";
            this.btnRestablecer.UseVisualStyleBackColor = true;
            this.btnRestablecer.Click += new System.EventHandler(this.btnRestablecer_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(34, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(431, 59);
            this.label5.TabIndex = 70;
            this.label5.Text = "Gestion Alumnos";
            // 
            // frmGestionAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1263, 546);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnRestablecer);
            this.Controls.Add(this.lblBuscarDniGA);
            this.Controls.Add(this.txtBuscarDNI);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvAlumnos);
            this.Name = "frmGestionAlumnos";
            this.Text = "frmGestionAlumnos";
            this.Load += new System.EventHandler(this.frmGestionAlumnos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblTelefonoGA;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblDireccionGA;
        private System.Windows.Forms.DateTimePicker dtpNacimiento;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnModificarGA;
        private System.Windows.Forms.Button btnAgregarAlumnoGA;
        private System.Windows.Forms.Button btnEliminarGA;
        private System.Windows.Forms.Label lblNombreGA;
        private System.Windows.Forms.Label lblApellidoGA;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.Label lblDniGA;
        private System.Windows.Forms.DataGridView dgvAlumnos;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscarDNI;
        private System.Windows.Forms.Label lblBuscarDniGA;
        private System.Windows.Forms.Button btnRestablecer;
        private System.Windows.Forms.Label label5;
    }
}