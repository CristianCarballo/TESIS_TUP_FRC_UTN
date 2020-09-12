using CDVU.Personas;
using System.Collections.Generic;

namespace CDVU.Clases.Club
{
    class DeporteProfesor
    {
        int id;
        Deporte deporte;
        Profesor profesor;
        List<Deporte> listaDeporte;
        List<Profesor> listaProfesor;

        public DeporteProfesor()
        {
            Id = 0;
            deporte = new Deporte();
            profesor = new Profesor();
            listaDeporte = new List<Deporte>();
            listaProfesor = new List<Profesor>();
        }

        public DeporteProfesor(Deporte deporte,  List<Profesor> listaProfesor)
        {
            this.deporte = deporte;
            this.listaProfesor = listaProfesor;
        }

        public DeporteProfesor(Profesor profesor, List<Deporte> listaDeporte)
        {
            this.profesor = profesor;
            this.listaDeporte = listaDeporte;
        }

        public Deporte Deporte { get => deporte; set => deporte = value; }
        public Profesor Profesor { get => profesor; set => profesor = value; }
        public List<Deporte> ListaDeporte { get => listaDeporte; set => listaDeporte = value; }
        public List<Profesor> ListaProfesor { get => listaProfesor; set => listaProfesor = value; }
        public int Id { get => id; set => id = value; }

        public override string ToString()
        {
            return profesor.ToString();
        }
    }
}
