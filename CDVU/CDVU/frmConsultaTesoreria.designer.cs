namespace CDVU
{
    partial class frmConsultaTesoreria
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grpConsultas = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDetalleDelRecibo = new System.Windows.Forms.Button();
            this.lstRecibo = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtpFechaRecaudacion = new System.Windows.Forms.DateTimePicker();
            this.cmbFecha = new System.Windows.Forms.ComboBox();
            this.label = new System.Windows.Forms.Label();
            this.btnRecaudacionPorFecha = new System.Windows.Forms.Button();
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
            this.groupBox2.SuspendLayout();
            this.grpDataGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).BeginInit();
            this.SuspendLayout();
            // 
            // grpConsultas
            // 
            this.grpConsultas.Controls.Add(this.groupBox1);
            this.grpConsultas.Controls.Add(this.groupBox2);
            this.grpConsultas.Controls.Add(this.label2);
            this.grpConsultas.Controls.Add(this.btnBuscarSocio);
            this.grpConsultas.Controls.Add(this.txtBuscarSocio);
            this.grpConsultas.Controls.Add(this.label1);
            this.grpConsultas.Controls.Add(this.lstSocios);
            this.grpConsultas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpConsultas.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpConsultas.ForeColor = System.Drawing.Color.White;
            this.grpConsultas.Location = new System.Drawing.Point(35, 191);
            this.grpConsultas.Name = "grpConsultas";
            this.grpConsultas.Size = new System.Drawing.Size(1090, 292);
            this.grpConsultas.TabIndex = 39;
            this.grpConsultas.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDetalleDelRecibo);
            this.groupBox1.Controls.Add(this.lstRecibo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(270, 97);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(395, 178);
            this.groupBox1.TabIndex = 62;
            this.groupBox1.TabStop = false;
            // 
            // btnDetalleDelRecibo
            // 
            this.btnDetalleDelRecibo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(129)))), ((int)(((byte)(5)))));
            this.btnDetalleDelRecibo.FlatAppearance.BorderSize = 0;
            this.btnDetalleDelRecibo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetalleDelRecibo.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetalleDelRecibo.ForeColor = System.Drawing.Color.White;
            this.btnDetalleDelRecibo.Location = new System.Drawing.Point(10, 133);
            this.btnDetalleDelRecibo.Name = "btnDetalleDelRecibo";
            this.btnDetalleDelRecibo.Size = new System.Drawing.Size(375, 27);
            this.btnDetalleDelRecibo.TabIndex = 59;
            this.btnDetalleDelRecibo.Text = "Ver detalles del recibo";
            this.btnDetalleDelRecibo.UseVisualStyleBackColor = false;
            this.btnDetalleDelRecibo.Click += new System.EventHandler(this.btnDetalleDelRecibo_Click);
            // 
            // lstRecibo
            // 
            this.lstRecibo.BackColor = System.Drawing.Color.DimGray;
            this.lstRecibo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lstRecibo.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstRecibo.ForeColor = System.Drawing.Color.White;
            this.lstRecibo.FormattingEnabled = true;
            this.lstRecibo.ItemHeight = 14;
            this.lstRecibo.Location = new System.Drawing.Point(114, 29);
            this.lstRecibo.Name = "lstRecibo";
            this.lstRecibo.Size = new System.Drawing.Size(271, 88);
            this.lstRecibo.TabIndex = 63;
            this.lstRecibo.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lstRecibo_DrawItem);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(35, 29);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 55;
            this.label3.Text = "Recibos";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtpFechaRecaudacion);
            this.groupBox2.Controls.Add(this.cmbFecha);
            this.groupBox2.Controls.Add(this.label);
            this.groupBox2.Controls.Add(this.btnRecaudacionPorFecha);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(673, 97);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(395, 178);
            this.groupBox2.TabIndex = 54;
            this.groupBox2.TabStop = false;
            // 
            // dtpFechaRecaudacion
            // 
            this.dtpFechaRecaudacion.CalendarFont = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaRecaudacion.CalendarMonthBackground = System.Drawing.Color.DimGray;
            this.dtpFechaRecaudacion.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaRecaudacion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaRecaudacion.Location = new System.Drawing.Point(235, 94);
            this.dtpFechaRecaudacion.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtpFechaRecaudacion.Name = "dtpFechaRecaudacion";
            this.dtpFechaRecaudacion.Size = new System.Drawing.Size(151, 23);
            this.dtpFechaRecaudacion.TabIndex = 58;
            // 
            // cmbFecha
            // 
            this.cmbFecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(129)))), ((int)(((byte)(5)))));
            this.cmbFecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbFecha.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFecha.ForeColor = System.Drawing.Color.White;
            this.cmbFecha.FormattingEnabled = true;
            this.cmbFecha.Items.AddRange(new object[] {
            "Anual",
            "Mensual",
            "Diario (Seleccione el día)"});
            this.cmbFecha.Location = new System.Drawing.Point(11, 94);
            this.cmbFecha.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbFecha.Name = "cmbFecha";
            this.cmbFecha.Size = new System.Drawing.Size(182, 22);
            this.cmbFecha.TabIndex = 57;
            this.cmbFecha.SelectedIndexChanged += new System.EventHandler(this.cmbFecha_SelectedIndexChanged);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.Color.White;
            this.label.Location = new System.Drawing.Point(8, 61);
            this.label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(159, 16);
            this.label.TabIndex = 56;
            this.label.Text = "Recaudación por fecha";
            // 
            // btnRecaudacionPorFecha
            // 
            this.btnRecaudacionPorFecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(129)))), ((int)(((byte)(5)))));
            this.btnRecaudacionPorFecha.FlatAppearance.BorderSize = 0;
            this.btnRecaudacionPorFecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecaudacionPorFecha.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecaudacionPorFecha.ForeColor = System.Drawing.Color.White;
            this.btnRecaudacionPorFecha.Location = new System.Drawing.Point(11, 133);
            this.btnRecaudacionPorFecha.Name = "btnRecaudacionPorFecha";
            this.btnRecaudacionPorFecha.Size = new System.Drawing.Size(375, 27);
            this.btnRecaudacionPorFecha.TabIndex = 52;
            this.btnRecaudacionPorFecha.Text = "Ver recaudación";
            this.btnRecaudacionPorFecha.UseVisualStyleBackColor = false;
            this.btnRecaudacionPorFecha.Click += new System.EventHandler(this.btnRecaudacionPorFecha_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(19, 105);
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
            this.btnBuscarSocio.Location = new System.Drawing.Point(174, 59);
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
            this.txtBuscarSocio.Location = new System.Drawing.Point(27, 59);
            this.txtBuscarSocio.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtBuscarSocio.Name = "txtBuscarSocio";
            this.txtBuscarSocio.Size = new System.Drawing.Size(139, 27);
            this.txtBuscarSocio.TabIndex = 48;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(23, 32);
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
            this.lstSocios.Location = new System.Drawing.Point(26, 103);
            this.lstSocios.Name = "lstSocios";
            this.lstSocios.Size = new System.Drawing.Size(236, 172);
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
            this.grpDataGrid.Location = new System.Drawing.Point(35, 527);
            this.grpDataGrid.Name = "grpDataGrid";
            this.grpDataGrid.Size = new System.Drawing.Size(1090, 308);
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
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.NullValue = "-";
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(129)))), ((int)(((byte)(5)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvResultado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvResultado.Location = new System.Drawing.Point(3, 56);
            this.dgvResultado.Name = "dgvResultado";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.NullValue = "-";
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(129)))), ((int)(((byte)(5)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvResultado.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.NullValue = "-";
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(129)))), ((int)(((byte)(5)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.White;
            this.dgvResultado.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.dgvResultado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResultado.Size = new System.Drawing.Size(1084, 249);
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
            // frmConsultaTesoreria
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
            this.Name = "frmConsultaTesoreria";
            this.Text = "frmSocio";
            this.Load += new System.EventHandler(this.frmConsultaTesoreria_Load);
            this.grpConsultas.ResumeLayout(false);
            this.grpConsultas.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnRecaudacionPorFecha;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.ComboBox cmbFecha;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpFechaRecaudacion;
        private System.Windows.Forms.Button btnDetalleDelRecibo;
        private System.Windows.Forms.ListBox lstRecibo;
        private System.Windows.Forms.Label label3;
    }
}