using CDVU.Clases.Lugares;
using System;

namespace CDVU.Personas
{
    class Socio : Persona
    {
        Tutor tutor;

        public Socio() : base()
        {
        }

        public Socio(int id, string nombre, string apellido, int idSexo, string sexo, string dni, string domicilio, Localidad localidad, string telefono, string email, DateTime fechaNacimiento, Pais nacionalidad, Tutor tutor) : base(id, nombre, apellido, idSexo, sexo, dni, domicilio, localidad, telefono, email, fechaNacimiento, nacionalidad)
        {
            this.Tutor = tutor;
        }

        public Tutor Tutor { get => tutor; set => tutor = value; }

        public override string ToString()
        {
            return "N° Socio: " + Id + " - " + Apellido + " " + Nombre;
        }
    }
}
