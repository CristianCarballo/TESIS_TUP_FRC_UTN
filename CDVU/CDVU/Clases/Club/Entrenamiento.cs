using System.Collections.Generic;

namespace CDVU.Clases.Club
{
    class Entrenamiento
    {
        int id;
        Deporte deporte;
        Predio predio;
        double precioMensual;
        double precioMatricula;
        int cantidadCuotas;

        public Entrenamiento()
        {
            deporte = new Deporte();
            predio = new Predio();
            precioMensual = 0;
            precioMatricula = 0;
            cantidadCuotas = 0;
        }

        public Entrenamiento(int id, Deporte deporte, Predio predio, double precioMensual, double precioMatricula, int cantidadCuotas)
        {
            this.id = id;
            this.deporte = deporte;
            this.predio = predio;
            this.precioMensual = precioMensual;
            this.precioMatricula = precioMatricula;
            this.cantidadCuotas = cantidadCuotas;
        }

        public override string ToString()
        {
            return deporte + " - " + predio;
        }

        public int Id { get => id; set => id = value; }
        public Deporte Deporte { get => deporte; set => deporte = value; }
        public Predio Predio { get => predio; set => predio = value; }
        public double PrecioMensual { get => precioMensual; set => precioMensual = value; }
        public double PrecioMatricula { get => precioMatricula; set => precioMatricula = value; }
        public int CantidadCuotas { get => cantidadCuotas; set => cantidadCuotas = value; }
    }
}
