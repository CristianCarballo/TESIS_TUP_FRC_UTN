using System;
using System.Windows.Forms;

namespace CDVU
{
    public partial class frmConsultaAdministracion : Form
    {

        public frmConsultaAdministracion()
        {
            InitializeComponent();
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

        private void btnSocio_Click(object sender, EventArgs e)
        {
            abrirForm(new frmConsultaSocio());
        }

        private void btnTesoreria_Click(object sender, EventArgs e)
        {
            abrirForm(new frmConsultaTesoreria());
        }
    }
}
