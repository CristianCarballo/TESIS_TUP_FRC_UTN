using CDVU.Clases.Lugares;
using System;

namespace CDVU.Personas
{
    class Tutor : Persona
    {
        public Tutor()
        {
        }

        public Tutor(int id, string nombre, string apellido, int idSexo, string sexo, string dni, string domicilio, Localidad localidad, string telefono, string email, DateTime fechaNacimiento, Pais nacionalidad) : base(id, nombre, apellido, idSexo, sexo, dni, domicilio, localidad, telefono, email, fechaNacimiento, nacionalidad)
        {
        }

        public override string ToString()
        {
            return Apellido + " " + Nombre;
        }
    }
}
