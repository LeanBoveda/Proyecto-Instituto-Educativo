namespace Proyecto_Instituto_Educativo_Ing_de_Software
{
    partial class frmProfesor
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
            this.btnBoletines = new System.Windows.Forms.Button();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.btnCargarNotas = new System.Windows.Forms.Button();
            this.panelContenido = new System.Windows.Forms.Panel();
            this.lblBienvenida = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panelContenido.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.btnBoletines);
            this.panel1.Controls.Add(this.btnCerrarSesion);
            this.panel1.Controls.Add(this.btnCargarNotas);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(180, 567);
            this.panel1.TabIndex = 1;
            // 
            // btnBoletines
            // 
            this.btnBoletines.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBoletines.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBoletines.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBoletines.ForeColor = System.Drawing.Color.White;
            this.btnBoletines.Location = new System.Drawing.Point(0, 49);
            this.btnBoletines.Name = "btnBoletines";
            this.btnBoletines.Size = new System.Drawing.Size(180, 49);
            this.btnBoletines.TabIndex = 13;
            this.btnBoletines.Text = "Boletines";
            this.btnBoletines.UseVisualStyleBackColor = true;
            this.btnBoletines.Click += new System.EventHandler(this.btnBoletines_Click);
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarSesion.ForeColor = System.Drawing.Color.White;
            this.btnCerrarSesion.Location = new System.Drawing.Point(0, 518);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(180, 49);
            this.btnCerrarSesion.TabIndex = 10;
            this.btnCerrarSesion.Text = "Cerrar Sesion";
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // btnCargarNotas
            // 
            this.btnCargarNotas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCargarNotas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargarNotas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarNotas.ForeColor = System.Drawing.Color.White;
            this.btnCargarNotas.Location = new System.Drawing.Point(0, 0);
            this.btnCargarNotas.Name = "btnCargarNotas";
            this.btnCargarNotas.Size = new System.Drawing.Size(180, 49);
            this.btnCargarNotas.TabIndex = 9;
            this.btnCargarNotas.Text = "CargarNotas";
            this.btnCargarNotas.UseVisualStyleBackColor = true;
            this.btnCargarNotas.Click += new System.EventHandler(this.btnCargarNotas_Click);
            // 
            // panelContenido
            // 
            this.panelContenido.Controls.Add(this.lblBienvenida);
            this.panelContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenido.Location = new System.Drawing.Point(180, 0);
            this.panelContenido.Name = "panelContenido";
            this.panelContenido.Size = new System.Drawing.Size(683, 567);
            this.panelContenido.TabIndex = 3;
            this.panelContenido.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContenido_Paint);
            // 
            // lblBienvenida
            // 
            this.lblBienvenida.AutoSize = true;
            this.lblBienvenida.Location = new System.Drawing.Point(30, 20);
            this.lblBienvenida.Name = "lblBienvenida";
            this.lblBienvenida.Size = new System.Drawing.Size(60, 13);
            this.lblBienvenida.TabIndex = 2;
            this.lblBienvenida.Text = "Bienvenido";
            // 
            // frmProfesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 567);
            this.Controls.Add(this.panelContenido);
            this.Controls.Add(this.panel1);
            this.Name = "frmProfesor";
            this.Text = "frmProfesor";
            this.Load += new System.EventHandler(this.frmPreceptor_Load);
            this.panel1.ResumeLayout(false);
            this.panelContenido.ResumeLayout(false);
            this.panelContenido.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Button btnCargarNotas;
        private System.Windows.Forms.Button btnBoletines;
        private System.Windows.Forms.Panel panelContenido;
        private System.Windows.Forms.Label lblBienvenida;
    }
}