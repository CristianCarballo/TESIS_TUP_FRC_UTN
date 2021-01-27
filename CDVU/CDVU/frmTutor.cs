using CDVU.Clases.Base_de_Datos;
using CDVU.Clases.Base_de_Datos.GestorPersonas;
using CDVU.Clases.Lugares;
using CDVU.Personas;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CDVU
{
    public partial class frmTutor : Form
    {
        GestorTutor gt;
        GestorSocio gs;
        GestorLocaciones gl;
        ToolTip toolTip;
        Tutor tutor;

        public frmTutor()
        {
            InitializeComponent();
            gt = new GestorTutor();
            gs = new GestorSocio();
            gl = new GestorLocaciones();
            toolTip = new ToolTip();
            tutor = new Tutor();
        }

        enum Acciones { agregar, modificar, eliminar, buscar}
        Acciones miAccion = Acciones.agregar;


        // ************************ CARGA DE DATOS ************************

        private void frmTutor_Load(object sender, EventArgs e)
        {
            cargarListaTutor();
            cargarTodosLosCombos();
            habilitar(false);
        }

        private void cargarListaTutor()
        {
            lstTutores.Update();
            lstTutores.DataSource = gt.listaTutores();
            lstTutores.ValueMember = "id";
            lstTutores.DisplayMember = "";
            lstTutores.SelectedIndex = -1;
        }

        private void cargarTodosLosCombos()
        {
            cmbProvincia.Update();
            cmbProvincia.DataSource = gl.listaProvincia();
            cmbProvincia.ValueMember = "id";
            cmbProvincia.DisplayMember = "";
            cmbProvincia.SelectedIndex = -1;

            cmbNacionalidad.Update();
            cmbNacionalidad.DataSource = gl.listaPais();
            cmbNacionalidad.ValueMember = "id";
            cmbNacionalidad.DisplayMember = "";
            cmbNacionalidad.SelectedIndex = -1;

            cmbLocalidad.Update();
            cmbLocalidad.DataSource = gl.listaLocalidad();
            cmbLocalidad.ValueMember = "id";
            cmbLocalidad.DisplayMember = "";
            cmbLocalidad.SelectedIndex = -1;
        }

        private void cmbProvincia_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cargarLocalidades(Convert.ToInt32(cmbProvincia.SelectedValue));
        }

        private void cargarLocalidades(int idProvincia)
        {
            cmbLocalidad.DataSource = gl.listaLocalidadSegunIdProvincia(idProvincia);
            cmbLocalidad.ValueMember = "id";
            cmbLocalidad.DisplayMember = "";
            cmbLocalidad.SelectedIndex = -1;
        }

        // ************************ VALIDACIONES ************************
        
        private void btnAgregarTutor_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(btnAgregarTutor, "Agregar nuevo tutor");
        }

        private void btnModificarTutor_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(btnModificarTutor, "Modificar tutor seleccionado");
        }

        private void btnEliminarTutor_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(btnEliminarTutor, "Eliminar tutor seleccionado");
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

        private void lstTutores_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (lstTutores.Enabled)
            {
                if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                {
                    e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(209, 129, 5)), new Rectangle(e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height));
                    e.Graphics.DrawString(lstTutores.Items[e.Index].ToString(), e.Font, Brushes.White, new Rectangle(e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height));
                }
                else
                {
                    e.DrawBackground();
                    if (e.Index >= 0)
                    {
                        e.Graphics.DrawString(lstTutores.Items[e.Index].ToString(), e.Font, Brushes.White, new Rectangle(e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height));
                    }
                }
                e.DrawFocusRectangle();
            }
            else
            {
                if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                {
                    e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(209, 129, 5)), new Rectangle(e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height));
                    e.Graphics.DrawString(lstTutores.Items[e.Index].ToString(), e.Font, Brushes.Black, new Rectangle(e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height));
                }
                else
                {
                    e.DrawBackground();
                    if (e.Index >= 0)
                    {
                        e.Graphics.DrawString(lstTutores.Items[e.Index].ToString(), e.Font, Brushes.Black, new Rectangle(e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height));
                    }
                }
                e.DrawFocusRectangle();
            }
        }

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

        private void limpiarCampos()
        {
            lstTutores.SelectedIndex = -1;
            lblId.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            cmbSexo.SelectedIndex = -1;
            txtDni.Text = "";
            txtDireccion.Text = "";
            cmbProvincia.SelectedIndex = -1;
            cmbLocalidad.SelectedIndex = -1;
            txtTelefono.Text = "";
            txtEmail.Text = "";
            dtpFechaNacimiento.Value = DateTime.Today;
            cmbNacionalidad.SelectedIndex = -1;
            lstSocios.DataSource = null;
            lstSocios.Items.Clear();
        }

        private Tutor getTutorDelForm()
        {
            if (miAccion == Acciones.agregar)
            {
                tutor = new Tutor();
                tutor.Nombre = txtNombre.Text;
                tutor.Apellido = txtApellido.Text;
                tutor.IdSexo = cmbSexo.SelectedIndex + 1;
                tutor.Dni = txtDni.Text;
                tutor.Domicilio = txtDireccion.Text;
                tutor.Localidad = (Localidad)cmbLocalidad.SelectedItem;
                tutor.Telefono = txtTelefono.Text;
                tutor.Email = txtEmail.Text;
                tutor.FechaNacimiento = dtpFechaNacimiento.Value;
                tutor.Nacionalidad = (Pais)cmbNacionalidad.SelectedItem;
            }
            else if (miAccion == Acciones.modificar)
            {
                tutor.Id = Convert.ToInt32(lblId.Text);
                tutor.Nombre = txtNombre.Text;
                tutor.Apellido = txtApellido.Text;
                tutor.IdSexo = cmbSexo.SelectedIndex + 1;
                tutor.Dni = txtDni.Text;
                tutor.Domicilio = txtDireccion.Text;
                tutor.Localidad = (Localidad)cmbLocalidad.SelectedItem;
                tutor.Telefono = txtTelefono.Text;
                tutor.Email = txtEmail.Text;
                tutor.FechaNacimiento = dtpFechaNacimiento.Value;
                tutor.Nacionalidad = (Pais)cmbNacionalidad.SelectedItem;
            }
            else
                tutor = (Tutor)lstTutores.SelectedItem;
            return tutor;
        }

        private void setTutorAlForm(Tutor t)
        {
            lblId.Text = Convert.ToString(t.Id);
            txtNombre.Text = t.Nombre;
            txtApellido.Text = t.Apellido;
            cmbSexo.SelectedIndex = t.IdSexo - 1;
            txtDni.Text = t.Dni;
            txtDireccion.Text = t.Domicilio;
            cmbLocalidad.SelectedValue = t.Localidad.Id;
            cmbProvincia.SelectedValue = t.Localidad.Provincia.Id;
            txtTelefono.Text = t.Telefono;
            txtEmail.Text = t.Email;
            dtpFechaNacimiento.Value = t.FechaNacimiento;
            cmbNacionalidad.SelectedValue = t.Nacionalidad.Id;
            lstSocios.Update();
            lstSocios.DataSource = gs.listaSociosSegunIdTutor(t.Id);
            lstSocios.ValueMember = "id";
            lstSocios.DisplayMember = "";
            lstSocios.SelectedIndex = -1;
        }

        private void abmTutor(Acciones accion)
        {
            if (accion == Acciones.agregar)
            {
                if (!gt.agregarTutor(getTutorDelForm()))
                    MessageBox.Show("Ocurrió un error al guardar el tutor");
                else
                    MessageBox.Show("Tutor agregado correctamente");
            }
            else if (accion == Acciones.modificar)
            {
                if (!gt.modificarTutor(getTutorDelForm()))
                    MessageBox.Show("Ocurrió un error al modificar el tutor");
                else
                    MessageBox.Show("Datos modificados correctamente");
            }
            else if (accion == Acciones.eliminar)
            {
                if (!gt.eliminarTutor(getTutorDelForm()))
                    MessageBox.Show("Ocurrió un error al eliminar el tutor");
                else
                    MessageBox.Show("Tutor eliminado correctamente");
            }
        }

        private void habilitar(bool x)
        {
            btnAgregarTutor.Enabled = !x;
            btnModificarTutor.Enabled = !x;
            btnEliminarTutor.Enabled = !x;
            lstTutores.Enabled = !x;
            txtNombre.Enabled = x;
            txtApellido.Enabled = x;
            cmbSexo.Enabled = x;
            txtDni.Enabled = x;
            txtDireccion.Enabled = x;
            cmbProvincia.Enabled = x;
            cmbLocalidad.Enabled = x;
            txtTelefono.Enabled = x;
            txtEmail.Enabled = x;
            dtpFechaNacimiento.Enabled = x;
            cmbNacionalidad.Enabled = x;
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

            if (btnAgregarTutor.Enabled)
                btnAgregarTutor.BackgroundImage = CDVU.Properties.Resources.icons8_añadir_64;
            else
                btnAgregarTutor.BackgroundImage = CDVU.Properties.Resources.icons8_añadir_64__osc1;

            if (btnModificarTutor.Enabled)
                btnModificarTutor.BackgroundImage = CDVU.Properties.Resources.icons8_reemplazar_64;
            else
                btnModificarTutor.BackgroundImage = CDVU.Properties.Resources.icons8_reemplazar_64_osc;

            if (btnEliminarTutor.Enabled)
                btnEliminarTutor.BackgroundImage = CDVU.Properties.Resources.icons8_eliminar_64;
            else
                btnEliminarTutor.BackgroundImage = CDVU.Properties.Resources.icons8_eliminar_64_;
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

        private void txtDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
                return;
            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                return;
            }
        }

        private bool validarVacios()
        {
            if (txtNombre.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese nombre", "Nombre", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                return false;
            }
            else
            if (txtApellido.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese apellido", "Apellido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                return false;
            }
            else
            if (cmbSexo.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione el sexo", "Sexo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                return false;
            }
            else
            if (txtDni.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese DNI", "DNI", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                return false;
            }
            else
            if (txtDireccion.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese domicilio", "Domicilio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                return false;
            }
            else
            if (cmbProvincia.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione la provincia de su domicilio", "Provincia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                return false;
            }
            else
            if (cmbLocalidad.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione la localidad de su domicilio", "Localidad", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                return false;
            }
            else
            if (dtpFechaNacimiento.Value >= DateTime.Today)
            {
                MessageBox.Show("La fecha de nacimiento incorrecta", "Fecha de nacimiento", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                return false;
            }
            else
            if (cmbNacionalidad.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione la nacionalidad", "Nacionalidad", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                return false;
            }
            else
                return true;
        }

        private bool validarSeleccionLista()
        {
            if (lstTutores.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un tutor de la lista para continuar", "Seleccione un tutor", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                return false;
            }
            return true;
        }

        // ************************ BOTONES ************************

        private void btnAgregarTutor_Click_1(object sender, EventArgs e)
        {
            miAccion = Acciones.agregar;
            habilitar(true);
            lstTutores.SelectedIndex = -1;
        }

        private void btnModificarTutor_Click_1(object sender, EventArgs e)
        {
            if (validarSeleccionLista())
            {
                miAccion = Acciones.modificar;
                habilitar(true);
                setTutorAlForm((Tutor)lstTutores.SelectedItem);
            }
        }

        private void btnEliminarTutor_Click_1(object sender, EventArgs e)
        {
            if (validarSeleccionLista() && MessageBox.Show("¿Seguro que quiere eliminar?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                miAccion = Acciones.eliminar;
                abmTutor(miAccion);
                cargarListaTutor();
                limpiarCampos();
                habilitar(false);
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (validarVacios() && MessageBox.Show("¿Guardar cambios?", "Guardando", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                abmTutor(miAccion);
                cargarListaTutor();
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
                txtApellido.Text = "";
                cmbSexo.SelectedIndex = -1;
                txtDni.Text = "";
                txtDireccion.Text = "";
                cmbProvincia.SelectedIndex = -1;
                cmbLocalidad.SelectedIndex = -1;
                txtTelefono.Text = "";
                txtEmail.Text = "";
                dtpFechaNacimiento.Value = DateTime.Today;
                cmbNacionalidad.SelectedIndex = -1;
            }
        }

        private void btnBuscarTutor_Click(object sender, EventArgs e)
        {
            if (txtBuscarTutor.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese el DNI del tutor para buscar");
            }
            else
            {
                tutor = gt.obtenerTutorPorDNI(txtBuscarTutor.Text.Trim());
                if (tutor == null)
                {
                    MessageBox.Show("No se encuentra el tutor");
                }
                else
                    lstTutores.SelectedValue = tutor.Id;
            }
        }
    }
}
