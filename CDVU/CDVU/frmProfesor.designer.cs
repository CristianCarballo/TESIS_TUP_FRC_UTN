namespace CDVU
{
    partial class frmProfesor
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
            this.btnEliminarProfesor = new System.Windows.Forms.Button();
            this.btnModificarProfesor = new System.Windows.Forms.Button();
            this.btnAgregarProfesor = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.cmbProvincia = new System.Windows.Forms.ComboBox();
            this.lblProvincia = new System.Windows.Forms.Label();
            this.grpFormulario = new System.Windows.Forms.GroupBox();
            this.cmbSexo = new System.Windows.Forms.ComboBox();
            this.lblSexo = new System.Windows.Forms.Label();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.lblMatruclia = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.lblNumProfesor = new System.Windows.Forms.Label();
            this.grpDeporte = new System.Windows.Forms.GroupBox();
            this.btnQuitarDeporte = new System.Windows.Forms.Button();
            this.btnAgregarDeporte = new System.Windows.Forms.Button();
            this.txtDeporte = new System.Windows.Forms.TextBox();
            this.cmbDeporte = new System.Windows.Forms.ComboBox();
            this.cmbTipoDeporte = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.lstDeporte = new System.Windows.Forms.ListBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.cmbBuscarPorDeporte = new System.Windows.Forms.ComboBox();
            this.btnListaCompleta = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lstProfesores = new System.Windows.Forms.ListBox();
            this.grpBotones.SuspendLayout();
            this.grpFormulario.SuspendLayout();
            this.grpDeporte.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(129)))), ((int)(((byte)(5)))));
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombre.ForeColor = System.Drawing.Color.White;
            this.txtNombre.Location = new System.Drawing.Point(275, 47);
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
            this.lblNombre.Location = new System.Drawing.Point(184, 49);
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
            this.lblApellido.Location = new System.Drawing.Point(181, 94);
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
            this.txtApellido.Location = new System.Drawing.Point(275, 92);
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
            this.lblDireccion.Location = new System.Drawing.Point(173, 274);
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
            this.txtDni.Location = new System.Drawing.Point(275, 182);
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
            this.lblTelefono.Location = new System.Drawing.Point(177, 364);
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
            this.txtDireccion.Location = new System.Drawing.Point(275, 272);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtDireccion.MaxLength = 100;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(437, 27);
            this.txtDireccion.TabIndex = 5;
            this.txtDireccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDireccion_KeyPress);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.White;
            this.lblEmail.Location = new System.Drawing.Point(201, 409);
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
            this.txtTelefono.Location = new System.Drawing.Point(275, 362);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTelefono.MaxLength = 20;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(259, 27);
            this.txtTelefono.TabIndex = 8;
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDni.ForeColor = System.Drawing.Color.White;
            this.lblDni.Location = new System.Drawing.Point(215, 184);
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
            this.txtEmail.Location = new System.Drawing.Point(275, 407);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(259, 27);
            this.txtEmail.TabIndex = 9;
            this.txtEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDireccion_KeyPress);
            // 
            // lblFechaNac
            // 
            this.lblFechaNac.AutoSize = true;
            this.lblFechaNac.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaNac.ForeColor = System.Drawing.Color.White;
            this.lblFechaNac.Location = new System.Drawing.Point(76, 454);
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
            this.lblNacionalidad.Location = new System.Drawing.Point(141, 499);
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
            this.cmbNacionalidad.Location = new System.Drawing.Point(275, 496);
            this.cmbNacionalidad.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbNacionalidad.Name = "cmbNacionalidad";
            this.cmbNacionalidad.Size = new System.Drawing.Size(259, 26);
            this.cmbNacionalidad.TabIndex = 11;
            // 
            // lblLocalidad
            // 
            this.lblLocalidad.AutoSize = true;
            this.lblLocalidad.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocalidad.ForeColor = System.Drawing.Color.White;
            this.lblLocalidad.Location = new System.Drawing.Point(449, 319);
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
            this.cmbLocalidad.Location = new System.Drawing.Point(552, 316);
            this.cmbLocalidad.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbLocalidad.Name = "cmbLocalidad";
            this.cmbLocalidad.Size = new System.Drawing.Size(160, 26);
            this.cmbLocalidad.TabIndex = 7;
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.CalendarFont = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaNacimiento.CalendarMonthBackground = System.Drawing.Color.DimGray;
            this.dtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(275, 448);
            this.dtpFechaNacimiento.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(135, 27);
            this.dtpFechaNacimiento.TabIndex = 10;
            // 
            // grpBotones
            // 
            this.grpBotones.Controls.Add(this.btnEliminarProfesor);
            this.grpBotones.Controls.Add(this.btnModificarProfesor);
            this.grpBotones.Controls.Add(this.btnAgregarProfesor);
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
            // btnEliminarProfesor
            // 
            this.btnEliminarProfesor.BackColor = System.Drawing.Color.DimGray;
            this.btnEliminarProfesor.BackgroundImage = global::CDVU.Properties.Resources.icons8_eliminar_64;
            this.btnEliminarProfesor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEliminarProfesor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarProfesor.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEliminarProfesor.FlatAppearance.BorderSize = 0;
            this.btnEliminarProfesor.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnEliminarProfesor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnEliminarProfesor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnEliminarProfesor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarProfesor.Location = new System.Drawing.Point(326, 30);
            this.btnEliminarProfesor.Name = "btnEliminarProfesor";
            this.btnEliminarProfesor.Size = new System.Drawing.Size(69, 70);
            this.btnEliminarProfesor.TabIndex = 2;
            this.btnEliminarProfesor.UseVisualStyleBackColor = false;
            this.btnEliminarProfesor.Click += new System.EventHandler(this.btnEliminarProfesor_Click);
            this.btnEliminarProfesor.MouseHover += new System.EventHandler(this.btnEliminarProfesor_MouseHover);
            // 
            // btnModificarProfesor
            // 
            this.btnModificarProfesor.BackColor = System.Drawing.Color.DimGray;
            this.btnModificarProfesor.BackgroundImage = global::CDVU.Properties.Resources.icons8_reemplazar_64;
            this.btnModificarProfesor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnModificarProfesor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificarProfesor.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnModificarProfesor.FlatAppearance.BorderSize = 0;
            this.btnModificarProfesor.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnModificarProfesor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnModificarProfesor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnModificarProfesor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarProfesor.Location = new System.Drawing.Point(206, 30);
            this.btnModificarProfesor.Name = "btnModificarProfesor";
            this.btnModificarProfesor.Size = new System.Drawing.Size(69, 70);
            this.btnModificarProfesor.TabIndex = 1;
            this.btnModificarProfesor.UseVisualStyleBackColor = false;
            this.btnModificarProfesor.Click += new System.EventHandler(this.btnModificarProfesor_Click);
            this.btnModificarProfesor.MouseHover += new System.EventHandler(this.btnModificarProfesor_MouseHover);
            // 
            // btnAgregarProfesor
            // 
            this.btnAgregarProfesor.BackColor = System.Drawing.Color.DimGray;
            this.btnAgregarProfesor.BackgroundImage = global::CDVU.Properties.Resources.icons8_añadir_64;
            this.btnAgregarProfesor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAgregarProfesor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarProfesor.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAgregarProfesor.FlatAppearance.BorderSize = 0;
            this.btnAgregarProfesor.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnAgregarProfesor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAgregarProfesor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAgregarProfesor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarProfesor.Location = new System.Drawing.Point(86, 30);
            this.btnAgregarProfesor.Name = "btnAgregarProfesor";
            this.btnAgregarProfesor.Size = new System.Drawing.Size(69, 70);
            this.btnAgregarProfesor.TabIndex = 0;
            this.btnAgregarProfesor.UseVisualStyleBackColor = false;
            this.btnAgregarProfesor.Click += new System.EventHandler(this.btnAgregarProfesor_Click);
            this.btnAgregarProfesor.MouseHover += new System.EventHandler(this.btnAgregarProfesor_MouseHover);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Futura Bk BT", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(129)))), ((int)(((byte)(5)))));
            this.lblTitulo.Location = new System.Drawing.Point(13, 9);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(420, 77);
            this.lblTitulo.TabIndex = 10;
            this.lblTitulo.Text = "PROFESORES";
            // 
            // cmbProvincia
            // 
            this.cmbProvincia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(129)))), ((int)(((byte)(5)))));
            this.cmbProvincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProvincia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbProvincia.ForeColor = System.Drawing.Color.White;
            this.cmbProvincia.FormattingEnabled = true;
            this.cmbProvincia.Location = new System.Drawing.Point(275, 316);
            this.cmbProvincia.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbProvincia.Name = "cmbProvincia";
            this.cmbProvincia.Size = new System.Drawing.Size(150, 26);
            this.cmbProvincia.TabIndex = 6;
            this.cmbProvincia.SelectionChangeCommitted += new System.EventHandler(this.cmbProvincia_SelectionChangeCommitted);
            // 
            // lblProvincia
            // 
            this.lblProvincia.AutoSize = true;
            this.lblProvincia.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProvincia.ForeColor = System.Drawing.Color.White;
            this.lblProvincia.Location = new System.Drawing.Point(173, 319);
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
            this.grpFormulario.Controls.Add(this.txtMatricula);
            this.grpFormulario.Controls.Add(this.lblMatruclia);
            this.grpFormulario.Controls.Add(this.lblId);
            this.grpFormulario.Controls.Add(this.lblNumProfesor);
            this.grpFormulario.Controls.Add(this.grpDeporte);
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
            this.grpFormulario.Text = "Datos del Profesor";
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
            this.cmbSexo.Location = new System.Drawing.Point(275, 136);
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
            this.lblSexo.Location = new System.Drawing.Point(207, 139);
            this.lblSexo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(47, 18);
            this.lblSexo.TabIndex = 19;
            this.lblSexo.Text = "Sexo";
            // 
            // txtMatricula
            // 
            this.txtMatricula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(129)))), ((int)(((byte)(5)))));
            this.txtMatricula.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMatricula.ForeColor = System.Drawing.Color.White;
            this.txtMatricula.Location = new System.Drawing.Point(275, 227);
            this.txtMatricula.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtMatricula.MaxLength = 8;
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(259, 27);
            this.txtMatricula.TabIndex = 4;
            // 
            // lblMatruclia
            // 
            this.lblMatruclia.AutoSize = true;
            this.lblMatruclia.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatruclia.ForeColor = System.Drawing.Color.White;
            this.lblMatruclia.Location = new System.Drawing.Point(75, 229);
            this.lblMatruclia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMatruclia.Name = "lblMatruclia";
            this.lblMatruclia.Size = new System.Drawing.Size(179, 18);
            this.lblMatruclia.TabIndex = 17;
            this.lblMatruclia.Text = "Matrícula Profesional";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.ForeColor = System.Drawing.Color.White;
            this.lblId.Location = new System.Drawing.Point(673, 49);
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
            this.lblNumProfesor.Location = new System.Drawing.Point(556, 49);
            this.lblNumProfesor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumProfesor.Name = "lblNumProfesor";
            this.lblNumProfesor.Size = new System.Drawing.Size(109, 18);
            this.lblNumProfesor.TabIndex = 15;
            this.lblNumProfesor.Text = "N° Profesor:";
            // 
            // grpDeporte
            // 
            this.grpDeporte.Controls.Add(this.btnQuitarDeporte);
            this.grpDeporte.Controls.Add(this.btnAgregarDeporte);
            this.grpDeporte.Controls.Add(this.txtDeporte);
            this.grpDeporte.Controls.Add(this.cmbDeporte);
            this.grpDeporte.Controls.Add(this.cmbTipoDeporte);
            this.grpDeporte.Controls.Add(this.label1);
            this.grpDeporte.Controls.Add(this.lblBuscar);
            this.grpDeporte.Controls.Add(this.lstDeporte);
            this.grpDeporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpDeporte.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDeporte.ForeColor = System.Drawing.Color.White;
            this.grpDeporte.Location = new System.Drawing.Point(119, 539);
            this.grpDeporte.Name = "grpDeporte";
            this.grpDeporte.Size = new System.Drawing.Size(575, 167);
            this.grpDeporte.TabIndex = 12;
            this.grpDeporte.TabStop = false;
            this.grpDeporte.Text = "Deportes que enseña el profesor";
            // 
            // btnQuitarDeporte
            // 
            this.btnQuitarDeporte.BackColor = System.Drawing.Color.DimGray;
            this.btnQuitarDeporte.BackgroundImage = global::CDVU.Properties.Resources.icons8_ventana_abierta_64;
            this.btnQuitarDeporte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnQuitarDeporte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuitarDeporte.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnQuitarDeporte.FlatAppearance.BorderSize = 0;
            this.btnQuitarDeporte.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnQuitarDeporte.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnQuitarDeporte.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnQuitarDeporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitarDeporte.Location = new System.Drawing.Point(252, 102);
            this.btnQuitarDeporte.Name = "btnQuitarDeporte";
            this.btnQuitarDeporte.Size = new System.Drawing.Size(59, 50);
            this.btnQuitarDeporte.TabIndex = 4;
            this.btnQuitarDeporte.UseVisualStyleBackColor = false;
            this.btnQuitarDeporte.Click += new System.EventHandler(this.btnQuitarDeporte_Click);
            this.btnQuitarDeporte.MouseHover += new System.EventHandler(this.btnQuitarDeporte_MouseHover);
            // 
            // btnAgregarDeporte
            // 
            this.btnAgregarDeporte.BackColor = System.Drawing.Color.DimGray;
            this.btnAgregarDeporte.BackgroundImage = global::CDVU.Properties.Resources.icons8_panel_cerrado_64;
            this.btnAgregarDeporte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAgregarDeporte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarDeporte.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAgregarDeporte.FlatAppearance.BorderSize = 0;
            this.btnAgregarDeporte.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnAgregarDeporte.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAgregarDeporte.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAgregarDeporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarDeporte.Location = new System.Drawing.Point(252, 50);
            this.btnAgregarDeporte.Name = "btnAgregarDeporte";
            this.btnAgregarDeporte.Size = new System.Drawing.Size(59, 50);
            this.btnAgregarDeporte.TabIndex = 3;
            this.btnAgregarDeporte.UseVisualStyleBackColor = false;
            this.btnAgregarDeporte.Click += new System.EventHandler(this.btnAgregarDeporte_Click);
            this.btnAgregarDeporte.MouseHover += new System.EventHandler(this.btnAgregarDeporte_MouseHover);
            // 
            // txtDeporte
            // 
            this.txtDeporte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(129)))), ((int)(((byte)(5)))));
            this.txtDeporte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDeporte.Cursor = System.Windows.Forms.Cursors.No;
            this.txtDeporte.ForeColor = System.Drawing.Color.White;
            this.txtDeporte.Location = new System.Drawing.Point(15, 125);
            this.txtDeporte.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtDeporte.Name = "txtDeporte";
            this.txtDeporte.ReadOnly = true;
            this.txtDeporte.Size = new System.Drawing.Size(219, 27);
            this.txtDeporte.TabIndex = 2;
            // 
            // cmbDeporte
            // 
            this.cmbDeporte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(129)))), ((int)(((byte)(5)))));
            this.cmbDeporte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDeporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbDeporte.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDeporte.ForeColor = System.Drawing.Color.White;
            this.cmbDeporte.FormattingEnabled = true;
            this.cmbDeporte.Location = new System.Drawing.Point(15, 88);
            this.cmbDeporte.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbDeporte.Name = "cmbDeporte";
            this.cmbDeporte.Size = new System.Drawing.Size(219, 22);
            this.cmbDeporte.TabIndex = 1;
            this.cmbDeporte.SelectedIndexChanged += new System.EventHandler(this.cmbDeporte_SelectedIndexChanged);
            // 
            // cmbTipoDeporte
            // 
            this.cmbTipoDeporte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(129)))), ((int)(((byte)(5)))));
            this.cmbTipoDeporte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoDeporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbTipoDeporte.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoDeporte.ForeColor = System.Drawing.Color.White;
            this.cmbTipoDeporte.FormattingEnabled = true;
            this.cmbTipoDeporte.Location = new System.Drawing.Point(15, 50);
            this.cmbTipoDeporte.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbTipoDeporte.Name = "cmbTipoDeporte";
            this.cmbTipoDeporte.Size = new System.Drawing.Size(219, 22);
            this.cmbTipoDeporte.TabIndex = 0;
            this.cmbTipoDeporte.SelectionChangeCommitted += new System.EventHandler(this.cmbTipoDeporte_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(322, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 16);
            this.label1.TabIndex = 20;
            this.label1.Text = "Deportes seleccionados";
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.ForeColor = System.Drawing.Color.White;
            this.lblBuscar.Location = new System.Drawing.Point(12, 31);
            this.lblBuscar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(140, 16);
            this.lblBuscar.TabIndex = 19;
            this.lblBuscar.Text = "Seleccionar deporte";
            // 
            // lstDeporte
            // 
            this.lstDeporte.BackColor = System.Drawing.Color.DimGray;
            this.lstDeporte.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lstDeporte.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstDeporte.ForeColor = System.Drawing.Color.White;
            this.lstDeporte.FormattingEnabled = true;
            this.lstDeporte.ItemHeight = 14;
            this.lstDeporte.Location = new System.Drawing.Point(325, 50);
            this.lstDeporte.Name = "lstDeporte";
            this.lstDeporte.Size = new System.Drawing.Size(238, 102);
            this.lstDeporte.TabIndex = 5;
            this.lstDeporte.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lstDeporte_DrawItem);
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
            this.btnCancelar.Location = new System.Drawing.Point(370, 716);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(69, 70);
            this.btnCancelar.TabIndex = 13;
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
            this.btnLimpiar.Location = new System.Drawing.Point(465, 716);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(69, 70);
            this.btnLimpiar.TabIndex = 14;
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
            this.btnAceptar.Location = new System.Drawing.Point(275, 716);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(69, 70);
            this.btnAceptar.TabIndex = 12;
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
            this.cmbBuscarPorDeporte.Location = new System.Drawing.Point(75, 280);
            this.cmbBuscarPorDeporte.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbBuscarPorDeporte.Name = "cmbBuscarPorDeporte";
            this.cmbBuscarPorDeporte.Size = new System.Drawing.Size(195, 26);
            this.cmbBuscarPorDeporte.TabIndex = 34;
            this.cmbBuscarPorDeporte.SelectionChangeCommitted += new System.EventHandler(this.cmbBuscarPorDeporte_SelectionChangeCommitted);
            // 
            // btnListaCompleta
            // 
            this.btnListaCompleta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(129)))), ((int)(((byte)(5)))));
            this.btnListaCompleta.FlatAppearance.BorderSize = 0;
            this.btnListaCompleta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListaCompleta.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListaCompleta.ForeColor = System.Drawing.Color.White;
            this.btnListaCompleta.Location = new System.Drawing.Point(294, 280);
            this.btnListaCompleta.Name = "btnListaCompleta";
            this.btnListaCompleta.Size = new System.Drawing.Size(178, 27);
            this.btnListaCompleta.TabIndex = 36;
            this.btnListaCompleta.Text = "Ver lista completa";
            this.btnListaCompleta.UseVisualStyleBackColor = false;
            this.btnListaCompleta.Click += new System.EventHandler(this.btnListaCompleta_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(72, 252);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 16);
            this.label2.TabIndex = 35;
            this.label2.Text = "Filtrar listado por deporte";
            // 
            // lstProfesores
            // 
            this.lstProfesores.BackColor = System.Drawing.Color.DimGray;
            this.lstProfesores.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lstProfesores.ForeColor = System.Drawing.Color.White;
            this.lstProfesores.FormattingEnabled = true;
            this.lstProfesores.ItemHeight = 14;
            this.lstProfesores.Location = new System.Drawing.Point(39, 335);
            this.lstProfesores.Name = "lstProfesores";
            this.lstProfesores.Size = new System.Drawing.Size(480, 494);
            this.lstProfesores.TabIndex = 40;
            this.lstProfesores.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lstProfesores_DrawItem);
            // 
            // frmProfesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1380, 862);
            this.Controls.Add(this.lstProfesores);
            this.Controls.Add(this.cmbBuscarPorDeporte);
            this.Controls.Add(this.btnListaCompleta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.grpBotones);
            this.Controls.Add(this.grpFormulario);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmProfesor";
            this.Text = "frmProfesor";
            this.Load += new System.EventHandler(this.frmProfesor_Load);
            this.grpBotones.ResumeLayout(false);
            this.grpFormulario.ResumeLayout(false);
            this.grpFormulario.PerformLayout();
            this.grpDeporte.ResumeLayout(false);
            this.grpDeporte.PerformLayout();
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
        private System.Windows.Forms.Button btnAgregarProfesor;
        private System.Windows.Forms.Button btnEliminarProfesor;
        private System.Windows.Forms.Button btnModificarProfesor;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ComboBox cmbProvincia;
        private System.Windows.Forms.Label lblProvincia;
        private System.Windows.Forms.GroupBox grpFormulario;
        private System.Windows.Forms.GroupBox grpDeporte;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblNumProfesor;
        private System.Windows.Forms.ListBox lstDeporte;
        private System.Windows.Forms.ComboBox cmbTipoDeporte;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.TextBox txtDeporte;
        private System.Windows.Forms.ComboBox cmbDeporte;
        private System.Windows.Forms.Button btnAgregarDeporte;
        private System.Windows.Forms.Button btnQuitarDeporte;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.Label lblMatruclia;
        private System.Windows.Forms.ComboBox cmbSexo;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.ComboBox cmbBuscarPorDeporte;
        private System.Windows.Forms.Button btnListaCompleta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstProfesores;
    }
}