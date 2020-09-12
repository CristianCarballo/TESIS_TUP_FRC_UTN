using CDVU.Personas;
using System;

namespace CDVU.Clases.Tesorería
{
    class Recibo
    {
        int id;
        DateTime fecha;
        Socio socio;
        double montoTotal;

        public Recibo()
        {
        }

        public Recibo(int id, DateTime fecha, Socio socio, double montoTotal)
        {
            this.id = id;
            this.fecha = fecha;
            this.socio = socio;
            this.montoTotal = montoTotal;
        }

        public int Id { get => id; set => id = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public double MontoTotal { get => montoTotal; set => montoTotal = value; }
        public Socio Socio { get => socio; set => socio = value; }

        public override string ToString()
        {
            return "N° Recibo: " + id + " - Fecha: " + fecha.Date.ToString("dd/MM/yyyy");
        }
    }
}
