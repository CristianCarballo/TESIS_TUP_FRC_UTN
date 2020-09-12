using CDVU.Clases.Lugares;
using System;

namespace CDVU
{
    abstract class Persona
    {
        int id;
        string nombre;
        string apellido;
        int idSexo;
        string sexo;
        string dni;
        string domicilio;
        Localidad localidad;
        string telefono;
        string email;
        DateTime fechaNacimiento;
        Pais nacionalidad;

        public Persona()
        {
        }

        protected Persona(int id, string nombre, string apellido, int idSexo, string sexo, string dni, string domicilio, Localidad localidad, string telefono, string email, DateTime fechaNacimiento, Pais nacionalidad)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellido = apellido;
            this.idSexo = idSexo;
            this.sexo = sexo;
            this.dni = dni;
            this.domicilio = domicilio;
            this.localidad = localidad;
            this.telefono = telefono;
            this.email = email;
            this.fechaNacimiento = fechaNacimiento;
            this.nacionalidad = nacionalidad;
        }

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Domicilio { get => domicilio; set => domicilio = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Email { get => email; set => email = value; }
        public string Dni { get => dni; set => dni = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public Localidad Localidad { get => localidad; set => localidad = value; }
        public Pais Nacionalidad { get => nacionalidad; set => nacionalidad = value; }
        public int IdSexo { get => idSexo; set => idSexo = value; }
        public string Sexo { get => sexo; set => sexo = value; }

        public override string ToString()
        {
            return apellido + " " + nombre;
        }
    }
}
