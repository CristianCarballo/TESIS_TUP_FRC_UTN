using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace CDVU
{
    public partial class frmVentanaAdministracion : Form
    {
        public frmVentanaAdministracion()
        {
            InitializeComponent();
        }

        private void frmVentanaAdministracion_Load(object sender, EventArgs e)
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
            abrirForm(new frmInicio());
        }

        private void btnProfesor_Click(object sender, EventArgs e)
        {
            abrirForm(new frmProfesor());
        }

        private void btnDeporte_Click(object sender, EventArgs e)
        {
            abrirForm(new frmDeporte());
        }

        private void btnPredio_Click(object sender, EventArgs e)
        {
            abrirForm(new frmPredio());
        }

        private void btnEntrenamiento_Click(object sender, EventArgs e)
        {
            abrirForm(new frmEntrenamiento());
        }

        private void btnTesoreria_Click(object sender, EventArgs e)
        {
            abrirForm(new frmTesoreria());
        }

        private void btmUsuario_Click(object sender, EventArgs e)
        {
            abrirForm(new frmVentanaUsuario());
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            abrirForm(new frmConsultaAdministracion());
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
