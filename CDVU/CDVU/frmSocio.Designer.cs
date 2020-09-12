namespace CDVU
{
    partial class frmSocio
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
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblDni = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblFechaNac = new System.Windows.Forms.Label();
            this.lblNacionalidad = new System.Windows.Forms.Label();
            this.cmbNacionalidad = new System.Windows.Forms.ComboBox();
            this.lblLocalidad = new System.Windows.Forms.Label();
            this.cmbLocalidad = new System.Windows.Forms.ComboBox();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.grpBotones = new System.Windows.Forms.GroupBox();
            this.btnEliminarSocio = new System.Windows.Forms.Button();
            this.btnModificarSocio = new System.Windows.Forms.Button();
            this.btnAgregarSocio = new System.Windows.Forms.Button();
            this.lstSocios = new System.Windows.Forms.ListBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.cmbProvincia = new System.Windows.Forms.ComboBox();
            this.lblProvincia = new System.Windows.Forms.Label();
            this.grpFormulario = new System.Windows.Forms.GroupBox();
            this.cmbSexo = new System.Windows.Forms.ComboBox();
            this.lblSexo = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.lblNumSocio = new System.Windows.Forms.Label();
            this.grpTutor = new System.Windows.Forms.GroupBox();
            this.lblNombreTutor = new System.Windows.Forms.Label();
            this.btnQuitarTutor = new System.Windows.Forms.Button();
            this.lblNombreTutorSeleccionado = new System.Windows.Forms.Label();
            this.btnBuscarTutor = new System.Windows.Forms.Button();
            this.txtBuscarTutor = new System.Windows.Forms.TextBox();
            this.lblDniTutor = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblDniTutorSeleccionado = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnBuscarSocio = new System.Windows.Forms.Button();
            this.txtBuscarSocio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpBotones.SuspendLayout();
            this.grpFormulario.SuspendLayout();
            this.grpTutor.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(129)))), ((int)(((byte)(5)))));
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombre.ForeColor = System.Drawing.Color.White;
            this.txtNombre.Location = new System.Drawing.Point(262, 45);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNombre.MaxLength = 50;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(259, 27);
            this.txtNombre.TabIndex = 0;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(171, 47);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(71, 18);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.ForeColor = System.Drawing.Color.White;
            this.lblApellido.Location = new System.Drawing.Point(168, 97);
            this.lblApellido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(74, 18);
            this.lblApellido.TabIndex = 2;
            this.lblApellido.Text = "Apellido";
            // 
            // txtApellido
            // 
            this.txtApellido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(129)))), ((int)(((byte)(5)))));
            this.txtApellido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtApellido.ForeColor = System.Drawing.Color.White;
            this.txtApellido.Location = new System.Drawing.Point(262, 95);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtApellido.MaxLength = 50;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(259, 27);
            this.txtApellido.TabIndex = 1;
            this.txtApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellido_KeyPress);
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.ForeColor = System.Drawing.Color.White;
            this.lblDireccion.Location = new System.Drawing.Point(160, 247);
            this.lblDireccion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(82, 18);
            this.lblDireccion.TabIndex = 2;
            this.lblDireccion.Text = "Dirección";
            // 
            // txtDni
            // 
            this.txtDni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(129)))), ((int)(((byte)(5)))));
            this.txtDni.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDni.ForeColor = System.Drawing.Color.White;
            this.txtDni.Location = new System.Drawing.Point(262, 195);
            this.txtDni.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtDni.MaxLength = 9;
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(259, 27);
            this.txtDni.TabIndex = 3;
            this.txtDni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDni_KeyPress);
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.ForeColor = System.Drawing.Color.White;
            this.lblTelefono.Location = new System.Drawing.Point(164, 347);
            this.lblTelefono.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(77, 18);
            this.lblTelefono.TabIndex = 2;
            this.lblTelefono.Text = "Teléfono";
            // 
            // txtDireccion
            // 
            this.txtDireccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(129)))), ((int)(((byte)(5)))));
            this.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDireccion.ForeColor = System.Drawing.Color.White;
            this.txtDireccion.Location = new System.Drawing.Point(262, 245);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtDireccion.MaxLength = 100;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(437, 27);
            this.txtDireccion.TabIndex = 4;
            this.txtDireccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDireccion_KeyPress);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.White;
            this.lblEmail.Location = new System.Drawing.Point(188, 397);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(53, 18);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Email";
            // 
            // txtTelefono
            // 
            this.txtTelefono.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(129)))), ((int)(((byte)(5)))));
            this.txtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTelefono.ForeColor = System.Drawing.Color.White;
            this.txtTelefono.Location = new System.Drawing.Point(262, 345);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTelefono.MaxLength = 20;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(259, 27);
            this.txtTelefono.TabIndex = 7;
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDni.ForeColor = System.Drawing.Color.White;
            this.lblDni.Location = new System.Drawing.Point(203, 197);
            this.lblDni.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(39, 18);
            this.lblDni.TabIndex = 2;
            this.lblDni.Text = "DNI";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(129)))), ((int)(((byte)(5)))));
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.ForeColor = System.Drawing.Color.White;
            this.txtEmail.Location = new System.Drawing.Point(262, 395);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(259, 27);
            this.txtEmail.TabIndex = 8;
            // 
            // lblFechaNac
            // 
            this.lblFechaNac.AutoSize = true;
            this.lblFechaNac.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaNac.ForeColor = System.Drawing.Color.White;
            this.lblFechaNac.Location = new System.Drawing.Point(63, 447);
            this.lblFechaNac.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaNac.Name = "lblFechaNac";
            this.lblFechaNac.Size = new System.Drawing.Size(179, 18);
            this.lblFechaNac.TabIndex = 2;
            this.lblFechaNac.Text = "Fecha de Nacimiento";
            // 
            // lblNacionalidad
            // 
            this.lblNacionalidad.AutoSize = true;
            this.lblNacionalidad.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNacionalidad.ForeColor = System.Drawing.Color.White;
            this.lblNacionalidad.Location = new System.Drawing.Point(128, 497);
            this.lblNacionalidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNacionalidad.Name = "lblNacionalidad";
            this.lblNacionalidad.Size = new System.Drawing.Size(113, 18);
            this.lblNacionalidad.TabIndex = 2;
            this.lblNacionalidad.Text = "Nacionalidad";
            // 
            // cmbNacionalidad
            // 
            this.cmbNacionalidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(129)))), ((int)(((byte)(5)))));
            this.cmbNacionalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNacionalidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbNacionalidad.ForeColor = System.Drawing.Color.White;
            this.cmbNacionalidad.FormattingEnabled = true;
            this.cmbNacionalidad.Location = new System.Drawing.Point(262, 494);
            this.cmbNacionalidad.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbNacionalidad.Name = "cmbNacionalidad";
            this.cmbNacionalidad.Size = new System.Drawing.Size(259, 26);
            this.cmbNacionalidad.TabIndex = 10;
            // 
            // lblLocalidad
            // 
            this.lblLocalidad.AutoSize = true;
            this.lblLocalidad.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocalidad.ForeColor = System.Drawing.Color.White;
            this.lblLocalidad.Location = new System.Drawing.Point(436, 297);
            this.lblLocalidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLocalidad.Name = "lblLocalidad";
            this.lblLocalidad.Size = new System.Drawing.Size(85, 18);
            this.lblLocalidad.TabIndex = 2;
            this.lblLocalidad.Text = "Localidad";
            // 
            // cmbLocalidad
            // 
            this.cmbLocalidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(129)))), ((int)(((byte)(5)))));
            this.cmbLocalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLocalidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbLocalidad.ForeColor = System.Drawing.Color.White;
            this.cmbLocalidad.FormattingEnabled = true;
            this.cmbLocalidad.Location = new System.Drawing.Point(539, 294);
            this.cmbLocalidad.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbLocalidad.Name = "cmbLocalidad";
            this.cmbLocalidad.Size = new System.Drawing.Size(160, 26);
            this.cmbLocalidad.TabIndex = 6;
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.CalendarFont = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaNacimiento.CalendarMonthBackground = System.Drawing.Color.DimGray;
            this.dtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(262, 441);
            this.dtpFechaNacimiento.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(135, 27);
            this.dtpFechaNacimiento.TabIndex = 9;
            // 
            // grpBotones
            // 
            this.grpBotones.Controls.Add(this.btnEliminarSocio);
            this.grpBotones.Controls.Add(this.btnModificarSocio);
            this.grpBotones.Controls.Add(this.btnAgregarSocio);
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
            // btnEliminarSocio
            // 
            this.btnEliminarSocio.BackColor = System.Drawing.Color.DimGray;
            this.btnEliminarSocio.BackgroundImage = global::CDVU.Properties.Resources.icons8_eliminar_64;
            this.btnEliminarSocio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEliminarSocio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarSocio.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEliminarSocio.FlatAppearance.BorderSize = 0;
            this.btnEliminarSocio.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnEliminarSocio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnEliminarSocio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnEliminarSocio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarSocio.Location = new System.Drawing.Point(326, 30);
            this.btnEliminarSocio.Name = "btnEliminarSocio";
            this.btnEliminarSocio.Size = new System.Drawing.Size(69, 70);
            this.btnEliminarSocio.TabIndex = 2;
            this.btnEliminarSocio.UseVisualStyleBackColor = false;
            this.btnEliminarSocio.Click += new System.EventHandler(this.btnEliminarSocio_Click);
            this.btnEliminarSocio.MouseHover += new System.EventHandler(this.btnEliminarSocio_MouseHover);
            // 
            // btnModificarSocio
            // 
            this.btnModificarSocio.BackColor = System.Drawing.Color.DimGray;
            this.btnModificarSocio.BackgroundImage = global::CDVU.Properties.Resources.icons8_reemplazar_64;
            this.btnModificarSocio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnModificarSocio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificarSocio.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnModificarSocio.FlatAppearance.BorderSize = 0;
            this.btnModificarSocio.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnModificarSocio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnModificarSocio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnModificarSocio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarSocio.Location = new System.Drawing.Point(206, 30);
            this.btnModificarSocio.Name = "btnModificarSocio";
            this.btnModificarSocio.Size = new System.Drawing.Size(69, 70);
            this.btnModificarSocio.TabIndex = 1;
            this.btnModificarSocio.UseVisualStyleBackColor = false;
            this.btnModificarSocio.Click += new System.EventHandler(this.btnModificarSocio_Click);
            this.btnModificarSocio.MouseHover += new System.EventHandler(this.btnModificarSocio_MouseHover);
            // 
            // btnAgregarSocio
            // 
            this.btnAgregarSocio.BackColor = System.Drawing.Color.DimGray;
            this.btnAgregarSocio.BackgroundImage = global::CDVU.Properties.Resources.icons8_añadir_64;
            this.btnAgregarSocio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAgregarSocio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarSocio.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAgregarSocio.FlatAppearance.BorderSize = 0;
            this.btnAgregarSocio.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnAgregarSocio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAgregarSocio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAgregarSocio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarSocio.Location = new System.Drawing.Point(86, 30);
            this.btnAgregarSocio.Name = "btnAgregarSocio";
            this.btnAgregarSocio.Size = new System.Drawing.Size(69, 70);
            this.btnAgregarSocio.TabIndex = 0;
            this.btnAgregarSocio.UseVisualStyleBackColor = false;
            this.btnAgregarSocio.Click += new System.EventHandler(this.btnAgregarSocio_Click);
            this.btnAgregarSocio.MouseHover += new System.EventHandler(this.btnAgregarSocio_MouseHover);
            // 
            // lstSocios
            // 
            this.lstSocios.BackColor = System.Drawing.Color.DimGray;
            this.lstSocios.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lstSocios.ForeColor = System.Drawing.Color.White;
            this.lstSocios.FormattingEnabled = true;
            this.lstSocios.ItemHeight = 14;
            this.lstSocios.Location = new System.Drawing.Point(42, 335);
            this.lstSocios.Name = "lstSocios";
            this.lstSocios.Size = new System.Drawing.Size(480, 494);
            this.lstSocios.TabIndex = 0;
            this.lstSocios.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lstSocios_DrawItem);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Futura Bk BT", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(129)))), ((int)(((byte)(5)))));
            this.lblTitulo.Location = new System.Drawing.Point(13, 9);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(280, 77);
            this.lblTitulo.TabIndex = 10;
            this.lblTitulo.Text = "SOCIOS";
            // 
            // cmbProvincia
            // 
            this.cmbProvincia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(129)))), ((int)(((byte)(5)))));
            this.cmbProvincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProvincia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbProvincia.ForeColor = System.Drawing.Color.White;
            this.cmbProvincia.FormattingEnabled = true;
            this.cmbProvincia.Location = new System.Drawing.Point(262, 294);
            this.cmbProvincia.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbProvincia.Name = "cmbProvincia";
            this.cmbProvincia.Size = new System.Drawing.Size(150, 26);
            this.cmbProvincia.TabIndex = 5;
            this.cmbProvincia.SelectionChangeCommitted += new System.EventHandler(this.cmbProvincia_SelectionChangeCommitted);
            // 
            // lblProvincia
            // 
            this.lblProvincia.AutoSize = true;
            this.lblProvincia.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProvincia.ForeColor = System.Drawing.Color.White;
            this.lblProvincia.Location = new System.Drawing.Point(160, 297);
            this.lblProvincia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProvincia.Name = "lblProvincia";
            this.lblProvincia.Size = new System.Drawing.Size(81, 18);
            this.lblProvincia.TabIndex = 13;
            this.lblProvincia.Text = "Provincia";
            // 
            // grpFormulario
            // 
            this.grpFormulario.Controls.Add(this.cmbSexo);
            this.grpFormulario.Controls.Add(this.lblSexo);
            this.grpFormulario.Controls.Add(this.lblId);
            this.grpFormulario.Controls.Add(this.lblNumSocio);
            this.grpFormulario.Controls.Add(this.grpTutor);
            this.grpFormulario.Controls.Add(this.cmbProvincia);
            this.grpFormulario.Controls.Add(this.txtDireccion);
            this.grpFormulario.Controls.Add(this.lblProvincia);
            this.grpFormulario.Controls.Add(this.btnCancelar);
            this.grpFormulario.Controls.Add(this.btnLimpiar);
            this.grpFormulario.Controls.Add(this.lblNombre);
            this.grpFormulario.Controls.Add(this.btnAceptar);
            this.grpFormulario.Controls.Add(this.txtNombre);
            this.grpFormulario.Controls.Add(this.lblApellido);
            this.grpFormulario.Controls.Add(this.txtApellido);
            this.grpFormulario.Controls.Add(this.dtpFechaNacimiento);
            this.grpFormulario.Controls.Add(this.lblDireccion);
            this.grpFormulario.Controls.Add(this.txtDni);
            this.grpFormulario.Controls.Add(this.cmbLocalidad);
            this.grpFormulario.Controls.Add(this.lblTelefono);
            this.grpFormulario.Controls.Add(this.lblLocalidad);
            this.grpFormulario.Controls.Add(this.lblEmail);
            this.grpFormulario.Controls.Add(this.cmbNacionalidad);
            this.grpFormulario.Controls.Add(this.txtTelefono);
            this.grpFormulario.Controls.Add(this.lblNacionalidad);
            this.grpFormulario.Controls.Add(this.lblDni);
            this.grpFormulario.Controls.Add(this.lblFechaNac);
            this.grpFormulario.Controls.Add(this.txtEmail);
            this.grpFormulario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpFormulario.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpFormulario.ForeColor = System.Drawing.Color.White;
            this.grpFormulario.Location = new System.Drawing.Point(552, 33);
            this.grpFormulario.Name = "grpFormulario";
            this.grpFormulario.Size = new System.Drawing.Size(787, 796);
            this.grpFormulario.TabIndex = 9;
            this.grpFormulario.TabStop = false;
            this.grpFormulario.Text = "Datos del Socio";
            // 
            // cmbSexo
            // 
            this.cmbSexo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(129)))), ((int)(((byte)(5)))));
            this.cmbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSexo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbSexo.ForeColor = System.Drawing.Color.White;
            this.cmbSexo.FormattingEnabled = true;
            this.cmbSexo.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.cmbSexo.Location = new System.Drawing.Point(262, 144);
            this.cmbSexo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbSexo.Name = "cmbSexo";
            this.cmbSexo.Size = new System.Drawing.Size(150, 26);
            this.cmbSexo.TabIndex = 2;
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSexo.ForeColor = System.Drawing.Color.White;
            this.lblSexo.Location = new System.Drawing.Point(194, 147);
            this.lblSexo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(47, 18);
            this.lblSexo.TabIndex = 21;
            this.lblSexo.Text = "Sexo";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.ForeColor = System.Drawing.Color.White;
            this.lblId.Location = new System.Drawing.Point(656, 47);
            this.lblId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(0, 18);
            this.lblId.TabIndex = 16;
            // 
            // lblNumSocio
            // 
            this.lblNumSocio.AutoSize = true;
            this.lblNumSocio.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumSocio.ForeColor = System.Drawing.Color.White;
            this.lblNumSocio.Location = new System.Drawing.Point(553, 47);
            this.lblNumSocio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumSocio.Name = "lblNumSocio";
            this.lblNumSocio.Size = new System.Drawing.Size(85, 18);
            this.lblNumSocio.TabIndex = 15;
            this.lblNumSocio.Text = "N° Socio:";
            // 
            // grpTutor
            // 
            this.grpTutor.Controls.Add(this.lblNombreTutor);
            this.grpTutor.Controls.Add(this.btnQuitarTutor);
            this.grpTutor.Controls.Add(this.lblNombreTutorSeleccionado);
            this.grpTutor.Controls.Add(this.btnBuscarTutor);
            this.grpTutor.Controls.Add(this.txtBuscarTutor);
            this.grpTutor.Controls.Add(this.lblDniTutor);
            this.grpTutor.Controls.Add(this.label4);
            this.grpTutor.Controls.Add(this.lblDniTutorSeleccionado);
            this.grpTutor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpTutor.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpTutor.ForeColor = System.Drawing.Color.White;
            this.grpTutor.Location = new System.Drawing.Point(186, 540);
            this.grpTutor.Name = "grpTutor";
            this.grpTutor.Size = new System.Drawing.Size(423, 159);
            this.grpTutor.TabIndex = 9;
            this.grpTutor.TabStop = false;
            this.grpTutor.Text = "Tutor";
            // 
            // lblNombreTutor
            // 
            this.lblNombreTutor.AutoSize = true;
            this.lblNombreTutor.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreTutor.ForeColor = System.Drawing.Color.White;
            this.lblNombreTutor.Location = new System.Drawing.Point(31, 127);
            this.lblNombreTutor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreTutor.Name = "lblNombreTutor";
            this.lblNombreTutor.Size = new System.Drawing.Size(56, 18);
            this.lblNombreTutor.TabIndex = 36;
            this.lblNombreTutor.Text = "Tutor:";
            // 
            // btnQuitarTutor
            // 
            this.btnQuitarTutor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(129)))), ((int)(((byte)(5)))));
            this.btnQuitarTutor.FlatAppearance.BorderSize = 0;
            this.btnQuitarTutor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitarTutor.Location = new System.Drawing.Point(277, 47);
            this.btnQuitarTutor.Name = "btnQuitarTutor";
            this.btnQuitarTutor.Size = new System.Drawing.Size(116, 27);
            this.btnQuitarTutor.TabIndex = 38;
            this.btnQuitarTutor.Text = "Quitar tutor";
            this.btnQuitarTutor.UseVisualStyleBackColor = false;
            this.btnQuitarTutor.Click += new System.EventHandler(this.btnQuitarTutor_Click);
            // 
            // lblNombreTutorSeleccionado
            // 
            this.lblNombreTutorSeleccionado.AutoSize = true;
            this.lblNombreTutorSeleccionado.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreTutorSeleccionado.ForeColor = System.Drawing.Color.White;
            this.lblNombreTutorSeleccionado.Location = new System.Drawing.Point(97, 127);
            this.lblNombreTutorSeleccionado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreTutorSeleccionado.Name = "lblNombreTutorSeleccionado";
            this.lblNombreTutorSeleccionado.Size = new System.Drawing.Size(0, 18);
            this.lblNombreTutorSeleccionado.TabIndex = 37;
            // 
            // btnBuscarTutor
            // 
            this.btnBuscarTutor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(129)))), ((int)(((byte)(5)))));
            this.btnBuscarTutor.FlatAppearance.BorderSize = 0;
            this.btnBuscarTutor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarTutor.Location = new System.Drawing.Point(179, 47);
            this.btnBuscarTutor.Name = "btnBuscarTutor";
            this.btnBuscarTutor.Size = new System.Drawing.Size(88, 27);
            this.btnBuscarTutor.TabIndex = 33;
            this.btnBuscarTutor.Text = "Buscar";
            this.btnBuscarTutor.UseVisualStyleBackColor = false;
            this.btnBuscarTutor.Click += new System.EventHandler(this.btnBuscarTutor_Click);
            // 
            // txtBuscarTutor
            // 
            this.txtBuscarTutor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(129)))), ((int)(((byte)(5)))));
            this.txtBuscarTutor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscarTutor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBuscarTutor.ForeColor = System.Drawing.Color.White;
            this.txtBuscarTutor.Location = new System.Drawing.Point(30, 47);
            this.txtBuscarTutor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtBuscarTutor.Name = "txtBuscarTutor";
            this.txtBuscarTutor.Size = new System.Drawing.Size(139, 27);
            this.txtBuscarTutor.TabIndex = 32;
            this.txtBuscarTutor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscarTutor_KeyPress);
            // 
            // lblDniTutor
            // 
            this.lblDniTutor.AutoSize = true;
            this.lblDniTutor.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDniTutor.ForeColor = System.Drawing.Color.White;
            this.lblDniTutor.Location = new System.Drawing.Point(41, 91);
            this.lblDniTutor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDniTutor.Name = "lblDniTutor";
            this.lblDniTutor.Size = new System.Drawing.Size(46, 18);
            this.lblDniTutor.TabIndex = 34;
            this.lblDniTutor.Text = "DNI:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(27, 23);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 16);
            this.label4.TabIndex = 29;
            this.label4.Text = "Buscar tutor por DNI";
            // 
            // lblDniTutorSeleccionado
            // 
            this.lblDniTutorSeleccionado.AutoSize = true;
            this.lblDniTutorSeleccionado.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDniTutorSeleccionado.ForeColor = System.Drawing.Color.White;
            this.lblDniTutorSeleccionado.Location = new System.Drawing.Point(97, 91);
            this.lblDniTutorSeleccionado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDniTutorSeleccionado.Name = "lblDniTutorSeleccionado";
            this.lblDniTutorSeleccionado.Size = new System.Drawing.Size(0, 18);
            this.lblDniTutorSeleccionado.TabIndex = 35;
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
            this.btnCancelar.Location = new System.Drawing.Point(357, 716);
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
            this.btnLimpiar.Location = new System.Drawing.Point(452, 716);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(69, 70);
            this.btnLimpiar.TabIndex = 13;
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
            this.btnAceptar.Location = new System.Drawing.Point(262, 716);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(69, 70);
            this.btnAceptar.TabIndex = 11;
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            this.btnAceptar.MouseHover += new System.EventHandler(this.btnAceptar_MouseHover);
            // 
            // btnBuscarSocio
            // 
            this.btnBuscarSocio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(129)))), ((int)(((byte)(5)))));
            this.btnBuscarSocio.FlatAppearance.BorderSize = 0;
            this.btnBuscarSocio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarSocio.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarSocio.ForeColor = System.Drawing.Color.White;
            this.btnBuscarSocio.Location = new System.Drawing.Point(307, 289);
            this.btnBuscarSocio.Name = "btnBuscarSocio";
            this.btnBuscarSocio.Size = new System.Drawing.Size(88, 27);
            this.btnBuscarSocio.TabIndex = 27;
            this.btnBuscarSocio.Text = "Buscar";
            this.btnBuscarSocio.UseVisualStyleBackColor = false;
            this.btnBuscarSocio.Click += new System.EventHandler(this.btnBuscarSocio_Click);
            // 
            // txtBuscarSocio
            // 
            this.txtBuscarSocio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(129)))), ((int)(((byte)(5)))));
            this.txtBuscarSocio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscarSocio.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBuscarSocio.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarSocio.ForeColor = System.Drawing.Color.White;
            this.txtBuscarSocio.Location = new System.Drawing.Point(161, 289);
            this.txtBuscarSocio.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtBuscarSocio.Name = "txtBuscarSocio";
            this.txtBuscarSocio.Size = new System.Drawing.Size(139, 27);
            this.txtBuscarSocio.TabIndex = 26;
            this.txtBuscarSocio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscarSocio_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(158, 261);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 16);
            this.label1.TabIndex = 25;
            this.label1.Text = "Buscar socio por DNI ó N° de socio";
            // 
            // frmSocio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1380, 862);
            this.Controls.Add(this.btnBuscarSocio);
            this.Controls.Add(this.txtBuscarSocio);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstSocios);
            this.Controls.Add(this.grpBotones);
            this.Controls.Add(this.grpFormulario);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmSocio";
            this.Text = "frmSocio";
            this.Load += new System.EventHandler(this.frmSocio_Load);
            this.grpBotones.ResumeLayout(false);
            this.grpFormulario.ResumeLayout(false);
            this.grpFormulario.PerformLayout();
            this.grpTutor.ResumeLayout(false);
            this.grpTutor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblFechaNac;
        private System.Windows.Forms.Label lblNacionalidad;
        private System.Windows.Forms.ComboBox cmbNacionalidad;
        private System.Windows.Forms.Label lblLocalidad;
        private System.Windows.Forms.ComboBox cmbLocalidad;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.GroupBox grpBotones;
        private System.Windows.Forms.Button btnAgregarSocio;
        private System.Windows.Forms.Button btnEliminarSocio;
        private System.Windows.Forms.Button btnModificarSocio;
        private System.Windows.Forms.ListBox lstSocios;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ComboBox cmbProvincia;
        private System.Windows.Forms.Label lblProvincia;
        private System.Windows.Forms.GroupBox grpFormulario;
        private System.Windows.Forms.GroupBox grpTutor;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblNumSocio;
        private System.Windows.Forms.ComboBox cmbSexo;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Button btnBuscarTutor;
        private System.Windows.Forms.TextBox txtBuscarTutor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblNombreTutor;
        private System.Windows.Forms.Label lblNombreTutorSeleccionado;
        private System.Windows.Forms.Label lblDniTutor;
        private System.Windows.Forms.Label lblDniTutorSeleccionado;
        private System.Windows.Forms.Button btnQuitarTutor;
        private System.Windows.Forms.Button btnBuscarSocio;
        private System.Windows.Forms.TextBox txtBuscarSocio;
        private System.Windows.Forms.Label label1;
    }
}