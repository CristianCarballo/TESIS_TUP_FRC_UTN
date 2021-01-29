using CDVU.Clases.Base_de_Datos.GestorClub;
using CDVU.Clases.Base_de_Datos.GestorPersonas;
using CDVU.Clases.Club;
using CDVU.Personas;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CDVU
{
    public partial class frmEntrenamiento : Form
    {
        GestorEntrenamiento ge;
        GestorDeporte gd;
        GestorProfesor gp;
        ToolTip toolTip;
        TurnoEntrenamiento turnoEntrenamiento;

        public frmEntrenamiento()
        {
            InitializeComponent();
            ge = new GestorEntrenamiento();
            gd = new GestorDeporte();
            gp = new GestorProfesor();
            toolTip = new ToolTip();
            turnoEntrenamiento = new TurnoEntrenamiento();
        }

        enum Acciones { agregar, modificar, eliminar, buscar}
        Acciones miAccion = Acciones.agregar;


        // ************************ CARGA DE DATOS ************************

        private void frmEntrenamiento_Load(object sender, EventArgs e)
        {
            cargarTodosLosCombos();
            cargarListaEntrenamiento();
            habilitar(false);
        }

        private void cargarTodosLosCombos()
        {
            cmbDeporte.Update();
            cmbDeporte.DataSource = gd.listaDeporte();
            cmbDeporte.ValueMember = "id";
            cmbDeporte.DisplayMember = "";
            cmbDeporte.SelectedIndex = -1;

            cmbPredio.Update();
            cmbPredio.DataSource = ge.listaPredios();
            cmbPredio.ValueMember = "id";
            cmbPredio.DisplayMember = "";
            cmbPredio.SelectedIndex = -1;

            txtPrecioMatricula.Text = "0";
        }

        private void cargarListaProfesor(List<Profesor> listaProfesor)
        {
            lstProfesores.Update();
            lstProfesores.DataSource = listaProfesor;
            lstProfesores.ValueMember = "";
            lstProfesores.SelectedIndex = -1;
        }

        private void cargarListaEntrenamiento()
        {
            lstEntrenamiento.Update();
            lstEntrenamiento.DataSource = ge.listaEntrenamiento();
            lstEntrenamiento.ValueMember = "id";
            lstEntrenamiento.DisplayMember = "";
            lstEntrenamiento.SelectedIndex = -1;
        }

        // ************************ VALIDACIONES ************************

        private void btnAgregarEntrenamiento_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(btnAgregarEntrenamiento, "Agregar nuevo entrenamiento");
        }

        private void btnModificarEntrenamiento_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(btnModificarEntrenamiento, "Modificar entrenamiento seleccionado");
        }

        private void btnEliminarEntrenamiento_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(btnEliminarEntrenamiento, "Eliminar entrenamiento seleccionado");
        }

        private void btnAceptar_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(btnAceptar, "Aceptar cambios");
        }

        private void btnCancelar_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(btnCancelar, "Cancelar cambios");
        }

        private void lstEntrenamiento_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (lstEntrenamiento.Enabled)
            {
                if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                {
                    e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(209, 129, 5)), new Rectangle(e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height));
                    e.Graphics.DrawString(lstEntrenamiento.Items[e.Index].ToString(), e.Font, Brushes.White, new Rectangle(e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height));
                }
                else
                {
                    e.DrawBackground();
                    if (e.Index >= 0)
                    {
                        e.Graphics.DrawString(lstEntrenamiento.Items[e.Index].ToString(), e.Font, Brushes.White, new Rectangle(e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height));
                    }
                }
                e.DrawFocusRectangle();
            }
            else
            {
                if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                {
                    e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(209, 129, 5)), new Rectangle(e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height));
                    e.Graphics.DrawString(lstEntrenamiento.Items[e.Index].ToString(), e.Font, Brushes.Black, new Rectangle(e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height));
                }
                else
                {
                    e.DrawBackground();
                    if (e.Index >= 0)
                    {
                        e.Graphics.DrawString(lstEntrenamiento.Items[e.Index].ToString(), e.Font, Brushes.Black, new Rectangle(e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height));
                    }
                }
                e.DrawFocusRectangle();
            }
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

        private void limpiarCampos()
        {
            lstEntrenamiento.SelectedIndex = -1;
            cmbDeporte.SelectedIndex = -1;
            cmbPredio.SelectedIndex = -1;
            lblId.Text = "";
            lblDeporteSeleccionado.Text = "";
            txtPredio.Text = "";
            lstProfesores.DataSource = null;
            lblLunes.Text = lblMartes.Text = lblMiercoles.Text = lblJueves.Text = lblViernes.Text = lblSabado.Text = lblDomingo.Text = "";
            txtPrecioMensual.Text = "";
            chkPrecioMatricula.Checked = false;
            txtPrecioMatricula.Enabled = false;
            txtPrecioMatricula.Text = "0";
            spnCantidadCuotas.Value = 1;
            lblCantidadCuotas.Text = "1";
            chkLunes.Checked = false;
            dtpHoraEntradaLunes.Enabled = dtpHoraSalidaLunes.Enabled = false;
            chkMartes.Checked = false;
            dtpHoraEntradaMartes.Enabled = dtpHoraSalidaMartes.Enabled = false;
            chkMiercoles.Checked = false;
            dtpHoraEntradaMiercoles.Enabled = dtpHoraSalidaMiercoles.Enabled = false;
            chkJueves.Checked = false;
            dtpHoraEntradaJueves.Enabled = dtpHoraSalidaJueves.Enabled = false;
            chkViernes.Checked = false;
            dtpHoraEntradaViernes.Enabled = dtpHoraSalidaViernes.Enabled = false;
            chkSabado.Checked = false;
            dtpHoraEntradaSabado.Enabled = dtpHoraSalidaSabado.Enabled = false;
            chkDomingo.Checked = false;
            dtpHoraEntradaDomingo.Enabled = dtpHoraSalidaDomingo.Enabled = false;
            dtpHoraEntradaLunes.Text = dtpHoraSalidaLunes.Text = "00:00";
            dtpHoraEntradaMartes.Text = dtpHoraSalidaMartes.Text = "00:00";
            dtpHoraEntradaMiercoles.Text = dtpHoraSalidaMiercoles.Text = "00:00";
            dtpHoraEntradaJueves.Text = dtpHoraSalidaJueves.Text = "00:00";
            dtpHoraEntradaViernes.Text = dtpHoraSalidaViernes.Text = "00:00";
            dtpHoraEntradaSabado.Text = dtpHoraSalidaSabado.Text = "00:00";
            dtpHoraEntradaDomingo.Text = dtpHoraSalidaDomingo.Text = "00:00";
        }

        private List<Turno> getListaTurnoDelForm()
        {
            List<Turno> lista = new List<Turno>();
            Turno turno;
            if (chkLunes.Checked)
            {
                turno = new Turno();
                turno.IdDia = 1;
                turno.HoraEntrada = dtpHoraEntradaLunes.Value;
                turno.HoraSalida = dtpHoraSalidaLunes.Value;
                lista.Add(turno);
            }
            if (chkMartes.Checked)
            {
                turno = new Turno();
                turno.IdDia = 2;
                turno.HoraEntrada = dtpHoraEntradaMartes.Value;
                turno.HoraSalida = dtpHoraSalidaMartes.Value;
                lista.Add(turno);
            }
            if (chkMiercoles.Checked)
            {
                turno = new Turno();
                turno.IdDia = 3;
                turno.HoraEntrada = dtpHoraEntradaMiercoles.Value;
                turno.HoraSalida = dtpHoraSalidaMiercoles.Value;
                lista.Add(turno);
            }
            if (chkJueves.Checked)
            {
                turno = new Turno();
                turno.IdDia = 4;
                turno.HoraEntrada = dtpHoraEntradaJueves.Value;
                turno.HoraSalida = dtpHoraSalidaJueves.Value;
                lista.Add(turno);
            }
            if (chkViernes.Checked)
            {
                turno = new Turno();
                turno.IdDia = 5;
                turno.HoraEntrada = dtpHoraEntradaViernes.Value;
                turno.HoraSalida = dtpHoraSalidaViernes.Value;
                lista.Add(turno);
            }
            if (chkSabado.Checked)
            {
                turno = new Turno();
                turno.IdDia = 6;
                turno.HoraEntrada = dtpHoraEntradaSabado.Value;
                turno.HoraSalida = dtpHoraSalidaSabado.Value;
                lista.Add(turno);
            }
            if (chkDomingo.Checked)
            {
                turno = new Turno();
                turno.IdDia = 7;
                turno.HoraEntrada = dtpHoraEntradaDomingo.Value;
                turno.HoraSalida = dtpHoraSalidaDomingo.Value;
                lista.Add(turno);
            }
            return lista;
        }

        private void chkPrecioMatricula_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPrecioMatricula.Checked == true)
                txtPrecioMatricula.Enabled = true;
            if (chkPrecioMatricula.Checked == false && (txtPrecioMatricula.Text == "" || txtPrecioMatricula.Text != ""))
            {
                txtPrecioMatricula.Enabled = false;
                txtPrecioMatricula.Text = "0";
            }
            if(chkPrecioMatricula.Checked == false)
                txtPrecioMatricula.Enabled = false;
        }

        private void dtpHoraEntradaLunes_ValueChanged(object sender, EventArgs e)
        {
            if (chkLunes.Checked)
                lblLunes.Text = " de " + dtpHoraEntradaLunes.Value.TimeOfDay.ToString() + " hs. a " + dtpHoraSalidaLunes.Value.TimeOfDay.ToString() + " hs.";
        }

        private void dtpHoraSalidaLunes_ValueChanged(object sender, EventArgs e)
        {
            if (chkLunes.Checked)
                lblLunes.Text = " de " + dtpHoraEntradaLunes.Value.TimeOfDay.ToString() + " hs. a " + dtpHoraSalidaLunes.Value.TimeOfDay.ToString() + " hs.";
        }

        private void dtpHoraEntradaMartes_ValueChanged(object sender, EventArgs e)
        {
            if (chkMartes.Checked)
                lblMartes.Text = " de " + dtpHoraEntradaMartes.Value.TimeOfDay.ToString() + " hs.a " + dtpHoraSalidaMartes.Value.TimeOfDay.ToString() + " hs.";
        }

        private void dtpHoraSalidaMartes_ValueChanged(object sender, EventArgs e)
        {
            if (chkMartes.Checked)
                lblMartes.Text = " de " + dtpHoraEntradaMartes.Value.TimeOfDay.ToString() + " hs.a " + dtpHoraSalidaMartes.Value.TimeOfDay.ToString() + " hs.";
        }

        private void dtpHoraEntradaMiercoles_ValueChanged(object sender, EventArgs e)
        {
            if (chkMiercoles.Checked)
                lblMiercoles.Text = " de " + dtpHoraEntradaMiercoles.Value.TimeOfDay.ToString() + " hs. a " + dtpHoraSalidaMiercoles.Value.TimeOfDay.ToString() + " hs.";
        }

        private void dtpHoraSalidaMiercoles_ValueChanged(object sender, EventArgs e)
        {
            if (chkMiercoles.Checked)
                lblMiercoles.Text = " de " + dtpHoraEntradaMiercoles.Value.TimeOfDay.ToString() + " hs. a " + dtpHoraSalidaMiercoles.Value.TimeOfDay.ToString() + " hs.";
        }

        private void dtpHoraEntradaJueves_ValueChanged(object sender, EventArgs e)
        {
            if (chkJueves.Checked)
                lblJueves.Text = " de " + dtpHoraEntradaJueves.Value.TimeOfDay.ToString() + " hs. a " + dtpHoraSalidaJueves.Value.TimeOfDay.ToString() + " hs.";
        }

        private void dtpHoraSalidaJueves_ValueChanged(object sender, EventArgs e)
        {
            if (chkJueves.Checked)
                lblJueves.Text = " de " + dtpHoraEntradaJueves.Value.TimeOfDay.ToString() + " hs. a " + dtpHoraSalidaJueves.Value.TimeOfDay.ToString() + " hs.";
        }

        private void dtpHoraEntradaViernes_ValueChanged(object sender, EventArgs e)
        {
            if (chkViernes.Checked)
                lblViernes.Text = " de " + dtpHoraEntradaViernes.Value.TimeOfDay.ToString() + " hs. a " + dtpHoraSalidaViernes.Value.TimeOfDay.ToString() + " hs.";
        }

        private void dtpHoraSalidaViernes_ValueChanged(object sender, EventArgs e)
        {
            if (chkViernes.Checked)
                lblViernes.Text = " de " + dtpHoraEntradaViernes.Value.TimeOfDay.ToString() + " hs. a " + dtpHoraSalidaViernes.Value.TimeOfDay.ToString() + " hs.";
        }

        private void dtpHoraEntradaSabado_ValueChanged(object sender, EventArgs e)
        {
            if (chkSabado.Checked)
                lblSabado.Text = " de " + dtpHoraEntradaSabado.Value.TimeOfDay.ToString() + " hs. a " + dtpHoraSalidaSabado.Value.TimeOfDay.ToString() + " hs.";
        }

        private void dtpHoraSalidaSabado_ValueChanged(object sender, EventArgs e)
        {
            if (chkSabado.Checked)
                lblSabado.Text = " de " + dtpHoraEntradaSabado.Value.TimeOfDay.ToString() + " hs. a " + dtpHoraSalidaSabado.Value.TimeOfDay.ToString() + " hs.";
        }

        private void dtpHoraEntradaDomingo_ValueChanged(object sender, EventArgs e)
        {
            if (chkDomingo.Checked)
                lblDomingo.Text = " de " + dtpHoraEntradaDomingo.Value.TimeOfDay.ToString() + " hs. a " + dtpHoraSalidaDomingo.Value.TimeOfDay.ToString() + " hs.";
        }

        private void dtpHoraSalidaDomingo_ValueChanged(object sender, EventArgs e)
        {
            if (chkDomingo.Checked)
                lblDomingo.Text = " de " + dtpHoraEntradaDomingo.Value.TimeOfDay.ToString() + " hs. a " + dtpHoraSalidaDomingo.Value.TimeOfDay.ToString() + " hs.";
        }

        private void chkLunes_CheckedChanged(object sender, EventArgs e)
        {
            if (chkLunes.Checked == true)
            {
                dtpHoraEntradaLunes.Enabled = dtpHoraSalidaLunes.Enabled = true;
                lblLunes.Text = " de " + dtpHoraEntradaLunes.Value.TimeOfDay.ToString() + " hs. a " + dtpHoraSalidaLunes.Value.TimeOfDay.ToString() + " hs.";
            }
            if (chkLunes.Checked == false)
            {
                dtpHoraEntradaLunes.Enabled = dtpHoraSalidaLunes.Enabled = false;
                lblLunes.Text = "";
            }
        }

        private void chkMartes_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMartes.Checked == true)
            {
                dtpHoraEntradaMartes.Enabled = dtpHoraSalidaMartes.Enabled = true;
                lblMartes.Text = " de " + dtpHoraEntradaMartes.Value.TimeOfDay.ToString() + " hs. a " + dtpHoraSalidaMartes.Value.TimeOfDay.ToString() + " hs.";
            }
            if (chkMartes.Checked == false)
            {
                dtpHoraEntradaMartes.Enabled = dtpHoraSalidaMartes.Enabled = false;
                lblMartes.Text = "";
            }
        }

        private void chkMiercoles_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMiercoles.Checked == true)
            {
                dtpHoraEntradaMiercoles.Enabled = dtpHoraSalidaMiercoles.Enabled = true;
                lblMiercoles.Text = " de " + dtpHoraEntradaMiercoles.Value.TimeOfDay.ToString() + " hs. a " + dtpHoraSalidaMiercoles.Value.TimeOfDay.ToString() + " hs.";
            }
            if (chkMiercoles.Checked == false)
            {
                dtpHoraEntradaMiercoles.Enabled = dtpHoraSalidaMiercoles.Enabled = false;
                lblMiercoles.Text = "";
            }
        }

        private void chkJueves_CheckedChanged(object sender, EventArgs e)
        {
            if (chkJueves.Checked == true)
            {
                dtpHoraEntradaJueves.Enabled = dtpHoraSalidaJueves.Enabled = true;
                lblJueves.Text = " de " + dtpHoraEntradaJueves.Value.TimeOfDay.ToString() + " hs. a " + dtpHoraSalidaJueves.Value.TimeOfDay.ToString() + " hs.";
            }
            if (chkJueves.Checked == false)
            {
                dtpHoraEntradaJueves.Enabled = dtpHoraSalidaJueves.Enabled = false;
                lblJueves.Text = "";
            }
        }

        private void chkViernes_CheckedChanged(object sender, EventArgs e)
        {
            if (chkViernes.Checked == true)
            {
                dtpHoraEntradaViernes.Enabled = dtpHoraSalidaViernes.Enabled = true;
                lblViernes.Text = " de " + dtpHoraEntradaViernes.Value.TimeOfDay.ToString() + " hs. a " + dtpHoraSalidaViernes.Value.TimeOfDay.ToString() + " hs.";
            }
            if (chkViernes.Checked == false)
            {
                dtpHoraEntradaViernes.Enabled = dtpHoraSalidaViernes.Enabled = false;
                lblViernes.Text = "";
            }
        }

        private void chkSabado_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSabado.Checked == true)
            {
                dtpHoraEntradaSabado.Enabled = dtpHoraSalidaSabado.Enabled = true;
                lblSabado.Text = " de " + dtpHoraEntradaSabado.Value.TimeOfDay.ToString() + " hs. a " + dtpHoraSalidaSabado.Value.TimeOfDay.ToString() + " hs.";
            }
            if (chkSabado.Checked == false)
            {
                dtpHoraEntradaSabado.Enabled = dtpHoraSalidaSabado.Enabled = false;
                lblSabado.Text = "";
            }
        }

        private void chkDomingo_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDomingo.Checked == true)
            {
                dtpHoraEntradaDomingo.Enabled = dtpHoraSalidaDomingo.Enabled = true;
                lblDomingo.Text = " de " + dtpHoraEntradaDomingo.Value.TimeOfDay.ToString() + " hs. a " + dtpHoraSalidaDomingo.Value.TimeOfDay.ToString() + " hs.";
            }
            if (chkDomingo.Checked == false)
            {
                dtpHoraEntradaDomingo.Enabled = dtpHoraSalidaDomingo.Enabled = false;
                lblDomingo.Text = "";
            }
        }

        private void cmbDeporte_SelectionChangeCommitted(object sender, EventArgs e)
        {
            lblDeporteSeleccionado.Text = cmbDeporte.SelectedItem.ToString();
            cargarListaProfesor(gp.listaProfesorSegunIdDeporte(Convert.ToInt32(cmbDeporte.SelectedValue)));
        }

        private void cmbPredio_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txtPredio.Text = cmbPredio.SelectedItem.ToString();
        }

        private void txtPrecioMensual_TextChanged(object sender, EventArgs e)
        {
            lblPrecioMensualSeleccionado.Text = txtPrecioMensual.Text.Trim().ToString();
        }

        private void txtPrecioMatricula_TextChanged(object sender, EventArgs e)
        {
            lblPrecioMatSeleccionado.Text = txtPrecioMatricula.Text.Trim().ToString();
        }

        private void spnCantidadCuotas_ValueChanged(object sender, EventArgs e)
        {
            lblCantidadCuotas.Text = spnCantidadCuotas.Value.ToString();
        }

        private TurnoEntrenamiento getTurnoEntrenamientoDelForm()
        {
            if (miAccion == Acciones.agregar)
            {
                turnoEntrenamiento = new TurnoEntrenamiento();
                turnoEntrenamiento.Entrenamiento.Deporte = (Deporte)cmbDeporte.SelectedItem;
                turnoEntrenamiento.Entrenamiento.Predio = (Predio)cmbPredio.SelectedItem;
                turnoEntrenamiento.Entrenamiento.PrecioMensual = Convert.ToDouble(txtPrecioMensual.Text);
                turnoEntrenamiento.Entrenamiento.PrecioMatricula = Convert.ToDouble(txtPrecioMatricula.Text);
                turnoEntrenamiento.Entrenamiento.CantidadCuotas = Convert.ToInt32(spnCantidadCuotas.Value);
                turnoEntrenamiento.ListaTurno = getListaTurnoDelForm();
            }
            else if (miAccion == Acciones.modificar)
            {
                turnoEntrenamiento.Entrenamiento.Id = Convert.ToInt32(lblId.Text);
                turnoEntrenamiento.Entrenamiento.Deporte = (Deporte)cmbDeporte.SelectedItem;
                turnoEntrenamiento.Entrenamiento.Predio = (Predio)cmbPredio.SelectedItem;
                turnoEntrenamiento.Entrenamiento.PrecioMensual = Convert.ToDouble(txtPrecioMensual.Text);
                turnoEntrenamiento.Entrenamiento.PrecioMatricula = Convert.ToDouble(txtPrecioMatricula.Text);
                turnoEntrenamiento.Entrenamiento.CantidadCuotas = Convert.ToInt32(spnCantidadCuotas.Value);
                turnoEntrenamiento.ListaTurno = getListaTurnoDelForm();
            }
            else
                turnoEntrenamiento.Entrenamiento = (Entrenamiento)lstEntrenamiento.SelectedItem;
            return turnoEntrenamiento;
        }
        
        private void setTurnoEntrenamientoAlForm(Entrenamiento e)
        {
            cmbDeporte.SelectedValue = e.Deporte.Id;
            cmbPredio.SelectedValue = e.Predio.Id;
            setHorarioAlForm((Entrenamiento)lstEntrenamiento.SelectedItem);
            txtPrecioMensual.Text = e.PrecioMensual.ToString();
            txtPrecioMatricula.Text = e.PrecioMatricula.ToString();
            if (e.PrecioMatricula.ToString() != "")
                chkPrecioMatricula.Checked = true;
            spnCantidadCuotas.Value = e.CantidadCuotas;
            setInformacion(e);
        }

        private void setInformacion(Entrenamiento e)
        {
            lblId.Text = Convert.ToString(e.Id);
            lblDeporteSeleccionado.Text = e.Deporte.ToString();
            cargarListaProfesor(gp.listaProfesorSegunIdDeporte(e.Deporte.Id));
            txtPredio.Text = e.Predio.ToString();
            lblPrecioMensualSeleccionado.Text = e.PrecioMensual.ToString();
            lblPrecioMatSeleccionado.Text = e.PrecioMatricula.ToString();
            lblCantidadCuotas.Text = e.CantidadCuotas.ToString();
        }

        private void setHorarioAlForm(Entrenamiento entrenamiento)
        {
            foreach (Turno x in ge.listaTurnoSegunIdEntrenamiento(entrenamiento.Id))
            {
                if (x.IdDia == 1)
                {
                    chkLunes.Checked = true;
                    dtpHoraEntradaLunes.Value = x.HoraEntrada;
                    dtpHoraSalidaLunes.Value = x.HoraSalida;
                }
                if (x.IdDia == 2)
                {
                    chkMartes.Checked = true;
                    dtpHoraEntradaMartes.Value = x.HoraEntrada;
                    dtpHoraSalidaMartes.Value = x.HoraSalida;
                }
                if (x.IdDia == 3)
                {
                    chkMiercoles.Checked = true;
                    dtpHoraEntradaMiercoles.Value = x.HoraEntrada;
                    dtpHoraSalidaMiercoles.Value = x.HoraSalida;
                }
                if (x.IdDia == 4)
                {
                    chkJueves.Checked = true;
                    dtpHoraEntradaJueves.Value = x.HoraEntrada;
                    dtpHoraSalidaJueves.Value = x.HoraSalida;
                }
                if (x.IdDia == 5)
                {
                    chkViernes.Checked = true;
                    dtpHoraEntradaViernes.Value = x.HoraEntrada;
                    dtpHoraSalidaViernes.Value = x.HoraSalida;
                }
                if (x.IdDia == 6)
                {
                    chkSabado.Checked = true;
                    dtpHoraEntradaSabado.Value = x.HoraEntrada;
                    dtpHoraSalidaSabado.Value = x.HoraSalida;
                }
                if (x.IdDia == 7)
                {
                    chkDomingo.Checked = true;
                    dtpHoraEntradaDomingo.Value = x.HoraEntrada;
                    dtpHoraSalidaDomingo.Value = x.HoraSalida;
                }

                if (chkLunes.Checked)
                    lblLunes.Text = " de " + dtpHoraEntradaLunes.Value.TimeOfDay.ToString() + " hs. a " + dtpHoraSalidaLunes.Value.TimeOfDay.ToString() + " hs.";
                if(chkMartes.Checked)
                    lblMartes.Text = " de " + dtpHoraEntradaMartes.Value.TimeOfDay.ToString() + " hs. a " + dtpHoraSalidaMartes.Value.TimeOfDay.ToString() + " hs.";
                if(chkMiercoles.Checked)
                    lblMiercoles.Text = " de " + dtpHoraEntradaMiercoles.Value.TimeOfDay.ToString() + " hs. a " + dtpHoraSalidaMiercoles.Value.TimeOfDay.ToString() + " hs.";
                if (chkJueves.Checked)
                    lblJueves.Text = " de " + dtpHoraEntradaJueves.Value.TimeOfDay.ToString() + " hs. a " + dtpHoraSalidaJueves.Value.TimeOfDay.ToString() + " hs.";
                if (chkViernes.Checked)
                    lblViernes.Text = " de " + dtpHoraEntradaViernes.Value.TimeOfDay.ToString() + " hs. a " + dtpHoraSalidaViernes.Value.TimeOfDay.ToString() + " hs.";
                if (chkSabado.Checked)
                    lblSabado.Text = " de " + dtpHoraEntradaSabado.Value.TimeOfDay.ToString() + " hs. a " + dtpHoraSalidaSabado.Value.TimeOfDay.ToString() + " hs.";
                if (chkDomingo.Checked)
                    lblDomingo.Text = " de " + dtpHoraEntradaDomingo.Value.TimeOfDay.ToString() + " hs. a " + dtpHoraSalidaDomingo.Value.TimeOfDay.ToString() + " hs.";
            }
        }

        private void abmTurnoEntrenamiento(Acciones accion)
        {
            if (accion == Acciones.agregar)
            {
                if (!ge.agregarTurnoEntrenamiento(getTurnoEntrenamientoDelForm()))
                    MessageBox.Show("Ocurrió un error al guardar el entrenamiento");
                else
                    MessageBox.Show("Entrenamiento agregado correctamente");
            }
            else if (accion == Acciones.modificar)
            {
                if (!ge.modificarTurnoEntrenamiento(getTurnoEntrenamientoDelForm()))
                    MessageBox.Show("Ocurrió un error al modificar el entrenamiento");
                else
                    MessageBox.Show("Datos modificados correctamente");
            }
            else if (accion == Acciones.eliminar)
            {
                if (!ge.eliminarEntrenamiento(getTurnoEntrenamientoDelForm()))
                    MessageBox.Show("Ocurrió un error al eliminar el entrenamiento");
                else
                    MessageBox.Show("Entrenamiento eliminado correctamente");
            }
        }

        private void habilitar(bool x)
        {
            btnAgregarEntrenamiento.Enabled = !x;
            btnModificarEntrenamiento.Enabled = !x;
            btnEliminarEntrenamiento.Enabled = !x;
            lstEntrenamiento.Enabled = !x;
            grpCombos.Enabled = x;
            txtPredio.Enabled = x;
            grpHorario.Enabled = x;
            grpPrecio.Enabled = x;
            lstProfesores.Enabled = x;
            btnAceptar.Enabled = x;
            btnCancelar.Enabled = x;

            if (btnAceptar.Enabled)
                btnAceptar.BackgroundImage = CDVU.Properties.Resources.icons8_aprobación_64;
            else
                btnAceptar.BackgroundImage = CDVU.Properties.Resources.icons8_aprobación_64__osc;

            if (btnCancelar.Enabled)
                btnCancelar.BackgroundImage = CDVU.Properties.Resources.icons8_no_molestar_64;
            else
                btnCancelar.BackgroundImage = CDVU.Properties.Resources.icons8_no_molestar_64__osc;

            if (btnAgregarEntrenamiento.Enabled)
                btnAgregarEntrenamiento.BackgroundImage = CDVU.Properties.Resources.icons8_añadir_64;
            else
                btnAgregarEntrenamiento.BackgroundImage = CDVU.Properties.Resources.icons8_añadir_64__osc1;

            if (btnModificarEntrenamiento.Enabled)
                btnModificarEntrenamiento.BackgroundImage = CDVU.Properties.Resources.icons8_reemplazar_64;
            else
                btnModificarEntrenamiento.BackgroundImage = CDVU.Properties.Resources.icons8_reemplazar_64_osc;

            if (btnEliminarEntrenamiento.Enabled)
                btnEliminarEntrenamiento.BackgroundImage = CDVU.Properties.Resources.icons8_eliminar_64;
            else
                btnEliminarEntrenamiento.BackgroundImage = CDVU.Properties.Resources.icons8_eliminar_64_;
        }

        private bool validarVacios()
        {
            if (cmbDeporte.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un deporte para continuar", "Deporte", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                return false;
            }
            else
                if (cmbPredio.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un predio para continuar", "Predio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                return false;
            }
            if (chkLunes.Checked == false && chkMartes.Checked == false && chkMiercoles.Checked == false && chkJueves.Checked == false && chkViernes.Checked == false && chkSabado.Checked == false && chkDomingo.Checked == false)
            {
                MessageBox.Show("Seleccione el horario para continuar", "Horario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                return false;
            }
            else
                if (txtPrecioMensual.Text.Trim() == "")
            {
                MessageBox.Show("Debe ponerle un precio a la cuota del entrenamiento", "Precio mensual", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                return false;
            }
            else
                return true;
        }

        private bool validarFechas()
        {
            if (dtpHoraEntradaLunes.Value > dtpHoraSalidaLunes.Value)
            {
                MessageBox.Show("El horario de entrada del día Lunes no puede ser mayor al de salida", "Lunes", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return false;
            }
            if (dtpHoraEntradaMartes.Value > dtpHoraSalidaMartes.Value)
            {
                MessageBox.Show("El horario de entrada del día Martes no puede ser mayor al de salida", "Martes", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return false;
            }
            if (dtpHoraEntradaMiercoles.Value > dtpHoraSalidaMiercoles.Value)
            {
                MessageBox.Show("El horario de entrada del día Miércoles no puede ser mayor al de salida", "Miércoles", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return false;
            }
            if (dtpHoraEntradaJueves.Value > dtpHoraSalidaJueves.Value)
            {
                MessageBox.Show("El horario de entrada del día Jueves no puede ser mayor al de salida", "Jueves", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return false;
            }
            if (dtpHoraEntradaViernes.Value > dtpHoraSalidaViernes.Value)
            {
                MessageBox.Show("El horario de entrada del día Viernes no puede ser mayor al de salida", "Viernes", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return false;
            }
            if (dtpHoraEntradaSabado.Value > dtpHoraSalidaSabado.Value)
            {
                MessageBox.Show("El horario de entrada del día Sábado no puede ser mayor al de salida", "Sábado", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return false;
            }
            if (dtpHoraEntradaDomingo.Value > dtpHoraSalidaDomingo.Value)
            {
                MessageBox.Show("El horario de entrada del día Domingo no puede ser mayor al de salida", "Domingo", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return false;
            }
            else
                return true;
        }

        private bool validarSeleccionLista()
        {
            if (lstEntrenamiento.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un entrenamiento de la lista para continuar", "Seleccione una entrenamiento", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                return false;
            }
            else
                return true;
        }

        // ************************ BOTONES ************************

        private void btnAgregarEntrenamiento_Click_1(object sender, EventArgs e)
        {
            miAccion = Acciones.agregar;
            limpiarCampos();
            habilitar(true);
        }

        private void btnModificarEntrenamiento_Click_1(object sender, EventArgs e)
        {
            if (validarSeleccionLista())
            {
                miAccion = Acciones.modificar;
                habilitar(true);
                setTurnoEntrenamientoAlForm((Entrenamiento)lstEntrenamiento.SelectedItem);
            }
        }

        private void btnEliminarEntrenamiento_Click_1(object sender, EventArgs e)
        {
            if (validarSeleccionLista() && MessageBox.Show("¿Seguro que quiere eliminar?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                miAccion = Acciones.eliminar;
                abmTurnoEntrenamiento(miAccion);
                limpiarCampos();
                cargarListaEntrenamiento();
                habilitar(false);
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (validarFechas() && validarVacios() && MessageBox.Show("¿Guardar cambios?", "Guardando", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                abmTurnoEntrenamiento(miAccion);
                limpiarCampos();
                cargarListaEntrenamiento();
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
    }
}
