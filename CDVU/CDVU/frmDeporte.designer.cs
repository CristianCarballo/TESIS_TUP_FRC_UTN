namespace CDVU
{
    partial class frmDeporte
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.grpBotones = new System.Windows.Forms.GroupBox();
            this.btnEliminarDeporte = new System.Windows.Forms.Button();
            this.btnModificarDeporte = new System.Windows.Forms.Button();
            this.btnAgregarDeporte = new System.Windows.Forms.Button();
            this.lstDeportes = new System.Windows.Forms.ListBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.cmbClasificacionDeporte = new System.Windows.Forms.ComboBox();
            this.lblClasificacion = new System.Windows.Forms.Label();
            this.grpFormulario = new System.Windows.Forms.GroupBox();
            this.lblId = new System.Windows.Forms.Label();
            this.lblNumProfesor = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnListaCompleta = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbBuscarPorClasificacion = new System.Windows.Forms.ComboBox();
            this.grpBotones.SuspendLayout();
            this.grpFormulario.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(129)))), ((int)(((byte)(5)))));
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombre.ForeColor = System.Drawing.Color.White;
            this.txtNombre.Location = new System.Drawing.Point(329, 230);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNombre.MaxLength = 50;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(259, 27);
            this.txtNombre.TabIndex = 3;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(237, 232);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(71, 18);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre";
            // 
            // grpBotones
            // 
            this.grpBotones.Controls.Add(this.btnEliminarDeporte);
            this.grpBotones.Controls.Add(this.btnModificarDeporte);
            this.grpBotones.Controls.Add(this.btnAgregarDeporte);
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
            // btnEliminarDeporte
            // 
            this.btnEliminarDeporte.BackColor = System.Drawing.Color.DimGray;
            this.btnEliminarDeporte.BackgroundImage = global::CDVU.Properties.Resources.icons8_eliminar_64;
            this.btnEliminarDeporte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEliminarDeporte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarDeporte.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEliminarDeporte.FlatAppearance.BorderSize = 0;
            this.btnEliminarDeporte.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnEliminarDeporte.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnEliminarDeporte.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnEliminarDeporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarDeporte.Location = new System.Drawing.Point(326, 30);
            this.btnEliminarDeporte.Name = "btnEliminarDeporte";
            this.btnEliminarDeporte.Size = new System.Drawing.Size(69, 70);
            this.btnEliminarDeporte.TabIndex = 2;
            this.btnEliminarDeporte.UseVisualStyleBackColor = false;
            this.btnEliminarDeporte.Click += new System.EventHandler(this.btnEliminarDeporte_Click);
            this.btnEliminarDeporte.MouseHover += new System.EventHandler(this.btnEliminarDeporte_MouseHover);
            // 
            // btnModificarDeporte
            // 
            this.btnModificarDeporte.BackColor = System.Drawing.Color.DimGray;
            this.btnModificarDeporte.BackgroundImage = global::CDVU.Properties.Resources.icons8_reemplazar_64;
            this.btnModificarDeporte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnModificarDeporte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificarDeporte.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnModificarDeporte.FlatAppearance.BorderSize = 0;
            this.btnModificarDeporte.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnModificarDeporte.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnModificarDeporte.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnModificarDeporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarDeporte.Location = new System.Drawing.Point(206, 30);
            this.btnModificarDeporte.Name = "btnModificarDeporte";
            this.btnModificarDeporte.Size = new System.Drawing.Size(69, 70);
            this.btnModificarDeporte.TabIndex = 1;
            this.btnModificarDeporte.UseVisualStyleBackColor = false;
            this.btnModificarDeporte.Click += new System.EventHandler(this.btnModificarDeporte_Click);
            this.btnModificarDeporte.MouseHover += new System.EventHandler(this.btnModificarDeporte_MouseHover);
            // 
            // btnAgregarDeporte
            // 
            this.btnAgregarDeporte.BackColor = System.Drawing.Color.DimGray;
            this.btnAgregarDeporte.BackgroundImage = global::CDVU.Properties.Resources.icons8_añadir_64;
            this.btnAgregarDeporte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAgregarDeporte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarDeporte.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAgregarDeporte.FlatAppearance.BorderSize = 0;
            this.btnAgregarDeporte.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnAgregarDeporte.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAgregarDeporte.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAgregarDeporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarDeporte.Location = new System.Drawing.Point(86, 30);
            this.btnAgregarDeporte.Name = "btnAgregarDeporte";
            this.btnAgregarDeporte.Size = new System.Drawing.Size(69, 70);
            this.btnAgregarDeporte.TabIndex = 0;
            this.btnAgregarDeporte.UseVisualStyleBackColor = false;
            this.btnAgregarDeporte.Click += new System.EventHandler(this.btnAgregarDeporte_Click);
            this.btnAgregarDeporte.MouseHover += new System.EventHandler(this.btnAgregarDeporte_MouseHover);
            // 
            // lstDeportes
            // 
            this.lstDeportes.BackColor = System.Drawing.Color.DimGray;
            this.lstDeportes.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lstDeportes.ForeColor = System.Drawing.Color.White;
            this.lstDeportes.FormattingEnabled = true;
            this.lstDeportes.ItemHeight = 14;
            this.lstDeportes.Location = new System.Drawing.Point(42, 335);
            this.lstDeportes.Name = "lstDeportes";
            this.lstDeportes.Size = new System.Drawing.Size(480, 494);
            this.lstDeportes.TabIndex = 9;
            this.lstDeportes.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lstDeportes_DrawItem);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Futura Bk BT", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(129)))), ((int)(((byte)(5)))));
            this.lblTitulo.Location = new System.Drawing.Point(13, 9);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(341, 77);
            this.lblTitulo.TabIndex = 10;
            this.lblTitulo.Text = "DEPORTES";
            // 
            // cmbClasificacionDeporte
            // 
            this.cmbClasificacionDeporte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(129)))), ((int)(((byte)(5)))));
            this.cmbClasificacionDeporte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClasificacionDeporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbClasificacionDeporte.ForeColor = System.Drawing.Color.White;
            this.cmbClasificacionDeporte.FormattingEnabled = true;
            this.cmbClasificacionDeporte.Location = new System.Drawing.Point(329, 285);
            this.cmbClasificacionDeporte.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbClasificacionDeporte.Name = "cmbClasificacionDeporte";
            this.cmbClasificacionDeporte.Size = new System.Drawing.Size(150, 26);
            this.cmbClasificacionDeporte.TabIndex = 14;
            // 
            // lblClasificacion
            // 
            this.lblClasificacion.AutoSize = true;
            this.lblClasificacion.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClasificacion.ForeColor = System.Drawing.Color.White;
            this.lblClasificacion.Location = new System.Drawing.Point(198, 288);
            this.lblClasificacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClasificacion.Name = "lblClasificacion";
            this.lblClasificacion.Size = new System.Drawing.Size(110, 18);
            this.lblClasificacion.TabIndex = 13;
            this.lblClasificacion.Text = "Clasificación";
            // 
            // grpFormulario
            // 
            this.grpFormulario.Controls.Add(this.lblId);
            this.grpFormulario.Controls.Add(this.lblNumProfesor);
            this.grpFormulario.Controls.Add(this.cmbClasificacionDeporte);
            this.grpFormulario.Controls.Add(this.lblClasificacion);
            this.grpFormulario.Controls.Add(this.btnCancelar);
            this.grpFormulario.Controls.Add(this.btnLimpiar);
            this.grpFormulario.Controls.Add(this.lblNombre);
            this.grpFormulario.Controls.Add(this.btnAceptar);
            this.grpFormulario.Controls.Add(this.txtNombre);
            this.grpFormulario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpFormulario.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpFormulario.ForeColor = System.Drawing.Color.White;
            this.grpFormulario.Location = new System.Drawing.Point(552, 237);
            this.grpFormulario.Name = "grpFormulario";
            this.grpFormulario.Size = new System.Drawing.Size(787, 592);
            this.grpFormulario.TabIndex = 9;
            this.grpFormulario.TabStop = false;
            this.grpFormulario.Text = "Datos del Deporte";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.ForeColor = System.Drawing.Color.White;
            this.lblId.Location = new System.Drawing.Point(326, 184);
            this.lblId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(0, 18);
            this.lblId.TabIndex = 16;
            // 
            // lblNumProfesor
            // 
            this.lblNumProfesor.AutoSize = true;
            this.lblNumProfesor.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumProfesor.ForeColor = System.Drawing.Color.White;
            this.lblNumProfesor.Location = new System.Drawing.Point(201, 184);
            this.lblNumProfesor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumProfesor.Name = "lblNumProfesor";
            this.lblNumProfesor.Size = new System.Drawing.Size(107, 18);
            this.lblNumProfesor.TabIndex = 15;
            this.lblNumProfesor.Text = "N° Deporte:";
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
            this.btnCancelar.Location = new System.Drawing.Point(358, 339);
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
            this.btnLimpiar.Location = new System.Drawing.Point(454, 339);
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
            this.btnAceptar.Location = new System.Drawing.Point(264, 339);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(69, 70);
            this.btnAceptar.TabIndex = 3;
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            this.btnAceptar.MouseHover += new System.EventHandler(this.btnAceptar_MouseHover);
            // 
            // btnListaCompleta
            // 
            this.btnListaCompleta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(129)))), ((int)(((byte)(5)))));
            this.btnListaCompleta.FlatAppearance.BorderSize = 0;
            this.btnListaCompleta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListaCompleta.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListaCompleta.ForeColor = System.Drawing.Color.White;
            this.btnListaCompleta.Location = new System.Drawing.Point(295, 288);
            this.btnListaCompleta.Name = "btnListaCompleta";
            this.btnListaCompleta.Size = new System.Drawing.Size(178, 27);
            this.btnListaCompleta.TabIndex = 30;
            this.btnListaCompleta.Text = "Ver lista completa";
            this.btnListaCompleta.UseVisualStyleBackColor = false;
            this.btnListaCompleta.Click += new System.EventHandler(this.btnListaCompleta_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(76, 259);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 16);
            this.label1.TabIndex = 28;
            this.label1.Text = "Filtrar listado por clasificación";
            // 
            // cmbBuscarPorClasificacion
            // 
            this.cmbBuscarPorClasificacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(129)))), ((int)(((byte)(5)))));
            this.cmbBuscarPorClasificacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbBuscarPorClasificacion.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBuscarPorClasificacion.ForeColor = System.Drawing.Color.White;
            this.cmbBuscarPorClasificacion.FormattingEnabled = true;
            this.cmbBuscarPorClasificacion.Location = new System.Drawing.Point(79, 288);
            this.cmbBuscarPorClasificacion.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbBuscarPorClasificacion.Name = "cmbBuscarPorClasificacion";
            this.cmbBuscarPorClasificacion.Size = new System.Drawing.Size(195, 26);
            this.cmbBuscarPorClasificacion.TabIndex = 17;
            this.cmbBuscarPorClasificacion.SelectionChangeCommitted += new System.EventHandler(this.cmbBuscarPorClasificacion_SelectionChangeCommitted);
            // 
            // frmDeporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1380, 862);
            this.Controls.Add(this.cmbBuscarPorClasificacion);
            this.Controls.Add(this.btnListaCompleta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lstDeportes);
            this.Controls.Add(this.grpBotones);
            this.Controls.Add(this.grpFormulario);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmDeporte";
            this.Text = "frmSocio";
            this.Load += new System.EventHandler(this.frmDeporte_Load);
            this.grpBotones.ResumeLayout(false);
            this.grpFormulario.ResumeLayout(false);
            this.grpFormulario.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.GroupBox grpBotones;
        private System.Windows.Forms.Button btnAgregarDeporte;
        private System.Windows.Forms.Button btnEliminarDeporte;
        private System.Windows.Forms.Button btnModificarDeporte;
        private System.Windows.Forms.ListBox lstDeportes;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ComboBox cmbClasificacionDeporte;
        private System.Windows.Forms.Label lblClasificacion;
        private System.Windows.Forms.GroupBox grpFormulario;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblNumProfesor;
        private System.Windows.Forms.Button btnListaCompleta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbBuscarPorClasificacion;
    }
}