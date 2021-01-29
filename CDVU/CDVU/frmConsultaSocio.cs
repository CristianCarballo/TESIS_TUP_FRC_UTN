using CDVU.Clases.Base_de_Datos;
using CDVU.Clases.Base_de_Datos.GestorClub;
using CDVU.Clases.Club;
using CDVU.Personas;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CDVU
{
    public partial class frmConsultaSocio : Form
    {
        AccesoBD bd;
        GestorSocio gs;
        GestorInscripcion gi;
        GestorEntrenamiento ge;
        Socio socio;

        public frmConsultaSocio()
        {
            InitializeComponent();
            bd = new AccesoBD();
            gs = new GestorSocio();
            gi = new GestorInscripcion();
            ge = new GestorEntrenamiento();
            socio = new Socio();
        }

        // ************************ CARGA DE DATOS ************************

        private void frmConsultaSocio_Load(object sender, EventArgs e)
        {
            cargarListaSocio();
        }

        private void cargarListaSocio()
        {
            lstSocios.Update();
            lstSocios.DataSource = gs.listaSocios();
            lstSocios.ValueMember = "id";
            lstSocios.DisplayMember = "";
            lstSocios.SelectedIndex = -1;
        }

        private void cargarComboInscripcion(int idSocio)
        {
            cmbInscripcion.Update();
            cmbInscripcion.DataSource = gi.listaInscripcionCompletaSegunIdSocio(idSocio);
            cmbInscripcion.ValueMember = "id";
            cmbInscripcion.DisplayMember = "";
        }

        private void lstSocios_SelectedIndexChanged(object sender, EventArgs e)
        {
            socio = (Socio)lstSocios.SelectedItem;
            if(socio == null)
            {
                cmbInscripcion.DataSource = null;
                cmbInscripcion.Items.Clear();
            }
            else
            cargarComboInscripcion(socio.Id);
        }

        // ************************ VALIDACIONES ************************

        private void lstSocios_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (lstSocios.Enabled)
            {
                if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                {
                    e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(209, 129, 5)), new Rectangle(e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height));
                    e.Graphics.DrawString(lstSocios.Items[e.Index].ToString(), e.Font, Brushes.White, new Rectangle(e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height));
                }
                else
                {
                    e.DrawBackground();
                    if (e.Index >= 0)
                    {
                        e.Graphics.DrawString(lstSocios.Items[e.Index].ToString(), e.Font, Brushes.White, new Rectangle(e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height));
                    }
                }
                e.DrawFocusRectangle();
            }
            else
            {
                if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                {
                    e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(209, 129, 5)), new Rectangle(e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height));
                    e.Graphics.DrawString(lstSocios.Items[e.Index].ToString(), e.Font, Brushes.Black, new Rectangle(e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height));
                }
                else
                {
                    e.DrawBackground();
                    if (e.Index >= 0)
                    {
                        e.Graphics.DrawString(lstSocios.Items[e.Index].ToString(), e.Font, Brushes.Black, new Rectangle(e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height));
                    }
                }
                e.DrawFocusRectangle();
            }
        }

        private void btnBuscarSocio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                return;
            }
        }

        private bool validarSeleccionLista()
        {
            if (lstSocios.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un socio de la lista para continuar", "Seleccione un socio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                return false;
            }
            else
            if (cmbInscripcion.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar una inscripción para continuar", "Seleccione una incripción", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                return false;
            }
            return true;
        }

        // ************************ BOTONES ************************

        private void btnBuscarSocio_Click(object sender, EventArgs e)
        {
            if (txtBuscarSocio.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese el DNI ó el N° del socio para buscar");
            }
            else
            {
                socio = gs.obtenerSocioPorId(Convert.ToInt32(txtBuscarSocio.Text));
                if (socio == null)
                {
                    socio = gs.obtenerSocioPorDNI(txtBuscarSocio.Text);
                    if (socio == null)
                    {
                        MessageBox.Show("No se encuentra el socio");
                    }
                    else
                        lstSocios.SelectedValue = socio.Id;
                }
                else
                    lstSocios.SelectedValue = socio.Id;
            }
        }

        private void btnDeudaSocio_Click(object sender, EventArgs e)
        {
            if (validarSeleccionLista())
            {
                Inscripcion inscripcion = (Inscripcion)cmbInscripcion.SelectedItem;
                string consulta = "select e.cantidadCuotas - COUNT(p.id) 'Cantidad de cuotas que debe el socio (No incluye la matrícula)' from Pago p right join Inscripcion i on p.inscripcion = i.id join Entrenamiento e on e.id = i.entrenamiento where i.id = " + inscripcion.Id + " and i.socio = " + inscripcion.Socio.Id + " group by e.cantidadCuotas";
                dgvResultado.DataSource = bd.buscarBD(consulta);
                txtBuscarSocio.Text = "";
            }
        }

        private void btnInscripcionesPagadas_Click(object sender, EventArgs e)
        {
            if (validarSeleccionLista())
            {
                socio = (Socio)lstSocios.SelectedItem;
                string consulta = "select i.id 'N° de Inscripción', i.fecha 'Fecha de inscripción', nombreDeporte Deporte, descripcion Predio from vw_listaEntrenamiento e join Inscripcion i on i.entrenamiento = e.idEntrenamiento where estaSaldado = 1 and i.socio = " + socio.Id;
                dgvResultado.DataSource = bd.buscarBD(consulta);
                txtBuscarSocio.Text = "";
            }
        }
    }
}
