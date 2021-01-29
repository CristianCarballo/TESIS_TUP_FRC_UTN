using CDVU.Clases.Base_de_Datos;
using System;
using System.Windows.Forms;

namespace CDVU
{
    public partial class frmConsultaRecaudacion : Form
    {
        AccesoBD bd;

        public frmConsultaRecaudacion()
        {
            InitializeComponent();
            bd = new AccesoBD();
        }

        // ************************ CARGA DE DATOS ************************

        private void frmConsultaRecaudacion_Load(object sender, EventArgs e)
        {
            dtpFechaRecaudacion.Enabled = false;
        }
       
        // ************************ VALIDACIONES ************************      

        private void cmbFecha_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFecha.SelectedIndex == 2)
            {
                dtpFechaRecaudacion.Enabled = true;
            }
            else
                dtpFechaRecaudacion.Enabled = false;
        }

        private void limpiarCampos()
        {
            dtpFechaRecaudacion.Enabled = false;
        }

        // ************************ BOTONES ************************

        private void btnRecaudacionPorFecha_Click(object sender, EventArgs e)
        {
            if (cmbFecha.SelectedIndex == -1)
                MessageBox.Show("Debe seleccionar una fecha para saber la recaudación", "Seleccione una fecha", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            else
            {
                // anual
                if (cmbFecha.SelectedIndex == 0)
                {
                    string consulta = "select YEAR(fecha) Año, sum(montoTotal) 'Recaudación total anual' from Recibo group by YEAR(fecha)";
                    dgvResultado.DataSource = bd.buscarBD(consulta);
                    limpiarCampos();
                }
                else
                //mensual
                    if (cmbFecha.SelectedIndex == 1)
                {
                    string consulta = "select MONTH(fecha) Mes, YEAR(fecha) Año, sum(montoTotal) 'Recaudación total mensual' from Recibo group by MONTH(fecha), YEAR(fecha)";
                    dgvResultado.DataSource = bd.buscarBD(consulta);
                    limpiarCampos();
                }
                //diario
                else
                {
                    DateTime fecha = dtpFechaRecaudacion.Value.Date;
                    string consulta = "select DAY(fecha) Día , MONTH(fecha) Mes, YEAR(fecha) Año, sum(montoTotal) 'Recaudación total diaria' from Recibo where fecha = convert(datetime, '" + fecha.Date.ToString("MM/dd/yyyy") + "' ) group by DAY(fecha), MONTH(fecha), YEAR(fecha)";
                    dgvResultado.DataSource = bd.buscarBD(consulta);
                }
            }
        }
    }
}
