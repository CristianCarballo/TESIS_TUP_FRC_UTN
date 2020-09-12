using CDVU.Clases.Base_de_Datos.GestorClub;
using CDVU.Clases.Club;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CDVU
{
    public partial class frmDeporte : Form
    {
        GestorDeporte gd;
        ToolTip toolTip;
        Deporte deporte;

        public frmDeporte()
        {
            InitializeComponent();
            gd = new GestorDeporte();
            toolTip = new ToolTip();
            deporte = new Deporte();
        }

        enum Acciones { agregar, modificar, eliminar, buscar }
        Acciones miAccion = Acciones.agregar;


        // ************************ CARGA DE DATOS ************************

        private void frmDeporte_Load(object sender, EventArgs e)
        {
            cargarListaDeporte();
            cargarComboClasificacion();
            habilitar(false);
        }

        private void cargarListaDeporte()
        {
            lstDeportes.Update();
            lstDeportes.DataSource = gd.listaDeporte();
            lstDeportes.ValueMember = "id";
            lstDeportes.DisplayMember = "";
            lstDeportes.SelectedIndex = -1;
        }

        private void cargarComboClasificacion()
        {
            cmbClasificacionDeporte.Update();
            cmbClasificacionDeporte.DataSource = gd.listaClasificacionDeporte();
            cmbClasificacionDeporte.ValueMember = "id";
            cmbClasificacionDeporte.DisplayMember = "";
            cmbClasificacionDeporte.SelectedIndex = -1;

            cmbBuscarPorClasificacion.Update();
            cmbBuscarPorClasificacion.DataSource = gd.listaClasificacionDeporte();
            cmbBuscarPorClasificacion.ValueMember = "id";
            cmbBuscarPorClasificacion.DisplayMember = "";
            cmbBuscarPorClasificacion.SelectedIndex = -1;
        }

        // ************************ VALIDACIONES ************************

        private void btnAgregarDeporte_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(btnAgregarDeporte, "Agregar nuevo deporte");
        }

        private void btnModificarDeporte_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(btnModificarDeporte, "Modificar deporte seleccionado");
        }

        private void btnEliminarDeporte_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(btnEliminarDeporte, "Eliminar deporte seleccionado");
        }

        private void btnAceptar_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(btnAceptar, "Aceptar cambios");
        }

        private void btnCancelar_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(btnCancelar, "Cancelar cambios");
        }

        private void btnLimpiar_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(btnLimpiar, "Vaciar todos los campos del formulario");
        }

        private void lstDeportes_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (lstDeportes.Enabled)
            {
                if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                {
                    e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(209, 129, 5)), new Rectangle(e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height));
                    e.Graphics.DrawString(lstDeportes.Items[e.Index].ToString(), e.Font, Brushes.White, new Rectangle(e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height));
                }
                else
                {
                    e.DrawBackground();
                    if (e.Index >= 0)
                    {
                        e.Graphics.DrawString(lstDeportes.Items[e.Index].ToString(), e.Font, Brushes.White, new Rectangle(e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height));
                    }
                }
                e.DrawFocusRectangle();
            }
            else
            {
                if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                {
                    e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(209, 129, 5)), new Rectangle(e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height));
                    e.Graphics.DrawString(lstDeportes.Items[e.Index].ToString(), e.Font, Brushes.Black, new Rectangle(e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height));
                }
                else
                {
                    e.DrawBackground();
                    if (e.Index >= 0)
                    {
                        e.Graphics.DrawString(lstDeportes.Items[e.Index].ToString(), e.Font, Brushes.Black, new Rectangle(e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height));
                    }
                }
                e.DrawFocusRectangle();
            }
        }

        private void limpiarCampos()
        {
            lstDeportes.SelectedIndex = -1;
            lblId.Text = "";
            txtNombre.Text = "";
            cmbClasificacionDeporte.SelectedIndex = -1;
        }

        private Deporte getDeporteDelForm()
        {
            if (miAccion == Acciones.agregar)
            {
                deporte = new Deporte();
                deporte.Nombre = txtNombre.Text;
                deporte.Clasificacion = (ClasificacionDeporte)cmbClasificacionDeporte.SelectedItem;
            }
            else if (miAccion == Acciones.modificar)
            {
                deporte.Id = Convert.ToInt32(lblId.Text);
                deporte.Nombre = txtNombre.Text;
                deporte.Clasificacion = (ClasificacionDeporte)cmbClasificacionDeporte.SelectedItem;
            }
            else
                deporte = (Deporte)lstDeportes.SelectedItem;
            return deporte;
        }

        private void setDeporteAlForm(Deporte d)
        {
            lblId.Text = Convert.ToString(d.Id);
            txtNombre.Text = d.Nombre;
            cmbClasificacionDeporte.SelectedValue = d.Clasificacion.Id;
        }

        private void abmDeporte(Acciones accion)
        {
            if (accion == Acciones.agregar)
            {
                if (!gd.agregarDeporte(getDeporteDelForm()))
                    MessageBox.Show("Ocurrió un error al guardar el deporte");
                else
                    MessageBox.Show("Deporte agregado correctamente");
            }
            else if (accion == Acciones.modificar)
            {
                if (!gd.modificarDeporte(getDeporteDelForm()))
                    MessageBox.Show("Ocurrió un error al modificar el deporte");
                else
                    MessageBox.Show("Datos modificados correctamente");
            }
            else if (accion == Acciones.eliminar)
            {
                if (!gd.eliminarDeporte(getDeporteDelForm()))
                    MessageBox.Show("Ocurrió un error al eliminar el deporte");
                else
                    MessageBox.Show("Deporte eliminado correctamente");
            }
        }

        private void habilitar(bool x)
        {
            btnAgregarDeporte.Enabled = !x;
            btnModificarDeporte.Enabled = !x;
            btnEliminarDeporte.Enabled = !x;
            lstDeportes.Enabled = !x;
            txtNombre.Enabled = x;
            cmbClasificacionDeporte.Enabled = x;
            btnAceptar.Enabled = x;
            btnCancelar.Enabled = x;
            btnLimpiar.Enabled = x;

            if (btnAceptar.Enabled)
                btnAceptar.BackgroundImage = CDVU.Properties.Resources.icons8_aprobación_64;
            else
                btnAceptar.BackgroundImage = CDVU.Properties.Resources.icons8_aprobación_64__osc;

            if (btnCancelar.Enabled)
                btnCancelar.BackgroundImage = CDVU.Properties.Resources.icons8_no_molestar_64;
            else
                btnCancelar.BackgroundImage = CDVU.Properties.Resources.icons8_no_molestar_64__osc;

            if (btnLimpiar.Enabled)
                btnLimpiar.BackgroundImage = CDVU.Properties.Resources.icons8_símbolo_vaciar_64;
            else
                btnLimpiar.BackgroundImage = CDVU.Properties.Resources.icons8_símbolo_vaciar_64_osc;

            if (btnAgregarDeporte.Enabled)
                btnAgregarDeporte.BackgroundImage = CDVU.Properties.Resources.icons8_añadir_64;
            else
                btnAgregarDeporte.BackgroundImage = CDVU.Properties.Resources.icons8_añadir_64__osc1;

            if (btnModificarDeporte.Enabled)
                btnModificarDeporte.BackgroundImage = CDVU.Properties.Resources.icons8_reemplazar_64;
            else
                btnModificarDeporte.BackgroundImage = CDVU.Properties.Resources.icons8_reemplazar_64_osc;

            if (btnEliminarDeporte.Enabled)
                btnEliminarDeporte.BackgroundImage = CDVU.Properties.Resources.icons8_eliminar_64;
            else
                btnEliminarDeporte.BackgroundImage = CDVU.Properties.Resources.icons8_eliminar_64_;
        }

        private void cmbBuscarPorClasificacion_SelectionChangeCommitted(object sender, EventArgs e)
        {
            lstDeportes.Update();
            lstDeportes.DataSource = gd.listaDeporteSegunIdClasificacion(Convert.ToInt32(cmbBuscarPorClasificacion.SelectedValue));
            lstDeportes.ValueMember = "id";
            lstDeportes.DisplayMember = "";
            lstDeportes.SelectedIndex = -1;
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                e.Handled = true;
                return;
            }
        }

        private bool validarVacios()
        {
            if (txtNombre.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese nombre del deporte", "Nombre", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                return false;
            }
            return true;
        }

        private bool validarSeleccionLista()
        {
            if (lstDeportes.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un deporte de la lista para continuar", "Seleccione un deporte", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                return false;
            }
            return true;
        }

        // ************************ BOTONES ************************

        private void btnAgregarDeporte_Click(object sender, EventArgs e)
        {
            miAccion = Acciones.agregar;
            habilitar(true);
            lstDeportes.SelectedIndex = -1;
        }

        private void btnModificarDeporte_Click(object sender, EventArgs e)
        {
            if (validarSeleccionLista())
            {
                miAccion = Acciones.modificar;
                habilitar(true);
                setDeporteAlForm((Deporte)lstDeportes.SelectedItem);
            }
        }

        private void btnEliminarDeporte_Click(object sender, EventArgs e)
        {
            if (validarSeleccionLista() && MessageBox.Show("¿Seguro que quiere eliminar?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                miAccion = Acciones.eliminar;
                abmDeporte(miAccion);
                cargarListaDeporte();
                limpiarCampos();
                habilitar(false);
            }
        }
                
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (validarVacios() && MessageBox.Show("¿Guardar cambios?", "Guardando", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                abmDeporte(miAccion);
                cargarListaDeporte();
                limpiarCampos();
                habilitar(false);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que quiere cancelar? \n No se guardarán los cambios", "Cancelando", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                limpiarCampos();
                habilitar(false);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que quiere vaciar los campos del formulario? \n No se guardarán los cambios", "Limpiando campos", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                txtNombre.Text = "";
                cmbClasificacionDeporte.SelectedIndex = -1;
            }
        }

        private void btnListaCompleta_Click(object sender, EventArgs e)
        {
            lstDeportes.Update();
            lstDeportes.DataSource = gd.listaDeporte();
            lstDeportes.ValueMember = "id";
            lstDeportes.DisplayMember = "";
            lstDeportes.SelectedIndex = -1;
            cmbBuscarPorClasificacion.SelectedIndex = -1;
        }
    }
}
