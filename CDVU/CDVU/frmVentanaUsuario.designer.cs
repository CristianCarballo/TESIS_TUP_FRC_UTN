namespace CDVU
{
    partial class frmVentanaUsuario
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
            this.grpBotones = new System.Windows.Forms.GroupBox();
            this.btnEliminarUsuario = new System.Windows.Forms.Button();
            this.btnModificarUsuario = new System.Windows.Forms.Button();
            this.btnAgregarUsuario = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.grpFormulario = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.rbtRecepcionista = new System.Windows.Forms.RadioButton();
            this.rbtAdministrador = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblContrasena = new System.Windows.Forms.Label();
            this.txtConfirmarContrasena = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.lblNumUsuario = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.cmbBuscarPorTipoUsuario = new System.Windows.Forms.ComboBox();
            this.btnListaCompleta = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lstUsuario = new System.Windows.Forms.ListBox();
            this.grpBotones.SuspendLayout();
            this.grpFormulario.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBotones
            // 
            this.grpBotones.Controls.Add(this.btnEliminarUsuario);
            this.grpBotones.Controls.Add(this.btnModificarUsuario);
            this.grpBotones.Controls.Add(this.btnAgregarUsuario);
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
            // btnEliminarUsuario
            // 
            this.btnEliminarUsuario.BackColor = System.Drawing.Color.DimGray;
            this.btnEliminarUsuario.BackgroundImage = global::CDVU.Properties.Resources.icons8_eliminar_64;
            this.btnEliminarUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEliminarUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarUsuario.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEliminarUsuario.FlatAppearance.BorderSize = 0;
            this.btnEliminarUsuario.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnEliminarUsuario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnEliminarUsuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnEliminarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarUsuario.Location = new System.Drawing.Point(326, 30);
            this.btnEliminarUsuario.Name = "btnEliminarUsuario";
            this.btnEliminarUsuario.Size = new System.Drawing.Size(69, 70);
            this.btnEliminarUsuario.TabIndex = 2;
            this.btnEliminarUsuario.UseVisualStyleBackColor = false;
            this.btnEliminarUsuario.Click += new System.EventHandler(this.btnEliminarUsuario_Click);
            this.btnEliminarUsuario.MouseHover += new System.EventHandler(this.btnEliminarUsuario_MouseHover);
            // 
            // btnModificarUsuario
            // 
            this.btnModificarUsuario.BackColor = System.Drawing.Color.DimGray;
            this.btnModificarUsuario.BackgroundImage = global::CDVU.Properties.Resources.icons8_reemplazar_64;
            this.btnModificarUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnModificarUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificarUsuario.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnModificarUsuario.FlatAppearance.BorderSize = 0;
            this.btnModificarUsuario.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnModificarUsuario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnModificarUsuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnModificarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarUsuario.Location = new System.Drawing.Point(206, 30);
            this.btnModificarUsuario.Name = "btnModificarUsuario";
            this.btnModificarUsuario.Size = new System.Drawing.Size(69, 70);
            this.btnModificarUsuario.TabIndex = 1;
            this.btnModificarUsuario.UseVisualStyleBackColor = false;
            this.btnModificarUsuario.Click += new System.EventHandler(this.btnModificarUsuario_Click);
            this.btnModificarUsuario.MouseHover += new System.EventHandler(this.btnModificarUsuario_MouseHover);
            // 
            // btnAgregarUsuario
            // 
            this.btnAgregarUsuario.BackColor = System.Drawing.Color.DimGray;
            this.btnAgregarUsuario.BackgroundImage = global::CDVU.Properties.Resources.icons8_añadir_64;
            this.btnAgregarUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAgregarUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarUsuario.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAgregarUsuario.FlatAppearance.BorderSize = 0;
            this.btnAgregarUsuario.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnAgregarUsuario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAgregarUsuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAgregarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarUsuario.Location = new System.Drawing.Point(86, 30);
            this.btnAgregarUsuario.Name = "btnAgregarUsuario";
            this.btnAgregarUsuario.Size = new System.Drawing.Size(69, 70);
            this.btnAgregarUsuario.TabIndex = 0;
            this.btnAgregarUsuario.UseVisualStyleBackColor = false;
            this.btnAgregarUsuario.Click += new System.EventHandler(this.btnAgregarUsuario_Click);
            this.btnAgregarUsuario.MouseHover += new System.EventHandler(this.btnAgregarUsuario_MouseHover);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Futura Bk BT", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(129)))), ((int)(((byte)(5)))));
            this.lblTitulo.Location = new System.Drawing.Point(13, 9);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(1013, 77);
            this.lblTitulo.TabIndex = 10;
            this.lblTitulo.Text = "ADMINISTRACIÓN DE USUARIOS";
            // 
            // grpFormulario
            // 
            this.grpFormulario.Controls.Add(this.label6);
            this.grpFormulario.Controls.Add(this.rbtRecepcionista);
            this.grpFormulario.Controls.Add(this.rbtAdministrador);
            this.grpFormulario.Controls.Add(this.label5);
            this.grpFormulario.Controls.Add(this.txtDni);
            this.grpFormulario.Controls.Add(this.label4);
            this.grpFormulario.Controls.Add(this.txtApellido);
            this.grpFormulario.Controls.Add(this.label2);
            this.grpFormulario.Controls.Add(this.txtNombre);
            this.grpFormulario.Controls.Add(this.txtContrasena);
            this.grpFormulario.Controls.Add(this.lblUsuario);
            this.grpFormulario.Controls.Add(this.txtUsuario);
            this.grpFormulario.Controls.Add(this.lblContrasena);
            this.grpFormulario.Controls.Add(this.txtConfirmarContrasena);
            this.grpFormulario.Controls.Add(this.label3);
            this.grpFormulario.Controls.Add(this.lblId);
            this.grpFormulario.Controls.Add(this.lblNumUsuario);
            this.grpFormulario.Controls.Add(this.btnCancelar);
            this.grpFormulario.Controls.Add(this.btnLimpiar);
            this.grpFormulario.Controls.Add(this.btnAceptar);
            this.grpFormulario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpFormulario.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpFormulario.ForeColor = System.Drawing.Color.White;
            this.grpFormulario.Location = new System.Drawing.Point(552, 251);
            this.grpFormulario.Name = "grpFormulario";
            this.grpFormulario.Size = new System.Drawing.Size(787, 578);
            this.grpFormulario.TabIndex = 9;
            this.grpFormulario.TabStop = false;
            this.grpFormulario.Text = "Datos del usuario";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(309, 130);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 18);
            this.label6.TabIndex = 66;
            this.label6.Text = "Permisos:";
            // 
            // rbtRecepcionista
            // 
            this.rbtRecepcionista.AutoSize = true;
            this.rbtRecepcionista.Checked = true;
            this.rbtRecepcionista.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtRecepcionista.Location = new System.Drawing.Point(416, 115);
            this.rbtRecepcionista.Name = "rbtRecepcionista";
            this.rbtRecepcionista.Size = new System.Drawing.Size(127, 22);
            this.rbtRecepcionista.TabIndex = 0;
            this.rbtRecepcionista.TabStop = true;
            this.rbtRecepcionista.Text = "Recepcionista";
            this.rbtRecepcionista.UseVisualStyleBackColor = true;
            // 
            // rbtAdministrador
            // 
            this.rbtAdministrador.AutoSize = true;
            this.rbtAdministrador.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtAdministrador.Location = new System.Drawing.Point(416, 143);
            this.rbtAdministrador.Name = "rbtAdministrador";
            this.rbtAdministrador.Size = new System.Drawing.Size(129, 22);
            this.rbtAdministrador.TabIndex = 1;
            this.rbtAdministrador.TabStop = true;
            this.rbtAdministrador.Text = "Administrador";
            this.rbtAdministrador.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(352, 273);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 18);
            this.label5.TabIndex = 63;
            this.label5.Text = "DNI:";
            // 
            // txtDni
            // 
            this.txtDni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(129)))), ((int)(((byte)(5)))));
            this.txtDni.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDni.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDni.ForeColor = System.Drawing.Color.White;
            this.txtDni.Location = new System.Drawing.Point(416, 271);
            this.txtDni.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtDni.MaxLength = 9;
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(156, 27);
            this.txtDni.TabIndex = 4;
            this.txtDni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDni_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(317, 225);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 18);
            this.label4.TabIndex = 62;
            this.label4.Text = "Apellido:";
            // 
            // txtApellido
            // 
            this.txtApellido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(129)))), ((int)(((byte)(5)))));
            this.txtApellido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtApellido.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido.ForeColor = System.Drawing.Color.White;
            this.txtApellido.Location = new System.Drawing.Point(416, 223);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtApellido.MaxLength = 20;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(156, 27);
            this.txtApellido.TabIndex = 3;
            this.txtApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellido_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(320, 177);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 18);
            this.label2.TabIndex = 61;
            this.label2.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(129)))), ((int)(((byte)(5)))));
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombre.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.Color.White;
            this.txtNombre.Location = new System.Drawing.Point(416, 175);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNombre.MaxLength = 20;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(156, 27);
            this.txtNombre.TabIndex = 2;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // txtContrasena
            // 
            this.txtContrasena.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(129)))), ((int)(((byte)(5)))));
            this.txtContrasena.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtContrasena.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContrasena.ForeColor = System.Drawing.Color.White;
            this.txtContrasena.Location = new System.Drawing.Point(416, 367);
            this.txtContrasena.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtContrasena.MaxLength = 10;
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.PasswordChar = '*';
            this.txtContrasena.Size = new System.Drawing.Size(156, 27);
            this.txtContrasena.TabIndex = 6;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.White;
            this.lblUsuario.Location = new System.Drawing.Point(321, 321);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(77, 18);
            this.lblUsuario.TabIndex = 59;
            this.lblUsuario.Text = "Usuario:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(129)))), ((int)(((byte)(5)))));
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsuario.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.ForeColor = System.Drawing.Color.White;
            this.txtUsuario.Location = new System.Drawing.Point(416, 319);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtUsuario.MaxLength = 20;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(156, 27);
            this.txtUsuario.TabIndex = 5;
            this.txtUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUsuario_KeyPress);
            // 
            // lblContrasena
            // 
            this.lblContrasena.AutoSize = true;
            this.lblContrasena.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContrasena.ForeColor = System.Drawing.Color.White;
            this.lblContrasena.Location = new System.Drawing.Point(290, 369);
            this.lblContrasena.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContrasena.Name = "lblContrasena";
            this.lblContrasena.Size = new System.Drawing.Size(108, 18);
            this.lblContrasena.TabIndex = 60;
            this.lblContrasena.Text = "Contraseña:";
            // 
            // txtConfirmarContrasena
            // 
            this.txtConfirmarContrasena.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(129)))), ((int)(((byte)(5)))));
            this.txtConfirmarContrasena.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtConfirmarContrasena.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmarContrasena.ForeColor = System.Drawing.Color.White;
            this.txtConfirmarContrasena.Location = new System.Drawing.Point(416, 415);
            this.txtConfirmarContrasena.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtConfirmarContrasena.MaxLength = 10;
            this.txtConfirmarContrasena.Name = "txtConfirmarContrasena";
            this.txtConfirmarContrasena.PasswordChar = '*';
            this.txtConfirmarContrasena.Size = new System.Drawing.Size(156, 27);
            this.txtConfirmarContrasena.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(214, 417);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 18);
            this.label3.TabIndex = 58;
            this.label3.Text = "Confirme contraseña:";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.ForeColor = System.Drawing.Color.White;
            this.lblId.Location = new System.Drawing.Point(413, 84);
            this.lblId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(0, 18);
            this.lblId.TabIndex = 16;
            // 
            // lblNumUsuario
            // 
            this.lblNumUsuario.AutoSize = true;
            this.lblNumUsuario.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumUsuario.ForeColor = System.Drawing.Color.White;
            this.lblNumUsuario.Location = new System.Drawing.Point(294, 84);
            this.lblNumUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumUsuario.Name = "lblNumUsuario";
            this.lblNumUsuario.Size = new System.Drawing.Size(104, 18);
            this.lblNumUsuario.TabIndex = 15;
            this.lblNumUsuario.Text = "N° Usuario:";
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
            this.btnCancelar.Location = new System.Drawing.Point(372, 491);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(69, 70);
            this.btnCancelar.TabIndex = 9;
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
            this.btnLimpiar.Location = new System.Drawing.Point(467, 491);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(69, 70);
            this.btnLimpiar.TabIndex = 10;
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
            this.btnAceptar.Location = new System.Drawing.Point(277, 491);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(69, 70);
            this.btnAceptar.TabIndex = 8;
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            this.btnAceptar.MouseHover += new System.EventHandler(this.btnAceptar_MouseHover);
            // 
            // cmbBuscarPorTipoUsuario
            // 
            this.cmbBuscarPorTipoUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(129)))), ((int)(((byte)(5)))));
            this.cmbBuscarPorTipoUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbBuscarPorTipoUsuario.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBuscarPorTipoUsuario.ForeColor = System.Drawing.Color.White;
            this.cmbBuscarPorTipoUsuario.FormattingEnabled = true;
            this.cmbBuscarPorTipoUsuario.Items.AddRange(new object[] {
            "Administrador",
            "Recepcionista"});
            this.cmbBuscarPorTipoUsuario.Location = new System.Drawing.Point(79, 288);
            this.cmbBuscarPorTipoUsuario.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbBuscarPorTipoUsuario.Name = "cmbBuscarPorTipoUsuario";
            this.cmbBuscarPorTipoUsuario.Size = new System.Drawing.Size(195, 26);
            this.cmbBuscarPorTipoUsuario.TabIndex = 0;
            this.cmbBuscarPorTipoUsuario.SelectionChangeCommitted += new System.EventHandler(this.cmbBuscarPorTipoUsuario_SelectionChangeCommitted);
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
            this.btnListaCompleta.TabIndex = 1;
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
            this.label1.Size = new System.Drawing.Size(224, 16);
            this.label1.TabIndex = 33;
            this.label1.Text = "Filtrar usuarios según su permiso";
            // 
            // lstUsuario
            // 
            this.lstUsuario.BackColor = System.Drawing.Color.DimGray;
            this.lstUsuario.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lstUsuario.ForeColor = System.Drawing.Color.White;
            this.lstUsuario.FormattingEnabled = true;
            this.lstUsuario.ItemHeight = 14;
            this.lstUsuario.Location = new System.Drawing.Point(42, 335);
            this.lstUsuario.Name = "lstUsuario";
            this.lstUsuario.Size = new System.Drawing.Size(480, 494);
            this.lstUsuario.TabIndex = 31;
            this.lstUsuario.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lstUsuario_DrawItem);
            // 
            // frmVentanaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1380, 862);
            this.Controls.Add(this.cmbBuscarPorTipoUsuario);
            this.Controls.Add(this.btnListaCompleta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstUsuario);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.grpBotones);
            this.Controls.Add(this.grpFormulario);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmVentanaUsuario";
            this.Text = "frmProfesor";
            this.Load += new System.EventHandler(this.frmVentanaUsuario_Load);
            this.grpBotones.ResumeLayout(false);
            this.grpFormulario.ResumeLayout(false);
            this.grpFormulario.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox grpBotones;
        private System.Windows.Forms.Button btnAgregarUsuario;
        private System.Windows.Forms.Button btnEliminarUsuario;
        private System.Windows.Forms.Button btnModificarUsuario;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.GroupBox grpFormulario;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblNumUsuario;
        private System.Windows.Forms.ComboBox cmbBuscarPorTipoUsuario;
        private System.Windows.Forms.Button btnListaCompleta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstUsuario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtContrasena;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblContrasena;
        private System.Windows.Forms.TextBox txtConfirmarContrasena;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rbtRecepcionista;
        private System.Windows.Forms.RadioButton rbtAdministrador;
    }
}