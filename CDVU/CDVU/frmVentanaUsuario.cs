using CDVU.Clases.Base_de_Datos.GestorPersonas;
using CDVU.Clases.Personas;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CDVU
{
    public partial class frmVentanaUsuario : Form
    {
        GestorUsuario gu;
        ToolTip toolTip;
        Usuario usuario;

        public frmVentanaUsuario()
        {
            InitializeComponent();
            toolTip = new ToolTip();
            gu = new GestorUsuario();
            usuario = new Usuario();
        }

        enum Acciones { agregar, modificar, eliminar, buscar }
        Acciones miAccion = Acciones.agregar;


        // ************************ CARGA DE DATOS ************************

        private void frmVentanaUsuario_Load(object sender, EventArgs e)
        {
            cargarListaUsuario();
            habilitar(false);
        }

        private void cargarListaUsuario()
        {
            lstUsuario.Update();
            lstUsuario.DataSource = gu.listaUsuario();
            lstUsuario.ValueMember = "id";
            lstUsuario.DisplayMember = "";
            lstUsuario.SelectedIndex = -1;
        }

        // ************************ VALIDACIONES ************************

        private void btnAgregarUsuario_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(btnAgregarUsuario, "Agregar nuevo usuario");
        }

        private void btnModificarUsuario_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(btnModificarUsuario, "Modificar usuario seleccionado");
        }

        private void btnEliminarUsuario_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(btnEliminarUsuario, "Eliminar usuario seleccionado");
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

        private void lstUsuario_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (lstUsuario.Enabled)
            {
                if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                {
                    e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(209, 129, 5)), new Rectangle(e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height));
                    e.Graphics.DrawString(lstUsuario.Items[e.Index].ToString(), e.Font, Brushes.White, new Rectangle(e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height));
                }
                else
                {
                    e.DrawBackground();
                    if (e.Index >= 0)
                    {
                        e.Graphics.DrawString(lstUsuario.Items[e.Index].ToString(), e.Font, Brushes.White, new Rectangle(e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height));
                    }
                }
                e.DrawFocusRectangle();
            }
            else
            {
                if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                {
                    e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(209, 129, 5)), new Rectangle(e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height));
                    e.Graphics.DrawString(lstUsuario.Items[e.Index].ToString(), e.Font, Brushes.Black, new Rectangle(e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height));
                }
                else
                {
                    e.DrawBackground();
                    if (e.Index >= 0)
                    {
                        e.Graphics.DrawString(lstUsuario.Items[e.Index].ToString(), e.Font, Brushes.Black, new Rectangle(e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height));
                    }
                }
                e.DrawFocusRectangle();
            }
        }

        private void limpiarCampos()
        {
            lstUsuario.SelectedIndex = -1;
            lblId.Text = "";
            rbtRecepcionista.Checked = true;
            rbtAdministrador.Checked = false;
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDni.Text = "";
            txtUsuario.Text = "";
            txtContrasena.Text = "";
            txtConfirmarContrasena.Text = "";
        }

        private Usuario getUsuarioDelForm()
        {
            if (miAccion == Acciones.agregar)
            {
                usuario = new Usuario();
                if (rbtAdministrador.Checked)
                {
                    usuario.IdTipoUsuario = 1;
                    usuario.TipoUsuario = "Administrador";
                }
                else
                if (rbtRecepcionista.Checked)
                {
                    usuario.IdTipoUsuario = 2;
                    usuario.TipoUsuario = "Recepcionista";
                }
                usuario.Nombre = txtNombre.Text.Trim();
                usuario.Apellido = txtApellido.Text.Trim();
                usuario.Dni = txtDni.Text.Trim();
                usuario.NombreUsuario = txtUsuario.Text.Trim();
                usuario.Contrasena = txtConfirmarContrasena.Text.Trim();
            }
            else if (miAccion == Acciones.modificar)
            {
                usuario.Id = Convert.ToInt32(lblId.Text);
                if (rbtAdministrador.Checked)
                {
                    usuario.IdTipoUsuario = 1;
                    usuario.TipoUsuario = "Administrador";
                }
                else
                if (rbtRecepcionista.Checked)
                {
                    usuario.IdTipoUsuario = 2;
                    usuario.TipoUsuario = "Recepcionista";
                }
                usuario.Nombre = txtNombre.Text.Trim();
                usuario.Apellido = txtApellido.Text.Trim();
                usuario.Dni = txtDni.Text.Trim();
                usuario.NombreUsuario = txtUsuario.Text.Trim();
                usuario.Contrasena = txtConfirmarContrasena.Text.Trim();
            }
            else
                usuario = (Usuario)lstUsuario.SelectedItem;
            return usuario;
        }

        private void setUsuarioAlForm(Usuario u)
        {
            lblId.Text = Convert.ToString(u.Id);
            if (u.IdTipoUsuario == 1)
                rbtAdministrador.Checked = true;
            if (u.IdTipoUsuario == 2)
                rbtRecepcionista.Checked = true;
            txtNombre.Text = u.Nombre;
            txtApellido.Text = u.Apellido;
            txtDni.Text = u.Dni;
            txtUsuario.Text = u.NombreUsuario;
            txtContrasena.Text = u.Contrasena;
            txtConfirmarContrasena.Text = u.Contrasena;
        }

        private void abmUsuario(Acciones accion)
        {
            usuario = getUsuarioDelForm();
            if (accion == Acciones.agregar)
            {
                if (!gu.agregarUsuario(usuario))
                    MessageBox.Show("Ocurrió un error al guardar el usuario");
                else
                    MessageBox.Show("Usuario agregado correctamente");
            }
            else if (accion == Acciones.modificar)
            {
                if (!gu.editarUsuario(usuario))
                    MessageBox.Show("Ocurrió un error al modificar el usuario");
                else
                    MessageBox.Show("Datos modificados correctamente");
            }
            else if (accion == Acciones.eliminar)
            {
                if (!gu.eliminarUsuario(usuario))
                    MessageBox.Show("Ocurrió un error al eliminar al usuario");
                else
                    MessageBox.Show("Usuario eliminado correctamente");
            }
        }

        private void cmbBuscarPorTipoUsuario_SelectionChangeCommitted(object sender, EventArgs e)
        {
            lstUsuario.Update();
            lstUsuario.DataSource = gu.listaUsuarioSegunIdTipoUsuario(Convert.ToInt32(cmbBuscarPorTipoUsuario.SelectedIndex + 1));
            lstUsuario.ValueMember = "id";
            lstUsuario.DisplayMember = "";
            lstUsuario.SelectedIndex = -1;
        }

        private void habilitar(bool x)
        {
            btnAgregarUsuario.Enabled = !x;
            btnModificarUsuario.Enabled = !x;
            btnEliminarUsuario.Enabled = !x;
            cmbBuscarPorTipoUsuario.Enabled = !x;
            btnListaCompleta.Enabled = !x;
            lstUsuario.Enabled = !x;
            rbtRecepcionista.Enabled = x;
            rbtAdministrador.Enabled = x;
            txtNombre.Enabled = x;
            txtApellido.Enabled = x;
            txtDni.Enabled = x;
            txtUsuario.Enabled = x;
            txtContrasena.Enabled = x;
            txtConfirmarContrasena.Enabled = x;
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

            if (btnAgregarUsuario.Enabled)
                btnAgregarUsuario.BackgroundImage = CDVU.Properties.Resources.icons8_añadir_64;
            else
                btnAgregarUsuario.BackgroundImage = CDVU.Properties.Resources.icons8_añadir_64__osc1;

            if (btnModificarUsuario.Enabled)
                btnModificarUsuario.BackgroundImage = CDVU.Properties.Resources.icons8_reemplazar_64;
            else
                btnModificarUsuario.BackgroundImage = CDVU.Properties.Resources.icons8_reemplazar_64_osc;

            if (btnEliminarUsuario.Enabled)
                btnEliminarUsuario.BackgroundImage = CDVU.Properties.Resources.icons8_eliminar_64;
            else
                btnEliminarUsuario.BackgroundImage = CDVU.Properties.Resources.icons8_eliminar_64_;
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

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
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
            if (txtDni.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese DNI", "DNI", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                return false;
            }
            else
            if (txtUsuario.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese usuario", "Usuario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                return false;
            }
            else
            {
                if (txtContrasena.Text.Trim() == "")
                {
                    MessageBox.Show("Ingrese contraseña", "Contraseña", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
                else
                if (txtConfirmarContrasena.Text.Trim() == "" || txtConfirmarContrasena.Text.Trim() != txtContrasena.Text.Trim())
                {
                    MessageBox.Show("Por favor confirme la contraseña para continuar", "Confirme la contraseña", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
            }
            return true;
        }

        private bool validarSeleccionLista()
        {
            if (lstUsuario.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un usuario de la lista para continuar", "Seleccione un usuario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                return false;
            }
            return true;
        }

        // ************************ BOTONES ************************

        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            miAccion = Acciones.agregar;
            habilitar(true);
            lstUsuario.SelectedIndex = -1;
        }

        private void btnModificarUsuario_Click(object sender, EventArgs e)
        {
            if (validarSeleccionLista())
            {
                miAccion = Acciones.modificar;
                habilitar(true);
                setUsuarioAlForm((Usuario)lstUsuario.SelectedItem);
            }
        }

        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            usuario = (Usuario)lstUsuario.SelectedItem;
            if (gu.listaUsuarioSegunIdTipoUsuario(1).Count <= 1 && usuario.IdTipoUsuario == 1)
                MessageBox.Show("No se puede eliminar el usuario.\n Debe haber al menos un usuario con permiso de administrador", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            if (validarSeleccionLista() && MessageBox.Show("¿Seguro que quiere eliminar?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                miAccion = Acciones.eliminar;
                abmUsuario(miAccion);
                cargarListaUsuario();
                limpiarCampos();
                habilitar(false);
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (gu.listaUsuarioSegunIdTipoUsuario(1).Count <= 1 && (miAccion == Acciones.modificar))
            {
                rbtAdministrador.Checked = true;
                MessageBox.Show("No se puede cambiar el permiso, debe haber al menos un administrador", "Permiso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            if (validarVacios() && MessageBox.Show("¿Guardar cambios?", "Guardando", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                abmUsuario(miAccion);
                cargarListaUsuario();
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
                rbtRecepcionista.Checked = true;
                rbtAdministrador.Checked = false;
                txtNombre.Text = "";
                txtApellido.Text = "";
                txtDni.Text = "";
                txtUsuario.Text = "";
                txtContrasena.Text = "";
                txtConfirmarContrasena.Text = "";
            }
        }

        private void btnListaCompleta_Click(object sender, EventArgs e)
        {
            cargarListaUsuario();
            cmbBuscarPorTipoUsuario.SelectedIndex = -1;
        }
    }
}
