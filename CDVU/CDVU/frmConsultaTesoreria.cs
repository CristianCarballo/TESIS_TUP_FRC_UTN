using CDVU.Clases.Base_de_Datos;
using CDVU.Clases.Base_de_Datos.GestorClub;
using CDVU.Clases.Club;
using CDVU.Clases.Tesorería;
using CDVU.Personas;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CDVU
{
    public partial class frmConsultaTesoreria : Form
    {
        AccesoBD bd;
        GestorSocio gs;
        GestorTesoreria gt;
        Socio socio;

        public frmConsultaTesoreria()
        {
            InitializeComponent();
            bd = new AccesoBD();
            gs = new GestorSocio();
            gt = new GestorTesoreria();
            socio = new Socio();
        }

        // ************************ CARGA DE DATOS ************************

        private void frmConsultaTesoreria_Load(object sender, EventArgs e)
        {
            cargarListaSocio();
            dtpFechaRecaudacion.Enabled = false;
        }

        private void cargarListaSocio()
        {
            lstSocios.Update();
            lstSocios.DataSource = gs.listaSocios();
            lstSocios.ValueMember = "id";
            lstSocios.DisplayMember = "";
            lstSocios.SelectedIndex = -1;
        }

        private void cargarListaRecibo(int idSocio)
        {
            lstRecibo.Update();
            lstRecibo.DataSource = gt.listaReciboSegunIdSocio(idSocio);
            lstRecibo.ValueMember = "id";
            lstRecibo.DisplayMember = "";
            lstRecibo.SelectedIndex = -1;
        }

        private void lstSocios_SelectedIndexChanged(object sender, EventArgs e)
        {
            socio = (Socio)lstSocios.SelectedItem;
            if (socio != null)
            {
                cargarListaRecibo(socio.Id);
            }
            else
            {
                lstRecibo.DataSource = null;
                lstRecibo.Items.Clear();
            }
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

        private void lstRecibo_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (lstRecibo.Enabled)
            {
                if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                {
                    e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(209, 129, 5)), new Rectangle(e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height));
                    e.Graphics.DrawString(lstRecibo.Items[e.Index].ToString(), e.Font, Brushes.White, new Rectangle(e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height));
                }
                else
                {
                    e.DrawBackground();
                    if (e.Index >= 0)
                    {
                        e.Graphics.DrawString(lstRecibo.Items[e.Index].ToString(), e.Font, Brushes.White, new Rectangle(e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height));
                    }
                }
                e.DrawFocusRectangle();
            }
            else
            {
                if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                {
                    e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(209, 129, 5)), new Rectangle(e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height));
                    e.Graphics.DrawString(lstRecibo.Items[e.Index].ToString(), e.Font, Brushes.Black, new Rectangle(e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height));
                }
                else
                {
                    e.DrawBackground();
                    if (e.Index >= 0)
                    {
                        e.Graphics.DrawString(lstRecibo.Items[e.Index].ToString(), e.Font, Brushes.Black, new Rectangle(e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height));
                    }
                }
                e.DrawFocusRectangle();
            }
        }

        private void cmbFecha_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFecha.SelectedIndex == 2)
            {
                dtpFechaRecaudacion.Enabled = true;
            }
            else
                dtpFechaRecaudacion.Enabled = false;
        }

        private void limpiarCampos()
        {
            txtBuscarSocio.Text = "";
            lstRecibo.DataSource = null;
            lstRecibo.Items.Clear();
            dtpFechaRecaudacion.Enabled = false;
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
            if (lstRecibo.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un recibo de la lista para continuar", "Seleccione un recibo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                return false;
            }
            else
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

        private void btnDetalleDelRecibo_Click(object sender, EventArgs e)
        {
            if (validarSeleccionLista())
            {
                Recibo recibo = (Recibo)lstRecibo.SelectedItem;
                dgvResultado.DataSource = gt.listaPagoSegunRecibo(recibo.Id);
                limpiarCampos();
            }
        }

        private void btnRecaudacionPorFecha_Click(object sender, EventArgs e)
        {
            if (cmbFecha.SelectedIndex == -1)
                MessageBox.Show("Debe seleccionar una fecha para saber la recaudación", "Seleccione una fecha", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            else
            {
                // anual
                if (cmbFecha.SelectedIndex == 0)
                {
                    string consulta = "select YEAR(fecha) Año, sum(montoTotal) 'Recaudación total anual' from Recibo group by YEAR(fecha)";
                    dgvResultado.DataSource = bd.buscarBD(consulta);
                    limpiarCampos();
                }
                else
                //mensual
                    if (cmbFecha.SelectedIndex == 1)
                {
                    string consulta = "select MONTH(fecha) Mes, YEAR(fecha) Año, sum(montoTotal) 'Recaudación total mensual' from Recibo group by MONTH(fecha), YEAR(fecha)";
                    dgvResultado.DataSource = bd.buscarBD(consulta);
                    limpiarCampos();
                }
                //diario
                else
                {
                    DateTime fecha = dtpFechaRecaudacion.Value.Date;
                    string consulta = "select DAY(fecha) Día , MONTH(fecha) Mes, YEAR(fecha) Año, sum(montoTotal) 'Recaudación total diaria' from Recibo where fecha = convert(datetime, '" + fecha.Date.ToString("MM/dd/yyyy") + "' ) group by DAY(fecha), MONTH(fecha), YEAR(fecha)";
                    dgvResultado.DataSource = bd.buscarBD(consulta);
                }
            }
        }
    }
}
