using CDVU.Clases.Club;

namespace CDVU.Clases.Tesorería
{
    class Pago
    {
        int id;
        Inscripcion inscripcion;
        string descripcion;
        int numeroCuota;
        double monto;

        public Pago()
        {
        }

        public Pago(int id, Inscripcion inscripcion, string descripcion, int numeroCuota, double monto)
        {
            this.id = id;
            this.inscripcion = inscripcion;
            this.descripcion = descripcion;
            this.numeroCuota = numeroCuota;
            this.monto = monto;
        }

        public int Id { get => id; set => id = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public int NumeroCuota { get => numeroCuota; set => numeroCuota = value; }
        public double Monto { get => monto; set => monto = value; }
        public Inscripcion Inscripcion { get => inscripcion; set => inscripcion = value; }

        public override string ToString()
        {
            return descripcion;
        }
    }
}
