namespace Proyecto_Instituto_Educativo_Ing_de_Software
{
    partial class frmCambiarContraseña
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
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblUsuarioCC = new System.Windows.Forms.Label();
            this.btnCambiarContraseñaCC = new System.Windows.Forms.Button();
            this.lblDNICC = new System.Windows.Forms.Label();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.lblNuevaClaveCC = new System.Windows.Forms.Label();
            this.txtNuevaClave = new System.Windows.Forms.TextBox();
            this.lblRepetirClaveCC = new System.Windows.Forms.Label();
            this.txtRepetirClave = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(95, 77);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtUsuario.TabIndex = 0;
            // 
            // lblUsuarioCC
            // 
            this.lblUsuarioCC.AutoSize = true;
            this.lblUsuarioCC.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarioCC.Location = new System.Drawing.Point(92, 61);
            this.lblUsuarioCC.Name = "lblUsuarioCC";
            this.lblUsuarioCC.Size = new System.Drawing.Size(53, 17);
            this.lblUsuarioCC.TabIndex = 1;
            this.lblUsuarioCC.Text = "Usuario";
            // 
            // btnCambiarContraseñaCC
            // 
            this.btnCambiarContraseñaCC.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCambiarContraseñaCC.Location = new System.Drawing.Point(80, 229);
            this.btnCambiarContraseñaCC.Name = "btnCambiarContraseñaCC";
            this.btnCambiarContraseñaCC.Size = new System.Drawing.Size(126, 49);
            this.btnCambiarContraseñaCC.TabIndex = 2;
            this.btnCambiarContraseñaCC.Text = "Cambiar";
            this.btnCambiarContraseñaCC.UseVisualStyleBackColor = true;
            this.btnCambiarContraseñaCC.Click += new System.EventHandler(this.btnCambiarContraseña_Click);
            // 
            // lblDNICC
            // 
            this.lblDNICC.AutoSize = true;
            this.lblDNICC.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDNICC.Location = new System.Drawing.Point(92, 100);
            this.lblDNICC.Name = "lblDNICC";
            this.lblDNICC.Size = new System.Drawing.Size(31, 17);
            this.lblDNICC.TabIndex = 4;
            this.lblDNICC.Text = "DNI";
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(95, 116);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(100, 20);
            this.txtDNI.TabIndex = 3;
            // 
            // lblNuevaClaveCC
            // 
            this.lblNuevaClaveCC.AutoSize = true;
            this.lblNuevaClaveCC.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNuevaClaveCC.Location = new System.Drawing.Point(92, 139);
            this.lblNuevaClaveCC.Name = "lblNuevaClaveCC";
            this.lblNuevaClaveCC.Size = new System.Drawing.Size(80, 17);
            this.lblNuevaClaveCC.TabIndex = 6;
            this.lblNuevaClaveCC.Text = "Nueva Clave";
            // 
            // txtNuevaClave
            // 
            this.txtNuevaClave.Location = new System.Drawing.Point(95, 155);
            this.txtNuevaClave.Name = "txtNuevaClave";
            this.txtNuevaClave.Size = new System.Drawing.Size(100, 20);
            this.txtNuevaClave.TabIndex = 5;
            // 
            // lblRepetirClaveCC
            // 
            this.lblRepetirClaveCC.AutoSize = true;
            this.lblRepetirClaveCC.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRepetirClaveCC.Location = new System.Drawing.Point(92, 178);
            this.lblRepetirClaveCC.Name = "lblRepetirClaveCC";
            this.lblRepetirClaveCC.Size = new System.Drawing.Size(85, 17);
            this.lblRepetirClaveCC.TabIndex = 8;
            this.lblRepetirClaveCC.Text = "Repetir Clave";
            // 
            // txtRepetirClave
            // 
            this.txtRepetirClave.Location = new System.Drawing.Point(95, 194);
            this.txtRepetirClave.Name = "txtRepetirClave";
            this.txtRepetirClave.Size = new System.Drawing.Size(100, 20);
            this.txtRepetirClave.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(34, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(243, 22);
            this.label5.TabIndex = 9;
            this.label5.Text = "RESTABLECER CONTRASEÑA";
            // 
            // frmCambiarContraseña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 308);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblRepetirClaveCC);
            this.Controls.Add(this.txtRepetirClave);
            this.Controls.Add(this.lblNuevaClaveCC);
            this.Controls.Add(this.txtNuevaClave);
            this.Controls.Add(this.lblDNICC);
            this.Controls.Add(this.txtDNI);
            this.Controls.Add(this.btnCambiarContraseñaCC);
            this.Controls.Add(this.lblUsuarioCC);
            this.Controls.Add(this.txtUsuario);
            this.Name = "frmCambiarContraseña";
            this.Text = "frmCambiarContraseña";
            this.Load += new System.EventHandler(this.frmCambiarContraseña_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblUsuarioCC;
        private System.Windows.Forms.Button btnCambiarContraseñaCC;
        private System.Windows.Forms.Label lblDNICC;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.Label lblNuevaClaveCC;
        private System.Windows.Forms.TextBox txtNuevaClave;
        private System.Windows.Forms.Label lblRepetirClaveCC;
        private System.Windows.Forms.TextBox txtRepetirClave;
        private System.Windows.Forms.Label label5;
    }
}