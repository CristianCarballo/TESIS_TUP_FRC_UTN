using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace CDVU
{
    public partial class frmVentanaRecepcion : Form
    {
        public frmVentanaRecepcion()
        {
            InitializeComponent();
        }

        private void frmVentanaRecepcion_Load(object sender, EventArgs e)
        {
            abrirForm(new frmInicio());
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRestaurar_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void btnMaximizar_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
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

        private void abrirForm(Form formHija)
        {
            if (pnlContenedor.Controls.Count > 0)
                pnlContenedor.Controls.RemoveAt(0);
            formHija.TopLevel = false;
            formHija.Dock = DockStyle.Fill;
            pnlContenedor.Controls.Add(formHija);
            pnlContenedor.Tag = formHija;
            formHija.Show();
        }

        private void pbxEscudo_Click(object sender, EventArgs e)
        {
            abrirForm(new frmVentanaRecepcion());
        }

        private void btnSocio_Click(object sender, EventArgs e)
        {
            abrirForm(new frmSocio());
        }

        private void btnTutor_Click(object sender, EventArgs e)
        {
            abrirForm(new frmTutor());
        }

        private void bntInscripcion_Click(object sender, EventArgs e)
        {
            abrirForm(new frmInscripcion());
        }

        private void btnTesoreria_Click(object sender, EventArgs e)
        {
            abrirForm(new frmTesoreria());
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            abrirForm(new frmConsultaRecepcion());
        }

        private void btnCerrarSesión_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea cerrar la sesión actual?", "Cerrando sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                new frmVentanaPrincipal().Visible = true;
                this.Dispose(false);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea cerrar la aplicación?", "Cerrando la aplicación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
