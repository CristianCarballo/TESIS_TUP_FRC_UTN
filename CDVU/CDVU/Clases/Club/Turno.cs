using System;
using System.Diagnostics;

namespace CDVU.Clases.Club
{
    class Turno
    {
        int id;
        DateTime horaEntrada;
        DateTime horaSalida;
        int idDia;
        string dia;

        public Turno()
        {
        }

        public Turno(int id, DateTime horaEntrada, DateTime horaSalida, int idDia, string dia)
        {
            this.Id = id;
            this.HoraEntrada = horaEntrada;
            this.HoraSalida = horaSalida;
            this.IdDia = idDia;
            this.dia = dia;
        }

        public override string ToString()
        {
            return dia + " de " + horaEntrada + "hs. a " + horaSalida + "hs.";
        }

        public int Id { get => id; set => id = value; }
        public DateTime HoraEntrada { get => horaEntrada; set => horaEntrada = value; }
        public DateTime HoraSalida { get => horaSalida; set => horaSalida = value; }
        public int IdDia { get => idDia; set => idDia = value; }
        public string Dia { get => dia; set => dia = value; }
    }
}
