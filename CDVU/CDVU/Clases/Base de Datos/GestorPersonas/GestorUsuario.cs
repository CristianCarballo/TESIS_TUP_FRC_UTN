using CDVU.Clases.Personas;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace CDVU.Clases.Base_de_Datos.GestorPersonas
{
    class GestorUsuario
    {
        AccesoBD bd;

        public GestorUsuario()
        {
            bd = new AccesoBD();
        }

        public List<Usuario> listaUsuario()
        {
            List<Usuario> lista = new List<Usuario>();
            bd.consultarBD("select u.id idUsuario, nombre, apellido, dni, usuario, contrasena, u.tipoUsuario idTipoUsuario, tu.tipoUsuario from Usuario u join TipoUsuario tu on u.tipoUsuario = tu.id");
            while (bd.Lector.Read())
            {
                Usuario usuario = new Usuario();
                if (!bd.Lector.IsDBNull(0))
                    usuario.Id = bd.Lector.GetInt32(0);
                if (!bd.Lector.IsDBNull(1))
                    usuario.Nombre = bd.Lector.GetString(1);
                if (!bd.Lector.IsDBNull(2))
                    usuario.Apellido = bd.Lector.GetString(2);
                if (!bd.Lector.IsDBNull(3))
                    usuario.Dni = bd.Lector.GetString(3);
                if (!bd.Lector.IsDBNull(4))
                    usuario.NombreUsuario = bd.Lector.GetString(4);
                if (!bd.Lector.IsDBNull(5))
                    usuario.Contrasena = bd.Lector.GetString(5);
                if (!bd.Lector.IsDBNull(6))
                    usuario.IdTipoUsuario = bd.Lector.GetInt32(6);
                if (!bd.Lector.IsDBNull(7))
                    usuario.TipoUsuario = bd.Lector.GetString(7);
                lista.Add(usuario);
            }
            bd.Lector.Close();
            bd.desconectar();
            return lista;
        }

        public List<Usuario> listaUsuarioSegunIdTipoUsuario(int idTipoUsuario)
        {
            List<Usuario> lista = new List<Usuario>();
            bd.consultarBD("select u.id idUsuario, nombre, apellido, dni, usuario, contrasena, u.tipoUsuario idTipoUsuario, tu.tipoUsuario from Usuario u join TipoUsuario tu on u.tipoUsuario = tu.id where u.tipoUsuario = " + idTipoUsuario);
            while (bd.Lector.Read())
            {
                Usuario usuario = new Usuario();
                if (!bd.Lector.IsDBNull(0))
                    usuario.Id = bd.Lector.GetInt32(0);
                if (!bd.Lector.IsDBNull(1))
                    usuario.Nombre = bd.Lector.GetString(1);
                if (!bd.Lector.IsDBNull(2))
                    usuario.Apellido = bd.Lector.GetString(2);
                if (!bd.Lector.IsDBNull(3))
                    usuario.Dni = bd.Lector.GetString(3);
                if (!bd.Lector.IsDBNull(4))
                    usuario.NombreUsuario = bd.Lector.GetString(4);
                if (!bd.Lector.IsDBNull(5))
                    usuario.Contrasena = bd.Lector.GetString(5);
                if (!bd.Lector.IsDBNull(6))
                    usuario.IdTipoUsuario = bd.Lector.GetInt32(6);
                if (!bd.Lector.IsDBNull(7))
                    usuario.TipoUsuario = bd.Lector.GetString(7);
                lista.Add(usuario);
            }
            bd.Lector.Close();
            bd.desconectar();
            return lista;
        }

        public Usuario logear(string user, string pass)
        {
            Usuario usuario = new Usuario();
            bd.actualizarBD("select u.id idUsuario, usuario, contrasena, u.tipoUsuario idTipoUsuario, tu.tipoUsuario from Usuario u join TipoUsuario tu on u.tipoUsuario = tu.id where usuario = @user and contrasena = @pass");
            bd.Comando.Parameters.Add(new SqlParameter("@user", user));
            bd.Comando.Parameters.Add(new SqlParameter("@pass", pass));
            bd.Lector = bd.Comando.ExecuteReader();
            if (bd.Lector.Read())
            {
                if (!bd.Lector.IsDBNull(0))
                    usuario.Id = bd.Lector.GetInt32(0);
                if (!bd.Lector.IsDBNull(1))
                    usuario.NombreUsuario = bd.Lector.GetString(1);
                if (!bd.Lector.IsDBNull(2))
                    usuario.Contrasena = bd.Lector.GetString(2);
                if (!bd.Lector.IsDBNull(3))
                    usuario.IdTipoUsuario = bd.Lector.GetInt32(3);
                if (!bd.Lector.IsDBNull(4))
                    usuario.TipoUsuario = bd.Lector.GetString(4);
            }
            else
                usuario = null;
            bd.Lector.Close();
            bd.desconectar();
            return usuario;
        }

        public Usuario existeNombreUsuario(string user)
        {
            Usuario usuario = new Usuario();
            bd.actualizarBD("select u.id idUsuario, usuario, contrasena, u.tipoUsuario idTipoUsuario, tu.tipoUsuario from Usuario u join TipoUsuario tu on u.tipoUsuario = tu.id where usuario like @user");
            bd.Comando.Parameters.Add(new SqlParameter("@user", user));
            bd.Lector = bd.Comando.ExecuteReader();
            if (bd.Lector.Read())
            {
                if (!bd.Lector.IsDBNull(0))
                    usuario.Id = bd.Lector.GetInt32(0);
                if (!bd.Lector.IsDBNull(1))
                    usuario.NombreUsuario = bd.Lector.GetString(1);
                if (!bd.Lector.IsDBNull(2))
                    usuario.Contrasena = bd.Lector.GetString(2);
                if (!bd.Lector.IsDBNull(3))
                    usuario.IdTipoUsuario = bd.Lector.GetInt32(3);
                if (!bd.Lector.IsDBNull(4))
                    usuario.TipoUsuario = bd.Lector.GetString(4);
            }
            else
                usuario = null;
            bd.Lector.Close();
            bd.desconectar();
            return usuario;
        }

        public Usuario existeUsuario(string nombre, string apellido, string dni, string user)
        {
            Usuario usuario = new Usuario();
            bd.actualizarBD("select u.id idUsuario, nombre, apellido, dni, usuario, contrasena, u.tipoUsuario idTipoUsuario, tu.tipoUsuario from Usuario u join TipoUsuario tu on u.tipoUsuario = tu.id where nombre like @nombre and apellido like @apellido and dni like @dni and usuario like @user");
            bd.Comando.Parameters.Add(new SqlParameter("@nombre", nombre));
            bd.Comando.Parameters.Add(new SqlParameter("@apellido", apellido));
            bd.Comando.Parameters.Add(new SqlParameter("@dni", dni));
            bd.Comando.Parameters.Add(new SqlParameter("@user", user));
            bd.Lector = bd.Comando.ExecuteReader();
            if (bd.Lector.Read())
            {
                if (!bd.Lector.IsDBNull(0))
                    usuario.Id = bd.Lector.GetInt32(0);
                if (!bd.Lector.IsDBNull(1))
                    usuario.Nombre = bd.Lector.GetString(1);
                if (!bd.Lector.IsDBNull(2))
                    usuario.Apellido = bd.Lector.GetString(2);
                if (!bd.Lector.IsDBNull(3))
                    usuario.Dni = bd.Lector.GetString(3);
                if (!bd.Lector.IsDBNull(4))
                    usuario.NombreUsuario = bd.Lector.GetString(4);
                if (!bd.Lector.IsDBNull(5))
                    usuario.Contrasena = bd.Lector.GetString(5);
                if (!bd.Lector.IsDBNull(6))
                    usuario.IdTipoUsuario = bd.Lector.GetInt32(6);
                if (!bd.Lector.IsDBNull(7))
                    usuario.TipoUsuario = bd.Lector.GetString(7);
            }
            else
                usuario = null;
            bd.Lector.Close();
            bd.desconectar();
            return usuario;
        }

        public bool agregarUsuario(Usuario u)
        {
            try
            {
                bd.actualizarBD("insert into usuario values(@nombre, @apellido, @dni, @user, @pass, @tipoUsuario)");
                bd.Comando.Parameters.Add(new SqlParameter("@nombre", u.Nombre));
                bd.Comando.Parameters.Add(new SqlParameter("@apellido", u.Apellido));
                bd.Comando.Parameters.Add(new SqlParameter("@dni", u.Dni));
                bd.Comando.Parameters.Add(new SqlParameter("@user", u.NombreUsuario));
                bd.Comando.Parameters.Add(new SqlParameter("@pass", u.Contrasena));
                bd.Comando.Parameters.Add(new SqlParameter("@tipoUsuario", u.IdTipoUsuario));
                bd.Comando.ExecuteNonQuery();
                bd.desconectar();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return false;
            }
        }

        public bool editarUsuario(Usuario u)
        {
            try
            {
                bd.actualizarBD("update usuario set nombre = @nombre, apellido = @apellido, dni = @dni, usuario = @user, contrasena = @pass, tipoUsuario = @tipoUsuario where id = @id");
                bd.Comando.Parameters.Add(new SqlParameter("@nombre", u.Nombre));
                bd.Comando.Parameters.Add(new SqlParameter("@apellido", u.Apellido));
                bd.Comando.Parameters.Add(new SqlParameter("@dni", u.Dni));
                bd.Comando.Parameters.Add(new SqlParameter("@user", u.NombreUsuario));
                bd.Comando.Parameters.Add(new SqlParameter("@pass", u.Contrasena));
                bd.Comando.Parameters.Add(new SqlParameter("@tipoUsuario", u.IdTipoUsuario));
                bd.Comando.Parameters.Add(new SqlParameter("@id", u.Id));
                bd.Comando.ExecuteNonQuery();
                bd.desconectar();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return false;
            }
        }

        public bool eliminarUsuario(Usuario u)
        {
            try
            {
                bd.actualizarBD("delete usuario where id = @id");
                bd.Comando.Parameters.Add(new SqlParameter("@id", u.Id));
                bd.Comando.ExecuteNonQuery();
                bd.desconectar();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return false;
            }
        }
    }
}
