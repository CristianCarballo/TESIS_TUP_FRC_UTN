using CDVU.Personas;
using System;

namespace CDVU.Clases.Club
{
    class Inscripcion
    {
        int id;
        Socio socio;
        Entrenamiento entrenamiento;
        DateTime fecha;
        bool estaSaldado;

        public Inscripcion()
        {

        }

        public Inscripcion(int id, Socio socio, Entrenamiento entrenamiento, DateTime fecha, bool estaSaldado)
        {
            this.id = id;
            this.socio = socio;
            this.entrenamiento = entrenamiento;
            this.fecha = fecha;
            this.estaSaldado = estaSaldado;
        }

        public override string ToString()
        {
            return "N° Incripción: " + id + " - Fecha: " + fecha.Date.ToString("dd/MM/yyyy");
        }

        public int Id { get => id; set => id = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public Socio Socio { get => socio; set => socio = value; }
        public Entrenamiento Entrenamiento { get => entrenamiento; set => entrenamiento = value; }
        public bool EstaSaldado { get => estaSaldado; set => estaSaldado = value; }
    }
}
