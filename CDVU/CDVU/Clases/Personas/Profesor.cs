using CDVU.Clases.Lugares;
using System;

namespace CDVU.Personas
{
    class Profesor : Persona
    {
        string matricula;

        public Profesor() : base()
        {
        }

        public Profesor(int id, string nombre, string apellido, int idSexo, string sexo, string dni, string domicilio, Localidad localidad, string telefono, string email, DateTime fechaNacimiento, Pais nacionalidad, string matricula) : base(id, nombre, apellido, idSexo, sexo, dni, domicilio, localidad, telefono, email, fechaNacimiento, nacionalidad)
        {
            this.matricula = matricula;
        }

        public string Matricula { get => matricula; set => matricula = value; }

        public override string ToString()
        {
            return Apellido + " " + Nombre + " - M.P.: " + matricula;
        }
    }
}
