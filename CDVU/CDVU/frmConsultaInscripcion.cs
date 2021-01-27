using CDVU.Clases.Base_de_Datos;
using CDVU.Clases.Base_de_Datos.GestorClub;
using CDVU.Clases.Club;
using CDVU.Personas;
using System;
using System.Drawing;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using Rectangle = System.Drawing.Rectangle;
using CDVU.Clases.Base_de_Datos.GestorPersonas;
using System.Collections.Generic;

namespace CDVU
{
    public partial class frmConsultaInscripcion : Form
    {
        AccesoBD bd;
        GestorSocio gs;
        GestorInscripcion gi;
        GestorEntrenamiento ge;
        Socio socio;

        public frmConsultaInscripcion()
        {
            InitializeComponent();
            bd = new AccesoBD();
            gs = new GestorSocio();
            gi = new GestorInscripcion();
            ge = new GestorEntrenamiento();
            socio = new Socio();
        }

        // ************************ CARGA DE DATOS ************************

        private void frmConsultaInscripcion_Load(object sender, EventArgs e)
        {
            cargarListaEntrenamiento();
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

        private void limpiarInformacion()
        {
            lblId.Text = "";
            lblDeporteSeleccionado.Text = "";
            lblLunes.Text = "";
            lblMartes.Text = "";
            lblMiercoles.Text = "";
            lblJueves.Text = "";
            lblViernes.Text = "";
            lblSabado.Text = "";
            lblDomingo.Text = "";
        }

        private void setInformacion(Entrenamiento e)
        {
            lblId.Text = Convert.ToString(e.Id);
            lblDeporteSeleccionado.Text = e.Deporte.ToString();
        }

        private void setHorarioAlForm(Entrenamiento entrenamiento)
        {
            foreach (Turno x in ge.listaTurnoSegunIdEntrenamiento(entrenamiento.Id))
            {
                if (x.IdDia == 1)
                    lblLunes.Text = " de " + x.HoraEntrada.TimeOfDay.ToString() + " hs. a " + x.HoraSalida.TimeOfDay.ToString() + " hs.";
                if (x.IdDia == 2)
                    lblMartes.Text = " de " + x.HoraEntrada.TimeOfDay.ToString() + " hs. a " + x.HoraSalida.TimeOfDay.ToString() + " hs.";
                if (x.IdDia == 3)
                    lblMiercoles.Text = " de " + x.HoraEntrada.TimeOfDay.ToString() + " hs. a " + x.HoraSalida.TimeOfDay.ToString() + " hs.";
                if (x.IdDia == 4)
                    lblJueves.Text = " de " + x.HoraEntrada.TimeOfDay.ToString() + " hs. a " + x.HoraSalida.TimeOfDay.ToString() + " hs.";
                if (x.IdDia == 5)
                    lblViernes.Text = " de " + x.HoraEntrada.TimeOfDay.ToString() + " hs. a " + x.HoraSalida.TimeOfDay.ToString() + " hs.";
                if (x.IdDia == 6)
                    lblSabado.Text = " de " + x.HoraEntrada.TimeOfDay.ToString() + " hs. a " + x.HoraSalida.TimeOfDay.ToString() + " hs.";
                if (x.IdDia == 7)
                    lblDomingo.Text = " de " + x.HoraEntrada.TimeOfDay.ToString() + " hs. a " + x.HoraSalida.TimeOfDay.ToString() + " hs.";
            }
        }

        private void generarPDF(Entrenamiento e)
        {
            try
            {
                // Cuadro de dialogo del sistema para guardar el PDF donde elija el usuario
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "Archivo PDF|*.pdf";
                save.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                save.FileName = "Lista de inscriptos del entrenamiento N° " + e.Id;

                if (save.ShowDialog() == DialogResult.OK)
                {
                    Document doc = new Document(PageSize.A4);
                    FileStream fl = new FileStream(save.FileName, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
                    PdfWriter.GetInstance(doc, fl);

                    // Metadata (titulo y autor del archivo pdf)
                    doc.AddAuthor("Club Deportivo Vecinos Unidos");
                    doc.AddTitle("Lista de inscriptos");
                    doc.Open();

                    // Imagen logo
                    iTextSharp.text.Image imagen = iTextSharp.text.Image.GetInstance(@"C:\Users\pepa_\Documents\Visual Studio 2019\Projects\CDVU\CDVU\Resources\vecinos-unidos1.png");
                    imagen.BorderWidth = 0;
                    imagen.ScalePercent(20f);
                    imagen.Alignment = Element.ALIGN_RIGHT;

                    // Titulo
                    Paragraph titulo = new Paragraph("Lista de inscriptos", FontFactory.GetFont("Calibri", 30));
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



                    Phrase datosRecibo = new Phrase("DATOS DEL ENTRENAMIENTO");
                    datosRecibo.Font.Size = 12;
                    datosRecibo.Font.SetStyle("italic");
                    tablaRecibo.AddCell(datosRecibo);

                    // Deporte
                    Phrase deporte = new Phrase("Deporte: " + e.Deporte.ToString());
                    deporte.Font.Size = 10;
                    deporte.Font.SetStyle("bold");

                    PdfPCell renglon9 = new PdfPCell(deporte);
                    renglon9.Border = 0;
                    renglon9.HorizontalAlignment = 0;
                    renglon9.VerticalAlignment = 1;
                    renglon9.Padding = 5;
                    tablaRecibo.AddCell(renglon9);

                    // Predio
                    Phrase predio = new Phrase("Predio: " + e.Predio.ToString());
                    predio.Font.Size = 10;
                    predio.Font.SetStyle("bold");

                    PdfPCell renglon10 = new PdfPCell(predio);
                    renglon10.Border = 0;
                    renglon10.HorizontalAlignment = 0;
                    renglon10.VerticalAlignment = 1;
                    renglon10.Padding = 5;
                    tablaRecibo.AddCell(renglon10);

                    // Profesores
                    List<Profesor> listaProfe = new GestorProfesor().listaProfesorSegunIdDeporte(e.Deporte.Id);
                    string nombres = "";
                    foreach (Profesor x in listaProfe)
                    {
                        nombres += "\t• " + x.Nombre + " " + x.Apellido + "\n";
                    }
                    Phrase profesor = new Phrase("Profesores:\n" + nombres);
                    profesor.Font.Size = 10;
                    profesor.Font.SetStyle("bold");

                    PdfPCell renglon1 = new PdfPCell(profesor);
                    renglon1.Border = 0;
                    renglon1.HorizontalAlignment = 0;
                    renglon1.VerticalAlignment = 1;
                    renglon1.Padding = 5;
                    tablaRecibo.AddCell(renglon1);

                    // Horario
                    List<Turno> turnos = ge.listaTurnoSegunIdEntrenamiento(e.Id);

                    string dia = "";
                    string horaEntrada = "";
                    string horaSalida = "";
                    string textoHorario = "";
                    foreach (Turno x in turnos)
                    {
                        dia = x.Dia;
                        horaEntrada = x.HoraEntrada.TimeOfDay.ToString();
                        horaSalida = x.HoraSalida.TimeOfDay.ToString();
                        textoHorario += "\t• " + dia + " de " + horaEntrada + " a " + horaSalida + "\n";
                    }
                    Phrase horario = new Phrase("Horario:\n" + textoHorario);
                    horario.Font.Size = 10;
                    horario.Font.SetStyle("bold");

                    PdfPCell renglon2 = new PdfPCell(horario);
                    renglon2.Border = 0;
                    renglon2.HorizontalAlignment = 0;
                    renglon2.VerticalAlignment = 1;
                    renglon2.Padding = 5;
                    tablaRecibo.AddCell(renglon2);

                    tablaRecibo.SpacingBefore = 5;
                    tablaRecibo.SpacingAfter = 15;

                    doc.Add(tablaRecibo);


                    // Tabla y cabecera que contendra los datos de los socios
                    PdfPTable tablaLista = new PdfPTable(3);
                    tablaLista.WidthPercentage = 100;

                    Phrase fraseColumna1 = new Phrase("Nombre y apellido");
                    fraseColumna1.Font.Color = BaseColor.WHITE;
                    fraseColumna1.Font.Size = 11;
                    fraseColumna1.Font.SetStyle("bold");

                    Phrase fraseColumna2 = new Phrase("DNI");
                    fraseColumna2.Font.Color = BaseColor.WHITE;
                    fraseColumna2.Font.Size = 11;
                    fraseColumna2.Font.SetStyle("bold");

                    Phrase fraseColumna3 = new Phrase("Teléfono");
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

                    tablaLista.AddCell(columnaCabecera1);
                    tablaLista.AddCell(columnaCabecera2);
                    tablaLista.AddCell(columnaCabecera3);

                    foreach (Socio socio in gs.listaSociosInscriptos(e.Id))
                    {
                        // Agrego los socios a la tabla

                        Phrase nombre = new Phrase(socio.Nombre + " " + socio.Apellido);
                        nombre.Font.Color = BaseColor.BLACK;
                        nombre.Font.Size = 10;
                        nombre.Font.SetStyle("bold");

                        Phrase dni = new Phrase(socio.Dni);
                        dni.Font.Color = BaseColor.BLACK;
                        dni.Font.Size = 10;
                        dni.Font.SetStyle("bold");

                        Phrase telefono = new Phrase(socio.Telefono);
                        telefono.Font.Color = BaseColor.BLACK;
                        telefono.Font.Size = 10;
                        telefono.Font.SetStyle("bold");

                        PdfPCell filaNombre = new PdfPCell(nombre);
                        PdfPCell filaDni = new PdfPCell(dni);
                        PdfPCell filaTelefono = new PdfPCell(telefono);

                        filaNombre.BackgroundColor = BaseColor.LIGHT_GRAY;
                        filaNombre.Border = 0;
                        filaNombre.HorizontalAlignment = 1;
                        filaNombre.Padding = 4;

                        filaDni.BackgroundColor = BaseColor.LIGHT_GRAY;
                        filaDni.Border = 0;
                        filaDni.HorizontalAlignment = 1;
                        filaDni.Padding = 4;

                        filaTelefono.BackgroundColor = BaseColor.LIGHT_GRAY;
                        filaTelefono.Border = 0;
                        filaTelefono.HorizontalAlignment = 1;
                        filaTelefono.Padding = 4;

                        tablaLista.AddCell(filaNombre);
                        tablaLista.AddCell(filaDni);
                        tablaLista.AddCell(filaTelefono);
                    }
                    tablaLista.SpacingAfter = 5;
                    doc.Add(tablaLista);

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
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo generar el pdf. \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        // ************************ BOTONES ************************


        private void btnListadoSociosInscriptos_Click(object sender, EventArgs e)
        {
            if (lstEntrenamiento.SelectedIndex == -1)
                MessageBox.Show("Debe seleccionar un entrenamiento de la lista para continuar", "Seleccione un entrenamiento", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            else
            {
                Entrenamiento entrenamiento = (Entrenamiento)lstEntrenamiento.SelectedItem;
                setInformacion(entrenamiento);
                setHorarioAlForm(entrenamiento);
                string consulta = "select Nombre, Apellido, DNI, Domicilio, Telefono, Email from Inscripcion i join vw_listaSocios s on i.socio = s.id where i.entrenamiento = " + entrenamiento.Id;
                dgvResultado.DataSource = bd.buscarBD(consulta);
            }
        }

        private void btnGenerarListado_Click(object sender, EventArgs e)
        {
            if (lstEntrenamiento.SelectedIndex == -1)
                MessageBox.Show("Debe seleccionar un entrenamiento de la lista para continuar", "Seleccione un entrenamiento", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            else
            {
                generarPDF((Entrenamiento)lstEntrenamiento.SelectedItem);
            }
        }
    }
}
