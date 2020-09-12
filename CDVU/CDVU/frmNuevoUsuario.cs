using CDVU.Clases.Base_de_Datos.GestorPersonas;
using CDVU.Clases.Personas;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace CDVU
{
    public partial class frmNuevoUsuario : Form
    {
        Usuario usuario;
        GestorUsuario gu;

        public frmNuevoUsuario()
        {
            InitializeComponent();
            usuario = new Usuario();
            gu = new GestorUsuario();
        }

        private void frmNuevoUsuario_Load(object sender, EventArgs e)
        {

        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void pnlBarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                e.Handled = true;
                return;
            }
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                e.Handled = true;
                return;
            }
        }

        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                return;
            }
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                e.Handled = true;
                return;
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Trim() == "")
                MessageBox.Show("Ingrese nombre", "Nombre", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            if(txtApellido.Text.Trim() == "")
                MessageBox.Show("Ingrese apellido", "Apellido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            if(txtDni.Text.Trim() == "")
                MessageBox.Show("Ingrese DNI", "DNI", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            if (txtUsuario.Text.Trim() == "")
                MessageBox.Show("Ingrese usuario", "Usuario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                if (txtContrasena.Text.Trim() == "")
                    MessageBox.Show("Ingrese contraseña", "Contraseña", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                if (txtConfirmarContrasena.Text.Trim() == "" || txtConfirmarContrasena.Text.Trim() != txtContrasena.Text.Trim())
                    MessageBox.Show("Por favor confirme la contraseña para continuar", "Confirme la contraseña", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                if (gu.existeNombreUsuario(txtUsuario.Text.Trim()) != null)
                    MessageBox.Show("Ya existe un usuario con ese nombre, por favor ingrese otro nombre de usuario", "Existe", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                {
                    usuario = new Usuario();
                    usuario.Nombre = txtNombre.Text.Trim();
                    usuario.Apellido = txtApellido.Text.Trim();
                    usuario.Dni = txtDni.Text.Trim();
                    usuario.NombreUsuario = txtUsuario.Text.Trim();
                    usuario.Contrasena = txtContrasena.Text.Trim();
                    usuario.IdTipoUsuario = 2;

                    if (gu.agregarUsuario(usuario))
                    {
                        MessageBox.Show("Usuario " + usuario.NombreUsuario + "\nAgregado correctamente", "Felicitaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        new frmVentanaPrincipal().Visible = true;
                        this.Dispose(false);
                    }
                    else
                        MessageBox.Show("Error al agregar usuario, por favor revise su usuario y contraseña", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea cancelar y volver a la pantalla de inicio de sesión?","Cancelar y salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                new frmVentanaPrincipal().Visible = true;
                this.Dispose(false);
            }
        }
    }
}
