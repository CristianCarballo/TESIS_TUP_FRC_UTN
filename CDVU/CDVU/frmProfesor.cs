using CDVU.Clases.Base_de_Datos;
using CDVU.Clases.Base_de_Datos.GestorClub;
using CDVU.Clases.Base_de_Datos.GestorPersonas;
using CDVU.Clases.Club;
using CDVU.Clases.Lugares;
using CDVU.Personas;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CDVU
{
    public partial class frmProfesor : Form
    {
        GestorProfesor gp;
        GestorDeporte gd;
        GestorLocaciones gl;
        ToolTip toolTip;
        Profesor profesor;
        DeporteProfesor deporteProfesor;
        List<Deporte> listaAnterior;

        public frmProfesor()
        {
            InitializeComponent();
            gp = new GestorProfesor();
            gd = new GestorDeporte();
            gl = new GestorLocaciones();
            toolTip = new ToolTip();
            profesor = new Profesor();
            deporteProfesor = new DeporteProfesor();
            listaAnterior = new List<Deporte>();
        }

        enum Acciones { agregar, modificar, eliminar, buscar }
        Acciones miAccion = Acciones.agregar;


        // ************************ CARGA DE DATOS ************************

        private void frmProfesor_Load(object sender, EventArgs e)
        {
            cargarListaProfesor();
            cargarTodosLosCombos();
            habilitar(false);
        }

        private void cargarListaProfesor()
        {
            lstProfesores.Update();
            lstProfesores.DataSource = gp.listaProfesor();
            lstProfesores.ValueMember = "id";
            lstProfesores.DisplayMember = "";
            lstProfesores.SelectedIndex = -1;
        }

        private void cargarListaDeporte(List<Deporte> lista)
        {
            lstDeporte.Update();
            lstDeporte.DataSource = lista;
            lstDeporte.ValueMember = "id";
            lstDeporte.DisplayMember = "";
            lstDeporte.SelectedIndex = -1;
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

            cmbTipoDeporte.Update();
            cmbTipoDeporte.DataSource = gd.listaClasificacionDeporte();
            cmbTipoDeporte.ValueMember = "id";
            cmbTipoDeporte.DisplayMember = "";
            cmbTipoDeporte.SelectedIndex = -1;

            cmbDeporte.Update();
            cmbDeporte.DataSource = gd.listaDeporte();
            cmbDeporte.ValueMember = "id";
            cmbDeporte.DisplayMember = "";
            cmbDeporte.SelectedIndex = -1;

            cmbBuscarPorDeporte.Update();
            cmbBuscarPorDeporte.DataSource = gd.listaDeporte();
            cmbBuscarPorDeporte.ValueMember = "id";
            cmbBuscarPorDeporte.DisplayMember = "";
            cmbBuscarPorDeporte.SelectedIndex = -1;
        }

        private void cmbTipoDeporte_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cargarComboDeporte(Convert.ToInt32(cmbTipoDeporte.SelectedValue));
        }

        private void cargarComboDeporte(int idTipoDeporte)
        {
            cmbDeporte.DataSource = gd.listaDeporteSegunIdClasificacion(idTipoDeporte);
            cmbDeporte.ValueMember = "id";
            cmbDeporte.DisplayMember = "";
            cmbDeporte.SelectedIndex = -1;
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

        private void btnAgregarProfesor_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(btnAgregarProfesor, "Agregar nuevo profesor");
        }

        private void btnModificarProfesor_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(btnModificarProfesor, "Modificar profesor seleccionado");
        }

        private void btnEliminarProfesor_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(btnEliminarProfesor, "Eliminar profesor seleccionado");
        }

        private void btnAgregarDeporte_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(btnCancelar, "Agregar deporte seleccionado");
        }

        private void btnQuitarDeporte_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(btnCancelar, "Quitar deporte seleccionado");
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

        private void lstProfesores_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (lstProfesores.Enabled)
            {
                if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                {
                    e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(209, 129, 5)), new Rectangle(e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height));
                    e.Graphics.DrawString(lstProfesores.Items[e.Index].ToString(), e.Font, Brushes.White, new Rectangle(e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height));
                }
                else
                {
                    e.DrawBackground();
                    if (e.Index >= 0)
                    {
                        e.Graphics.DrawString(lstProfesores.Items[e.Index].ToString(), e.Font, Brushes.White, new Rectangle(e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height));
                    }
                }
                e.DrawFocusRectangle();
            }
            else
            {
                if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                {
                    e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(209, 129, 5)), new Rectangle(e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height));
                    e.Graphics.DrawString(lstProfesores.Items[e.Index].ToString(), e.Font, Brushes.Black, new Rectangle(e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height));
                }
                else
                {
                    e.DrawBackground();
                    if (e.Index >= 0)
                    {
                        e.Graphics.DrawString(lstProfesores.Items[e.Index].ToString(), e.Font, Brushes.Black, new Rectangle(e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height));
                    }
                }
                e.DrawFocusRectangle();
            }
        }

        private void lstDeporte_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (lstDeporte.Enabled)
            {
                if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                {
                    e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(209, 129, 5)), new Rectangle(e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height));
                    e.Graphics.DrawString(lstDeporte.Items[e.Index].ToString(), e.Font, Brushes.White, new Rectangle(e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height));
                }
                else
                {
                    e.DrawBackground();
                    if (e.Index >= 0)
                    {
                        e.Graphics.DrawString(lstDeporte.Items[e.Index].ToString(), e.Font, Brushes.White, new Rectangle(e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height));
                    }
                }
                e.DrawFocusRectangle();
            }
            else
            {
                if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                {
                    e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(209, 129, 5)), new Rectangle(e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height));
                    e.Graphics.DrawString(lstDeporte.Items[e.Index].ToString(), e.Font, Brushes.Black, new Rectangle(e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height));
                }
                else
                {
                    e.DrawBackground();
                    if (e.Index >= 0)
                    {
                        e.Graphics.DrawString(lstDeporte.Items[e.Index].ToString(), e.Font, Brushes.Black, new Rectangle(e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height));
                    }
                }
                e.DrawFocusRectangle();
            }
        }

        private void limpiarCampos()
        {
            lstProfesores.SelectedIndex = -1;
            lblId.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            cmbSexo.SelectedIndex = -1;
            txtDni.Text = "";
            txtMatricula.Text = "";
            txtDireccion.Text = "";
            cmbProvincia.SelectedIndex = -1;
            cmbLocalidad.SelectedIndex = -1;
            txtTelefono.Text = "";
            txtEmail.Text = "";
            dtpFechaNacimiento.Value = DateTime.Today;
            cmbNacionalidad.SelectedIndex = -1;
            cmbTipoDeporte.SelectedIndex = -1;
            cmbDeporte.SelectedIndex = -1;
            lstDeporte.DataSource = null;
            lstDeporte.Items.Clear();
            txtDeporte.Text = "";
        }

        private DeporteProfesor getProfesorDelForm()
        {
            if (miAccion == Acciones.agregar)
            {
                profesor = new Profesor();
                deporteProfesor = new DeporteProfesor();
                profesor.Nombre = txtNombre.Text;
                profesor.Apellido = txtApellido.Text;
                profesor.IdSexo = cmbSexo.SelectedIndex + 1;
                profesor.Dni = txtDni.Text;
                profesor.Matricula = txtMatricula.Text;
                profesor.Domicilio = txtDireccion.Text;
                profesor.Localidad = (Localidad)cmbLocalidad.SelectedItem;
                profesor.Telefono = txtTelefono.Text;
                profesor.Email = txtEmail.Text;
                profesor.FechaNacimiento = dtpFechaNacimiento.Value;
                profesor.Nacionalidad = (Pais)cmbNacionalidad.SelectedItem;
                deporteProfesor.Profesor = profesor;
                foreach (Deporte x in lstDeporte.Items)
                {
                    if (x != null)
                        deporteProfesor.ListaDeporte.Add(x);
                }
            }
            else if (miAccion == Acciones.modificar)
            {
                profesor.Id = Convert.ToInt32(lblId.Text);
                profesor.Nombre = txtNombre.Text;
                profesor.Apellido = txtApellido.Text;
                profesor.IdSexo = cmbSexo.SelectedIndex + 1;
                profesor.Dni = txtDni.Text;
                profesor.Matricula = txtMatricula.Text;
                profesor.Domicilio = txtDireccion.Text;
                profesor.Localidad = (Localidad)cmbLocalidad.SelectedItem;
                profesor.Telefono = txtTelefono.Text;
                profesor.Email = txtEmail.Text;
                profesor.FechaNacimiento = dtpFechaNacimiento.Value;
                profesor.Nacionalidad = (Pais)cmbNacionalidad.SelectedItem;
                deporteProfesor.Profesor = profesor;
                deporteProfesor.ListaDeporte.Clear();
                foreach (Deporte x in lstDeporte.Items)
                {
                    if (x != null)
                        deporteProfesor.ListaDeporte.Add(x);
                }
            }
            else
                deporteProfesor = (DeporteProfesor)lstProfesores.SelectedItem;
            return deporteProfesor;
        }

        private void setProfesorAlForm(DeporteProfesor dp)
        {
            lblId.Text = Convert.ToString(dp.Profesor.Id);
            txtNombre.Text = dp.Profesor.Nombre;
            txtApellido.Text = dp.Profesor.Apellido;
            cmbSexo.SelectedIndex = dp.Profesor.IdSexo -1;
            txtDni.Text = dp.Profesor.Dni;
            txtMatricula.Text = dp.Profesor.Matricula;
            txtDireccion.Text = dp.Profesor.Domicilio;
            cmbLocalidad.SelectedValue = dp.Profesor.Localidad.Id;
            cmbProvincia.SelectedValue = dp.Profesor.Localidad.Provincia.Id;
            txtTelefono.Text = dp.Profesor.Telefono;
            txtEmail.Text = dp.Profesor.Email;
            dtpFechaNacimiento.Value = dp.Profesor.FechaNacimiento;
            cmbNacionalidad.SelectedValue = dp.Profesor.Nacionalidad.Id;
            cargarListaDeporte(gd.listaDeporteSegunIdProfesor(dp.Profesor.Id));
            listaAnterior = dp.ListaDeporte;
        }

        private void abmProfesor(Acciones accion)
        {
            deporteProfesor = getProfesorDelForm();
            if (accion == Acciones.agregar)
            {
                if (!gp.agregarDeporteProfesor(deporteProfesor) || deporteProfesor.ListaDeporte == null)
                    MessageBox.Show("Ocurrió un error al guardar el profesor");
                else
                    MessageBox.Show("Profesor agregado correctamente");
            }
            else if (accion == Acciones.modificar)
            {
                if (!gp.modificarDeporteProfesor(deporteProfesor) || deporteProfesor.ListaDeporte == null)
                    MessageBox.Show("Ocurrió un error al modificar el profesor");
                else
                    MessageBox.Show("Datos modificados correctamente");
            }
            else if (accion == Acciones.eliminar)
            {
                if (!gp.eliminarProfesor(deporteProfesor))
                    MessageBox.Show("Ocurrió un error al eliminar al profesor");
                else
                    MessageBox.Show("Profesor eliminado correctamente");
            }
        }

        private void cmbDeporte_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDeporte.SelectedItem != null)
                txtDeporte.Text = cmbDeporte.SelectedItem.ToString();
            else
                txtDeporte.Text = "";
        }

        private void cmbBuscarPorDeporte_SelectionChangeCommitted(object sender, EventArgs e)
        {
            lstProfesores.Update();
            lstProfesores.DataSource = gp.listaProfesorSegunIdDeporte(Convert.ToInt32(cmbBuscarPorDeporte.SelectedValue));
            lstProfesores.ValueMember = "id";
            lstProfesores.DisplayMember = "";
            lstProfesores.SelectedIndex = -1;
        }

        private void habilitar(bool x)
        {
            btnAgregarProfesor.Enabled = !x;
            btnModificarProfesor.Enabled = !x;
            btnEliminarProfesor.Enabled = !x;
            lstProfesores.Enabled = !x;
            txtNombre.Enabled = x;
            txtApellido.Enabled = x;
            cmbSexo.Enabled = x;
            txtDni.Enabled = x;
            txtMatricula.Enabled = x;
            txtDireccion.Enabled = x;
            cmbProvincia.Enabled = x;
            cmbLocalidad.Enabled = x;
            txtTelefono.Enabled = x;
            txtEmail.Enabled = x;
            dtpFechaNacimiento.Enabled = x;
            cmbNacionalidad.Enabled = x;
            cmbTipoDeporte.Enabled = x;
            cmbDeporte.Enabled = x;
            txtDeporte.Enabled = x;
            btnAgregarDeporte.Enabled = x;
            btnQuitarDeporte.Enabled = x;
            lstDeporte.Enabled = x;
            btnAceptar.Enabled = x;
            btnCancelar.Enabled = x;
            btnLimpiar.Enabled = x;

            if (btnAgregarDeporte.Enabled)
                btnAgregarDeporte.BackgroundImage = CDVU.Properties.Resources.icons8_panel_cerrado_64;
            else
                btnAgregarDeporte.BackgroundImage = CDVU.Properties.Resources.icons8_panel_cerrado_64_osc;

            if (btnQuitarDeporte.Enabled)
                btnQuitarDeporte.BackgroundImage = CDVU.Properties.Resources.icons8_ventana_abierta_64;
            else
                btnQuitarDeporte.BackgroundImage = CDVU.Properties.Resources.icons8_ventana_abierta_64_osc;

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

            if (btnAgregarProfesor.Enabled)
                btnAgregarProfesor.BackgroundImage = CDVU.Properties.Resources.icons8_añadir_64;
            else
                btnAgregarProfesor.BackgroundImage = CDVU.Properties.Resources.icons8_añadir_64__osc1;

            if (btnModificarProfesor.Enabled)
                btnModificarProfesor.BackgroundImage = CDVU.Properties.Resources.icons8_reemplazar_64;
            else
                btnModificarProfesor.BackgroundImage = CDVU.Properties.Resources.icons8_reemplazar_64_osc;

            if (btnEliminarProfesor.Enabled)
                btnEliminarProfesor.BackgroundImage = CDVU.Properties.Resources.icons8_eliminar_64;
            else
                btnEliminarProfesor.BackgroundImage = CDVU.Properties.Resources.icons8_eliminar_64_;
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
            if (txtMatricula.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese Matrícula", "Matrícula", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                return false;
            }
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
            if (txtTelefono.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese número de teléfono o celular", "Teléfono", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                return false;
            }
            else
            if (txtEmail.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese email", "Email", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
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
            if (lstDeporte.Items.Count == 0)
            {
                MessageBox.Show("Seleccione al menos un deporte", "Deportes que enseña", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                return false;
            }
            else
                return true;
        }

        private bool validarSeleccionLista()
        {
            if (lstProfesores.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un profesor de la lista para continuar", "Seleccione un profesor", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                return false;
            }
            return true;
        }

        // ************************ BOTONES ************************

        private void btnAgregarProfesor_Click(object sender, EventArgs e)
        {
            miAccion = Acciones.agregar;
            habilitar(true);
            lstProfesores.SelectedIndex = -1;
        }

        private void btnModificarProfesor_Click(object sender, EventArgs e)
        {
            if (validarSeleccionLista())
            {
                miAccion = Acciones.modificar;
                habilitar(true);
                setProfesorAlForm((DeporteProfesor)lstProfesores.SelectedItem);
            }
        }

        private void btnEliminarProfesor_Click(object sender, EventArgs e)
        {
            if (validarSeleccionLista() && MessageBox.Show("¿Seguro que quiere eliminar?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                miAccion = Acciones.eliminar;
                abmProfesor(miAccion);
                cargarListaProfesor();
                limpiarCampos();
                habilitar(false);
            }
        }

        private void btnAgregarDeporte_Click(object sender, EventArgs e)
        {
            if (txtDeporte.Text == "" || cmbDeporte.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione el deporte que desea agregar a la lista", "Deporte", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                foreach (Deporte d in lstDeporte.Items)
                {
                    if(cmbDeporte.SelectedItem == d)
                    { 
                        MessageBox.Show("El deporte que intenta agregar ya está en la lista", "Deporte", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                listaAnterior = new List<Deporte>();
                foreach (Deporte d in lstDeporte.Items)
                {
                    if (d != null)
                        listaAnterior.Add(d);
                }
                lstDeporte.DataSource = null;
                lstDeporte.Items.Clear();
                lstDeporte.Items.Add((Deporte)cmbDeporte.SelectedItem);
                foreach (Deporte d in listaAnterior)
                {
                    if (d != null)
                        lstDeporte.Items.Add(d);
                }
                cmbTipoDeporte.SelectedItem = -1;
                cmbDeporte.SelectedItem = -1;
            }
        }

        private void btnQuitarDeporte_Click(object sender, EventArgs e)
        {
            if (lstDeporte.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione el deporte que desea quitar de la lista", "Deporte", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                listaAnterior = new List<Deporte>();
                foreach (Deporte d in lstDeporte.Items)
                {
                    if (d != null)
                        listaAnterior.Add(d);
                }
                listaAnterior.Remove((Deporte)lstDeporte.SelectedItem);
                lstDeporte.DataSource = null;
                lstDeporte.Items.Clear();
                foreach (Deporte x in listaAnterior)
                {
                    lstDeporte.Items.Add(x);
                }
                cmbTipoDeporte.SelectedItem = -1;
                cmbDeporte.SelectedItem = -1;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (validarVacios() && MessageBox.Show("¿Guardar cambios?", "Guardando", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                abmProfesor(miAccion);
                cargarListaProfesor();
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
                txtMatricula.Text = "";
                txtDireccion.Text = "";
                cmbProvincia.SelectedIndex = -1;
                cmbLocalidad.SelectedIndex = -1;
                txtTelefono.Text = "";
                txtEmail.Text = "";
                dtpFechaNacimiento.Value = DateTime.Today;
                cmbNacionalidad.SelectedIndex = -1;
                cmbTipoDeporte.SelectedIndex = -1;
                cmbDeporte.SelectedIndex = -1;
                lstDeporte.DataSource = null;
                lstDeporte.Items.Clear();
                txtDeporte.Text = "";
            }
        }

        private void btnListaCompleta_Click(object sender, EventArgs e)
        {
            cargarListaProfesor();
            cmbBuscarPorDeporte.SelectedIndex = -1;
        }
    }
}
