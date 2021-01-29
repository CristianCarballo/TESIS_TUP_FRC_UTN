namespace CDVU
{
    partial class frmConsultaRecaudacion
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtpFechaRecaudacion = new System.Windows.Forms.DateTimePicker();
            this.cmbFecha = new System.Windows.Forms.ComboBox();
            this.label = new System.Windows.Forms.Label();
            this.btnRecaudacionPorFecha = new System.Windows.Forms.Button();
            this.grpDataGrid = new System.Windows.Forms.GroupBox();
            this.dgvResultado = new System.Windows.Forms.DataGridView();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.grpDataGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).BeginInit();
            this.SuspendLayout();
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
            this.groupBox2.Location = new System.Drawing.Point(41, 157);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(408, 144);
            this.groupBox2.TabIndex = 54;
            this.groupBox2.TabStop = false;
            // 
            // dtpFechaRecaudacion
            // 
            this.dtpFechaRecaudacion.CalendarFont = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaRecaudacion.CalendarMonthBackground = System.Drawing.Color.DimGray;
            this.dtpFechaRecaudacion.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaRecaudacion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaRecaudacion.Location = new System.Drawing.Point(21, 95);
            this.dtpFechaRecaudacion.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtpFechaRecaudacion.Name = "dtpFechaRecaudacion";
            this.dtpFechaRecaudacion.Size = new System.Drawing.Size(182, 23);
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
            this.cmbFecha.Location = new System.Drawing.Point(21, 59);
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
            this.label.Location = new System.Drawing.Point(18, 26);
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
            this.btnRecaudacionPorFecha.Location = new System.Drawing.Point(225, 59);
            this.btnRecaudacionPorFecha.Name = "btnRecaudacionPorFecha";
            this.btnRecaudacionPorFecha.Size = new System.Drawing.Size(165, 59);
            this.btnRecaudacionPorFecha.TabIndex = 52;
            this.btnRecaudacionPorFecha.Text = "Ver recaudación";
            this.btnRecaudacionPorFecha.UseVisualStyleBackColor = false;
            this.btnRecaudacionPorFecha.Click += new System.EventHandler(this.btnRecaudacionPorFecha_Click);
            // 
            // grpDataGrid
            // 
            this.grpDataGrid.Controls.Add(this.dgvResultado);
            this.grpDataGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpDataGrid.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDataGrid.ForeColor = System.Drawing.Color.White;
            this.grpDataGrid.Location = new System.Drawing.Point(41, 343);
            this.grpDataGrid.Name = "grpDataGrid";
            this.grpDataGrid.Size = new System.Drawing.Size(1078, 337);
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
            this.dgvResultado.Location = new System.Drawing.Point(21, 34);
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
            this.dgvResultado.Size = new System.Drawing.Size(1037, 269);
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
            // frmConsultaRecaudacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1160, 862);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.grpDataGrid);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmConsultaRecaudacion";
            this.Text = "frmSocio";
            this.Load += new System.EventHandler(this.frmConsultaRecaudacion_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.grpDataGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox grpDataGrid;
        private System.Windows.Forms.DataGridView dgvResultado;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnRecaudacionPorFecha;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.ComboBox cmbFecha;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.DateTimePicker dtpFechaRecaudacion;
    }
}