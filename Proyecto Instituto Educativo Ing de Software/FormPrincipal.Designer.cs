namespace Proyecto_Instituto_Educativo_Ing_de_Software
{
    partial class FormPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuSesion = new System.Windows.Forms.ToolStripMenuItem();
            this.menuIniciarSesion = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCerrarSesion = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCambiarContraseña = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCambiarIdioma = new System.Windows.Forms.ToolStripMenuItem();
            this.españolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inglesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.portuguesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.titulo = new System.Windows.Forms.Label();
            this.btnsalir = new System.Windows.Forms.Button();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.gp_iniciarSesion = new System.Windows.Forms.GroupBox();
            this.btnCambiarContraseña = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.titulo2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.gp_iniciarSesion.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSesion,
            this.menuCambiarIdioma});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1086, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuSesion
            // 
            this.menuSesion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuIniciarSesion,
            this.menuCerrarSesion,
            this.menuCambiarContraseña});
            this.menuSesion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuSesion.Name = "menuSesion";
            this.menuSesion.Size = new System.Drawing.Size(68, 25);
            this.menuSesion.Text = "Sesion";
            // 
            // menuIniciarSesion
            // 
            this.menuIniciarSesion.Name = "menuIniciarSesion";
            this.menuIniciarSesion.Size = new System.Drawing.Size(218, 26);
            this.menuIniciarSesion.Text = "Iniciar Sesion";
            this.menuIniciarSesion.Click += new System.EventHandler(this.IniciarSesion_Click);
            // 
            // menuCerrarSesion
            // 
            this.menuCerrarSesion.Name = "menuCerrarSesion";
            this.menuCerrarSesion.Size = new System.Drawing.Size(218, 26);
            this.menuCerrarSesion.Text = "Cerrar Sesion";
            this.menuCerrarSesion.Click += new System.EventHandler(this.CerrarSesion_Click);
            // 
            // menuCambiarContraseña
            // 
            this.menuCambiarContraseña.Name = "menuCambiarContraseña";
            this.menuCambiarContraseña.Size = new System.Drawing.Size(218, 26);
            this.menuCambiarContraseña.Text = "CambiarContraseña";
            this.menuCambiarContraseña.Click += new System.EventHandler(this.cambiarContraseñaToolStripMenuItem_Click);
            // 
            // menuCambiarIdioma
            // 
            this.menuCambiarIdioma.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.españolToolStripMenuItem,
            this.inglesToolStripMenuItem,
            this.portuguesToolStripMenuItem});
            this.menuCambiarIdioma.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.menuCambiarIdioma.Name = "menuCambiarIdioma";
            this.menuCambiarIdioma.Size = new System.Drawing.Size(133, 25);
            this.menuCambiarIdioma.Text = "Cambiar Idioma";
            // 
            // españolToolStripMenuItem
            // 
            this.españolToolStripMenuItem.Name = "españolToolStripMenuItem";
            this.españolToolStripMenuItem.Size = new System.Drawing.Size(150, 26);
            this.españolToolStripMenuItem.Text = "Español";
            this.españolToolStripMenuItem.Click += new System.EventHandler(this.españolToolStripMenuItem_Click);
            // 
            // inglesToolStripMenuItem
            // 
            this.inglesToolStripMenuItem.Name = "inglesToolStripMenuItem";
            this.inglesToolStripMenuItem.Size = new System.Drawing.Size(150, 26);
            this.inglesToolStripMenuItem.Text = "Ingles";
            this.inglesToolStripMenuItem.Click += new System.EventHandler(this.inglesToolStripMenuItem_Click);
            // 
            // portuguesToolStripMenuItem
            // 
            this.portuguesToolStripMenuItem.Name = "portuguesToolStripMenuItem";
            this.portuguesToolStripMenuItem.Size = new System.Drawing.Size(150, 26);
            this.portuguesToolStripMenuItem.Text = "Portugues";
            this.portuguesToolStripMenuItem.Click += new System.EventHandler(this.portuguesToolStripMenuItem_Click);
            // 
            // titulo
            // 
            this.titulo.AutoSize = true;
            this.titulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(138)))));
            this.titulo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.titulo.Location = new System.Drawing.Point(255, 60);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(407, 75);
            this.titulo.TabIndex = 2;
            this.titulo.Text = "CampusSec";
            // 
            // btnsalir
            // 
            this.btnsalir.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnsalir.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalir.Location = new System.Drawing.Point(177, 181);
            this.btnsalir.Margin = new System.Windows.Forms.Padding(2);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(102, 47);
            this.btnsalir.TabIndex = 20;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(42, 55);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(160, 29);
            this.txtUsuario.TabIndex = 16;
            this.txtUsuario.Text = "admin";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(89, 33);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(64, 20);
            this.lblUsuario.TabIndex = 21;
            this.lblUsuario.Text = "Usuario";
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(42, 128);
            this.txtContraseña.Margin = new System.Windows.Forms.Padding(2);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '*';
            this.txtContraseña.Size = new System.Drawing.Size(160, 29);
            this.txtContraseña.TabIndex = 17;
            this.txtContraseña.Text = "123456";
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraseña.Location = new System.Drawing.Point(79, 106);
            this.lblContraseña.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(92, 20);
            this.lblContraseña.TabIndex = 18;
            this.lblContraseña.Text = "Contraseña";
            // 
            // btnIngresar
            // 
            this.btnIngresar.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnIngresar.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.Location = new System.Drawing.Point(42, 181);
            this.btnIngresar.Margin = new System.Windows.Forms.Padding(2);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(102, 47);
            this.btnIngresar.TabIndex = 19;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // gp_iniciarSesion
            // 
            this.gp_iniciarSesion.BackColor = System.Drawing.Color.Snow;
            this.gp_iniciarSesion.Controls.Add(this.btnCambiarContraseña);
            this.gp_iniciarSesion.Controls.Add(this.txtUsuario);
            this.gp_iniciarSesion.Controls.Add(this.btnsalir);
            this.gp_iniciarSesion.Controls.Add(this.btnIngresar);
            this.gp_iniciarSesion.Controls.Add(this.lblContraseña);
            this.gp_iniciarSesion.Controls.Add(this.lblUsuario);
            this.gp_iniciarSesion.Controls.Add(this.txtContraseña);
            this.gp_iniciarSesion.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gp_iniciarSesion.Location = new System.Drawing.Point(383, 195);
            this.gp_iniciarSesion.Name = "gp_iniciarSesion";
            this.gp_iniciarSesion.Size = new System.Drawing.Size(314, 307);
            this.gp_iniciarSesion.TabIndex = 22;
            this.gp_iniciarSesion.TabStop = false;
            this.gp_iniciarSesion.Text = "Iniciar Sesion";
            this.gp_iniciarSesion.Visible = false;
            // 
            // btnCambiarContraseña
            // 
            this.btnCambiarContraseña.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnCambiarContraseña.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCambiarContraseña.Location = new System.Drawing.Point(42, 246);
            this.btnCambiarContraseña.Margin = new System.Windows.Forms.Padding(2);
            this.btnCambiarContraseña.Name = "btnCambiarContraseña";
            this.btnCambiarContraseña.Size = new System.Drawing.Size(146, 33);
            this.btnCambiarContraseña.TabIndex = 22;
            this.btnCambiarContraseña.Text = "Olvide Contraseña";
            this.btnCambiarContraseña.UseVisualStyleBackColor = true;
            this.btnCambiarContraseña.Click += new System.EventHandler(this.btnCambiarContraseña_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox1.Controls.Add(this.titulo2);
            this.groupBox1.Controls.Add(this.titulo);
            this.groupBox1.Controls.Add(this.gp_iniciarSesion);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(0, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1482, 698);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            // 
            // titulo2
            // 
            this.titulo2.AutoSize = true;
            this.titulo2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.titulo2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(138)))));
            this.titulo2.Location = new System.Drawing.Point(657, 60);
            this.titulo2.Name = "titulo2";
            this.titulo2.Size = new System.Drawing.Size(128, 75);
            this.titulo2.TabIndex = 23;
            this.titulo2.Text = "1.0";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1086, 674);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormPrincipal";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gp_iniciarSesion.ResumeLayout(false);
            this.gp_iniciarSesion.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuSesion;
        private System.Windows.Forms.ToolStripMenuItem menuIniciarSesion;
        private System.Windows.Forms.ToolStripMenuItem menuCerrarSesion;
        private System.Windows.Forms.Label titulo;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.GroupBox gp_iniciarSesion;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label titulo2;
        private System.Windows.Forms.Button btnCambiarContraseña;
        private System.Windows.Forms.ToolStripMenuItem menuCambiarContraseña;
        private System.Windows.Forms.ToolStripMenuItem menuCambiarIdioma;
        private System.Windows.Forms.ToolStripMenuItem españolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inglesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem portuguesToolStripMenuItem;
    }
}

