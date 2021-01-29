using CDVU.Clases.Base_de_Datos;
using CDVU.Clases.Base_de_Datos.GestorClub;
using CDVU.Clases.Club;
using CDVU.Clases.Tesorería;
using CDVU.Personas;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace CDVU
{
    public partial class frmTesoreria : Form
    {
        GestorTesoreria gt;
        GestorInscripcion gi;
        GestorSocio gs;
        ToolTip toolTip;
        PagoRecibo pagoRecibo;
        List<Pago> listaAnterior;

        public frmTesoreria()
        {
            InitializeComponent();
            gt = new GestorTesoreria();
            gi = new GestorInscripcion();
            gs = new GestorSocio();
            toolTip = new ToolTip();
            pagoRecibo = new PagoRecibo();
            listaAnterior = new List<Pago>();
        }

        enum Acciones { agregar, modificar, eliminar, buscar }
        Acciones miAccion = Acciones.agregar;


        // ************************ CARGA DE DATOS ************************

        private void frmTesoreria_Load(object sender, EventArgs e)
        {
            txtFecha.Text = DateTime.Today.ToString("dd/MM/yyyy");
        }

        private void cargarComboInscripcion(int idSocio)
        {
            cmbInscripcion.DataSource = null;
            cmbInscripcion.Items.Clear();
            cmbInscripcion.DataSource = gi.listaInscripcionSegunIdSocio(idSocio);
            cmbInscripcion.ValueMember = "id";
            cmbInscripcion.DisplayMember = "";
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

        private void lstCuotaDeuda_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (lstCuotaDeuda.Enabled)
            {
                if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                {
                    e.Graphics.FillRectangle(new SolidBrush(Color.DimGray), new System.Drawing.Rectangle(e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height));
                    e.Graphics.DrawString(lstCuotaDeuda.Items[e.Index].ToString(), e.Font, Brushes.White, new System.Drawing.Rectangle(e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height));
                }
                else
                {
                    e.DrawBackground();
                    if (e.Index >= 0)
                    {
                        e.Graphics.DrawString(lstCuotaDeuda.Items[e.Index].ToString(), e.Font, Brushes.White, new System.Drawing.Rectangle(e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height));
                    }
                }
                e.DrawFocusRectangle();
            }
            else
            {
                if (lstCuotaDeuda.Enabled)
                {
                    if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                    {
                        e.Graphics.FillRectangle(new SolidBrush(Color.DimGray), new System.Drawing.Rectangle(e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height));
                        e.Graphics.DrawString(lstCuotaDeuda.Items[e.Index].ToString(), e.Font, Brushes.Black, new System.Drawing.Rectangle(e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height));
                    }
                    else
                    {
                        e.DrawBackground();
                        if (e.Index >= 0)
                        {
                            e.Graphics.DrawString(lstCuotaDeuda.Items[e.Index].ToString(), e.Font, Brushes.Black, new System.Drawing.Rectangle(e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height));
                        }
                    }
                    e.DrawFocusRectangle();
                }
            }
        }

        private void lstCuotaAPagar_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (lstCuotaAPagar.Enabled)
            {
                if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                {
                    e.Graphics.FillRectangle(new SolidBrush(Color.DimGray), new System.Drawing.Rectangle(e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height));
                    e.Graphics.DrawString(lstCuotaAPagar.Items[e.Index].ToString(), e.Font, Brushes.White, new System.Drawing.Rectangle(e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height));
                }
                else
                {
                    e.DrawBackground();
                    if (e.Index >= 0)
                    {
                        e.Graphics.DrawString(lstCuotaAPagar.Items[e.Index].ToString(), e.Font, Brushes.White, new System.Drawing.Rectangle(e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height));
                    }
                }
                e.DrawFocusRectangle();
            }
            else
            {
                if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                {
                    e.Graphics.FillRectangle(new SolidBrush(Color.DimGray), new System.Drawing.Rectangle(e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height));
                    e.Graphics.DrawString(lstCuotaAPagar.Items[e.Index].ToString(), e.Font, Brushes.Black, new System.Drawing.Rectangle(e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height));
                }
                else
                {
                    e.DrawBackground();
                    if (e.Index >= 0)
                    {
                        e.Graphics.DrawString(lstCuotaAPagar.Items[e.Index].ToString(), e.Font, Brushes.Black, new System.Drawing.Rectangle(e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height));
                    }
                }
                e.DrawFocusRectangle();
            }
        }

        private void limpiarCampos()
        {
            txtBuscarSocio.Text = "";
            lblIdSocioSeleccionado.Text = "";
            lblDniSocioSeleccionado.Text = "";
            lblNombreSocioSeleccionado.Text = "";
            lblDniTutorSeleccionado.Text = "";
            lblNombreTutorSeleccionado.Text = "";
            cmbInscripcion.DataSource = null;
            cmbInscripcion.Items.Clear();
            lblFechaInscripcion.Text = "";
            lblDeporteSeleccionado.Text = "";
            lblPrecioMatSeleccionado.Text = "";
            lblPrecioMensualSeleccionado.Text = "";
            lblCantidadCuotas.Text = "";
            lstCuotaDeuda.DataSource = null;
            lstCuotaDeuda.Items.Clear();
            lstCuotaAPagar.DataSource = null;
            lstCuotaAPagar.Items.Clear();
            txtFecha.Text = DateTime.Today.ToString("dd/MM/yyyy");
            txtNombre.Text = "";
            txtTotal.Text = "";
        }

        private void cmbInscripcion_SelectedIndexChanged(object sender, EventArgs e)
        {
            Inscripcion i = (Inscripcion)cmbInscripcion.SelectedItem;
            if (i == null)
            {
                lblDeporteSeleccionado.Text = "";
                lblFechaInscripcion.Text = "";
                lblPrecioMensualSeleccionado.Text = "";
                lblPrecioMatSeleccionado.Text = "";
                lblCantidadCuotas.Text = "";
                txtTotal.Text = "";
                lstCuotaDeuda.Update();
                lstCuotaDeuda.DataSource = null;
                lstCuotaDeuda.Items.Clear();
                lstCuotaAPagar.Update();
                lstCuotaAPagar.DataSource = null;
                lstCuotaAPagar.Items.Clear();
            }
            else
            {
                lblDeporteSeleccionado.Text = i.Entrenamiento.Deporte.ToString();
                lblFechaInscripcion.Text = i.Fecha.ToString("dd/MM/yyyy");
                lblPrecioMensualSeleccionado.Text = i.Entrenamiento.PrecioMensual.ToString();
                lblPrecioMatSeleccionado.Text = i.Entrenamiento.PrecioMatricula.ToString();
                lblCantidadCuotas.Text = i.Entrenamiento.CantidadCuotas.ToString();
                lstCuotaDeuda.Update();
                lstCuotaDeuda.DataSource = gt.listaCuotaSinPagarPorIdInscripcion(i.Id);
                lstCuotaDeuda.ValueMember = "id";
                lstCuotaDeuda.DisplayMember = "";
                if (lstCuotaDeuda.Items.Count > 0)
                {
                    lstCuotaDeuda.SelectedIndex = 0;
                }
            }
        }

        private void moverItem(ListBox listaOrigen, ListBox listaDestino)
        {
            listaAnterior = new List<Pago>();
            while (listaOrigen.SelectedItems.Count > 0)
            {
                foreach (Pago p in listaOrigen.Items)
                {
                    if (p != null)
                        listaAnterior.Add(p);
                }
                Pago item = (Pago)listaOrigen.SelectedItems[0];
                listaDestino.Items.Add(item);
                listaOrigen.DataSource = null;
                listaOrigen.Items.Clear();
                foreach (Pago p in listaAnterior)
                {
                    if (p != null)
                        listaOrigen.Items.Add(p);
                }
                listaOrigen.Items.Remove(item);
            }
            listaOrigen.SelectedIndex = -1;
            total();
        }

        private void total()
        {
            double tot = 0;
            foreach (Pago p in lstCuotaAPagar.Items)
            {
                tot += p.Monto;
            }
            txtTotal.Text = tot.ToString();
        }

        private PagoRecibo getPagoReciboDelForm()
        {
            if (miAccion == Acciones.agregar)
            {
                pagoRecibo = new PagoRecibo();
                pagoRecibo.Recibo.Fecha = DateTime.Today;
                pagoRecibo.Recibo.Socio = gs.obtenerSocioPorId(Convert.ToInt32(lblIdSocioSeleccionado.Text));
                foreach (Pago x in lstCuotaAPagar.Items)
                {
                    pagoRecibo.ListaPago.Add(x);
                }
                pagoRecibo.Recibo.MontoTotal = Convert.ToDouble(txtTotal.Text);
            }
            //else if (miAccion == Acciones.modificar)
            //{
            //}
            //else
            //    recibo = (Recibo)lstInscripciones.SelectedItem;
            return pagoRecibo;
        }

        private void abmPagoRecibo(Acciones accion)
        {
            if (accion == Acciones.agregar)
            {
                if (!gt.agregarPagoRecibo(getPagoReciboDelForm()))
                    MessageBox.Show("Ocurrió un error al generar el recibo");
                else
                    MessageBox.Show("Recibo agregado correctamente");
            }
            //else if (accion == Acciones.modificar)
            //{
            //    if (!gi.modificarInscripcion(getInscripcionDelForm()))
            //        MessageBox.Show("Ocurrió un error al modificar la inscripción");
            //    else
            //        MessageBox.Show("Datos modificados correctamente");
            //}
            //else if (accion == Acciones.eliminar)
            //{
            //    if (!gi.eliminarInscripcion(getInscripcionDelForm()))
            //        MessageBox.Show("Ocurrió un error al eliminar la inscripción");
            //    else
            //        MessageBox.Show("Inscripción eliminado correctamente");
            //}
        }

        private bool validarVacios()
        {
            if (lblIdSocioSeleccionado.Text == "")
            {
                MessageBox.Show("Busque un socio para continuar", "Socio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                return false;
            }
            else
                if (cmbInscripcion.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione la inscripción del socio para continuar", "Inscripcion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                return false;
            }
            else
                if (lstCuotaAPagar.Items.Count <= 0)
            {
                MessageBox.Show("Agregue cuotas a pagar a la lista para continuar", "Cuotas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                return false;
            }
            else
                return true;
        }

        private void generarPDF(Recibo recibo)
        {
            try
            {
                // Cuadro de dialogo del sistema para guardar el PDF donde elija el usuario
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "Archivo PDF|*.pdf";
                save.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                save.FileName = "Recibo N° " + recibo.Id;

                if (save.ShowDialog() == DialogResult.OK)
                {
                    Document doc = new Document(PageSize.A4);
                    FileStream fl = new FileStream(save.FileName, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
                    PdfWriter.GetInstance(doc, fl);

                    // Metadata (titulo y autor del archivo pdf)
                    doc.AddAuthor("Club Deportivo Vecinos Unidos");
                    doc.AddTitle("Recibo");
                    doc.Open();

                    // Imagen logo
                    iTextSharp.text.Image imagen = iTextSharp.text.Image.GetInstance(@"C:\Users\pepa_\Documents\Visual Studio 2019\Projects\CDVU\CDVU\Resources\vecinos-unidos1.png");
                    imagen.BorderWidth = 0;
                    imagen.ScalePercent(20f);
                    imagen.Alignment = Element.ALIGN_RIGHT;

                    // Titulo
                    Paragraph titulo = new Paragraph("Recibo", FontFactory.GetFont("Calibri", 30));
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

                    Phrase datosRecibo = new Phrase("DATOS DEL RECIBO");
                    datosRecibo.Font.Size = 12;
                    datosRecibo.Font.SetStyle("italic");
                    tablaRecibo.AddCell(datosRecibo);

                    // N° de Recibo
                    Phrase frase1 = new Phrase("Recibo N°: " + recibo.Id);
                    frase1.Font.Size = 10;
                    frase1.Font.SetStyle("bold");

                    PdfPCell renglon1 = new PdfPCell(frase1);
                    renglon1.Border = 0;
                    renglon1.HorizontalAlignment = 0;
                    renglon1.VerticalAlignment = 1;
                    renglon1.Padding = 5;
                    tablaRecibo.AddCell(renglon1);

                    // Fecha del recibo
                    Phrase frase2 = new Phrase("Fecha: " + recibo.Fecha.ToString("dd/MM/yyyy"));
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
                    Phrase frase3 = new Phrase("Nombre: " + recibo.Socio.Apellido + " " + recibo.Socio.Nombre);
                    frase3.Font.Size = 10;
                    frase3.Font.SetStyle("bold");

                    PdfPCell renglon3 = new PdfPCell(frase3);
                    renglon3.Border = 0;
                    renglon3.HorizontalAlignment = 0;
                    renglon3.VerticalAlignment = 1;
                    renglon3.Padding = 5;
                    tablaSocio.AddCell(renglon3);

                    // DNI del socio
                    Phrase frase4 = new Phrase("DNI: " + recibo.Socio.Dni);
                    frase4.Font.Size = 10;
                    frase4.Font.SetStyle("bold");

                    PdfPCell renglon4 = new PdfPCell(frase4);
                    renglon4.Border = 0;
                    renglon4.HorizontalAlignment = 0;
                    renglon4.VerticalAlignment = 1;
                    renglon4.Padding = 5;
                    tablaSocio.AddCell(renglon4);

                    // Teléfono del socio
                    Phrase frase5 = new Phrase("Teléfono: " + recibo.Socio.Telefono);
                    frase5.Font.Size = 10;
                    frase5.Font.SetStyle("bold");

                    PdfPCell renglon5 = new PdfPCell(frase5);
                    renglon5.Border = 0;
                    renglon5.HorizontalAlignment = 0;
                    renglon5.VerticalAlignment = 1;
                    renglon5.Padding = 5;
                    tablaSocio.AddCell(renglon5);

                    // Email del socio
                    Phrase frase6 = new Phrase("Email: " + recibo.Socio.Email);
                    frase6.Font.Size = 10;
                    frase6.Font.SetStyle("bold");

                    PdfPCell renglon6 = new PdfPCell(frase6);
                    renglon6.Border = 0;
                    renglon6.HorizontalAlignment = 0;
                    renglon6.VerticalAlignment = 1;
                    renglon6.Padding = 5;
                    tablaSocio.AddCell(renglon6);

                    // Tutor de este socio
                    if (recibo.Socio.Tutor == null)
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
                        Phrase frase7 = new Phrase("Tutor: " + recibo.Socio.Tutor.ToString());
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



                    // Datos de la inscripcion
                    Inscripcion inscripcion = new GestorInscripcion().obtenerInscripcionPorIdRecibo(recibo.Id);
                    PdfPTable tablaInscripcion = new PdfPTable(1);
                    tablaInscripcion.WidthPercentage = 100;

                    Phrase datosInscripcion = new Phrase("DATOS DE LA INSCRIPCIÓN");
                    datosInscripcion.Font.Size = 12;
                    datosInscripcion.Font.SetStyle("italic");
                    tablaInscripcion.AddCell(datosInscripcion);

                    // Fecha inscripcion
                    Phrase fechaInscripcion = new Phrase("Fecha inscripción: " + inscripcion.Fecha.ToString("dd/MM/yyyy"));
                    fechaInscripcion.Font.Size = 10;
                    fechaInscripcion.Font.SetStyle("bold");

                    PdfPCell renglon8 = new PdfPCell(fechaInscripcion);
                    renglon8.Border = 0;
                    renglon8.HorizontalAlignment = 0;
                    renglon8.VerticalAlignment = 1;
                    renglon8.Padding = 5;
                    tablaInscripcion.AddCell(renglon8);

                    // Deporte
                    Phrase deporte = new Phrase("Deporte: " + inscripcion.Entrenamiento.Deporte.ToString());
                    deporte.Font.Size = 10;
                    deporte.Font.SetStyle("bold");

                    PdfPCell renglon9 = new PdfPCell(deporte);
                    renglon9.Border = 0;
                    renglon9.HorizontalAlignment = 0;
                    renglon9.VerticalAlignment = 1;
                    renglon9.Padding = 5;
                    tablaInscripcion.AddCell(renglon9);

                    // Predio
                    Phrase predio = new Phrase("Predio: " + inscripcion.Entrenamiento.Predio.ToString());
                    predio.Font.Size = 10;
                    predio.Font.SetStyle("bold");

                    PdfPCell renglon10 = new PdfPCell(predio);
                    renglon10.Border = 0;
                    renglon10.HorizontalAlignment = 0;
                    renglon10.VerticalAlignment = 1;
                    renglon10.Padding = 5;
                    tablaInscripcion.AddCell(renglon10);

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

                    // Tabla y cabecera que contendra los datos de los pagos
                    PdfPTable tablaPago = new PdfPTable(3);
                    tablaPago.WidthPercentage = 100;

                    Phrase fraseColumna1 = new Phrase("N° de cuota");
                    fraseColumna1.Font.Color = BaseColor.WHITE;
                    fraseColumna1.Font.Size = 11;
                    fraseColumna1.Font.SetStyle("bold");

                    Phrase fraseColumna2 = new Phrase("Descripción");
                    fraseColumna2.Font.Color = BaseColor.WHITE;
                    fraseColumna2.Font.Size = 11;
                    fraseColumna2.Font.SetStyle("bold");

                    Phrase fraseColumna3 = new Phrase("Total");
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

                    tablaPago.AddCell(columnaCabecera1);
                    tablaPago.AddCell(columnaCabecera2);
                    tablaPago.AddCell(columnaCabecera3);

                    foreach (Pago p in gt.listaPagoSegunRecibo(recibo.Id))
                    {
                        // Agrego los datos de cada pago a la tabla

                        Phrase fraseCuota = new Phrase(p.NumeroCuota.ToString());
                        fraseCuota.Font.Color = BaseColor.BLACK;
                        fraseCuota.Font.Size = 10;
                        fraseCuota.Font.SetStyle("bold");

                        Phrase fraseDescripcion = new Phrase(p.Descripcion);
                        fraseDescripcion.Font.Color = BaseColor.BLACK;
                        fraseDescripcion.Font.Size = 10;
                        fraseDescripcion.Font.SetStyle("bold");

                        Phrase fraseTotal = new Phrase("$ " + p.Monto.ToString());
                        fraseTotal.Font.Color = BaseColor.BLACK;
                        fraseTotal.Font.Size = 10;
                        fraseTotal.Font.SetStyle("bold");

                        PdfPCell filaCuota = new PdfPCell(fraseCuota);
                        PdfPCell filaDescripcion = new PdfPCell(fraseDescripcion);
                        PdfPCell filaTotal = new PdfPCell(fraseTotal);

                        filaCuota.BackgroundColor = BaseColor.LIGHT_GRAY;
                        filaCuota.Border = 0;
                        filaCuota.HorizontalAlignment = 1;
                        filaCuota.Padding = 4;

                        filaDescripcion.BackgroundColor = BaseColor.LIGHT_GRAY;
                        filaDescripcion.Border = 0;
                        filaDescripcion.HorizontalAlignment = 1;
                        filaDescripcion.Padding = 4;

                        filaTotal.BackgroundColor = BaseColor.LIGHT_GRAY;
                        filaTotal.Border = 0;
                        filaTotal.HorizontalAlignment = 1;
                        filaTotal.Padding = 4;

                        tablaPago.AddCell(filaCuota);
                        tablaPago.AddCell(filaDescripcion);
                        tablaPago.AddCell(filaTotal);
                    }
                    tablaPago.SpacingAfter = 5;
                    doc.Add(tablaPago);

                    // Tabla para el total
                    PdfPTable tablaTotal = new PdfPTable(1);
                    tablaTotal.WidthPercentage = 100;

                    Phrase fraseTotalFinal = new Phrase("Total: $" + recibo.MontoTotal.ToString());
                    fraseTotalFinal.Font.Color = BaseColor.BLACK;
                    fraseTotalFinal.Font.Size = 10;
                    fraseTotalFinal.Font.SetStyle("bold");

                    PdfPCell total = new PdfPCell(fraseTotalFinal);
                    total.BackgroundColor = BaseColor.LIGHT_GRAY;
                    total.Border = 0;
                    total.HorizontalAlignment = 2;
                    total.Padding = 4;

                    tablaTotal.AddCell(total);
                    tablaTotal.SpacingAfter = 15;
                    doc.Add(tablaTotal);

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

        private void btnBuscarSocio_Click(object sender, EventArgs e)
        {
            if (txtBuscarSocio.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese el DNI ó el N° del socio para buscar");
            }
            else
            {
                Socio s = gs.obtenerSocioPorId(Convert.ToInt32(txtBuscarSocio.Text));
                if (s == null)
                {
                    s = gs.obtenerSocioPorDNI(txtBuscarSocio.Text);
                    if (s == null)
                    {
                        MessageBox.Show("No se encuentra el socio");
                        limpiarCampos();
                    }

                    else
                    {
                        lblIdSocioSeleccionado.Text = Convert.ToString(s.Id);
                        lblDniSocioSeleccionado.Text = s.Dni;
                        lblNombreSocioSeleccionado.Text = s.Apellido + " " + s.Nombre;
                        txtNombre.Text = lblNombreSocioSeleccionado.Text;
                        if (s.Tutor == null)
                        {
                            lblDniTutorSeleccionado.Text = "-";
                            lblNombreTutorSeleccionado.Text = "-";
                        }
                        else
                        {
                            lblDniTutorSeleccionado.Text = s.Tutor.Dni;
                            lblNombreTutorSeleccionado.Text = s.Tutor.Apellido + " " + s.Tutor.Nombre;
                        }
                        cargarComboInscripcion(s.Id);
                    }
                }
                else
                {
                    lblIdSocioSeleccionado.Text = Convert.ToString(s.Id);
                    lblDniSocioSeleccionado.Text = s.Dni;
                    lblNombreSocioSeleccionado.Text = s.Apellido + " " + s.Nombre;
                    lblNombreSocioSeleccionado.Text = s.Apellido + " " + s.Nombre;
                    txtNombre.Text = lblNombreSocioSeleccionado.Text;
                    if (s.Tutor == null)
                    {
                        lblDniTutorSeleccionado.Text = "-";
                        lblNombreTutorSeleccionado.Text = "-";
                    }
                    else
                    {
                        lblDniTutorSeleccionado.Text = s.Tutor.Dni;
                        lblNombreTutorSeleccionado.Text = s.Tutor.Apellido + " " + s.Tutor.Nombre;
                    }

                    cargarComboInscripcion(s.Id);
                }
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (validarVacios())
            {
                abmPagoRecibo(miAccion);
                limpiarCampos();
                generarPDF(gt.ultimoReciboGenerado());
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }

        private void btnAgregarPago_Click(object sender, EventArgs e)
        {
            if (lstCuotaDeuda.SelectedIndex == -1)
            {
                MessageBox.Show("No hay mas cuotas para agregar", "Cuota", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                moverItem(lstCuotaDeuda, lstCuotaAPagar);
                if (lstCuotaDeuda.Items.Count > 0)
                    lstCuotaDeuda.SelectedIndex = 0;
                lstCuotaAPagar.SelectedIndex = lstCuotaAPagar.Items.Count - 1;
            }
        }

        private void btnQuitarPago_Click(object sender, EventArgs e)
        {
            if (lstCuotaAPagar.SelectedIndex == -1)
            {
                MessageBox.Show("No hay mas cuotas para quitar", "Cuota", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                moverItem(lstCuotaAPagar, lstCuotaDeuda);
                if (lstCuotaAPagar.Items.Count > 0)
                    lstCuotaDeuda.SelectedIndex = 0;
                lstCuotaAPagar.SelectedIndex = lstCuotaAPagar.Items.Count - 1;
            }
        }
    }
}
