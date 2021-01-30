using CDVU.Clases.Base_de_Datos;
using CDVU.Clases.Base_de_Datos.GestorClub;
using CDVU.Clases.Base_de_Datos.GestorPersonas;
using CDVU.Clases.Club;
using CDVU.Personas;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace CDVU
{
    public partial class frmInscripcion : Form
    {
        GestorInscripcion gi;
        GestorEntrenamiento ge;
        GestorSocio gs;
        GestorProfesor gp;
        ToolTip toolTip;
        Inscripcion inscripcion;

        public frmInscripcion()
        {
            InitializeComponent();
            gi = new GestorInscripcion();
            ge = new GestorEntrenamiento();
            gs = new GestorSocio();
            gp = new GestorProfesor();
            toolTip = new ToolTip();
            inscripcion = new Inscripcion();
        }

        enum Acciones { agregar, modificar, eliminar, buscar }
        Acciones miAccion = Acciones.agregar;


        // ************************ CARGA DE DATOS ************************

        private void frmInscripcion_Load(object sender, EventArgs e)
        {
            cargarDatos();
        }

        private void cargarDatos()
        {
            cmbEntrenamiento.Update();
            cmbEntrenamiento.DataSource = ge.listaEntrenamiento();
            cmbEntrenamiento.ValueMember = "id";
            cmbEntrenamiento.DisplayMember = "";
            cmbEntrenamiento.SelectedIndex = -1;
        }

        // ************************ VALIDACIONES ************************

        private void btnAceptar_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(btnAceptar, "Aceptar cambios");
        }

        private void btnCancelar_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(btnCancelar, "Cancelar cambios");
        }

        private void lstProfesores_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (lstProfesores.Enabled)
            {
                if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                {
                    e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(209, 129, 5)), new System.Drawing.Rectangle(e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height));
                    e.Graphics.DrawString(lstProfesores.Items[e.Index].ToString(), e.Font, Brushes.White, new System.Drawing.Rectangle(e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height));
                }
                else
                {
                    e.DrawBackground();
                    if (e.Index >= 0)
                    {
                        e.Graphics.DrawString(lstProfesores.Items[e.Index].ToString(), e.Font, Brushes.White, new System.Drawing.Rectangle(e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height));
                    }
                }
                e.DrawFocusRectangle();
            }
            else
            {
                if (lstProfesores.Enabled)
                {
                    if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                    {
                        e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(209, 129, 5)), new System.Drawing.Rectangle(e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height));
                        e.Graphics.DrawString(lstProfesores.Items[e.Index].ToString(), e.Font, Brushes.Black, new System.Drawing.Rectangle(e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height));
                    }
                    else
                    {
                        e.DrawBackground();
                        if (e.Index >= 0)
                        {
                            e.Graphics.DrawString(lstProfesores.Items[e.Index].ToString(), e.Font, Brushes.Black, new System.Drawing.Rectangle(e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height));
                        }
                    }
                    e.DrawFocusRectangle();
                }
            }
        }

        private void cmbEntrenamiento_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Entrenamiento entrenamiento = (Entrenamiento)cmbEntrenamiento.SelectedItem;
            lblDeporteSeleccionado.Text = entrenamiento.Deporte.ToString();
            lstProfesores.DataSource = gp.listaProfesorSegunIdDeporte(entrenamiento.Deporte.Id);
            txtPredio.Text = entrenamiento.Predio.ToString();

            foreach (Turno t in ge.listaTurnoSegunIdEntrenamiento(entrenamiento.Id))
            {
                if (t.IdDia == 1)
                    lblLunes.Text = " de " + t.HoraEntrada.TimeOfDay.ToString() + " hs. a " + t.HoraSalida.TimeOfDay.ToString() + " hs.";
                if (t.IdDia == 2)
                    lblMartes.Text = " de " + t.HoraEntrada.TimeOfDay.ToString() + " hs. a " + t.HoraSalida.TimeOfDay.ToString() + " hs.";
                if (t.IdDia == 3)
                    lblMiercoles.Text = " de " + t.HoraEntrada.TimeOfDay.ToString() + " hs. a " + t.HoraSalida.TimeOfDay.ToString() + " hs.";
                if (t.IdDia == 4)
                    lblJueves.Text = " de " + t.HoraEntrada.TimeOfDay.ToString() + " hs. a " + t.HoraSalida.TimeOfDay.ToString() + " hs.";
                if (t.IdDia == 5)
                    lblViernes.Text = " de " + t.HoraEntrada.TimeOfDay.ToString() + " hs. a " + t.HoraSalida.TimeOfDay.ToString() + " hs.";
                if (t.IdDia == 6)
                    lblSabado.Text = " de " + t.HoraEntrada.TimeOfDay.ToString() + " hs. a " + t.HoraSalida.TimeOfDay.ToString() + " hs.";
                if (t.IdDia == 7)
                    lblDomingo.Text = " de " + t.HoraEntrada.TimeOfDay.ToString() + " hs. a " + t.HoraSalida.TimeOfDay.ToString() + " hs.";
            }

            lblPrecioMensualSeleccionado.Text = entrenamiento.PrecioMensual.ToString();
            lblPrecioMatSeleccionado.Text = entrenamiento.PrecioMatricula.ToString();
            lblCantidadCuotas.Text = entrenamiento.CantidadCuotas.ToString();
        }

        private void limpiarCampos()
        {
            txtBuscarSocio.Text = "";
            lblIdSocioSeleccionado.Text = "";
            lblDniSocioSeleccionado.Text = "";
            lblNombreSocioSeleccionado.Text = "";
            lblDniTutorSeleccionado.Text = "";
            lblNombreTutorSeleccionado.Text = "";
            cmbEntrenamiento.SelectedIndex = -1;
            lblDeporteSeleccionado.Text = "";
            lstProfesores.DataSource = null;
            txtPredio.Text = "";
            lblLunes.Text = lblMartes.Text = lblMiercoles.Text = lblJueves.Text = lblViernes.Text = lblSabado.Text = lblDomingo.Text = "";
            lblPrecioMensualSeleccionado.Text = "";
            lblPrecioMatSeleccionado.Text = "";
            lblCantidadCuotas.Text = "";
        }

        private Inscripcion getInscripcionDelForm()
        {
            if (miAccion == Acciones.agregar)
            {
                inscripcion = new Inscripcion();
                inscripcion.Socio = gs.obtenerSocioPorId(Convert.ToInt32(lblIdSocioSeleccionado.Text));
                inscripcion.Entrenamiento = (Entrenamiento)cmbEntrenamiento.SelectedItem;
                inscripcion.Fecha = DateTime.Today;
            }
            return inscripcion;
        }

        private void abmInscripcion(Acciones accion)
        {
            if (accion == Acciones.agregar)
            {
                if (!gi.agregarInscripcion(getInscripcionDelForm()))
                    MessageBox.Show("Ocurrió un error al generar la inscripción");
                else
                    MessageBox.Show("Inscripción realizada correctamente");
            }
            else if (accion == Acciones.eliminar)
            {
                if (!gi.eliminarInscripcion(getInscripcionDelForm()))
                    MessageBox.Show("Ocurrió un error al eliminar la inscripción");
                else
                    MessageBox.Show("Inscripción eliminada correctamente");
            }
        }

        private bool validarVacios()
        {
            if (txtBuscarSocio.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese el dni o número del socio para buscar", "Socio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                return false;
            }
            else
            if (cmbEntrenamiento.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un entrenamiento para continuar", "Entrenamiento", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                return false;
            }
            else
                return true;
        }

        private void generarPDF(Inscripcion i)
        {
            try
            {
                // Cuadro de dialogo del sistema para guardar el PDF donde elija el usuario
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "Archivo PDF|*.pdf";
                save.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                save.FileName = "Inscripción N° " + i.Id;

                if (save.ShowDialog() == DialogResult.OK)
                {
                    Document doc = new Document(PageSize.A4);
                    FileStream fl = new FileStream(save.FileName, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
                    PdfWriter.GetInstance(doc, fl);

                    // Metadata (titulo y autor del archivo pdf)
                    doc.AddAuthor("Club Deportivo Vecinos Unidos");
                    doc.AddTitle("Inscripción");
                    doc.Open();

                    // Imagen logo
                    iTextSharp.text.Image imagen = iTextSharp.text.Image.GetInstance(@"C:\Users\pepa_\Documents\Visual Studio 2019\Projects\CDVU\CDVU\Resources\vecinos-unidos1.png");
                    imagen.BorderWidth = 0;
                    imagen.ScalePercent(20f);
                    imagen.Alignment = Element.ALIGN_RIGHT;

                    // Titulo
                    Paragraph titulo = new Paragraph("Inscripción", FontFactory.GetFont("Calibri", 30));
                    titulo.Alignment = Element.ALIGN_CENTER;

                    // Tabla cabecera
                    PdfPTable tablaCabecera = new PdfPTable(2);
                    tablaCabecera.WidthPercentage = 100;

                    PdfPCell celda1 = new PdfPCell(titulo);
                    celda1.Border = 0;
                    celda1.HorizontalAlignment = 0;
                    celda1.VerticalAlignment = 1;
                    tablaCabecera.AddCell(celda1);

                    PdfPCell celda2 = new PdfPCell(imagen);
                    celda2.Border = 0;
                    celda2.HorizontalAlignment = 2;
                    celda2.VerticalAlignment = 1;
                    tablaCabecera.AddCell(celda2);

                    tablaCabecera.SpacingAfter = 15;
                    doc.Add(tablaCabecera);

                    PdfPTable tablaRecibo = new PdfPTable(1);
                    tablaRecibo.WidthPercentage = 100;

                    Phrase datosRecibo = new Phrase("DATOS DE LA INSCRIPCIÓN");
                    datosRecibo.Font.Size = 12;
                    datosRecibo.Font.SetStyle("italic");
                    tablaRecibo.AddCell(datosRecibo);

                    // N° de inscripcion
                    Phrase frase1 = new Phrase("Inscripción N°: " + i.Id);
                    frase1.Font.Size = 10;
                    frase1.Font.SetStyle("bold");

                    PdfPCell renglon1 = new PdfPCell(frase1);
                    renglon1.Border = 0;
                    renglon1.HorizontalAlignment = 0;
                    renglon1.VerticalAlignment = 1;
                    renglon1.Padding = 5;
                    tablaRecibo.AddCell(renglon1);

                    // Fecha de la inscripción
                    Phrase frase2 = new Phrase("Fecha: " + i.Fecha.ToString("dd/MM/yyyy"));
                    frase2.Font.Size = 10;
                    frase2.Font.SetStyle("bold");

                    PdfPCell renglon2 = new PdfPCell(frase2);
                    renglon2.Border = 0;
                    renglon2.HorizontalAlignment = 0;
                    renglon2.VerticalAlignment = 1;
                    renglon2.Padding = 5;
                    tablaRecibo.AddCell(renglon2);

                    doc.Add(tablaRecibo);


                    // Datos del socio y recibo
                    PdfPTable tablaSocio = new PdfPTable(1);
                    tablaSocio.WidthPercentage = 100;

                    Phrase datosSocio = new Phrase("DATOS DEL SOCIO");
                    datosSocio.Font.Size = 12;
                    datosSocio.Font.SetStyle("italic");
                    tablaSocio.AddCell(datosSocio);

                    // Nombre del socio
                    Phrase frase3 = new Phrase("Nombre: " + i.Socio.Apellido + " " + i.Socio.Nombre);
                    frase3.Font.Size = 10;
                    frase3.Font.SetStyle("bold");

                    PdfPCell renglon3 = new PdfPCell(frase3);
                    renglon3.Border = 0;
                    renglon3.HorizontalAlignment = 0;
                    renglon3.VerticalAlignment = 1;
                    renglon3.Padding = 5;
                    tablaSocio.AddCell(renglon3);

                    // DNI del socio
                    Phrase frase4 = new Phrase("DNI: " + i.Socio.Dni);
                    frase4.Font.Size = 10;
                    frase4.Font.SetStyle("bold");

                    PdfPCell renglon4 = new PdfPCell(frase4);
                    renglon4.Border = 0;
                    renglon4.HorizontalAlignment = 0;
                    renglon4.VerticalAlignment = 1;
                    renglon4.Padding = 5;
                    tablaSocio.AddCell(renglon4);

                    // Teléfono del socio
                    Phrase frase5 = new Phrase("Teléfono: " + i.Socio.Telefono);
                    frase5.Font.Size = 10;
                    frase5.Font.SetStyle("bold");

                    PdfPCell renglon5 = new PdfPCell(frase5);
                    renglon5.Border = 0;
                    renglon5.HorizontalAlignment = 0;
                    renglon5.VerticalAlignment = 1;
                    renglon5.Padding = 5;
                    tablaSocio.AddCell(renglon5);

                    // Email del socio
                    Phrase frase6 = new Phrase("Email: " + i.Socio.Email);
                    frase6.Font.Size = 10;
                    frase6.Font.SetStyle("bold");

                    PdfPCell renglon6 = new PdfPCell(frase6);
                    renglon6.Border = 0;
                    renglon6.HorizontalAlignment = 0;
                    renglon6.VerticalAlignment = 1;
                    renglon6.Padding = 5;
                    tablaSocio.AddCell(renglon6);

                    // Tutor de este socio
                    if (i.Socio.Tutor == null)
                    {
                        Phrase frase7 = new Phrase("Tutor: No tiene");
                        frase7.Font.Size = 10;
                        frase7.Font.SetStyle("bold");

                        PdfPCell renglon7 = new PdfPCell(frase7);
                        renglon7.Border = 0;
                        renglon7.HorizontalAlignment = 0;
                        renglon7.VerticalAlignment = 1;
                        renglon7.Padding = 5;
                        tablaSocio.AddCell(renglon7);
                    }
                    else
                    {
                        Phrase frase7 = new Phrase("Tutor: " + i.Socio.Tutor.ToString());
                        frase7.Font.Size = 10;
                        frase7.Font.SetStyle("bold");

                        PdfPCell renglon7 = new PdfPCell(frase7);
                        renglon7.Border = 0;
                        renglon7.HorizontalAlignment = 0;
                        renglon7.Padding = 5;
                        tablaSocio.AddCell(renglon7);
                    }

                    tablaSocio.SpacingBefore = 5;
                    tablaSocio.SpacingAfter = 15;



                    // Datos del entrenamiento
                    PdfPTable tablaInscripcion = new PdfPTable(1);
                    tablaInscripcion.WidthPercentage = 100;

                    Phrase datosInscripcion = new Phrase("DATOS DEL ENTRENAMIENTO");
                    datosInscripcion.Font.Size = 12;
                    datosInscripcion.Font.SetStyle("italic");
                    tablaInscripcion.AddCell(datosInscripcion);

                    // Deporte
                    Phrase deporte = new Phrase("Deporte: " + i.Entrenamiento.Deporte.ToString());
                    deporte.Font.Size = 10;
                    deporte.Font.SetStyle("bold");

                    PdfPCell renglon9 = new PdfPCell(deporte);
                    renglon9.Border = 0;
                    renglon9.HorizontalAlignment = 0;
                    renglon9.VerticalAlignment = 1;
                    renglon9.Padding = 5;
                    tablaInscripcion.AddCell(renglon9);

                    // Predio
                    Phrase predio = new Phrase("Predio: " + i.Entrenamiento.Predio.ToString());
                    predio.Font.Size = 10;
                    predio.Font.SetStyle("bold");

                    PdfPCell renglon10 = new PdfPCell(predio);
                    renglon10.Border = 0;
                    renglon10.HorizontalAlignment = 0;
                    renglon10.VerticalAlignment = 1;
                    renglon10.Padding = 5;
                    tablaInscripcion.AddCell(renglon10);

                    // Precio matricula
                    Phrase matricula = new Phrase("Matrícula: $ " + i.Entrenamiento.PrecioMatricula);
                    matricula.Font.Size = 10;
                    matricula.Font.SetStyle("bold");

                    PdfPCell renglon11 = new PdfPCell(matricula);
                    renglon11.Border = 0;
                    renglon11.HorizontalAlignment = 0;
                    renglon11.VerticalAlignment = 1;
                    renglon11.Padding = 5;
                    tablaInscripcion.AddCell(renglon11);

                    // Precio cuota
                    Phrase cuota = new Phrase("Precio de la cuota: $ " + i.Entrenamiento.PrecioMensual);
                    cuota.Font.Size = 10;
                    cuota.Font.SetStyle("bold");

                    PdfPCell renglon12 = new PdfPCell(cuota);
                    renglon12.Border = 0;
                    renglon12.HorizontalAlignment = 0;
                    renglon12.VerticalAlignment = 1;
                    renglon12.Padding = 5;
                    tablaInscripcion.AddCell(renglon12);

                    // Cantidad de cuotas
                    Phrase cantCuota = new Phrase("Cantidad de cuotas: " + i.Entrenamiento.CantidadCuotas);
                    cantCuota.Font.Size = 10;
                    cantCuota.Font.SetStyle("bold");

                    PdfPCell renglon13 = new PdfPCell(cantCuota);
                    renglon13.Border = 0;
                    renglon13.HorizontalAlignment = 0;
                    renglon13.VerticalAlignment = 1;
                    renglon13.Padding = 5;
                    tablaInscripcion.AddCell(renglon13);

                    tablaInscripcion.SpacingBefore = 5;
                    tablaInscripcion.SpacingAfter = 15;

                    // Tabla contenido
                    PdfPTable tablaContenido = new PdfPTable(2);
                    tablaContenido.WidthPercentage = 100;

                    PdfPCell cell1 = new PdfPCell(tablaSocio);
                    cell1.Border = 0;
                    cell1.HorizontalAlignment = 0;
                    cell1.VerticalAlignment = 1;
                    tablaContenido.AddCell(cell1);

                    PdfPCell cell2 = new PdfPCell(tablaInscripcion);
                    cell2.Border = 0;
                    cell2.HorizontalAlignment = 2;
                    cell2.VerticalAlignment = 1;
                    tablaContenido.AddCell(cell2);

                    tablaContenido.SpacingAfter = 10;
                    doc.Add(tablaContenido);

                    // Tabla y cabecera que contendra el horario del entrenamiento
                    PdfPTable tablaHorario = new PdfPTable(3);
                    tablaHorario.WidthPercentage = 100;

                    Phrase fraseColumna1 = new Phrase("Día");
                    fraseColumna1.Font.Color = BaseColor.WHITE;
                    fraseColumna1.Font.Size = 11;
                    fraseColumna1.Font.SetStyle("bold");

                    Phrase fraseColumna2 = new Phrase("Hora de entrada");
                    fraseColumna2.Font.Color = BaseColor.WHITE;
                    fraseColumna2.Font.Size = 11;
                    fraseColumna2.Font.SetStyle("bold");

                    Phrase fraseColumna3 = new Phrase("Hora de salida");
                    fraseColumna3.Font.Color = BaseColor.WHITE;
                    fraseColumna3.Font.Size = 11;
                    fraseColumna3.Font.SetStyle("bold");

                    PdfPCell columnaCabecera1 = new PdfPCell(fraseColumna1);
                    PdfPCell columnaCabecera2 = new PdfPCell(fraseColumna2);
                    PdfPCell columnaCabecera3 = new PdfPCell(fraseColumna3);

                    columnaCabecera1.BackgroundColor = BaseColor.BLACK;
                    columnaCabecera1.Border = 0;
                    columnaCabecera1.HorizontalAlignment = 1;
                    columnaCabecera1.VerticalAlignment = 1;
                    columnaCabecera1.Padding = 4;

                    columnaCabecera2.BackgroundColor = BaseColor.BLACK;
                    columnaCabecera2.Border = 0;
                    columnaCabecera2.HorizontalAlignment = 1;
                    columnaCabecera2.VerticalAlignment = 1;
                    columnaCabecera2.Padding = 4;

                    columnaCabecera3.BackgroundColor = BaseColor.BLACK;
                    columnaCabecera3.Border = 0;
                    columnaCabecera3.HorizontalAlignment = 1;
                    columnaCabecera3.VerticalAlignment = 1;
                    columnaCabecera3.Padding = 4;

                    tablaHorario.AddCell(columnaCabecera1);
                    tablaHorario.AddCell(columnaCabecera2);
                    tablaHorario.AddCell(columnaCabecera3);

                    foreach (Turno turno in ge.listaTurnoSegunIdEntrenamiento(i.Entrenamiento.Id))
                    {
                        // Agrego los horarios a la tabla

                        Phrase dia = new Phrase(turno.Dia);
                        dia.Font.Color = BaseColor.BLACK;
                        dia.Font.Size = 10;
                        dia.Font.SetStyle("bold");

                        Phrase horaEntrada = new Phrase(turno.HoraEntrada.TimeOfDay.ToString() + " hs.");
                        horaEntrada.Font.Color = BaseColor.BLACK;
                        horaEntrada.Font.Size = 10;
                        horaEntrada.Font.SetStyle("bold");

                        Phrase horaSalida = new Phrase(turno.HoraSalida.TimeOfDay.ToString() + " hs.");
                        horaSalida.Font.Color = BaseColor.BLACK;
                        horaSalida.Font.Size = 10;
                        horaSalida.Font.SetStyle("bold");

                        PdfPCell filaDia = new PdfPCell(dia);
                        PdfPCell filaHoraEntrada = new PdfPCell(horaEntrada);
                        PdfPCell filaHoraSalida = new PdfPCell(horaSalida);

                        filaDia.BackgroundColor = BaseColor.LIGHT_GRAY;
                        filaDia.Border = 0;
                        filaDia.HorizontalAlignment = 1;
                        filaDia.Padding = 4;

                        filaHoraEntrada.BackgroundColor = BaseColor.LIGHT_GRAY;
                        filaHoraEntrada.Border = 0;
                        filaHoraEntrada.HorizontalAlignment = 1;
                        filaHoraEntrada.Padding = 4;

                        filaHoraSalida.BackgroundColor = BaseColor.LIGHT_GRAY;
                        filaHoraSalida.Border = 0;
                        filaHoraSalida.HorizontalAlignment = 1;
                        filaHoraSalida.Padding = 4;

                        tablaHorario.AddCell(filaDia);
                        tablaHorario.AddCell(filaHoraEntrada);
                        tablaHorario.AddCell(filaHoraSalida);
                    }
                    tablaHorario.SpacingAfter = 5;
                    doc.Add(tablaHorario);

                    // Tabla para el total
                    PdfPTable tablaTotal = new PdfPTable(1);
                    tablaTotal.WidthPercentage = 100;
                    tablaTotal.SpacingAfter = 15;

                    Phrase generado = new Phrase("Archivo generado el día " + DateTime.Today.ToString("dd/MM/yyyy"));
                    generado.Font.Color = BaseColor.BLACK;
                    generado.Font.Size = 7;
                    generado.Font.SetStyle("italic");
                    doc.Add(generado);

                    // Cierro el documento
                    doc.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("No se pudo generar el pdf. \n" + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        // ************************ BOTONES ************************
                
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (validarVacios() && MessageBox.Show("¿Guardar cambios?", "Guardando", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                abmInscripcion(miAccion);
                cargarDatos();
                limpiarCampos();
                generarPDF(gi.ultimaInscripcionGenerada());
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que quiere cancelar? \n No se guardarán los cambios", "Cancelando", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                limpiarCampos();
            }
        }

        private void btnBuscarSocio_Click(object sender, EventArgs e)
        {
            Socio s = gs.obtenerSocioPorId(Convert.ToInt32(txtBuscarSocio.Text));
            if (s == null)
            {
                s = gs.obtenerSocioPorDNI(txtBuscarSocio.Text);
                if (s == null)
                {
                    MessageBox.Show("No se encuentra el socio");
                    lblIdSocioSeleccionado.Text = "";
                    lblDniSocioSeleccionado.Text = "";
                    lblNombreSocioSeleccionado.Text = "";
                    lblDniTutorSeleccionado.Text = "";
                    lblNombreTutorSeleccionado.Text = "";
                }
                    
                else
                { 
                    lblIdSocioSeleccionado.Text = Convert.ToString(s.Id);
                    lblDniSocioSeleccionado.Text = s.Dni;
                    lblNombreSocioSeleccionado.Text = s.Apellido + " " + s.Nombre;
                    if (s.Tutor == null)
                    {
                        lblDniTutorSeleccionado.Text = "-";
                        lblNombreTutorSeleccionado.Text = "No tiene tutor";
                    }
                    else
                    {
                        lblDniTutorSeleccionado.Text = s.Tutor.Dni;
                        lblNombreTutorSeleccionado.Text = s.Tutor.Apellido + " " + s.Tutor.Nombre;
                    }
                }
            }
            else
            {
                lblIdSocioSeleccionado.Text = Convert.ToString(s.Id);
                lblDniSocioSeleccionado.Text = s.Dni;
                lblNombreSocioSeleccionado.Text = s.Apellido + " "+ s.Nombre;
                if (s.Tutor == null)
                {
                    lblDniTutorSeleccionado.Text = "-";
                    lblNombreTutorSeleccionado.Text = "No tiene tutor";
                }
                else
                {
                    lblDniTutorSeleccionado.Text = s.Tutor.Dni;
                    lblNombreTutorSeleccionado.Text = s.Tutor.Apellido + " " + s.Tutor.Nombre;
                }
            }
        }
    }
}
