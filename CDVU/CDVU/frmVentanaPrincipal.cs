using CDVU.Clases.Base_de_Datos.GestorPersonas;
using CDVU.Clases.Personas;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace CDVU
{
    public partial class frmVentanaPrincipal : Form
    {
        Usuario usuario;
        GestorUsuario gu;

        public frmVentanaPrincipal()
        {
            InitializeComponent();
            usuario = new Usuario();
            gu = new GestorUsuario();
        }

        private void frmVentanaPrincipal_Load(object sender, EventArgs e)
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

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Trim() == "")
                MessageBox.Show("Ingrese usuario para iniciar sesión", "Usuario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                if (txtContrasena.Text == "")
                    MessageBox.Show("Ingrese contraseña para iniciar sesión", "Contraseña", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                {
                    usuario = gu.logear(txtUsuario.Text.Trim(), txtContrasena.Text.Trim());
                    if (usuario != null && usuario.IdTipoUsuario == 1)
                    {
                        MessageBox.Show("Bienvenido " + usuario.Nombre + "\nUsted tiene permisos de " + usuario.TipoUsuario, "Inicio de sesión exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        new frmVentanaAdministracion().Visible = true;
                        this.Dispose(false);
                    }
                    else
                    if (usuario != null && usuario.IdTipoUsuario == 2)
                    {
                        MessageBox.Show("Bienvenido " + usuario.Nombre + "\nUsted tiene permisos de " + usuario.TipoUsuario, "Inicio de sesión exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        new frmVentanaRecepcion().Visible = true;
                        this.Dispose(false);
                    }
                    else
                        MessageBox.Show("Error al iniciar sesión, por favor revise su usuario y contraseña", "Iniciar sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnNuevoUsuario_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea crear un nuevo usuario?", "Nuevo usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                new frmNuevoUsuario().Visible = true;
                this.Dispose(false);
            }
        }

        private void lblOlvideContrasena_Click(object sender, EventArgs e)
        {
            new frmRestaurar().Visible = true;
            this.Dispose(false);
        }
    }
}
