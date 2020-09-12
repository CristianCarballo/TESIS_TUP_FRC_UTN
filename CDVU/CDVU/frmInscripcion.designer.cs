namespace CDVU
{
    partial class frmInscripcion
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
            this.lstInscripciones = new System.Windows.Forms.ListBox();
            this.grpBotones = new System.Windows.Forms.GroupBox();
            this.btnEliminarInscripcion = new System.Windows.Forms.Button();
            this.btnAgregarInscripcion = new System.Windows.Forms.Button();
            this.grpSocio = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNombreTutor = new System.Windows.Forms.Label();
            this.lblNombreTutorSeleccionado = new System.Windows.Forms.Label();
            this.lblDniTutor = new System.Windows.Forms.Label();
            this.lblDniTutorSeleccionado = new System.Windows.Forms.Label();
            this.lblNombreSocio = new System.Windows.Forms.Label();
            this.lblNombreSocioSeleccionado = new System.Windows.Forms.Label();
            this.btnBuscarSocio = new System.Windows.Forms.Button();
            this.txtBuscarSocio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblIdSocio = new System.Windows.Forms.Label();
            this.lblDniSocio = new System.Windows.Forms.Label();
            this.lblIdSocioSeleccionado = new System.Windows.Forms.Label();
            this.lblDniSocioSeleccionado = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.grpEntrenamiento = new System.Windows.Forms.GroupBox();
            this.lblPrecioMensualSeleccionado = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.lblCantidadCuotas = new System.Windows.Forms.Label();
            this.cmbEntrenamiento = new System.Windows.Forms.ComboBox();
            this.lblPrecioMatSeleccionado = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.lblPrecioMatri = new System.Windows.Forms.Label();
            this.lblCantCuotas = new System.Windows.Forms.Label();
            this.lblPrecioMensual = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.lblDeporteSeleccionado = new System.Windows.Forms.Label();
            this.lblHorario = new System.Windows.Forms.Label();
            this.lblDomingo = new System.Windows.Forms.Label();
            this.lstProfesores = new System.Windows.Forms.ListBox();
            this.lblSabado = new System.Windows.Forms.Label();
            this.lblProfesores = new System.Windows.Forms.Label();
            this.lblViernes = new System.Windows.Forms.Label();
            this.txtPredio = new System.Windows.Forms.RichTextBox();
            this.lblJueves = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblMiercoles = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.lblMartes = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lblLunes = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.lblControle = new System.Windows.Forms.Label();
            this.grpBotones.SuspendLayout();
            this.grpSocio.SuspendLayout();
            this.grpEntrenamiento.SuspendLayout();
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
            this.lblTitulo.Size = new System.Drawing.Size(511, 77);
            this.lblTitulo.TabIndex = 10;
            this.lblTitulo.Text = "INSCRIPCIONES";
            // 
            // lstInscripciones
            // 
            this.lstInscripciones.BackColor = System.Drawing.Color.DimGray;
            this.lstInscripciones.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lstInscripciones.ForeColor = System.Drawing.Color.White;
            this.lstInscripciones.FormattingEnabled = true;
            this.lstInscripciones.ItemHeight = 14;
            this.lstInscripciones.Location = new System.Drawing.Point(44, 357);
            this.lstInscripciones.Name = "lstInscripciones";
            this.lstInscripciones.Size = new System.Drawing.Size(480, 354);
            this.lstInscripciones.TabIndex = 12;
            this.lstInscripciones.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lstInscripciones_DrawItem);
            // 
            // grpBotones
            // 
            this.grpBotones.Controls.Add(this.btnEliminarInscripcion);
            this.grpBotones.Controls.Add(this.btnAgregarInscripcion);
            this.grpBotones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpBotones.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBotones.ForeColor = System.Drawing.Color.White;
            this.grpBotones.Location = new System.Drawing.Point(42, 98);
            this.grpBotones.Name = "grpBotones";
            this.grpBotones.Size = new System.Drawing.Size(480, 115);
            this.grpBotones.TabIndex = 11;
            this.grpBotones.TabStop = false;
            this.grpBotones.Text = "¿Qué desea hacer?";
            // 
            // btnEliminarInscripcion
            // 
            this.btnEliminarInscripcion.BackColor = System.Drawing.Color.DimGray;
            this.btnEliminarInscripcion.BackgroundImage = global::CDVU.Properties.Resources.icons8_eliminar_64;
            this.btnEliminarInscripcion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEliminarInscripcion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarInscripcion.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEliminarInscripcion.FlatAppearance.BorderSize = 0;
            this.btnEliminarInscripcion.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnEliminarInscripcion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnEliminarInscripcion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnEliminarInscripcion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarInscripcion.Location = new System.Drawing.Point(258, 30);
            this.btnEliminarInscripcion.Name = "btnEliminarInscripcion";
            this.btnEliminarInscripcion.Size = new System.Drawing.Size(69, 70);
            this.btnEliminarInscripcion.TabIndex = 2;
            this.btnEliminarInscripcion.UseVisualStyleBackColor = false;
            this.btnEliminarInscripcion.Click += new System.EventHandler(this.btnEliminarInscripcion_Click);
            this.btnEliminarInscripcion.MouseHover += new System.EventHandler(this.btnEliminarInscripcion_MouseHover);
            // 
            // btnAgregarInscripcion
            // 
            this.btnAgregarInscripcion.BackColor = System.Drawing.Color.DimGray;
            this.btnAgregarInscripcion.BackgroundImage = global::CDVU.Properties.Resources.icons8_añadir_64;
            this.btnAgregarInscripcion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAgregarInscripcion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarInscripcion.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAgregarInscripcion.FlatAppearance.BorderSize = 0;
            this.btnAgregarInscripcion.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnAgregarInscripcion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAgregarInscripcion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAgregarInscripcion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarInscripcion.Location = new System.Drawing.Point(154, 30);
            this.btnAgregarInscripcion.Name = "btnAgregarInscripcion";
            this.btnAgregarInscripcion.Size = new System.Drawing.Size(69, 70);
            this.btnAgregarInscripcion.TabIndex = 0;
            this.btnAgregarInscripcion.UseVisualStyleBackColor = false;
            this.btnAgregarInscripcion.Click += new System.EventHandler(this.btnAgregarInscripcion_Click);
            this.btnAgregarInscripcion.MouseHover += new System.EventHandler(this.btnAgregarInscripcion_MouseHover);
            // 
            // grpSocio
            // 
            this.grpSocio.Controls.Add(this.label2);
            this.grpSocio.Controls.Add(this.lblNombreTutor);
            this.grpSocio.Controls.Add(this.lblNombreTutorSeleccionado);
            this.grpSocio.Controls.Add(this.lblDniTutor);
            this.grpSocio.Controls.Add(this.lblDniTutorSeleccionado);
            this.grpSocio.Controls.Add(this.lblNombreSocio);
            this.grpSocio.Controls.Add(this.lblNombreSocioSeleccionado);
            this.grpSocio.Controls.Add(this.btnBuscarSocio);
            this.grpSocio.Controls.Add(this.txtBuscarSocio);
            this.grpSocio.Controls.Add(this.label1);
            this.grpSocio.Controls.Add(this.lblIdSocio);
            this.grpSocio.Controls.Add(this.lblDniSocio);
            this.grpSocio.Controls.Add(this.lblIdSocioSeleccionado);
            this.grpSocio.Controls.Add(this.lblDniSocioSeleccionado);
            this.grpSocio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpSocio.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSocio.ForeColor = System.Drawing.Color.White;
            this.grpSocio.Location = new System.Drawing.Point(562, 98);
            this.grpSocio.Name = "grpSocio";
            this.grpSocio.Size = new System.Drawing.Size(773, 220);
            this.grpSocio.TabIndex = 12;
            this.grpSocio.TabStop = false;
            this.grpSocio.Text = "Datos del socio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(516, 97);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 18);
            this.label2.TabIndex = 31;
            this.label2.Text = "Datos del tutor";
            // 
            // lblNombreTutor
            // 
            this.lblNombreTutor.AutoSize = true;
            this.lblNombreTutor.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreTutor.ForeColor = System.Drawing.Color.White;
            this.lblNombreTutor.Location = new System.Drawing.Point(410, 179);
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
            this.lblNombreTutorSeleccionado.Location = new System.Drawing.Point(476, 179);
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
            this.lblDniTutor.Location = new System.Drawing.Point(420, 143);
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
            this.lblDniTutorSeleccionado.Location = new System.Drawing.Point(476, 143);
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
            this.lblNombreSocio.Location = new System.Drawing.Point(62, 179);
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
            this.lblNombreSocioSeleccionado.Location = new System.Drawing.Point(132, 179);
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
            this.btnBuscarSocio.Location = new System.Drawing.Point(178, 63);
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
            this.txtBuscarSocio.Location = new System.Drawing.Point(32, 63);
            this.txtBuscarSocio.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtBuscarSocio.Name = "txtBuscarSocio";
            this.txtBuscarSocio.Size = new System.Drawing.Size(139, 27);
            this.txtBuscarSocio.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(29, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 16);
            this.label1.TabIndex = 20;
            this.label1.Text = "Buscar socio por DNI ó N° de socio";
            // 
            // lblIdSocio
            // 
            this.lblIdSocio.AutoSize = true;
            this.lblIdSocio.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdSocio.ForeColor = System.Drawing.Color.White;
            this.lblIdSocio.Location = new System.Drawing.Point(35, 107);
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
            this.lblDniSocio.Location = new System.Drawing.Point(74, 143);
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
            this.lblIdSocioSeleccionado.Location = new System.Drawing.Point(132, 107);
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
            this.lblDniSocioSeleccionado.Location = new System.Drawing.Point(132, 143);
            this.lblDniSocioSeleccionado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDniSocioSeleccionado.Name = "lblDniSocioSeleccionado";
            this.lblDniSocioSeleccionado.Size = new System.Drawing.Size(0, 18);
            this.lblDniSocioSeleccionado.TabIndex = 22;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.Color.White;
            this.label.Location = new System.Drawing.Point(29, 34);
            this.label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(103, 16);
            this.label.TabIndex = 19;
            this.label.Text = "Entrenamiento";
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
            this.btnCancelar.Location = new System.Drawing.Point(969, 759);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(69, 70);
            this.btnCancelar.TabIndex = 14;
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
            this.btnAceptar.Location = new System.Drawing.Point(874, 759);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(69, 70);
            this.btnAceptar.TabIndex = 13;
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            this.btnAceptar.MouseHover += new System.EventHandler(this.btnAceptar_MouseHover);
            // 
            // grpEntrenamiento
            // 
            this.grpEntrenamiento.Controls.Add(this.lblPrecioMensualSeleccionado);
            this.grpEntrenamiento.Controls.Add(this.label24);
            this.grpEntrenamiento.Controls.Add(this.lblCantidadCuotas);
            this.grpEntrenamiento.Controls.Add(this.cmbEntrenamiento);
            this.grpEntrenamiento.Controls.Add(this.lblPrecioMatSeleccionado);
            this.grpEntrenamiento.Controls.Add(this.label23);
            this.grpEntrenamiento.Controls.Add(this.lblPrecioMatri);
            this.grpEntrenamiento.Controls.Add(this.lblCantCuotas);
            this.grpEntrenamiento.Controls.Add(this.label);
            this.grpEntrenamiento.Controls.Add(this.lblPrecioMensual);
            this.grpEntrenamiento.Controls.Add(this.label22);
            this.grpEntrenamiento.Controls.Add(this.label13);
            this.grpEntrenamiento.Controls.Add(this.label21);
            this.grpEntrenamiento.Controls.Add(this.lblDeporteSeleccionado);
            this.grpEntrenamiento.Controls.Add(this.lblHorario);
            this.grpEntrenamiento.Controls.Add(this.lblDomingo);
            this.grpEntrenamiento.Controls.Add(this.lstProfesores);
            this.grpEntrenamiento.Controls.Add(this.lblSabado);
            this.grpEntrenamiento.Controls.Add(this.lblProfesores);
            this.grpEntrenamiento.Controls.Add(this.lblViernes);
            this.grpEntrenamiento.Controls.Add(this.txtPredio);
            this.grpEntrenamiento.Controls.Add(this.lblJueves);
            this.grpEntrenamiento.Controls.Add(this.label14);
            this.grpEntrenamiento.Controls.Add(this.lblMiercoles);
            this.grpEntrenamiento.Controls.Add(this.label20);
            this.grpEntrenamiento.Controls.Add(this.lblMartes);
            this.grpEntrenamiento.Controls.Add(this.label18);
            this.grpEntrenamiento.Controls.Add(this.lblLunes);
            this.grpEntrenamiento.Controls.Add(this.label19);
            this.grpEntrenamiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpEntrenamiento.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpEntrenamiento.ForeColor = System.Drawing.Color.White;
            this.grpEntrenamiento.Location = new System.Drawing.Point(562, 346);
            this.grpEntrenamiento.Name = "grpEntrenamiento";
            this.grpEntrenamiento.Size = new System.Drawing.Size(773, 365);
            this.grpEntrenamiento.TabIndex = 31;
            this.grpEntrenamiento.TabStop = false;
            this.grpEntrenamiento.Text = "Datos del entrenamiento";
            // 
            // lblPrecioMensualSeleccionado
            // 
            this.lblPrecioMensualSeleccionado.AutoSize = true;
            this.lblPrecioMensualSeleccionado.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioMensualSeleccionado.ForeColor = System.Drawing.Color.White;
            this.lblPrecioMensualSeleccionado.Location = new System.Drawing.Point(580, 250);
            this.lblPrecioMensualSeleccionado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrecioMensualSeleccionado.Name = "lblPrecioMensualSeleccionado";
            this.lblPrecioMensualSeleccionado.Size = new System.Drawing.Size(0, 18);
            this.lblPrecioMensualSeleccionado.TabIndex = 40;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.White;
            this.label24.Location = new System.Drawing.Point(377, 198);
            this.label24.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(69, 16);
            this.label24.TabIndex = 58;
            this.label24.Text = "Domingo:";
            // 
            // lblCantidadCuotas
            // 
            this.lblCantidadCuotas.AutoSize = true;
            this.lblCantidadCuotas.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadCuotas.ForeColor = System.Drawing.Color.White;
            this.lblCantidadCuotas.Location = new System.Drawing.Point(580, 330);
            this.lblCantidadCuotas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCantidadCuotas.Name = "lblCantidadCuotas";
            this.lblCantidadCuotas.Size = new System.Drawing.Size(0, 18);
            this.lblCantidadCuotas.TabIndex = 39;
            // 
            // cmbEntrenamiento
            // 
            this.cmbEntrenamiento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(129)))), ((int)(((byte)(5)))));
            this.cmbEntrenamiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbEntrenamiento.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEntrenamiento.ForeColor = System.Drawing.Color.White;
            this.cmbEntrenamiento.FormattingEnabled = true;
            this.cmbEntrenamiento.Location = new System.Drawing.Point(32, 62);
            this.cmbEntrenamiento.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbEntrenamiento.Name = "cmbEntrenamiento";
            this.cmbEntrenamiento.Size = new System.Drawing.Size(287, 22);
            this.cmbEntrenamiento.TabIndex = 31;
            this.cmbEntrenamiento.SelectionChangeCommitted += new System.EventHandler(this.cmbEntrenamiento_SelectionChangeCommitted);
            // 
            // lblPrecioMatSeleccionado
            // 
            this.lblPrecioMatSeleccionado.AutoSize = true;
            this.lblPrecioMatSeleccionado.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioMatSeleccionado.ForeColor = System.Drawing.Color.White;
            this.lblPrecioMatSeleccionado.Location = new System.Drawing.Point(580, 290);
            this.lblPrecioMatSeleccionado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrecioMatSeleccionado.Name = "lblPrecioMatSeleccionado";
            this.lblPrecioMatSeleccionado.Size = new System.Drawing.Size(0, 18);
            this.lblPrecioMatSeleccionado.TabIndex = 38;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.White;
            this.label23.Location = new System.Drawing.Point(383, 175);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(63, 16);
            this.label23.TabIndex = 57;
            this.label23.Text = "Sábado:";
            // 
            // lblPrecioMatri
            // 
            this.lblPrecioMatri.AutoSize = true;
            this.lblPrecioMatri.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioMatri.ForeColor = System.Drawing.Color.White;
            this.lblPrecioMatri.Location = new System.Drawing.Point(388, 290);
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
            this.lblCantCuotas.Location = new System.Drawing.Point(386, 330);
            this.lblCantCuotas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCantCuotas.Name = "lblCantCuotas";
            this.lblCantCuotas.Size = new System.Drawing.Size(174, 18);
            this.lblCantCuotas.TabIndex = 36;
            this.lblCantCuotas.Text = "Cantidad de cuotas:";
            // 
            // lblPrecioMensual
            // 
            this.lblPrecioMensual.AutoSize = true;
            this.lblPrecioMensual.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioMensual.ForeColor = System.Drawing.Color.White;
            this.lblPrecioMensual.Location = new System.Drawing.Point(421, 250);
            this.lblPrecioMensual.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrecioMensual.Name = "lblPrecioMensual";
            this.lblPrecioMensual.Size = new System.Drawing.Size(155, 18);
            this.lblPrecioMensual.TabIndex = 35;
            this.lblPrecioMensual.Text = "Precio mensual: $";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.White;
            this.label22.Location = new System.Drawing.Point(383, 152);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(62, 16);
            this.label22.TabIndex = 56;
            this.label22.Text = "Viernes:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(29, 127);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(80, 18);
            this.label13.TabIndex = 21;
            this.label13.Text = "Deporte:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.White;
            this.label21.Location = new System.Drawing.Point(386, 129);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(59, 16);
            this.label21.TabIndex = 55;
            this.label21.Text = "Jueves:";
            // 
            // lblDeporteSeleccionado
            // 
            this.lblDeporteSeleccionado.AutoSize = true;
            this.lblDeporteSeleccionado.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeporteSeleccionado.ForeColor = System.Drawing.Color.White;
            this.lblDeporteSeleccionado.Location = new System.Drawing.Point(109, 127);
            this.lblDeporteSeleccionado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDeporteSeleccionado.Name = "lblDeporteSeleccionado";
            this.lblDeporteSeleccionado.Size = new System.Drawing.Size(0, 18);
            this.lblDeporteSeleccionado.TabIndex = 22;
            // 
            // lblHorario
            // 
            this.lblHorario.AutoSize = true;
            this.lblHorario.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorario.ForeColor = System.Drawing.Color.White;
            this.lblHorario.Location = new System.Drawing.Point(370, 32);
            this.lblHorario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHorario.Name = "lblHorario";
            this.lblHorario.Size = new System.Drawing.Size(74, 18);
            this.lblHorario.TabIndex = 25;
            this.lblHorario.Text = "Horario:";
            // 
            // lblDomingo
            // 
            this.lblDomingo.AutoSize = true;
            this.lblDomingo.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDomingo.ForeColor = System.Drawing.Color.White;
            this.lblDomingo.Location = new System.Drawing.Point(462, 198);
            this.lblDomingo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDomingo.Name = "lblDomingo";
            this.lblDomingo.Size = new System.Drawing.Size(0, 16);
            this.lblDomingo.TabIndex = 54;
            // 
            // lstProfesores
            // 
            this.lstProfesores.BackColor = System.Drawing.Color.DimGray;
            this.lstProfesores.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lstProfesores.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstProfesores.ForeColor = System.Drawing.Color.White;
            this.lstProfesores.FormattingEnabled = true;
            this.lstProfesores.ItemHeight = 14;
            this.lstProfesores.Location = new System.Drawing.Point(112, 175);
            this.lstProfesores.Name = "lstProfesores";
            this.lstProfesores.Size = new System.Drawing.Size(207, 60);
            this.lstProfesores.TabIndex = 21;
            this.lstProfesores.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lstProfesores_DrawItem);
            // 
            // lblSabado
            // 
            this.lblSabado.AutoSize = true;
            this.lblSabado.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSabado.ForeColor = System.Drawing.Color.White;
            this.lblSabado.Location = new System.Drawing.Point(462, 175);
            this.lblSabado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSabado.Name = "lblSabado";
            this.lblSabado.Size = new System.Drawing.Size(0, 16);
            this.lblSabado.TabIndex = 53;
            // 
            // lblProfesores
            // 
            this.lblProfesores.AutoSize = true;
            this.lblProfesores.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfesores.ForeColor = System.Drawing.Color.White;
            this.lblProfesores.Location = new System.Drawing.Point(8, 174);
            this.lblProfesores.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProfesores.Name = "lblProfesores";
            this.lblProfesores.Size = new System.Drawing.Size(101, 18);
            this.lblProfesores.TabIndex = 23;
            this.lblProfesores.Text = "Profesores:";
            // 
            // lblViernes
            // 
            this.lblViernes.AutoSize = true;
            this.lblViernes.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViernes.ForeColor = System.Drawing.Color.White;
            this.lblViernes.Location = new System.Drawing.Point(462, 152);
            this.lblViernes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblViernes.Name = "lblViernes";
            this.lblViernes.Size = new System.Drawing.Size(0, 16);
            this.lblViernes.TabIndex = 52;
            // 
            // txtPredio
            // 
            this.txtPredio.BackColor = System.Drawing.Color.DimGray;
            this.txtPredio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPredio.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPredio.ForeColor = System.Drawing.Color.White;
            this.txtPredio.Location = new System.Drawing.Point(112, 271);
            this.txtPredio.Name = "txtPredio";
            this.txtPredio.ReadOnly = true;
            this.txtPredio.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.txtPredio.Size = new System.Drawing.Size(207, 77);
            this.txtPredio.TabIndex = 34;
            this.txtPredio.Text = "";
            // 
            // lblJueves
            // 
            this.lblJueves.AutoSize = true;
            this.lblJueves.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJueves.ForeColor = System.Drawing.Color.White;
            this.lblJueves.Location = new System.Drawing.Point(462, 129);
            this.lblJueves.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblJueves.Name = "lblJueves";
            this.lblJueves.Size = new System.Drawing.Size(0, 16);
            this.lblJueves.TabIndex = 51;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(43, 271);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(66, 18);
            this.label14.TabIndex = 21;
            this.label14.Text = "Predio:";
            // 
            // lblMiercoles
            // 
            this.lblMiercoles.AutoSize = true;
            this.lblMiercoles.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMiercoles.ForeColor = System.Drawing.Color.White;
            this.lblMiercoles.Location = new System.Drawing.Point(462, 106);
            this.lblMiercoles.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMiercoles.Name = "lblMiercoles";
            this.lblMiercoles.Size = new System.Drawing.Size(0, 16);
            this.lblMiercoles.TabIndex = 50;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(370, 106);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(75, 16);
            this.label20.TabIndex = 43;
            this.label20.Text = "Miércoles:";
            // 
            // lblMartes
            // 
            this.lblMartes.AutoSize = true;
            this.lblMartes.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMartes.ForeColor = System.Drawing.Color.White;
            this.lblMartes.Location = new System.Drawing.Point(462, 83);
            this.lblMartes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMartes.Name = "lblMartes";
            this.lblMartes.Size = new System.Drawing.Size(0, 16);
            this.lblMartes.TabIndex = 49;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(393, 60);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(52, 16);
            this.label18.TabIndex = 41;
            this.label18.Text = "Lunes:";
            // 
            // lblLunes
            // 
            this.lblLunes.AutoSize = true;
            this.lblLunes.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLunes.ForeColor = System.Drawing.Color.White;
            this.lblLunes.Location = new System.Drawing.Point(462, 60);
            this.lblLunes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLunes.Name = "lblLunes";
            this.lblLunes.Size = new System.Drawing.Size(0, 16);
            this.lblLunes.TabIndex = 48;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(386, 83);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(59, 16);
            this.label19.TabIndex = 42;
            this.label19.Text = "Martes:";
            // 
            // lblControle
            // 
            this.lblControle.AutoSize = true;
            this.lblControle.Font = new System.Drawing.Font("Verdana", 10F);
            this.lblControle.ForeColor = System.Drawing.Color.White;
            this.lblControle.Location = new System.Drawing.Point(707, 727);
            this.lblControle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblControle.Name = "lblControle";
            this.lblControle.Size = new System.Drawing.Size(490, 17);
            this.lblControle.TabIndex = 32;
            this.lblControle.Text = "Por favor controle los datos antes de dar por finalizada la inscripción";
            // 
            // frmInscripcion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1380, 862);
            this.Controls.Add(this.lblControle);
            this.Controls.Add(this.grpEntrenamiento);
            this.Controls.Add(this.lstInscripciones);
            this.Controls.Add(this.grpBotones);
            this.Controls.Add(this.grpSocio);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnAceptar);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmInscripcion";
            this.Text = "frmSocio";
            this.Load += new System.EventHandler(this.frmInscripcion_Load);
            this.grpBotones.ResumeLayout(false);
            this.grpSocio.ResumeLayout(false);
            this.grpSocio.PerformLayout();
            this.grpEntrenamiento.ResumeLayout(false);
            this.grpEntrenamiento.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.ListBox lstInscripciones;
        private System.Windows.Forms.GroupBox grpBotones;
        private System.Windows.Forms.Button btnEliminarInscripcion;
        private System.Windows.Forms.Button btnAgregarInscripcion;
        private System.Windows.Forms.GroupBox grpEntrenamiento;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.GroupBox grpSocio;
        private System.Windows.Forms.Label lblNombreTutor;
        private System.Windows.Forms.Label lblNombreTutorSeleccionado;
        private System.Windows.Forms.Label lblDniTutor;
        private System.Windows.Forms.Label lblDniTutorSeleccionado;
        private System.Windows.Forms.Label lblNombreSocio;
        private System.Windows.Forms.Label lblNombreSocioSeleccionado;
        private System.Windows.Forms.Button btnBuscarSocio;
        private System.Windows.Forms.TextBox txtBuscarSocio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblIdSocio;
        private System.Windows.Forms.Label lblDniSocio;
        private System.Windows.Forms.Label lblIdSocioSeleccionado;
        private System.Windows.Forms.Label lblDniSocioSeleccionado;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.ComboBox cmbEntrenamiento;
        private System.Windows.Forms.Label lblControle;
        private System.Windows.Forms.Label lblPrecioMensualSeleccionado;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label lblCantidadCuotas;
        private System.Windows.Forms.Label lblPrecioMatSeleccionado;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label lblPrecioMatri;
        private System.Windows.Forms.Label lblCantCuotas;
        private System.Windows.Forms.Label lblPrecioMensual;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label lblDeporteSeleccionado;
        private System.Windows.Forms.Label lblHorario;
        private System.Windows.Forms.Label lblDomingo;
        private System.Windows.Forms.ListBox lstProfesores;
        private System.Windows.Forms.Label lblSabado;
        private System.Windows.Forms.Label lblProfesores;
        private System.Windows.Forms.Label lblViernes;
        private System.Windows.Forms.RichTextBox txtPredio;
        private System.Windows.Forms.Label lblJueves;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblMiercoles;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label lblMartes;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lblLunes;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label2;
    }
}