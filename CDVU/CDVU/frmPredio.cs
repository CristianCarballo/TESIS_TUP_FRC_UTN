using CDVU.Clases.Base_de_Datos.GestorClub;
using CDVU.Clases.Club;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CDVU
{
    public partial class frmPredio : Form
    {
        GestorEntrenamiento ge;
        GestorDeporte gd;
        ToolTip toolTip;
        Predio predio;

        public frmPredio()
        {
            InitializeComponent();
            ge = new GestorEntrenamiento();
            gd = new GestorDeporte();
            toolTip = new ToolTip();
            predio = new Predio();
        }

        enum Acciones { agregar, modificar, eliminar, buscar }
        Acciones miAccion = Acciones.agregar;


        // ************************ CARGA DE DATOS ************************

        private void frmPredio_Load(object sender, EventArgs e)
        {
            cargarComboDeporte();
            cargarListaPredios();
            habilitar(false);
        }

        private void cargarListaPredios()
        {
            lstPredios.Update();
            lstPredios.DataSource = ge.listaPredios();
            lstPredios.ValueMember = "id";
            lstPredios.DisplayMember = "";
            lstPredios.SelectedIndex = -1;
        }

        private void cargarComboDeporte()
        {
            cmbBuscarPorDeporte.Update();
            cmbBuscarPorDeporte.DataSource = gd.listaDeporte();
            cmbBuscarPorDeporte.ValueMember = "id";
            cmbBuscarPorDeporte.DisplayMember = "";
            cmbBuscarPorDeporte.SelectedIndex = -1;
        }

        // ************************ VALIDACIONES ************************

        private void btnAgregarPredio_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(btnAgregarPredio, "Agregar nuevo predio");
        }

        private void btnModificarPredio_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(btnModificarPredio, "Modificar predio seleccionado");
        }

        private void btnEliminarPredio_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(btnEliminarPredio, "Eliminar predio seleccionado");
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

        private void lstPredios_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (lstPredios.Enabled)
            {
                if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                {
                    e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(209, 129, 5)), new Rectangle(e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height));
                    e.Graphics.DrawString(lstPredios.Items[e.Index].ToString(), e.Font, Brushes.White, new Rectangle(e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height));
                }
                else
                {
                    e.DrawBackground();
                    if (e.Index >= 0)
                    {
                        e.Graphics.DrawString(lstPredios.Items[e.Index].ToString(), e.Font, Brushes.White, new Rectangle(e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height));
                    }
                }
                e.DrawFocusRectangle();
            }
            else
            {
                if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                {
                    e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(209, 129, 5)), new Rectangle(e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height));
                    e.Graphics.DrawString(lstPredios.Items[e.Index].ToString(), e.Font, Brushes.Black, new Rectangle(e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height));
                }
                else
                {
                    e.DrawBackground();
                    if (e.Index >= 0)
                    {
                        e.Graphics.DrawString(lstPredios.Items[e.Index].ToString(), e.Font, Brushes.Black, new Rectangle(e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height));
                    }
                }
                e.DrawFocusRectangle();
            }
        }

        private void limpiarCampos()
        {
            lstPredios.SelectedIndex = -1;
            lblId.Text = "";
            txtDescripcion.Text = "";
            cmbBuscarPorDeporte.SelectedIndex = -1;
        }

        private Predio getPredioDelForm()
        {
            if (miAccion == Acciones.agregar)
            {
                predio = new Predio();
                predio.Descripcion = txtDescripcion.Text;
            }
            else if (miAccion == Acciones.modificar)
            {
                predio.Id = Convert.ToInt32(lblId.Text);
                predio.Descripcion = txtDescripcion.Text;
            }
            else
                predio = (Predio)lstPredios.SelectedItem;
            return predio;
        }

        private void setPredioAlForm(Predio p)
        {
            lblId.Text = Convert.ToString(p.Id);
            txtDescripcion.Text = p.Descripcion;
        }

        private void abmPredio(Acciones accion)
        {
            if (accion == Acciones.agregar)
            {
                if (!ge.agregarPredio(getPredioDelForm()))
                    MessageBox.Show("Ocurrió un error al guardar el predio");
                else
                    MessageBox.Show("Predio agregado correctamente");
            }
            else if (accion == Acciones.modificar)
            {
                if (!ge.modificarPredio(getPredioDelForm()))
                    MessageBox.Show("Ocurrió un error al modificar el predio");
                else
                    MessageBox.Show("Datos modificados correctamente");
            }
            else if (accion == Acciones.eliminar)
            {
                if (!ge.eliminarPredio(getPredioDelForm()))
                    MessageBox.Show("Ocurrió un error al eliminar el predio");
                else
                    MessageBox.Show("Predio eliminado correctamente");
            }
        }

        private void habilitar(bool x)
        {
            btnAgregarPredio.Enabled = !x;
            btnModificarPredio.Enabled = !x;
            btnEliminarPredio.Enabled = !x;
            lstPredios.Enabled = !x;
            txtDescripcion.Enabled = x;
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

            if (btnAgregarPredio.Enabled)
                btnAgregarPredio.BackgroundImage = CDVU.Properties.Resources.icons8_añadir_64;
            else
                btnAgregarPredio.BackgroundImage = CDVU.Properties.Resources.icons8_añadir_64__osc1;

            if (btnModificarPredio.Enabled)
                btnModificarPredio.BackgroundImage = CDVU.Properties.Resources.icons8_reemplazar_64;
            else
                btnModificarPredio.BackgroundImage = CDVU.Properties.Resources.icons8_reemplazar_64_osc;

            if (btnEliminarPredio.Enabled)
                btnEliminarPredio.BackgroundImage = CDVU.Properties.Resources.icons8_eliminar_64;
            else
                btnEliminarPredio.BackgroundImage = CDVU.Properties.Resources.icons8_eliminar_64_;
        }

        private void cmbBuscarPorDeporte_SelectionChangeCommitted(object sender, EventArgs e)
        {
            lstPredios.Update();
            lstPredios.DataSource = ge.listaPredioSegunIdDeporte(Convert.ToInt32(cmbBuscarPorDeporte.SelectedValue));
            lstPredios.ValueMember = "id";
            lstPredios.DisplayMember = "";
            lstPredios.SelectedIndex = -1;
        }

        private bool validarVacios()
        {
            if (txtDescripcion.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese una descripción del predio", "Descripción", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                return false;
            }
            return true;
        }

        private bool validarSeleccionLista()
        {
            if (lstPredios.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un predio de la lista para continuar", "Seleccione un predio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                return false;
            }
            return true;
        }

        // ************************ BOTONES ************************

        private void btnAgregarPredio_Click(object sender, EventArgs e)
        {
            miAccion = Acciones.agregar;
            habilitar(true);
            lstPredios.SelectedIndex = -1;
        }

        private void btnModificarPredio_Click(object sender, EventArgs e)
        {
            if (validarSeleccionLista())
            {
                miAccion = Acciones.modificar;
                habilitar(true);
                setPredioAlForm((Predio)lstPredios.SelectedItem);
            }
        }

        private void btnEliminarPredio_Click(object sender, EventArgs e)
        {
            if (validarSeleccionLista() && MessageBox.Show("¿Seguro que quiere eliminar?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                miAccion = Acciones.eliminar;
                abmPredio(miAccion);
                cargarListaPredios();
                limpiarCampos();
                habilitar(false);
            }
        }
                
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (validarVacios() && MessageBox.Show("¿Guardar cambios?", "Guardando", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                abmPredio(miAccion);
                cargarListaPredios();
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
                txtDescripcion.Text = "";
            }
        }

        private void btnListaCompleta_Click(object sender, EventArgs e)
        {
            cargarListaPredios();
            cmbBuscarPorDeporte.SelectedIndex = -1;
        }
    }
}
