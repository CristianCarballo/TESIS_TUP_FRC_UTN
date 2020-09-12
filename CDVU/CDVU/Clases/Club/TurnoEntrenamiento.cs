using System.Collections.Generic;

namespace CDVU.Clases.Club
{
    class TurnoEntrenamiento
    {
        int id;
        Turno turno;
        Entrenamiento entrenamiento;
        List<Turno> listaTurno;
        List<Entrenamiento> listaEntrenamiento;

        public TurnoEntrenamiento()
        {
            turno = new Turno();
            entrenamiento = new Entrenamiento();
            listaTurno = new List<Turno>();
            ListaEntrenamiento = new List<Entrenamiento>();
        }

        public TurnoEntrenamiento(int id, Turno turno, List<Entrenamiento> listaEntrenamiento)
        {
            this.id = id;
            this.Turno = turno;
            this.ListaEntrenamiento = listaEntrenamiento;
        }

        public TurnoEntrenamiento(int id, Entrenamiento entrenamiento, List<Turno> listaTurno)
        {
            this.id = id;
            this.entrenamiento = entrenamiento;
            this.listaTurno = listaTurno;
        }

        public Turno Turno { get => turno; set => turno = value; }
        public Entrenamiento Entrenamiento { get => entrenamiento; set => entrenamiento = value; }
        public int Id { get => id; set => id = value; }
        public List<Turno> ListaTurno { get => listaTurno; set => listaTurno = value; }
        public List<Entrenamiento> ListaEntrenamiento { get => listaEntrenamiento; set => listaEntrenamiento = value; }

        public override string ToString()
        {
            return entrenamiento.ToString();
        }
    }
}
