using CDVU.Clases.Base_de_Datos;
using CDVU.Clases.Base_de_Datos.GestorPersonas;
using CDVU.Clases.Lugares;
using CDVU.Personas;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CDVU
{
    public partial class frmSocio : Form
    {
        GestorSocio gs;
        GestorTutor gt;
        GestorLocaciones gl;
        ToolTip toolTip;
        Socio socio;

        public frmSocio()
        {
            InitializeComponent();
            gs = new GestorSocio();
            gt = new GestorTutor();
            gl = new GestorLocaciones();
            toolTip = new ToolTip();
            socio = new Socio();
        }

        enum Acciones { agregar, modificar, eliminar, buscar}
        Acciones miAccion = Acciones.agregar;


        // ************************ CARGA DE DATOS ************************

        private void frmSocio_Load(object sender, EventArgs e)
        {
            cargarListaSocio();
            cargarTodosLosCombos();
            habilitar(false);
        }

        private void cargarListaSocio()
        {
            lstSocios.Update();
            lstSocios.DataSource = gs.listaSocios();
            lstSocios.ValueMember = "id";
            lstSocios.DisplayMember = "";
            lstSocios.SelectedIndex = -1;
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
        
        private void btnAgregarSocio_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(btnAgregarSocio, "Agregar nuevo socio");
        }

        private void btnModificarSocio_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(btnModificarSocio, "Modificar socio seleccionado");
        }

        private void btnEliminarSocio_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(btnEliminarSocio, "Eliminar socio seleccionado");
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
            txtBuscarSocio.Text = "";
            lstSocios.SelectedIndex = -1;
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
            txtBuscarTutor.Text = "";
            lblDniTutorSeleccionado.Text = "";
            lblNombreTutorSeleccionado.Text = "";
        }

        private Socio getSocioDelForm()
        {
            if (miAccion == Acciones.agregar)
            {
                socio = new Socio();
                socio.Nombre = txtNombre.Text.Trim();
                socio.Apellido = txtApellido.Text.Trim();
                socio.IdSexo = cmbSexo.SelectedIndex +1;
                socio.Dni = txtDni.Text.Trim();
                socio.Domicilio = txtDireccion.Text.Trim();
                socio.Localidad = (Localidad)cmbLocalidad.SelectedItem;
                socio.Telefono = txtTelefono.Text.Trim();
                socio.Email = txtEmail.Text.Trim();
                socio.FechaNacimiento = dtpFechaNacimiento.Value;
                socio.Nacionalidad = (Pais)cmbNacionalidad.SelectedItem;
                if (lblDniTutorSeleccionado.Text.Trim() == "")
                    socio.Tutor = null;
                else
                    socio.Tutor = gt.obtenerTutorPorDNI(lblDniTutorSeleccionado.Text.Trim());
            }
            else if (miAccion == Acciones.modificar)
            {
                socio.Id = Convert.ToInt32(lblId.Text);
                socio.Nombre = txtNombre.Text.Trim();
                socio.Apellido = txtApellido.Text.Trim();
                socio.IdSexo = cmbSexo.SelectedIndex + 1;
                socio.Dni = txtDni.Text.Trim();
                socio.Domicilio = txtDireccion.Text.Trim();
                socio.Localidad = (Localidad)cmbLocalidad.SelectedItem;
                socio.Telefono = txtTelefono.Text.Trim();
                socio.Email = txtEmail.Text.Trim();
                socio.FechaNacimiento = dtpFechaNacimiento.Value;
                socio.Nacionalidad = (Pais)cmbNacionalidad.SelectedItem;
                if (lblDniTutorSeleccionado.Text.Trim() == "")
                    socio.Tutor = null;
                else
                    socio.Tutor = gt.obtenerTutorPorDNI(lblDniTutorSeleccionado.Text.Trim());
            }
            else
                socio = (Socio)lstSocios.SelectedItem;
            return socio;
        }

        private void setSocioAlForm(Socio s)
        {
            lblId.Text = Convert.ToString(s.Id);
            txtNombre.Text = s.Nombre;
            txtApellido.Text = s.Apellido;
            cmbSexo.SelectedIndex = s.IdSexo - 1;
            txtDni.Text = s.Dni;
            txtDireccion.Text = s.Domicilio;
            cmbLocalidad.SelectedValue = s.Localidad.Id;
            cmbProvincia.SelectedValue = s.Localidad.Provincia.Id;
            txtTelefono.Text = s.Telefono;
            txtEmail.Text = s.Email;
            dtpFechaNacimiento.Value = s.FechaNacimiento;
            cmbNacionalidad.SelectedValue = s.Nacionalidad.Id;
            if(s.Tutor != null)
            { 
                lblDniTutorSeleccionado.Text = s.Tutor.Dni;
                lblNombreTutorSeleccionado.Text = s.Tutor.ToString();
            }
        }

        private void abmSocio(Acciones accion)
        {
            if (accion == Acciones.agregar)
            {
                if (!gs.agregarSocio(getSocioDelForm()))
                    MessageBox.Show("Ocurrió un error al guardar el socio");
                else
                    MessageBox.Show("Socio agregado correctamente");
            }
            else if (accion == Acciones.modificar)
            {
                if (!gs.modificarSocio(getSocioDelForm()))
                    MessageBox.Show("Ocurrió un error al modificar el socio");
                else
                    MessageBox.Show("Datos modificados correctamente");
            }
            else if (accion == Acciones.eliminar)
            {
                if (!gs.eliminarSocio(getSocioDelForm()))
                    MessageBox.Show("Ocurrió un error al eliminar al socio");
                else
                    MessageBox.Show("Socio eliminado correctamente");
            }
        }

        private void habilitar(bool x)
        {
            btnAgregarSocio.Enabled = !x;
            btnModificarSocio.Enabled = !x;
            btnEliminarSocio.Enabled = !x;
            txtBuscarSocio.Enabled = !x;
            btnBuscarSocio.Enabled = !x;
            lstSocios.Enabled = !x;
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
            txtBuscarTutor.Enabled = x;
            btnBuscarTutor.Enabled = x;
            btnQuitarTutor.Enabled = x;
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

            if (btnAgregarSocio.Enabled)
                btnAgregarSocio.BackgroundImage = CDVU.Properties.Resources.icons8_añadir_64;
            else
                btnAgregarSocio.BackgroundImage = CDVU.Properties.Resources.icons8_añadir_64__osc1;

            if (btnModificarSocio.Enabled)
                btnModificarSocio.BackgroundImage = CDVU.Properties.Resources.icons8_reemplazar_64;
            else
                btnModificarSocio.BackgroundImage = CDVU.Properties.Resources.icons8_reemplazar_64_osc;

            if (btnEliminarSocio.Enabled)
                btnEliminarSocio.BackgroundImage = CDVU.Properties.Resources.icons8_eliminar_64;
            else
                btnEliminarSocio.BackgroundImage = CDVU.Properties.Resources.icons8_eliminar_64_;
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

        private void txtBuscarTutor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                return;
            }
        }

        private void txtBuscarSocio_KeyPress(object sender, KeyPressEventArgs e)
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
            if (lstSocios.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un socio de la lista para continuar", "Seleccione un socio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                return false;
            }
            return true;
        }

        // ************************ BOTONES ************************

        private void btnAgregarSocio_Click(object sender, EventArgs e)
        {
            miAccion = Acciones.agregar;
            habilitar(true);
            lstSocios.SelectedIndex = -1;
        }

        private void btnModificarSocio_Click(object sender, EventArgs e)
        {
            if (validarSeleccionLista())
            {
                miAccion = Acciones.modificar;
                habilitar(true);
                setSocioAlForm((Socio)lstSocios.SelectedItem);
            }
        }

        private void btnEliminarSocio_Click(object sender, EventArgs e)
        {
            if (validarSeleccionLista() && MessageBox.Show("¿Seguro que quiere eliminar?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                miAccion = Acciones.eliminar;
                abmSocio(miAccion);
                cargarListaSocio();
                limpiarCampos();
                habilitar(false);
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (validarVacios() && MessageBox.Show("¿Guardar cambios?", "Guardando", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                abmSocio(miAccion);
                cargarListaSocio();
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
                txtBuscarTutor.Text = "";
                lblDniTutorSeleccionado.Text = "";
                lblNombreTutorSeleccionado.Text = "";
            }
        }

        private void btnBuscarTutor_Click(object sender, EventArgs e)
        {
            socio.Tutor = gt.obtenerTutorPorDNI(txtBuscarTutor.Text.Trim());
            if (socio.Tutor == null)
                MessageBox.Show("No se encuentra el socio");
            else
            {
                lblDniTutorSeleccionado.Text = socio.Tutor.Dni;
                lblNombreTutorSeleccionado.Text = socio.Tutor.ToString();
            }
        }

        private void btnQuitarTutor_Click(object sender, EventArgs e)
        {
            socio.Tutor = null;
            lblNombreTutorSeleccionado.Text = "";
            lblDniTutorSeleccionado.Text = "";
        }

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
    }
}
