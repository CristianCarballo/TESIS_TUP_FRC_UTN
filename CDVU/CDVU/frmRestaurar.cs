using CDVU.Clases.Base_de_Datos.GestorPersonas;
using CDVU.Clases.Personas;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace CDVU
{
    public partial class frmRestaurar : Form
    {
        Usuario usuario;
        GestorUsuario gu;

        public frmRestaurar()
        {
            InitializeComponent();
            usuario = new Usuario();
            gu = new GestorUsuario();
        }

        private void frmRestaurar_Load(object sender, EventArgs e)
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

        private void limpiarCampos()
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDni.Text = "";
            txtUsuario.Text = "";
            lblPassAnterior.Text = "";
            txtContrasena.Text = "";
            txtConfirmarContrasena.Text = "";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea cancelar y volver a la pantalla de inicio de sesión?","Cancelar y salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                new frmVentanaPrincipal().Visible = true;
                this.Dispose(false);
            }
        }

        private void btnBuscarUsuario_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Trim() == "")
                MessageBox.Show("Ingrese nombre", "Nombre", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            if (txtApellido.Text.Trim() == "")
                MessageBox.Show("Ingrese apellido", "Apellido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            if (txtDni.Text.Trim() == "")
                MessageBox.Show("Ingrese DNI", "DNI", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            if (txtUsuario.Text.Trim() == "")
                MessageBox.Show("Ingrese usuario", "Usuario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                usuario = gu.existeUsuario(txtNombre.Text.Trim(), txtApellido.Text.Trim(), txtDni.Text.Trim(), txtUsuario.Text.Trim());
                if (usuario == null)
                    MessageBox.Show("No existe el usuario, por favor revise los datos", "No existe", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                {
                    lblPassAnterior.Text = usuario.Contrasena;
                    grpContrasena.Enabled = true;
                }
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtContrasena.Text.Trim() == "")
                MessageBox.Show("Ingrese contraseña", "Contraseña", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            if (txtConfirmarContrasena.Text.Trim() == "" || txtConfirmarContrasena.Text.Trim() != txtContrasena.Text.Trim())
                MessageBox.Show("Por favor confirme la contraseña para continuar", "Confirme la contraseña", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            if (usuario != null && MessageBox.Show("¿Desea guardar contraseña nueva?", "Contraseña", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                usuario.Contrasena = txtConfirmarContrasena.Text.Trim();
                if (!gu.editarUsuario(usuario))
                    MessageBox.Show("Error al cambiar la contraseña, intente nuevamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    MessageBox.Show("La contraseña se restauró sin problemas", "Contraseña restablecida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiarCampos();
                    grpContrasena.Enabled = false;
                }
            }
        }
    }
}
