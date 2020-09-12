namespace CDVU
{
    partial class frmVentanaAdministracion
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlBarraTitulo = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnRestaurar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnMaximizar = new System.Windows.Forms.PictureBox();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btmUsuario = new System.Windows.Forms.Button();
            this.panel10 = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnCerrarSesión = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbxEscudo = new System.Windows.Forms.PictureBox();
            this.btnProfesor = new System.Windows.Forms.Button();
            this.btnEntrenamiento = new System.Windows.Forms.Button();
            this.btnPredio = new System.Windows.Forms.Button();
            this.btnDeporte = new System.Windows.Forms.Button();
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.pnlBarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).BeginInit();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEscudo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBarraTitulo
            // 
            this.pnlBarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(219)))), ((int)(((byte)(165)))));
            this.pnlBarraTitulo.Controls.Add(this.lblTitulo);
            this.pnlBarraTitulo.Controls.Add(this.btnRestaurar);
            this.pnlBarraTitulo.Controls.Add(this.btnCerrar);
            this.pnlBarraTitulo.Controls.Add(this.btnMinimizar);
            this.pnlBarraTitulo.Controls.Add(this.btnMaximizar);
            this.pnlBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlBarraTitulo.Name = "pnlBarraTitulo";
            this.pnlBarraTitulo.Size = new System.Drawing.Size(1600, 38);
            this.pnlBarraTitulo.TabIndex = 8;
            this.pnlBarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlBarraTitulo_MouseDown);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(12, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(182, 18);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Administración C.D.V.U.";
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestaurar.Image = global::CDVU.Properties.Resources.icons8_restaurar_ventana_64;
            this.btnRestaurar.Location = new System.Drawing.Point(1532, 6);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(25, 25);
            this.btnRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRestaurar.TabIndex = 7;
            this.btnRestaurar.TabStop = false;
            this.btnRestaurar.Visible = false;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click_1);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = global::CDVU.Properties.Resources.icons8_cerrar_ventana_64;
            this.btnCerrar.Location = new System.Drawing.Point(1563, 6);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(25, 25);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 4;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click_1);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Image = global::CDVU.Properties.Resources.icons8_minimizar_la_ventana_64;
            this.btnMinimizar.Location = new System.Drawing.Point(1501, 6);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(25, 25);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizar.TabIndex = 6;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click_1);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximizar.Image = global::CDVU.Properties.Resources.icons8_maximizar_la_ventana_64;
            this.btnMaximizar.Location = new System.Drawing.Point(1532, 6);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(25, 25);
            this.btnMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMaximizar.TabIndex = 5;
            this.btnMaximizar.TabStop = false;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click_1);
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.Black;
            this.pnlMenu.Controls.Add(this.panel8);
            this.pnlMenu.Controls.Add(this.btnConsulta);
            this.pnlMenu.Controls.Add(this.panel7);
            this.pnlMenu.Controls.Add(this.btmUsuario);
            this.pnlMenu.Controls.Add(this.panel10);
            this.pnlMenu.Controls.Add(this.btnSalir);
            this.pnlMenu.Controls.Add(this.panel6);
            this.pnlMenu.Controls.Add(this.btnCerrarSesión);
            this.pnlMenu.Controls.Add(this.panel4);
            this.pnlMenu.Controls.Add(this.panel3);
            this.pnlMenu.Controls.Add(this.panel2);
            this.pnlMenu.Controls.Add(this.panel1);
            this.pnlMenu.Controls.Add(this.pbxEscudo);
            this.pnlMenu.Controls.Add(this.btnProfesor);
            this.pnlMenu.Controls.Add(this.btnEntrenamiento);
            this.pnlMenu.Controls.Add(this.btnPredio);
            this.pnlMenu.Controls.Add(this.btnDeporte);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 38);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(220, 862);
            this.pnlMenu.TabIndex = 0;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(129)))), ((int)(((byte)(5)))));
            this.panel8.Location = new System.Drawing.Point(0, 402);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(10, 32);
            this.panel8.TabIndex = 24;
            // 
            // btnConsulta
            // 
            this.btnConsulta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsulta.FlatAppearance.BorderSize = 0;
            this.btnConsulta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(129)))), ((int)(((byte)(5)))));
            this.btnConsulta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(129)))), ((int)(((byte)(5)))));
            this.btnConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsulta.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsulta.ForeColor = System.Drawing.Color.White;
            this.btnConsulta.Location = new System.Drawing.Point(3, 402);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(217, 32);
            this.btnConsulta.TabIndex = 5;
            this.btnConsulta.Text = "CONSULTAS";
            this.btnConsulta.UseVisualStyleBackColor = true;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(129)))), ((int)(((byte)(5)))));
            this.panel7.Location = new System.Drawing.Point(0, 350);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(10, 46);
            this.panel7.TabIndex = 22;
            // 
            // btmUsuario
            // 
            this.btmUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btmUsuario.FlatAppearance.BorderSize = 0;
            this.btmUsuario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(129)))), ((int)(((byte)(5)))));
            this.btmUsuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(129)))), ((int)(((byte)(5)))));
            this.btmUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btmUsuario.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmUsuario.ForeColor = System.Drawing.Color.White;
            this.btmUsuario.Location = new System.Drawing.Point(3, 350);
            this.btmUsuario.Name = "btmUsuario";
            this.btmUsuario.Size = new System.Drawing.Size(217, 46);
            this.btmUsuario.TabIndex = 4;
            this.btmUsuario.Text = "ADMINISTRACIÓN\r\nDE USUARIOS";
            this.btmUsuario.UseVisualStyleBackColor = true;
            this.btmUsuario.Click += new System.EventHandler(this.btmUsuario_Click);
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(129)))), ((int)(((byte)(5)))));
            this.panel10.Location = new System.Drawing.Point(0, 818);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(10, 32);
            this.panel10.TabIndex = 20;
            // 
            // btnSalir
            // 
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(129)))), ((int)(((byte)(5)))));
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(129)))), ((int)(((byte)(5)))));
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(3, 818);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(217, 32);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(129)))), ((int)(((byte)(5)))));
            this.panel6.Location = new System.Drawing.Point(0, 440);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(10, 32);
            this.panel6.TabIndex = 18;
            // 
            // btnCerrarSesión
            // 
            this.btnCerrarSesión.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarSesión.FlatAppearance.BorderSize = 0;
            this.btnCerrarSesión.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(129)))), ((int)(((byte)(5)))));
            this.btnCerrarSesión.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(129)))), ((int)(((byte)(5)))));
            this.btnCerrarSesión.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesión.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarSesión.ForeColor = System.Drawing.Color.White;
            this.btnCerrarSesión.Location = new System.Drawing.Point(3, 440);
            this.btnCerrarSesión.Name = "btnCerrarSesión";
            this.btnCerrarSesión.Size = new System.Drawing.Size(217, 32);
            this.btnCerrarSesión.TabIndex = 6;
            this.btnCerrarSesión.Text = "CERRAR SESIÓN";
            this.btnCerrarSesión.UseVisualStyleBackColor = true;
            this.btnCerrarSesión.Click += new System.EventHandler(this.btnCerrarSesión_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(129)))), ((int)(((byte)(5)))));
            this.panel4.Location = new System.Drawing.Point(0, 312);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 32);
            this.panel4.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(129)))), ((int)(((byte)(5)))));
            this.panel3.Location = new System.Drawing.Point(0, 274);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 32);
            this.panel3.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(129)))), ((int)(((byte)(5)))));
            this.panel2.Location = new System.Drawing.Point(0, 236);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 32);
            this.panel2.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(129)))), ((int)(((byte)(5)))));
            this.panel1.Location = new System.Drawing.Point(0, 198);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 32);
            this.panel1.TabIndex = 3;
            // 
            // pbxEscudo
            // 
            this.pbxEscudo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxEscudo.Image = global::CDVU.Properties.Resources.vecinos_unidos1;
            this.pbxEscudo.Location = new System.Drawing.Point(0, 14);
            this.pbxEscudo.Name = "pbxEscudo";
            this.pbxEscudo.Size = new System.Drawing.Size(220, 170);
            this.pbxEscudo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxEscudo.TabIndex = 1;
            this.pbxEscudo.TabStop = false;
            this.pbxEscudo.Click += new System.EventHandler(this.pbxEscudo_Click);
            // 
            // btnProfesor
            // 
            this.btnProfesor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProfesor.FlatAppearance.BorderSize = 0;
            this.btnProfesor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(129)))), ((int)(((byte)(5)))));
            this.btnProfesor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(129)))), ((int)(((byte)(5)))));
            this.btnProfesor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfesor.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfesor.ForeColor = System.Drawing.Color.White;
            this.btnProfesor.Location = new System.Drawing.Point(3, 198);
            this.btnProfesor.Name = "btnProfesor";
            this.btnProfesor.Size = new System.Drawing.Size(217, 32);
            this.btnProfesor.TabIndex = 0;
            this.btnProfesor.Text = "PROFESOR";
            this.btnProfesor.UseVisualStyleBackColor = true;
            this.btnProfesor.Click += new System.EventHandler(this.btnProfesor_Click);
            // 
            // btnEntrenamiento
            // 
            this.btnEntrenamiento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEntrenamiento.FlatAppearance.BorderSize = 0;
            this.btnEntrenamiento.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(129)))), ((int)(((byte)(5)))));
            this.btnEntrenamiento.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(129)))), ((int)(((byte)(5)))));
            this.btnEntrenamiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntrenamiento.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrenamiento.ForeColor = System.Drawing.Color.White;
            this.btnEntrenamiento.Location = new System.Drawing.Point(3, 312);
            this.btnEntrenamiento.Name = "btnEntrenamiento";
            this.btnEntrenamiento.Size = new System.Drawing.Size(217, 32);
            this.btnEntrenamiento.TabIndex = 3;
            this.btnEntrenamiento.Text = "ENTRENAMIENTO";
            this.btnEntrenamiento.UseVisualStyleBackColor = true;
            this.btnEntrenamiento.Click += new System.EventHandler(this.btnEntrenamiento_Click);
            // 
            // btnPredio
            // 
            this.btnPredio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPredio.FlatAppearance.BorderSize = 0;
            this.btnPredio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(129)))), ((int)(((byte)(5)))));
            this.btnPredio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(129)))), ((int)(((byte)(5)))));
            this.btnPredio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPredio.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPredio.ForeColor = System.Drawing.Color.White;
            this.btnPredio.Location = new System.Drawing.Point(3, 274);
            this.btnPredio.Name = "btnPredio";
            this.btnPredio.Size = new System.Drawing.Size(217, 32);
            this.btnPredio.TabIndex = 2;
            this.btnPredio.Text = "PREDIO";
            this.btnPredio.UseVisualStyleBackColor = true;
            this.btnPredio.Click += new System.EventHandler(this.btnPredio_Click);
            // 
            // btnDeporte
            // 
            this.btnDeporte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeporte.FlatAppearance.BorderSize = 0;
            this.btnDeporte.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(129)))), ((int)(((byte)(5)))));
            this.btnDeporte.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(129)))), ((int)(((byte)(5)))));
            this.btnDeporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeporte.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeporte.ForeColor = System.Drawing.Color.White;
            this.btnDeporte.Location = new System.Drawing.Point(3, 236);
            this.btnDeporte.Name = "btnDeporte";
            this.btnDeporte.Size = new System.Drawing.Size(217, 32);
            this.btnDeporte.TabIndex = 1;
            this.btnDeporte.Text = "DEPORTE";
            this.btnDeporte.UseVisualStyleBackColor = true;
            this.btnDeporte.Click += new System.EventHandler(this.btnDeporte_Click);
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.BackColor = System.Drawing.Color.DimGray;
            this.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenedor.Location = new System.Drawing.Point(220, 38);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(1380, 862);
            this.pnlContenedor.TabIndex = 10;
            // 
            // frmVentanaAdministracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 900);
            this.Controls.Add(this.pnlContenedor);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlBarraTitulo);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmVentanaAdministracion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administración C.D.V.U.";
            this.Load += new System.EventHandler(this.frmVentanaAdministracion_Load);
            this.pnlBarraTitulo.ResumeLayout(false);
            this.pnlBarraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).EndInit();
            this.pnlMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxEscudo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox btnRestaurar;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnMaximizar;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.Panel pnlBarraTitulo;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.PictureBox pbxEscudo;
        private System.Windows.Forms.Panel pnlContenedor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnProfesor;
        private System.Windows.Forms.Button btnPredio;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnDeporte;
        private System.Windows.Forms.Button btnEntrenamiento;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnCerrarSesión;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btmUsuario;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button btnConsulta;
    }
}

