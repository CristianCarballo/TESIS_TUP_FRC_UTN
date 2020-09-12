namespace CDVU
{
    partial class frmPredio
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
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.grpBotones = new System.Windows.Forms.GroupBox();
            this.btnEliminarPredio = new System.Windows.Forms.Button();
            this.btnModificarPredio = new System.Windows.Forms.Button();
            this.btnAgregarPredio = new System.Windows.Forms.Button();
            this.lstPredios = new System.Windows.Forms.ListBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.grpFormulario = new System.Windows.Forms.GroupBox();
            this.txtDescripcion = new System.Windows.Forms.RichTextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.lblNumPredio = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.cmbBuscarPorDeporte = new System.Windows.Forms.ComboBox();
            this.btnListaCompleta = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.grpBotones.SuspendLayout();
            this.grpFormulario.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.ForeColor = System.Drawing.Color.White;
            this.lblDescripcion.Location = new System.Drawing.Point(151, 177);
            this.lblDescripcion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(101, 18);
            this.lblDescripcion.TabIndex = 2;
            this.lblDescripcion.Text = "Descripción";
            // 
            // grpBotones
            // 
            this.grpBotones.Controls.Add(this.btnEliminarPredio);
            this.grpBotones.Controls.Add(this.btnModificarPredio);
            this.grpBotones.Controls.Add(this.btnAgregarPredio);
            this.grpBotones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpBotones.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBotones.ForeColor = System.Drawing.Color.White;
            this.grpBotones.Location = new System.Drawing.Point(42, 98);
            this.grpBotones.Name = "grpBotones";
            this.grpBotones.Size = new System.Drawing.Size(480, 115);
            this.grpBotones.TabIndex = 8;
            this.grpBotones.TabStop = false;
            this.grpBotones.Text = "¿Qué desea hacer?";
            // 
            // btnEliminarPredio
            // 
            this.btnEliminarPredio.BackColor = System.Drawing.Color.DimGray;
            this.btnEliminarPredio.BackgroundImage = global::CDVU.Properties.Resources.icons8_eliminar_64;
            this.btnEliminarPredio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEliminarPredio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarPredio.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEliminarPredio.FlatAppearance.BorderSize = 0;
            this.btnEliminarPredio.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnEliminarPredio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnEliminarPredio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnEliminarPredio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarPredio.Location = new System.Drawing.Point(326, 30);
            this.btnEliminarPredio.Name = "btnEliminarPredio";
            this.btnEliminarPredio.Size = new System.Drawing.Size(69, 70);
            this.btnEliminarPredio.TabIndex = 2;
            this.btnEliminarPredio.UseVisualStyleBackColor = false;
            this.btnEliminarPredio.Click += new System.EventHandler(this.btnEliminarPredio_Click);
            this.btnEliminarPredio.MouseHover += new System.EventHandler(this.btnEliminarPredio_MouseHover);
            // 
            // btnModificarPredio
            // 
            this.btnModificarPredio.BackColor = System.Drawing.Color.DimGray;
            this.btnModificarPredio.BackgroundImage = global::CDVU.Properties.Resources.icons8_reemplazar_64;
            this.btnModificarPredio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnModificarPredio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificarPredio.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnModificarPredio.FlatAppearance.BorderSize = 0;
            this.btnModificarPredio.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnModificarPredio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnModificarPredio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnModificarPredio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarPredio.Location = new System.Drawing.Point(206, 30);
            this.btnModificarPredio.Name = "btnModificarPredio";
            this.btnModificarPredio.Size = new System.Drawing.Size(69, 70);
            this.btnModificarPredio.TabIndex = 1;
            this.btnModificarPredio.UseVisualStyleBackColor = false;
            this.btnModificarPredio.Click += new System.EventHandler(this.btnModificarPredio_Click);
            this.btnModificarPredio.MouseHover += new System.EventHandler(this.btnModificarPredio_MouseHover);
            // 
            // btnAgregarPredio
            // 
            this.btnAgregarPredio.BackColor = System.Drawing.Color.DimGray;
            this.btnAgregarPredio.BackgroundImage = global::CDVU.Properties.Resources.icons8_añadir_64;
            this.btnAgregarPredio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAgregarPredio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarPredio.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAgregarPredio.FlatAppearance.BorderSize = 0;
            this.btnAgregarPredio.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnAgregarPredio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAgregarPredio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAgregarPredio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarPredio.Location = new System.Drawing.Point(86, 30);
            this.btnAgregarPredio.Name = "btnAgregarPredio";
            this.btnAgregarPredio.Size = new System.Drawing.Size(69, 70);
            this.btnAgregarPredio.TabIndex = 0;
            this.btnAgregarPredio.UseVisualStyleBackColor = false;
            this.btnAgregarPredio.Click += new System.EventHandler(this.btnAgregarPredio_Click);
            this.btnAgregarPredio.MouseHover += new System.EventHandler(this.btnAgregarPredio_MouseHover);
            // 
            // lstPredios
            // 
            this.lstPredios.BackColor = System.Drawing.Color.DimGray;
            this.lstPredios.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lstPredios.ForeColor = System.Drawing.Color.White;
            this.lstPredios.FormattingEnabled = true;
            this.lstPredios.ItemHeight = 14;
            this.lstPredios.Location = new System.Drawing.Point(42, 335);
            this.lstPredios.Name = "lstPredios";
            this.lstPredios.Size = new System.Drawing.Size(480, 494);
            this.lstPredios.TabIndex = 9;
            this.lstPredios.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lstPredios_DrawItem);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Futura Bk BT", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(129)))), ((int)(((byte)(5)))));
            this.lblTitulo.Location = new System.Drawing.Point(13, 9);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(292, 77);
            this.lblTitulo.TabIndex = 10;
            this.lblTitulo.Text = "PREDIOS";
            // 
            // grpFormulario
            // 
            this.grpFormulario.Controls.Add(this.txtDescripcion);
            this.grpFormulario.Controls.Add(this.lblId);
            this.grpFormulario.Controls.Add(this.lblNumPredio);
            this.grpFormulario.Controls.Add(this.btnCancelar);
            this.grpFormulario.Controls.Add(this.btnLimpiar);
            this.grpFormulario.Controls.Add(this.lblDescripcion);
            this.grpFormulario.Controls.Add(this.btnAceptar);
            this.grpFormulario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpFormulario.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpFormulario.ForeColor = System.Drawing.Color.White;
            this.grpFormulario.Location = new System.Drawing.Point(552, 237);
            this.grpFormulario.Name = "grpFormulario";
            this.grpFormulario.Size = new System.Drawing.Size(787, 592);
            this.grpFormulario.TabIndex = 9;
            this.grpFormulario.TabStop = false;
            this.grpFormulario.Text = "Datos del Predio";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(129)))), ((int)(((byte)(5)))));
            this.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescripcion.ForeColor = System.Drawing.Color.White;
            this.txtDescripcion.Location = new System.Drawing.Point(287, 175);
            this.txtDescripcion.MaxLength = 145;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(348, 176);
            this.txtDescripcion.TabIndex = 17;
            this.txtDescripcion.Text = "";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.ForeColor = System.Drawing.Color.White;
            this.lblId.Location = new System.Drawing.Point(284, 129);
            this.lblId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(0, 18);
            this.lblId.TabIndex = 16;
            // 
            // lblNumPredio
            // 
            this.lblNumPredio.AutoSize = true;
            this.lblNumPredio.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumPredio.ForeColor = System.Drawing.Color.White;
            this.lblNumPredio.Location = new System.Drawing.Point(159, 129);
            this.lblNumPredio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumPredio.Name = "lblNumPredio";
            this.lblNumPredio.Size = new System.Drawing.Size(93, 18);
            this.lblNumPredio.TabIndex = 15;
            this.lblNumPredio.Text = "N° Predio:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.DimGray;
            this.btnCancelar.BackgroundImage = global::CDVU.Properties.Resources.icons8_no_molestar_64;
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Location = new System.Drawing.Point(381, 393);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(69, 70);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            this.btnCancelar.MouseHover += new System.EventHandler(this.btnCancelar_MouseHover);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.DimGray;
            this.btnLimpiar.BackgroundImage = global::CDVU.Properties.Resources.icons8_símbolo_vaciar_64;
            this.btnLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnLimpiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnLimpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Location = new System.Drawing.Point(477, 393);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(69, 70);
            this.btnLimpiar.TabIndex = 11;
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            this.btnLimpiar.MouseHover += new System.EventHandler(this.btnLimpiar_MouseHover);
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.DimGray;
            this.btnAceptar.BackgroundImage = global::CDVU.Properties.Resources.icons8_aprobación_64;
            this.btnAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAceptar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAceptar.FlatAppearance.BorderSize = 0;
            this.btnAceptar.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnAceptar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Location = new System.Drawing.Point(287, 393);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(69, 70);
            this.btnAceptar.TabIndex = 3;
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            this.btnAceptar.MouseHover += new System.EventHandler(this.btnAceptar_MouseHover);
            // 
            // cmbBuscarPorDeporte
            // 
            this.cmbBuscarPorDeporte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(129)))), ((int)(((byte)(5)))));
            this.cmbBuscarPorDeporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbBuscarPorDeporte.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBuscarPorDeporte.ForeColor = System.Drawing.Color.White;
            this.cmbBuscarPorDeporte.FormattingEnabled = true;
            this.cmbBuscarPorDeporte.Location = new System.Drawing.Point(56, 292);
            this.cmbBuscarPorDeporte.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbBuscarPorDeporte.Name = "cmbBuscarPorDeporte";
            this.cmbBuscarPorDeporte.Size = new System.Drawing.Size(195, 26);
            this.cmbBuscarPorDeporte.TabIndex = 31;
            this.cmbBuscarPorDeporte.SelectionChangeCommitted += new System.EventHandler(this.cmbBuscarPorDeporte_SelectionChangeCommitted);
            // 
            // btnListaCompleta
            // 
            this.btnListaCompleta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(129)))), ((int)(((byte)(5)))));
            this.btnListaCompleta.FlatAppearance.BorderSize = 0;
            this.btnListaCompleta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListaCompleta.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListaCompleta.ForeColor = System.Drawing.Color.White;
            this.btnListaCompleta.Location = new System.Drawing.Point(273, 292);
            this.btnListaCompleta.Name = "btnListaCompleta";
            this.btnListaCompleta.Size = new System.Drawing.Size(178, 27);
            this.btnListaCompleta.TabIndex = 33;
            this.btnListaCompleta.Text = "Ver lista completa";
            this.btnListaCompleta.UseVisualStyleBackColor = false;
            this.btnListaCompleta.Click += new System.EventHandler(this.btnListaCompleta_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(53, 246);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(455, 32);
            this.label1.TabIndex = 32;
            this.label1.Text = "Filtrar listado por deporte\r\n(muestra los predios en donde se practica el deporte" +
    " seleccionado)";
            // 
            // frmPredio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1380, 862);
            this.Controls.Add(this.cmbBuscarPorDeporte);
            this.Controls.Add(this.btnListaCompleta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lstPredios);
            this.Controls.Add(this.grpBotones);
            this.Controls.Add(this.grpFormulario);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmPredio";
            this.Text = "frmSocio";
            this.Load += new System.EventHandler(this.frmPredio_Load);
            this.grpBotones.ResumeLayout(false);
            this.grpFormulario.ResumeLayout(false);
            this.grpFormulario.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.GroupBox grpBotones;
        private System.Windows.Forms.Button btnAgregarPredio;
        private System.Windows.Forms.Button btnEliminarPredio;
        private System.Windows.Forms.Button btnModificarPredio;
        private System.Windows.Forms.ListBox lstPredios;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.GroupBox grpFormulario;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblNumPredio;
        private System.Windows.Forms.RichTextBox txtDescripcion;
        private System.Windows.Forms.ComboBox cmbBuscarPorDeporte;
        private System.Windows.Forms.Button btnListaCompleta;
        private System.Windows.Forms.Label label1;
    }
}