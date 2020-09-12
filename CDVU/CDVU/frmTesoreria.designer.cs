namespace CDVU
{
    partial class frmTesoreria
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.grpPago = new System.Windows.Forms.GroupBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.grpInscripcion = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblFechaInscripcion = new System.Windows.Forms.Label();
            this.lblPrecioMensualSeleccionado = new System.Windows.Forms.Label();
            this.lblCantidadCuotas = new System.Windows.Forms.Label();
            this.cmbInscripcion = new System.Windows.Forms.ComboBox();
            this.lblPrecioMatSeleccionado = new System.Windows.Forms.Label();
            this.lblPrecioMatri = new System.Windows.Forms.Label();
            this.lblCantCuotas = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.lblPrecioMensual = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblDeporteSeleccionado = new System.Windows.Forms.Label();
            this.grpSocio = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNombreTutor = new System.Windows.Forms.Label();
            this.lblNombreTutorSeleccionado = new System.Windows.Forms.Label();
            this.lblDniTutor = new System.Windows.Forms.Label();
            this.lblDniTutorSeleccionado = new System.Windows.Forms.Label();
            this.lblNombreSocio = new System.Windows.Forms.Label();
            this.lblNombreSocioSeleccionado = new System.Windows.Forms.Label();
            this.btnBuscarSocio = new System.Windows.Forms.Button();
            this.txtBuscarSocio = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblIdSocio = new System.Windows.Forms.Label();
            this.lblDniSocio = new System.Windows.Forms.Label();
            this.lblIdSocioSeleccionado = new System.Windows.Forms.Label();
            this.lblDniSocioSeleccionado = new System.Windows.Forms.Label();
            this.btnQuitarPago = new System.Windows.Forms.Button();
            this.btnAgregarPago = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lstCuotaDeuda = new System.Windows.Forms.ListBox();
            this.lstCuotaAPagar = new System.Windows.Forms.ListBox();
            this.lblControle = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.grpPago.SuspendLayout();
            this.grpInscripcion.SuspendLayout();
            this.grpSocio.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Futura Bk BT", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(129)))), ((int)(((byte)(5)))));
            this.lblTitulo.Location = new System.Drawing.Point(13, 9);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(354, 77);
            this.lblTitulo.TabIndex = 10;
            this.lblTitulo.Text = "TESORERIA";
            // 
            // grpPago
            // 
            this.grpPago.Controls.Add(this.lblControle);
            this.grpPago.Controls.Add(this.txtTotal);
            this.grpPago.Controls.Add(this.label8);
            this.grpPago.Controls.Add(this.txtFecha);
            this.grpPago.Controls.Add(this.label6);
            this.grpPago.Controls.Add(this.btnCancelar);
            this.grpPago.Controls.Add(this.btnAceptar);
            this.grpPago.Controls.Add(this.txtNombre);
            this.grpPago.Controls.Add(this.label5);
            this.grpPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpPago.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPago.ForeColor = System.Drawing.Color.White;
            this.grpPago.Location = new System.Drawing.Point(532, 533);
            this.grpPago.Name = "grpPago";
            this.grpPago.Size = new System.Drawing.Size(564, 274);
            this.grpPago.TabIndex = 31;
            this.grpPago.TabStop = false;
            this.grpPago.Text = "Pago de cuota";
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(129)))), ((int)(((byte)(5)))));
            this.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotal.Cursor = System.Windows.Forms.Cursors.No;
            this.txtTotal.ForeColor = System.Drawing.Color.White;
            this.txtTotal.Location = new System.Drawing.Point(205, 108);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(155, 27);
            this.txtTotal.TabIndex = 43;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(58, 110);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(145, 18);
            this.label8.TabIndex = 42;
            this.label8.Text = "Total a pagar:  $";
            // 
            // txtFecha
            // 
            this.txtFecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(129)))), ((int)(((byte)(5)))));
            this.txtFecha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFecha.Cursor = System.Windows.Forms.Cursors.No;
            this.txtFecha.ForeColor = System.Drawing.Color.White;
            this.txtFecha.Location = new System.Drawing.Point(205, 40);
            this.txtFecha.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.ReadOnly = true;
            this.txtFecha.Size = new System.Drawing.Size(155, 27);
            this.txtFecha.TabIndex = 41;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(119, 42);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 18);
            this.label6.TabIndex = 40;
            this.label6.Text = "Fecha:";
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(129)))), ((int)(((byte)(5)))));
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombre.Cursor = System.Windows.Forms.Cursors.No;
            this.txtNombre.ForeColor = System.Drawing.Color.White;
            this.txtNombre.Location = new System.Drawing.Point(205, 74);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ReadOnly = true;
            this.txtNombre.Size = new System.Drawing.Size(155, 27);
            this.txtNombre.TabIndex = 39;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(62, 76);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 18);
            this.label5.TabIndex = 38;
            this.label5.Text = "A nombre de:";
            // 
            // grpInscripcion
            // 
            this.grpInscripcion.Controls.Add(this.label7);
            this.grpInscripcion.Controls.Add(this.lblFechaInscripcion);
            this.grpInscripcion.Controls.Add(this.lblPrecioMensualSeleccionado);
            this.grpInscripcion.Controls.Add(this.lblCantidadCuotas);
            this.grpInscripcion.Controls.Add(this.cmbInscripcion);
            this.grpInscripcion.Controls.Add(this.lblPrecioMatSeleccionado);
            this.grpInscripcion.Controls.Add(this.lblPrecioMatri);
            this.grpInscripcion.Controls.Add(this.lblCantCuotas);
            this.grpInscripcion.Controls.Add(this.btnQuitarPago);
            this.grpInscripcion.Controls.Add(this.label);
            this.grpInscripcion.Controls.Add(this.btnAgregarPago);
            this.grpInscripcion.Controls.Add(this.lblPrecioMensual);
            this.grpInscripcion.Controls.Add(this.label2);
            this.grpInscripcion.Controls.Add(this.label13);
            this.grpInscripcion.Controls.Add(this.label1);
            this.grpInscripcion.Controls.Add(this.lblDeporteSeleccionado);
            this.grpInscripcion.Controls.Add(this.lstCuotaDeuda);
            this.grpInscripcion.Controls.Add(this.lstCuotaAPagar);
            this.grpInscripcion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpInscripcion.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpInscripcion.ForeColor = System.Drawing.Color.White;
            this.grpInscripcion.Location = new System.Drawing.Point(532, 146);
            this.grpInscripcion.Name = "grpInscripcion";
            this.grpInscripcion.Size = new System.Drawing.Size(773, 367);
            this.grpInscripcion.TabIndex = 32;
            this.grpInscripcion.TabStop = false;
            this.grpInscripcion.Text = "Datos de la Inscripción";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(25, 161);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(156, 18);
            this.label7.TabIndex = 41;
            this.label7.Text = "Fecha Inscripción:";
            // 
            // lblFechaInscripcion
            // 
            this.lblFechaInscripcion.AutoSize = true;
            this.lblFechaInscripcion.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaInscripcion.ForeColor = System.Drawing.Color.White;
            this.lblFechaInscripcion.Location = new System.Drawing.Point(181, 161);
            this.lblFechaInscripcion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaInscripcion.Name = "lblFechaInscripcion";
            this.lblFechaInscripcion.Size = new System.Drawing.Size(0, 18);
            this.lblFechaInscripcion.TabIndex = 42;
            // 
            // lblPrecioMensualSeleccionado
            // 
            this.lblPrecioMensualSeleccionado.AutoSize = true;
            this.lblPrecioMensualSeleccionado.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioMensualSeleccionado.ForeColor = System.Drawing.Color.White;
            this.lblPrecioMensualSeleccionado.Location = new System.Drawing.Point(620, 88);
            this.lblPrecioMensualSeleccionado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrecioMensualSeleccionado.Name = "lblPrecioMensualSeleccionado";
            this.lblPrecioMensualSeleccionado.Size = new System.Drawing.Size(0, 18);
            this.lblPrecioMensualSeleccionado.TabIndex = 40;
            // 
            // lblCantidadCuotas
            // 
            this.lblCantidadCuotas.AutoSize = true;
            this.lblCantidadCuotas.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadCuotas.ForeColor = System.Drawing.Color.White;
            this.lblCantidadCuotas.Location = new System.Drawing.Point(622, 161);
            this.lblCantidadCuotas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCantidadCuotas.Name = "lblCantidadCuotas";
            this.lblCantidadCuotas.Size = new System.Drawing.Size(0, 18);
            this.lblCantidadCuotas.TabIndex = 39;
            // 
            // cmbInscripcion
            // 
            this.cmbInscripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(129)))), ((int)(((byte)(5)))));
            this.cmbInscripcion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbInscripcion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbInscripcion.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbInscripcion.ForeColor = System.Drawing.Color.White;
            this.cmbInscripcion.FormattingEnabled = true;
            this.cmbInscripcion.Location = new System.Drawing.Point(28, 69);
            this.cmbInscripcion.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbInscripcion.Name = "cmbInscripcion";
            this.cmbInscripcion.Size = new System.Drawing.Size(365, 22);
            this.cmbInscripcion.TabIndex = 31;
            this.cmbInscripcion.SelectedIndexChanged += new System.EventHandler(this.cmbInscripcion_SelectedIndexChanged);
            // 
            // lblPrecioMatSeleccionado
            // 
            this.lblPrecioMatSeleccionado.AutoSize = true;
            this.lblPrecioMatSeleccionado.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioMatSeleccionado.ForeColor = System.Drawing.Color.White;
            this.lblPrecioMatSeleccionado.Location = new System.Drawing.Point(620, 125);
            this.lblPrecioMatSeleccionado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrecioMatSeleccionado.Name = "lblPrecioMatSeleccionado";
            this.lblPrecioMatSeleccionado.Size = new System.Drawing.Size(0, 18);
            this.lblPrecioMatSeleccionado.TabIndex = 38;
            // 
            // lblPrecioMatri
            // 
            this.lblPrecioMatri.AutoSize = true;
            this.lblPrecioMatri.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioMatri.ForeColor = System.Drawing.Color.White;
            this.lblPrecioMatri.Location = new System.Drawing.Point(428, 125);
            this.lblPrecioMatri.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrecioMatri.Name = "lblPrecioMatri";
            this.lblPrecioMatri.Size = new System.Drawing.Size(188, 18);
            this.lblPrecioMatri.TabIndex = 37;
            this.lblPrecioMatri.Text = "Precio de matrícula: $";
            // 
            // lblCantCuotas
            // 
            this.lblCantCuotas.AutoSize = true;
            this.lblCantCuotas.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantCuotas.ForeColor = System.Drawing.Color.White;
            this.lblCantCuotas.Location = new System.Drawing.Point(428, 161);
            this.lblCantCuotas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCantCuotas.Name = "lblCantCuotas";
            this.lblCantCuotas.Size = new System.Drawing.Size(174, 18);
            this.lblCantCuotas.TabIndex = 36;
            this.lblCantCuotas.Text = "Cantidad de cuotas:";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.Color.White;
            this.label.Location = new System.Drawing.Point(25, 41);
            this.label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(79, 16);
            this.label.TabIndex = 19;
            this.label.Text = "Inscripción";
            // 
            // lblPrecioMensual
            // 
            this.lblPrecioMensual.AutoSize = true;
            this.lblPrecioMensual.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioMensual.ForeColor = System.Drawing.Color.White;
            this.lblPrecioMensual.Location = new System.Drawing.Point(461, 88);
            this.lblPrecioMensual.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrecioMensual.Name = "lblPrecioMensual";
            this.lblPrecioMensual.Size = new System.Drawing.Size(155, 18);
            this.lblPrecioMensual.TabIndex = 35;
            this.lblPrecioMensual.Text = "Precio mensual: $";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(101, 125);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(80, 18);
            this.label13.TabIndex = 21;
            this.label13.Text = "Deporte:";
            // 
            // lblDeporteSeleccionado
            // 
            this.lblDeporteSeleccionado.AutoSize = true;
            this.lblDeporteSeleccionado.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeporteSeleccionado.ForeColor = System.Drawing.Color.White;
            this.lblDeporteSeleccionado.Location = new System.Drawing.Point(181, 125);
            this.lblDeporteSeleccionado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDeporteSeleccionado.Name = "lblDeporteSeleccionado";
            this.lblDeporteSeleccionado.Size = new System.Drawing.Size(0, 18);
            this.lblDeporteSeleccionado.TabIndex = 22;
            // 
            // grpSocio
            // 
            this.grpSocio.Controls.Add(this.label3);
            this.grpSocio.Controls.Add(this.lblNombreTutor);
            this.grpSocio.Controls.Add(this.lblNombreTutorSeleccionado);
            this.grpSocio.Controls.Add(this.lblDniTutor);
            this.grpSocio.Controls.Add(this.lblDniTutorSeleccionado);
            this.grpSocio.Controls.Add(this.lblNombreSocio);
            this.grpSocio.Controls.Add(this.lblNombreSocioSeleccionado);
            this.grpSocio.Controls.Add(this.btnBuscarSocio);
            this.grpSocio.Controls.Add(this.txtBuscarSocio);
            this.grpSocio.Controls.Add(this.label4);
            this.grpSocio.Controls.Add(this.lblIdSocio);
            this.grpSocio.Controls.Add(this.lblDniSocio);
            this.grpSocio.Controls.Add(this.lblIdSocioSeleccionado);
            this.grpSocio.Controls.Add(this.lblDniSocioSeleccionado);
            this.grpSocio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpSocio.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSocio.ForeColor = System.Drawing.Color.White;
            this.grpSocio.Location = new System.Drawing.Point(75, 146);
            this.grpSocio.Name = "grpSocio";
            this.grpSocio.Size = new System.Drawing.Size(409, 367);
            this.grpSocio.TabIndex = 37;
            this.grpSocio.TabStop = false;
            this.grpSocio.Text = "Datos del socio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(138, 238);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 18);
            this.label3.TabIndex = 31;
            this.label3.Text = "Datos del tutor";
            // 
            // lblNombreTutor
            // 
            this.lblNombreTutor.AutoSize = true;
            this.lblNombreTutor.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreTutor.ForeColor = System.Drawing.Color.White;
            this.lblNombreTutor.Location = new System.Drawing.Point(61, 320);
            this.lblNombreTutor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreTutor.Name = "lblNombreTutor";
            this.lblNombreTutor.Size = new System.Drawing.Size(56, 18);
            this.lblNombreTutor.TabIndex = 29;
            this.lblNombreTutor.Text = "Tutor:";
            // 
            // lblNombreTutorSeleccionado
            // 
            this.lblNombreTutorSeleccionado.AutoSize = true;
            this.lblNombreTutorSeleccionado.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreTutorSeleccionado.ForeColor = System.Drawing.Color.White;
            this.lblNombreTutorSeleccionado.Location = new System.Drawing.Point(127, 320);
            this.lblNombreTutorSeleccionado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreTutorSeleccionado.Name = "lblNombreTutorSeleccionado";
            this.lblNombreTutorSeleccionado.Size = new System.Drawing.Size(0, 18);
            this.lblNombreTutorSeleccionado.TabIndex = 30;
            // 
            // lblDniTutor
            // 
            this.lblDniTutor.AutoSize = true;
            this.lblDniTutor.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDniTutor.ForeColor = System.Drawing.Color.White;
            this.lblDniTutor.Location = new System.Drawing.Point(71, 284);
            this.lblDniTutor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDniTutor.Name = "lblDniTutor";
            this.lblDniTutor.Size = new System.Drawing.Size(46, 18);
            this.lblDniTutor.TabIndex = 27;
            this.lblDniTutor.Text = "DNI:";
            // 
            // lblDniTutorSeleccionado
            // 
            this.lblDniTutorSeleccionado.AutoSize = true;
            this.lblDniTutorSeleccionado.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDniTutorSeleccionado.ForeColor = System.Drawing.Color.White;
            this.lblDniTutorSeleccionado.Location = new System.Drawing.Point(127, 284);
            this.lblDniTutorSeleccionado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDniTutorSeleccionado.Name = "lblDniTutorSeleccionado";
            this.lblDniTutorSeleccionado.Size = new System.Drawing.Size(0, 18);
            this.lblDniTutorSeleccionado.TabIndex = 28;
            // 
            // lblNombreSocio
            // 
            this.lblNombreSocio.AutoSize = true;
            this.lblNombreSocio.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreSocio.ForeColor = System.Drawing.Color.White;
            this.lblNombreSocio.Location = new System.Drawing.Point(59, 197);
            this.lblNombreSocio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreSocio.Name = "lblNombreSocio";
            this.lblNombreSocio.Size = new System.Drawing.Size(58, 18);
            this.lblNombreSocio.TabIndex = 25;
            this.lblNombreSocio.Text = "Socio:";
            // 
            // lblNombreSocioSeleccionado
            // 
            this.lblNombreSocioSeleccionado.AutoSize = true;
            this.lblNombreSocioSeleccionado.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreSocioSeleccionado.ForeColor = System.Drawing.Color.White;
            this.lblNombreSocioSeleccionado.Location = new System.Drawing.Point(129, 197);
            this.lblNombreSocioSeleccionado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreSocioSeleccionado.Name = "lblNombreSocioSeleccionado";
            this.lblNombreSocioSeleccionado.Size = new System.Drawing.Size(0, 18);
            this.lblNombreSocioSeleccionado.TabIndex = 26;
            // 
            // btnBuscarSocio
            // 
            this.btnBuscarSocio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(129)))), ((int)(((byte)(5)))));
            this.btnBuscarSocio.FlatAppearance.BorderSize = 0;
            this.btnBuscarSocio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarSocio.Location = new System.Drawing.Point(234, 69);
            this.btnBuscarSocio.Name = "btnBuscarSocio";
            this.btnBuscarSocio.Size = new System.Drawing.Size(88, 27);
            this.btnBuscarSocio.TabIndex = 24;
            this.btnBuscarSocio.Text = "Buscar";
            this.btnBuscarSocio.UseVisualStyleBackColor = false;
            this.btnBuscarSocio.Click += new System.EventHandler(this.btnBuscarSocio_Click);
            // 
            // txtBuscarSocio
            // 
            this.txtBuscarSocio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(129)))), ((int)(((byte)(5)))));
            this.txtBuscarSocio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscarSocio.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBuscarSocio.ForeColor = System.Drawing.Color.White;
            this.txtBuscarSocio.Location = new System.Drawing.Point(88, 69);
            this.txtBuscarSocio.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtBuscarSocio.Name = "txtBuscarSocio";
            this.txtBuscarSocio.Size = new System.Drawing.Size(139, 27);
            this.txtBuscarSocio.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(85, 41);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(239, 16);
            this.label4.TabIndex = 20;
            this.label4.Text = "Buscar socio por DNI ó N° de socio";
            // 
            // lblIdSocio
            // 
            this.lblIdSocio.AutoSize = true;
            this.lblIdSocio.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdSocio.ForeColor = System.Drawing.Color.White;
            this.lblIdSocio.Location = new System.Drawing.Point(32, 125);
            this.lblIdSocio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdSocio.Name = "lblIdSocio";
            this.lblIdSocio.Size = new System.Drawing.Size(85, 18);
            this.lblIdSocio.TabIndex = 17;
            this.lblIdSocio.Text = "N° Socio:";
            // 
            // lblDniSocio
            // 
            this.lblDniSocio.AutoSize = true;
            this.lblDniSocio.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDniSocio.ForeColor = System.Drawing.Color.White;
            this.lblDniSocio.Location = new System.Drawing.Point(71, 161);
            this.lblDniSocio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDniSocio.Name = "lblDniSocio";
            this.lblDniSocio.Size = new System.Drawing.Size(46, 18);
            this.lblDniSocio.TabIndex = 18;
            this.lblDniSocio.Text = "DNI:";
            // 
            // lblIdSocioSeleccionado
            // 
            this.lblIdSocioSeleccionado.AutoSize = true;
            this.lblIdSocioSeleccionado.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdSocioSeleccionado.ForeColor = System.Drawing.Color.White;
            this.lblIdSocioSeleccionado.Location = new System.Drawing.Point(129, 125);
            this.lblIdSocioSeleccionado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdSocioSeleccionado.Name = "lblIdSocioSeleccionado";
            this.lblIdSocioSeleccionado.Size = new System.Drawing.Size(0, 18);
            this.lblIdSocioSeleccionado.TabIndex = 21;
            // 
            // lblDniSocioSeleccionado
            // 
            this.lblDniSocioSeleccionado.AutoSize = true;
            this.lblDniSocioSeleccionado.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDniSocioSeleccionado.ForeColor = System.Drawing.Color.White;
            this.lblDniSocioSeleccionado.Location = new System.Drawing.Point(129, 161);
            this.lblDniSocioSeleccionado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDniSocioSeleccionado.Name = "lblDniSocioSeleccionado";
            this.lblDniSocioSeleccionado.Size = new System.Drawing.Size(0, 18);
            this.lblDniSocioSeleccionado.TabIndex = 22;
            // 
            // btnQuitarPago
            // 
            this.btnQuitarPago.BackColor = System.Drawing.Color.DimGray;
            this.btnQuitarPago.BackgroundImage = global::CDVU.Properties.Resources.icons8_ventana_abierta_64;
            this.btnQuitarPago.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnQuitarPago.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuitarPago.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnQuitarPago.FlatAppearance.BorderSize = 0;
            this.btnQuitarPago.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnQuitarPago.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnQuitarPago.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnQuitarPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitarPago.Location = new System.Drawing.Point(358, 286);
            this.btnQuitarPago.Name = "btnQuitarPago";
            this.btnQuitarPago.Size = new System.Drawing.Size(59, 50);
            this.btnQuitarPago.TabIndex = 33;
            this.btnQuitarPago.UseVisualStyleBackColor = false;
            this.btnQuitarPago.Click += new System.EventHandler(this.btnQuitarPago_Click);
            // 
            // btnAgregarPago
            // 
            this.btnAgregarPago.BackColor = System.Drawing.Color.DimGray;
            this.btnAgregarPago.BackgroundImage = global::CDVU.Properties.Resources.icons8_panel_cerrado_64;
            this.btnAgregarPago.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAgregarPago.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarPago.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAgregarPago.FlatAppearance.BorderSize = 0;
            this.btnAgregarPago.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnAgregarPago.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAgregarPago.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAgregarPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarPago.Location = new System.Drawing.Point(358, 234);
            this.btnAgregarPago.Name = "btnAgregarPago";
            this.btnAgregarPago.Size = new System.Drawing.Size(59, 50);
            this.btnAgregarPago.TabIndex = 32;
            this.btnAgregarPago.UseVisualStyleBackColor = false;
            this.btnAgregarPago.Click += new System.EventHandler(this.btnAgregarPago_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(83, 215);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 16);
            this.label2.TabIndex = 35;
            this.label2.Text = "Cuotas que se deben";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(455, 215);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 16);
            this.label1.TabIndex = 35;
            this.label1.Text = "Cuotas a pagar";
            // 
            // lstCuotaDeuda
            // 
            this.lstCuotaDeuda.BackColor = System.Drawing.Color.DimGray;
            this.lstCuotaDeuda.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lstCuotaDeuda.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCuotaDeuda.ForeColor = System.Drawing.Color.White;
            this.lstCuotaDeuda.FormattingEnabled = true;
            this.lstCuotaDeuda.ItemHeight = 14;
            this.lstCuotaDeuda.Location = new System.Drawing.Point(86, 234);
            this.lstCuotaDeuda.Name = "lstCuotaDeuda";
            this.lstCuotaDeuda.ScrollAlwaysVisible = true;
            this.lstCuotaDeuda.Size = new System.Drawing.Size(231, 102);
            this.lstCuotaDeuda.TabIndex = 34;
            this.lstCuotaDeuda.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lstCuotaDeuda_DrawItem);
            // 
            // lstCuotaAPagar
            // 
            this.lstCuotaAPagar.BackColor = System.Drawing.Color.DimGray;
            this.lstCuotaAPagar.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lstCuotaAPagar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCuotaAPagar.ForeColor = System.Drawing.Color.White;
            this.lstCuotaAPagar.FormattingEnabled = true;
            this.lstCuotaAPagar.ItemHeight = 14;
            this.lstCuotaAPagar.Location = new System.Drawing.Point(458, 234);
            this.lstCuotaAPagar.Name = "lstCuotaAPagar";
            this.lstCuotaAPagar.ScrollAlwaysVisible = true;
            this.lstCuotaAPagar.Size = new System.Drawing.Size(231, 102);
            this.lstCuotaAPagar.TabIndex = 34;
            this.lstCuotaAPagar.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lstCuotaAPagar_DrawItem);
            // 
            // lblControle
            // 
            this.lblControle.AutoSize = true;
            this.lblControle.Font = new System.Drawing.Font("Verdana", 10F);
            this.lblControle.ForeColor = System.Drawing.Color.White;
            this.lblControle.Location = new System.Drawing.Point(56, 162);
            this.lblControle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblControle.Name = "lblControle";
            this.lblControle.Size = new System.Drawing.Size(453, 17);
            this.lblControle.TabIndex = 44;
            this.lblControle.Text = "Por favor controle los datos antes de dar por finalizado el pago";
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
            this.btnCancelar.Location = new System.Drawing.Point(294, 193);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(69, 70);
            this.btnCancelar.TabIndex = 43;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            this.btnCancelar.MouseHover += new System.EventHandler(this.btnCancelar_MouseHover);
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
            this.btnAceptar.Location = new System.Drawing.Point(199, 193);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(69, 70);
            this.btnAceptar.TabIndex = 42;
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            this.btnAceptar.MouseHover += new System.EventHandler(this.btnAceptar_MouseHover);
            // 
            // frmTesoreria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1380, 862);
            this.Controls.Add(this.grpPago);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.grpInscripcion);
            this.Controls.Add(this.grpSocio);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmTesoreria";
            this.Text = "frmSocio";
            this.Load += new System.EventHandler(this.frmTesoreria_Load);
            this.grpPago.ResumeLayout(false);
            this.grpPago.PerformLayout();
            this.grpInscripcion.ResumeLayout(false);
            this.grpInscripcion.PerformLayout();
            this.grpSocio.ResumeLayout(false);
            this.grpSocio.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox grpPago;
        private System.Windows.Forms.Button btnQuitarPago;
        private System.Windows.Forms.Button btnAgregarPago;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstCuotaDeuda;
        private System.Windows.Forms.ListBox lstCuotaAPagar;
        private System.Windows.Forms.GroupBox grpSocio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNombreTutor;
        private System.Windows.Forms.Label lblNombreTutorSeleccionado;
        private System.Windows.Forms.Label lblDniTutor;
        private System.Windows.Forms.Label lblDniTutorSeleccionado;
        private System.Windows.Forms.Label lblNombreSocio;
        private System.Windows.Forms.Label lblNombreSocioSeleccionado;
        private System.Windows.Forms.Button btnBuscarSocio;
        private System.Windows.Forms.TextBox txtBuscarSocio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblIdSocio;
        private System.Windows.Forms.Label lblDniSocio;
        private System.Windows.Forms.Label lblIdSocioSeleccionado;
        private System.Windows.Forms.Label lblDniSocioSeleccionado;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox grpInscripcion;
        private System.Windows.Forms.Label lblPrecioMensualSeleccionado;
        private System.Windows.Forms.Label lblCantidadCuotas;
        private System.Windows.Forms.ComboBox cmbInscripcion;
        private System.Windows.Forms.Label lblPrecioMatSeleccionado;
        private System.Windows.Forms.Label lblPrecioMatri;
        private System.Windows.Forms.Label lblCantCuotas;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label lblPrecioMensual;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblDeporteSeleccionado;
        private System.Windows.Forms.Label lblControle;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblFechaInscripcion;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label8;
    }
}