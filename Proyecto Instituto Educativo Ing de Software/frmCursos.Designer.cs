namespace Proyecto_Instituto_Educativo_Ing_de_Software
{
    partial class frmCursos
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
            this.btnModificarCurso = new System.Windows.Forms.Button();
            this.txtDivision = new System.Windows.Forms.TextBox();
            this.lblDivisionC = new System.Windows.Forms.Label();
            this.txtAño = new System.Windows.Forms.TextBox();
            this.btnAgregarCurso = new System.Windows.Forms.Button();
            this.btnEliminarCurso = new System.Windows.Forms.Button();
            this.lblAnoC = new System.Windows.Forms.Label();
            this.dgvCurso = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurso)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnModificarCurso);
            this.groupBox1.Controls.Add(this.txtDivision);
            this.groupBox1.Controls.Add(this.lblDivisionC);
            this.groupBox1.Controls.Add(this.txtAño);
            this.groupBox1.Controls.Add(this.btnAgregarCurso);
            this.groupBox1.Controls.Add(this.btnEliminarCurso);
            this.groupBox1.Controls.Add(this.lblAnoC);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(29, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(282, 191);
            this.groupBox1.TabIndex = 69;
            this.groupBox1.TabStop = false;
            // 
            // btnModificarCurso
            // 
            this.btnModificarCurso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarCurso.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarCurso.ForeColor = System.Drawing.Color.Gray;
            this.btnModificarCurso.Location = new System.Drawing.Point(99, 136);
            this.btnModificarCurso.Name = "btnModificarCurso";
            this.btnModificarCurso.Size = new System.Drawing.Size(93, 32);
            this.btnModificarCurso.TabIndex = 68;
            this.btnModificarCurso.Text = "Modificar";
            this.btnModificarCurso.UseVisualStyleBackColor = true;
            this.btnModificarCurso.Click += new System.EventHandler(this.btnModificarCurso_Click);
            // 
            // txtDivision
            // 
            this.txtDivision.Location = new System.Drawing.Point(124, 87);
            this.txtDivision.Name = "txtDivision";
            this.txtDivision.Size = new System.Drawing.Size(100, 28);
            this.txtDivision.TabIndex = 67;
            // 
            // lblDivisionC
            // 
            this.lblDivisionC.AutoSize = true;
            this.lblDivisionC.Location = new System.Drawing.Point(53, 87);
            this.lblDivisionC.Name = "lblDivisionC";
            this.lblDivisionC.Size = new System.Drawing.Size(69, 21);
            this.lblDivisionC.TabIndex = 66;
            this.lblDivisionC.Text = "Division";
            // 
            // txtAño
            // 
            this.txtAño.Location = new System.Drawing.Point(124, 37);
            this.txtAño.MaxLength = 1;
            this.txtAño.Name = "txtAño";
            this.txtAño.Size = new System.Drawing.Size(100, 28);
            this.txtAño.TabIndex = 46;
            // 
            // btnAgregarCurso
            // 
            this.btnAgregarCurso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarCurso.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarCurso.ForeColor = System.Drawing.Color.Gray;
            this.btnAgregarCurso.Location = new System.Drawing.Point(15, 136);
            this.btnAgregarCurso.Name = "btnAgregarCurso";
            this.btnAgregarCurso.Size = new System.Drawing.Size(93, 32);
            this.btnAgregarCurso.TabIndex = 44;
            this.btnAgregarCurso.Text = "Cargar";
            this.btnAgregarCurso.UseVisualStyleBackColor = true;
            this.btnAgregarCurso.Click += new System.EventHandler(this.btnAgregarCurso_Click);
            // 
            // btnEliminarCurso
            // 
            this.btnEliminarCurso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarCurso.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarCurso.ForeColor = System.Drawing.Color.Gray;
            this.btnEliminarCurso.Location = new System.Drawing.Point(187, 136);
            this.btnEliminarCurso.Name = "btnEliminarCurso";
            this.btnEliminarCurso.Size = new System.Drawing.Size(78, 32);
            this.btnEliminarCurso.TabIndex = 61;
            this.btnEliminarCurso.Text = "Eliminar";
            this.btnEliminarCurso.UseVisualStyleBackColor = true;
            this.btnEliminarCurso.Click += new System.EventHandler(this.btnEliminarCurso_Click);
            // 
            // lblAnoC
            // 
            this.lblAnoC.AutoSize = true;
            this.lblAnoC.Location = new System.Drawing.Point(53, 40);
            this.lblAnoC.Name = "lblAnoC";
            this.lblAnoC.Size = new System.Drawing.Size(41, 21);
            this.lblAnoC.TabIndex = 45;
            this.lblAnoC.Text = "Año";
            // 
            // dgvCurso
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCurso.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCurso.BackgroundColor = System.Drawing.Color.White;
            this.dgvCurso.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCurso.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCurso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCurso.EnableHeadersVisualStyles = false;
            this.dgvCurso.GridColor = System.Drawing.Color.LightGray;
            this.dgvCurso.Location = new System.Drawing.Point(317, 65);
            this.dgvCurso.Name = "dgvCurso";
            this.dgvCurso.Size = new System.Drawing.Size(247, 180);
            this.dgvCurso.TabIndex = 69;
            // 
            // frmCursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 334);
            this.Controls.Add(this.dgvCurso);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmCursos";
            this.Text = "frmCursos";
            this.Load += new System.EventHandler(this.frmCursos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurso)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDivision;
        private System.Windows.Forms.Label lblDivisionC;
        private System.Windows.Forms.TextBox txtAño;
        private System.Windows.Forms.Button btnAgregarCurso;
        private System.Windows.Forms.Button btnEliminarCurso;
        private System.Windows.Forms.Label lblAnoC;
        private System.Windows.Forms.Button btnModificarCurso;
        private System.Windows.Forms.DataGridView dgvCurso;
    }
}