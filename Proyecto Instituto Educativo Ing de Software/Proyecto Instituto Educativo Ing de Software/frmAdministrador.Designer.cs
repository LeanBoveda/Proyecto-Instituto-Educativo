namespace Proyecto_Instituto_Educativo_Ing_de_Software
{
    partial class frmAdministrador
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnInscripciones = new System.Windows.Forms.Button();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.btnBitacora = new System.Windows.Forms.Button();
            this.btnCertificados = new System.Windows.Forms.Button();
            this.btnGestionAlumnos = new System.Windows.Forms.Button();
            this.btnGestionUsuarios = new System.Windows.Forms.Button();
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.btnInscripciones);
            this.panel1.Controls.Add(this.btnCerrarSesion);
            this.panel1.Controls.Add(this.btnBitacora);
            this.panel1.Controls.Add(this.btnCertificados);
            this.panel1.Controls.Add(this.btnGestionAlumnos);
            this.panel1.Controls.Add(this.btnGestionUsuarios);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(180, 504);
            this.panel1.TabIndex = 0;
            // 
            // btnInscripciones
            // 
            this.btnInscripciones.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInscripciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInscripciones.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInscripciones.ForeColor = System.Drawing.Color.White;
            this.btnInscripciones.Location = new System.Drawing.Point(0, 196);
            this.btnInscripciones.Name = "btnInscripciones";
            this.btnInscripciones.Size = new System.Drawing.Size(180, 49);
            this.btnInscripciones.TabIndex = 11;
            this.btnInscripciones.Text = "Inscripciones";
            this.btnInscripciones.UseVisualStyleBackColor = true;
            this.btnInscripciones.Click += new System.EventHandler(this.btnInscripciones_Click);
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarSesion.ForeColor = System.Drawing.Color.White;
            this.btnCerrarSesion.Location = new System.Drawing.Point(0, 455);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(180, 49);
            this.btnCerrarSesion.TabIndex = 10;
            this.btnCerrarSesion.Text = "Cerrar Sesion";
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // btnBitacora
            // 
            this.btnBitacora.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBitacora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBitacora.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBitacora.ForeColor = System.Drawing.Color.White;
            this.btnBitacora.Location = new System.Drawing.Point(0, 147);
            this.btnBitacora.Name = "btnBitacora";
            this.btnBitacora.Size = new System.Drawing.Size(180, 49);
            this.btnBitacora.TabIndex = 9;
            this.btnBitacora.Text = "Auditoria/Logs";
            this.btnBitacora.UseVisualStyleBackColor = true;
            this.btnBitacora.Click += new System.EventHandler(this.btnBitacora_Click);
            // 
            // btnCertificados
            // 
            this.btnCertificados.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCertificados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCertificados.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCertificados.ForeColor = System.Drawing.Color.White;
            this.btnCertificados.Location = new System.Drawing.Point(0, 98);
            this.btnCertificados.Name = "btnCertificados";
            this.btnCertificados.Size = new System.Drawing.Size(180, 49);
            this.btnCertificados.TabIndex = 8;
            this.btnCertificados.Text = "Certificados";
            this.btnCertificados.UseVisualStyleBackColor = true;
            this.btnCertificados.Click += new System.EventHandler(this.btnCertificados_Click);
            // 
            // btnGestionAlumnos
            // 
            this.btnGestionAlumnos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGestionAlumnos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestionAlumnos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionAlumnos.ForeColor = System.Drawing.Color.White;
            this.btnGestionAlumnos.Location = new System.Drawing.Point(0, 49);
            this.btnGestionAlumnos.Name = "btnGestionAlumnos";
            this.btnGestionAlumnos.Size = new System.Drawing.Size(180, 49);
            this.btnGestionAlumnos.TabIndex = 7;
            this.btnGestionAlumnos.Text = "Gestion Alumnos";
            this.btnGestionAlumnos.UseVisualStyleBackColor = true;
            this.btnGestionAlumnos.Click += new System.EventHandler(this.btnGestionAlumnos_Click);
            // 
            // btnGestionUsuarios
            // 
            this.btnGestionUsuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGestionUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestionUsuarios.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionUsuarios.ForeColor = System.Drawing.Color.White;
            this.btnGestionUsuarios.Location = new System.Drawing.Point(0, 0);
            this.btnGestionUsuarios.Name = "btnGestionUsuarios";
            this.btnGestionUsuarios.Size = new System.Drawing.Size(180, 49);
            this.btnGestionUsuarios.TabIndex = 6;
            this.btnGestionUsuarios.Text = "Gestion Usuarios";
            this.btnGestionUsuarios.UseVisualStyleBackColor = true;
            this.btnGestionUsuarios.Click += new System.EventHandler(this.btnGestionUsuarios_Click);
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPrincipal.Location = new System.Drawing.Point(180, 0);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(1139, 504);
            this.panelPrincipal.TabIndex = 1;
            // 
            // frmAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1319, 504);
            this.Controls.Add(this.panelPrincipal);
            this.Controls.Add(this.panel1);
            this.Name = "frmAdministrador";
            this.Text = "frmAdministrador";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCertificados;
        private System.Windows.Forms.Button btnGestionAlumnos;
        private System.Windows.Forms.Button btnGestionUsuarios;
        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.Button btnBitacora;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Button btnInscripciones;
    }
}