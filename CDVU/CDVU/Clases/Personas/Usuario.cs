using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDVU.Clases.Personas
{
    class Usuario
    {
        int id;
        string nombre;
        string apellido;
        string dni;
        string nombreUsuario;
        string contrasena;
        int idTipoUsuario;
        string tipoUsuario;

        public Usuario()
        {
        }

        public Usuario(int id, string nombre, string apellido, string dni, string nombreUsuario, string contrasena, int idTipoUsuario, string tipoUsuario)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Dni = dni;
            this.NombreUsuario = nombreUsuario;
            this.Contrasena = contrasena;
            this.IdTipoUsuario = idTipoUsuario;
            this.TipoUsuario = tipoUsuario;
        }

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Dni { get => dni; set => dni = value; }
        public string NombreUsuario { get => nombreUsuario; set => nombreUsuario = value; }
        public string Contrasena { get => contrasena; set => contrasena = value; }
        public int IdTipoUsuario { get => idTipoUsuario; set => idTipoUsuario = value; }
        public string TipoUsuario { get => tipoUsuario; set => tipoUsuario = value; }

        public override string ToString()
        {
            return nombreUsuario;
        }
    }
}
