using System.Collections.Generic;

namespace CDVU.Clases.Tesorería
{
    class PagoRecibo
    {
        int id;
        Pago pago;
        Recibo recibo;
        List<Pago> listaPago;
        List<Recibo> listaRecibo;

        public PagoRecibo(int id, Recibo recibo, List<Pago> listaPago)
        {
            this.id = id;
            this.recibo = recibo;
            this.listaPago = listaPago;
        }

        public PagoRecibo(int id, Pago pago, List<Recibo> listaRecibo)
        {
            this.id = id;
            this.pago = pago;
            this.listaRecibo = listaRecibo;
        }

        public PagoRecibo()
        {
            pago = new Pago();
            recibo = new Recibo();
            listaPago = new List<Pago>();
            listaRecibo = new List<Recibo>();
        }

        public Pago Pago { get => pago; set => pago = value; }
        public Recibo Recibo { get => recibo; set => recibo = value; }
        public List<Pago> ListaPago { get => listaPago; set => listaPago = value; }
        public List<Recibo> ListaRecibo { get => listaRecibo; set => listaRecibo = value; }

        public override string ToString()
        {
            return recibo.ToString();
        }
    }
}
