namespace CDVU
{
    partial class frmConsultaSocio
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grpConsultas = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbInscripcion = new System.Windows.Forms.ComboBox();
            this.btnDeudaSocio = new System.Windows.Forms.Button();
            this.btnInscripcionesPagadas = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBuscarSocio = new System.Windows.Forms.Button();
            this.txtBuscarSocio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lstSocios = new System.Windows.Forms.ListBox();
            this.grpDataGrid = new System.Windows.Forms.GroupBox();
            this.dgvResultado = new System.Windows.Forms.DataGridView();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.grpConsultas.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grpDataGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).BeginInit();
            this.SuspendLayout();
            // 
            // grpConsultas
            // 
            this.grpConsultas.Controls.Add(this.groupBox1);
            this.grpConsultas.Controls.Add(this.label2);
            this.grpConsultas.Controls.Add(this.btnBuscarSocio);
            this.grpConsultas.Controls.Add(this.txtBuscarSocio);
            this.grpConsultas.Controls.Add(this.label1);
            this.grpConsultas.Controls.Add(this.lstSocios);
            this.grpConsultas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpConsultas.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpConsultas.ForeColor = System.Drawing.Color.White;
            this.grpConsultas.Location = new System.Drawing.Point(35, 152);
            this.grpConsultas.Name = "grpConsultas";
            this.grpConsultas.Size = new System.Drawing.Size(810, 292);
            this.grpConsultas.TabIndex = 39;
            this.grpConsultas.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbInscripcion);
            this.groupBox1.Controls.Add(this.btnDeudaSocio);
            this.groupBox1.Controls.Add(this.btnInscripcionesPagadas);
            this.groupBox1.Controls.Add(this.label);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(395, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(395, 216);
            this.groupBox1.TabIndex = 62;
            this.groupBox1.TabStop = false;
            // 
            // cmbInscripcion
            // 
            this.cmbInscripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(129)))), ((int)(((byte)(5)))));
            this.cmbInscripcion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbInscripcion.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbInscripcion.ForeColor = System.Drawing.Color.White;
            this.cmbInscripcion.FormattingEnabled = true;
            this.cmbInscripcion.Location = new System.Drawing.Point(10, 75);
            this.cmbInscripcion.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbInscripcion.Name = "cmbInscripcion";
            this.cmbInscripcion.Size = new System.Drawing.Size(287, 22);
            this.cmbInscripcion.TabIndex = 57;
            // 
            // btnDeudaSocio
            // 
            this.btnDeudaSocio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(129)))), ((int)(((byte)(5)))));
            this.btnDeudaSocio.FlatAppearance.BorderSize = 0;
            this.btnDeudaSocio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeudaSocio.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeudaSocio.ForeColor = System.Drawing.Color.White;
            this.btnDeudaSocio.Location = new System.Drawing.Point(10, 119);
            this.btnDeudaSocio.Name = "btnDeudaSocio";
            this.btnDeudaSocio.Size = new System.Drawing.Size(375, 27);
            this.btnDeudaSocio.TabIndex = 52;
            this.btnDeudaSocio.Text = "Cuotas que debe el socio";
            this.btnDeudaSocio.UseVisualStyleBackColor = false;
            this.btnDeudaSocio.Click += new System.EventHandler(this.btnDeudaSocio_Click);
            // 
            // btnInscripcionesPagadas
            // 
            this.btnInscripcionesPagadas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(129)))), ((int)(((byte)(5)))));
            this.btnInscripcionesPagadas.FlatAppearance.BorderSize = 0;
            this.btnInscripcionesPagadas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInscripcionesPagadas.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInscripcionesPagadas.ForeColor = System.Drawing.Color.White;
            this.btnInscripcionesPagadas.Location = new System.Drawing.Point(10, 168);
            this.btnInscripcionesPagadas.Name = "btnInscripcionesPagadas";
            this.btnInscripcionesPagadas.Size = new System.Drawing.Size(375, 27);
            this.btnInscripcionesPagadas.TabIndex = 53;
            this.btnInscripcionesPagadas.Text = "Inscripciones pagadas";
            this.btnInscripcionesPagadas.UseVisualStyleBackColor = false;
            this.btnInscripcionesPagadas.Click += new System.EventHandler(this.btnInscripcionesPagadas_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.Color.White;
            this.label.Location = new System.Drawing.Point(7, 44);
            this.label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(157, 16);
            this.label.TabIndex = 56;
            this.label.Text = "Inscripciones del socio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(21, 105);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 51;
            // 
            // btnBuscarSocio
            // 
            this.btnBuscarSocio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(129)))), ((int)(((byte)(5)))));
            this.btnBuscarSocio.FlatAppearance.BorderSize = 0;
            this.btnBuscarSocio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarSocio.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarSocio.ForeColor = System.Drawing.Color.White;
            this.btnBuscarSocio.Location = new System.Drawing.Point(279, 59);
            this.btnBuscarSocio.Name = "btnBuscarSocio";
            this.btnBuscarSocio.Size = new System.Drawing.Size(88, 27);
            this.btnBuscarSocio.TabIndex = 49;
            this.btnBuscarSocio.Text = "Buscar";
            this.btnBuscarSocio.UseVisualStyleBackColor = false;
            this.btnBuscarSocio.Click += new System.EventHandler(this.btnBuscarSocio_Click);
            this.btnBuscarSocio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnBuscarSocio_KeyPress);
            // 
            // txtBuscarSocio
            // 
            this.txtBuscarSocio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(129)))), ((int)(((byte)(5)))));
            this.txtBuscarSocio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscarSocio.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBuscarSocio.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarSocio.ForeColor = System.Drawing.Color.White;
            this.txtBuscarSocio.Location = new System.Drawing.Point(29, 59);
            this.txtBuscarSocio.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtBuscarSocio.Name = "txtBuscarSocio";
            this.txtBuscarSocio.Size = new System.Drawing.Size(216, 27);
            this.txtBuscarSocio.TabIndex = 48;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(25, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 16);
            this.label1.TabIndex = 47;
            this.label1.Text = "Buscar socio por DNI ó N° de socio";
            // 
            // lstSocios
            // 
            this.lstSocios.BackColor = System.Drawing.Color.DimGray;
            this.lstSocios.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lstSocios.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstSocios.ForeColor = System.Drawing.Color.White;
            this.lstSocios.FormattingEnabled = true;
            this.lstSocios.ItemHeight = 14;
            this.lstSocios.Location = new System.Drawing.Point(28, 103);
            this.lstSocios.Name = "lstSocios";
            this.lstSocios.Size = new System.Drawing.Size(339, 172);
            this.lstSocios.TabIndex = 46;
            this.lstSocios.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lstSocios_DrawItem);
            this.lstSocios.SelectedIndexChanged += new System.EventHandler(this.lstSocios_SelectedIndexChanged);
            // 
            // grpDataGrid
            // 
            this.grpDataGrid.Controls.Add(this.dgvResultado);
            this.grpDataGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpDataGrid.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDataGrid.ForeColor = System.Drawing.Color.White;
            this.grpDataGrid.Location = new System.Drawing.Point(35, 471);
            this.grpDataGrid.Name = "grpDataGrid";
            this.grpDataGrid.Size = new System.Drawing.Size(1090, 364);
            this.grpDataGrid.TabIndex = 38;
            this.grpDataGrid.TabStop = false;
            this.grpDataGrid.Text = "Resultados de la consulta";
            // 
            // dgvResultado
            // 
            this.dgvResultado.AllowUserToAddRows = false;
            this.dgvResultado.AllowUserToDeleteRows = false;
            this.dgvResultado.AllowUserToResizeColumns = false;
            this.dgvResultado.AllowUserToResizeRows = false;
            this.dgvResultado.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dgvResultado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvResultado.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvResultado.BackgroundColor = System.Drawing.Color.DimGray;
            this.dgvResultado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.NullValue = "-";
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(129)))), ((int)(((byte)(5)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvResultado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvResultado.Location = new System.Drawing.Point(40, 25);
            this.dgvResultado.Name = "dgvResultado";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.NullValue = "-";
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(129)))), ((int)(((byte)(5)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvResultado.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.NullValue = "-";
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(129)))), ((int)(((byte)(5)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dgvResultado.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvResultado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResultado.Size = new System.Drawing.Size(1011, 334);
            this.dgvResultado.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Futura Bk BT", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(129)))), ((int)(((byte)(5)))));
            this.lblTitulo.Location = new System.Drawing.Point(22, 26);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(407, 77);
            this.lblTitulo.TabIndex = 40;
            this.lblTitulo.Text = "CONSULTAS";
            // 
            // frmConsultaSocio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1160, 862);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.grpConsultas);
            this.Controls.Add(this.grpDataGrid);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmConsultaSocio";
            this.Text = "frmSocio";
            this.Load += new System.EventHandler(this.frmConsultaSocio_Load);
            this.grpConsultas.ResumeLayout(false);
            this.grpConsultas.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpDataGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpConsultas;
        private System.Windows.Forms.GroupBox grpDataGrid;
        private System.Windows.Forms.DataGridView dgvResultado;
        private System.Windows.Forms.Button btnBuscarSocio;
        private System.Windows.Forms.TextBox txtBuscarSocio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstSocios;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDeudaSocio;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.ComboBox cmbInscripcion;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button btnInscripcionesPagadas;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}