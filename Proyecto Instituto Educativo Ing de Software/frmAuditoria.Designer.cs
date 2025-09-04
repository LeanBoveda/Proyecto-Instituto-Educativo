namespace Proyecto_Instituto_Educativo_Ing_de_Software
{
    partial class frmAuditoria
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
            this.dgvBitacora = new System.Windows.Forms.DataGridView();
            this.txtUsuarioNombre = new System.Windows.Forms.TextBox();
            this.txtUsuarioApellido = new System.Windows.Forms.TextBox();
            this.dgvAuditoriaCambios = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBitacora)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuditoriaCambios)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBitacora
            // 
            this.dgvBitacora.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvBitacora.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvBitacora.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBitacora.Location = new System.Drawing.Point(47, 12);
            this.dgvBitacora.Name = "dgvBitacora";
            this.dgvBitacora.Size = new System.Drawing.Size(701, 223);
            this.dgvBitacora.TabIndex = 0;
            this.dgvBitacora.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAuditoria_CellClick);
            this.dgvBitacora.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAuditoria_CellContentClick);
            // 
            // txtUsuarioNombre
            // 
            this.txtUsuarioNombre.Location = new System.Drawing.Point(47, 241);
            this.txtUsuarioNombre.Name = "txtUsuarioNombre";
            this.txtUsuarioNombre.Size = new System.Drawing.Size(100, 20);
            this.txtUsuarioNombre.TabIndex = 1;
            // 
            // txtUsuarioApellido
            // 
            this.txtUsuarioApellido.Location = new System.Drawing.Point(165, 241);
            this.txtUsuarioApellido.Name = "txtUsuarioApellido";
            this.txtUsuarioApellido.Size = new System.Drawing.Size(100, 20);
            this.txtUsuarioApellido.TabIndex = 2;
            // 
            // dgvAuditoriaCambios
            // 
            this.dgvAuditoriaCambios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvAuditoriaCambios.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvAuditoriaCambios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAuditoriaCambios.Location = new System.Drawing.Point(47, 284);
            this.dgvAuditoriaCambios.Name = "dgvAuditoriaCambios";
            this.dgvAuditoriaCambios.Size = new System.Drawing.Size(701, 223);
            this.dgvAuditoriaCambios.TabIndex = 3;
            // 
            // frmAuditoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 520);
            this.Controls.Add(this.dgvAuditoriaCambios);
            this.Controls.Add(this.txtUsuarioApellido);
            this.Controls.Add(this.txtUsuarioNombre);
            this.Controls.Add(this.dgvBitacora);
            this.Name = "frmAuditoria";
            this.Text = "frmAuditoria";
            this.Load += new System.EventHandler(this.frmAuditoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBitacora)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuditoriaCambios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBitacora;
        private System.Windows.Forms.TextBox txtUsuarioNombre;
        private System.Windows.Forms.TextBox txtUsuarioApellido;
        private System.Windows.Forms.DataGridView dgvAuditoriaCambios;
    }
}