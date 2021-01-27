using CDVU.Clases.Lugares;
using CDVU.Personas;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace CDVU.Clases.Base_de_Datos
{
    class GestorSocio
    {
        AccesoBD bd;

        public GestorSocio()
        {
            bd = new AccesoBD();
        }

        public List<Socio> listaSocios()
        {
            List<Socio> lista = new List<Socio>();
            bd.consultarBD("select * from vw_listaSocios order by id");
            while (bd.Lector.Read())
            {
                Socio socio = new Socio();
                if (!bd.Lector.IsDBNull(0))
                    socio.Id = bd.Lector.GetInt32(0);
                if (!bd.Lector.IsDBNull(1))
                    socio.Nombre = bd.Lector.GetString(1);
                if (!bd.Lector.IsDBNull(2))
                    socio.Apellido = bd.Lector.GetString(2);
                if (!bd.Lector.IsDBNull(3))
                    socio.IdSexo = bd.Lector.GetInt32(3);
                if (!bd.Lector.IsDBNull(4))
                    socio.Sexo= bd.Lector.GetString(4);
                if (!bd.Lector.IsDBNull(5))
                    socio.Dni = bd.Lector.GetString(5);
                if (!bd.Lector.IsDBNull(6))
                    socio.Domicilio = bd.Lector.GetString(6);
                if (!bd.Lector.IsDBNull(7))
                    socio.Localidad = new Localidad(bd.Lector.GetInt32(7), bd.Lector.GetString(8), new Provincia(bd.Lector.GetInt32(9), bd.Lector.GetString(10)));
                if (!bd.Lector.IsDBNull(11))
                    socio.Telefono = bd.Lector.GetString(11);
                if (!bd.Lector.IsDBNull(12))
                    socio.Email = bd.Lector.GetString(12);
                if (!bd.Lector.IsDBNull(13))
                    socio.FechaNacimiento = bd.Lector.GetDateTime(13);
                if (!bd.Lector.IsDBNull(14))
                    socio.Nacionalidad = new Pais(bd.Lector.GetInt32(14), bd.Lector.GetString(15));
                if (!bd.Lector.IsDBNull(16))
                    socio.Tutor = new Tutor(bd.Lector.GetInt32(16), bd.Lector.GetString(17), bd.Lector.GetString(18), bd.Lector.GetInt32(19), bd.Lector.GetString(20), bd.Lector.GetString(21), bd.Lector.GetString(22), new Localidad(bd.Lector.GetInt32(23), bd.Lector.GetString(8), new Provincia(bd.Lector.GetInt32(9), bd.Lector.GetString(10))), bd.Lector.GetString(24), bd.Lector.GetString(25), bd.Lector.GetDateTime(26), new Pais(bd.Lector.GetInt32(27), bd.Lector.GetString(15)));
                else
                    socio.Tutor = null;
                lista.Add(socio);
            }
            bd.Lector.Close();
            bd.desconectar();
            return lista;
        }

        public List<Socio> listaSociosSegunIdTutor(int idTutor)
        {
            List<Socio> lista = new List<Socio>();
            bd.consultarBD("select * from vw_listaSocios where idTutor = " + idTutor + " order by id");
            while (bd.Lector.Read())
            {
                Socio socio = new Socio();
                if (!bd.Lector.IsDBNull(0))
                    socio.Id = bd.Lector.GetInt32(0);
                if (!bd.Lector.IsDBNull(1))
                    socio.Nombre = bd.Lector.GetString(1);
                if (!bd.Lector.IsDBNull(2))
                    socio.Apellido = bd.Lector.GetString(2);
                if (!bd.Lector.IsDBNull(3))
                    socio.IdSexo = bd.Lector.GetInt32(3);
                if (!bd.Lector.IsDBNull(4))
                    socio.Sexo = bd.Lector.GetString(4);
                if (!bd.Lector.IsDBNull(5))
                    socio.Dni = bd.Lector.GetString(5);
                if (!bd.Lector.IsDBNull(6))
                    socio.Domicilio = bd.Lector.GetString(6);
                if (!bd.Lector.IsDBNull(7))
                    socio.Localidad = new Localidad(bd.Lector.GetInt32(7), bd.Lector.GetString(8), new Provincia(bd.Lector.GetInt32(9), bd.Lector.GetString(10)));
                if (!bd.Lector.IsDBNull(11))
                    socio.Telefono = bd.Lector.GetString(11);
                if (!bd.Lector.IsDBNull(12))
                    socio.Email = bd.Lector.GetString(12);
                if (!bd.Lector.IsDBNull(13))
                    socio.FechaNacimiento = bd.Lector.GetDateTime(13);
                if (!bd.Lector.IsDBNull(14))
                    socio.Nacionalidad = new Pais(bd.Lector.GetInt32(14), bd.Lector.GetString(15));
                if (!bd.Lector.IsDBNull(16))
                    socio.Tutor = new Tutor(bd.Lector.GetInt32(16), bd.Lector.GetString(17), bd.Lector.GetString(18), bd.Lector.GetInt32(19), bd.Lector.GetString(20), bd.Lector.GetString(21), bd.Lector.GetString(22), new Localidad(bd.Lector.GetInt32(23), bd.Lector.GetString(8), new Provincia(bd.Lector.GetInt32(9), bd.Lector.GetString(10))), bd.Lector.GetString(24), bd.Lector.GetString(25), bd.Lector.GetDateTime(26), new Pais(bd.Lector.GetInt32(27), bd.Lector.GetString(15)));
                else
                    socio.Tutor = null;
                lista.Add(socio);
            }
            bd.Lector.Close();
            bd.desconectar();
            return lista;
        }

        public List<Socio> listaSociosInscriptos(int idEntrenamiento)
        {
            List<Socio> lista = new List<Socio>();
            bd.consultarBD("select * from vw_listaSocios s join Inscripcion i on s.id = i.socio join Entrenamiento e on e.id = i.entrenamiento where e.id = " + idEntrenamiento);
            while (bd.Lector.Read())
            {
                Socio socio = new Socio();
                if (!bd.Lector.IsDBNull(0))
                    socio.Id = bd.Lector.GetInt32(0);
                if (!bd.Lector.IsDBNull(1))
                    socio.Nombre = bd.Lector.GetString(1);
                if (!bd.Lector.IsDBNull(2))
                    socio.Apellido = bd.Lector.GetString(2);
                if (!bd.Lector.IsDBNull(3))
                    socio.IdSexo = bd.Lector.GetInt32(3);
                if (!bd.Lector.IsDBNull(4))
                    socio.Sexo = bd.Lector.GetString(4);
                if (!bd.Lector.IsDBNull(5))
                    socio.Dni = bd.Lector.GetString(5);
                if (!bd.Lector.IsDBNull(6))
                    socio.Domicilio = bd.Lector.GetString(6);
                if (!bd.Lector.IsDBNull(7))
                    socio.Localidad = new Localidad(bd.Lector.GetInt32(7), bd.Lector.GetString(8), new Provincia(bd.Lector.GetInt32(9), bd.Lector.GetString(10)));
                if (!bd.Lector.IsDBNull(11))
                    socio.Telefono = bd.Lector.GetString(11);
                if (!bd.Lector.IsDBNull(12))
                    socio.Email = bd.Lector.GetString(12);
                if (!bd.Lector.IsDBNull(13))
                    socio.FechaNacimiento = bd.Lector.GetDateTime(13);
                if (!bd.Lector.IsDBNull(14))
                    socio.Nacionalidad = new Pais(bd.Lector.GetInt32(14), bd.Lector.GetString(15));
                if (!bd.Lector.IsDBNull(16))
                    socio.Tutor = new Tutor(bd.Lector.GetInt32(16), bd.Lector.GetString(17), bd.Lector.GetString(18), bd.Lector.GetInt32(19), bd.Lector.GetString(20), bd.Lector.GetString(21), bd.Lector.GetString(22), new Localidad(bd.Lector.GetInt32(23), bd.Lector.GetString(8), new Provincia(bd.Lector.GetInt32(9), bd.Lector.GetString(10))), bd.Lector.GetString(24), bd.Lector.GetString(25), bd.Lector.GetDateTime(26), new Pais(bd.Lector.GetInt32(27), bd.Lector.GetString(15)));
                else
                    socio.Tutor = null;
                lista.Add(socio);
            }
            bd.Lector.Close();
            bd.desconectar();
            return lista;
        }

        public Socio obtenerSocioPorDNI(string dni)
        {
            Socio socio = new Socio();
            bd.consultarBD("select * from vw_listaSocios where dni like '" + dni + "'");
            if (bd.Lector.Read())
            {
                if (!bd.Lector.IsDBNull(0))
                    socio.Id = bd.Lector.GetInt32(0);
                if (!bd.Lector.IsDBNull(1))
                    socio.Nombre = bd.Lector.GetString(1);
                if (!bd.Lector.IsDBNull(2))
                    socio.Apellido = bd.Lector.GetString(2);
                if (!bd.Lector.IsDBNull(3))
                    socio.IdSexo = bd.Lector.GetInt32(3);
                if (!bd.Lector.IsDBNull(4))
                    socio.Sexo = bd.Lector.GetString(4);
                if (!bd.Lector.IsDBNull(5))
                    socio.Dni = bd.Lector.GetString(5);
                if (!bd.Lector.IsDBNull(6))
                    socio.Domicilio = bd.Lector.GetString(6);
                if (!bd.Lector.IsDBNull(7))
                    socio.Localidad = new Localidad(bd.Lector.GetInt32(7), bd.Lector.GetString(8), new Provincia(bd.Lector.GetInt32(9), bd.Lector.GetString(10)));
                if (!bd.Lector.IsDBNull(11))
                    socio.Telefono = bd.Lector.GetString(11);
                if (!bd.Lector.IsDBNull(12))
                    socio.Email = bd.Lector.GetString(12);
                if (!bd.Lector.IsDBNull(13))
                    socio.FechaNacimiento = bd.Lector.GetDateTime(13);
                if (!bd.Lector.IsDBNull(14))
                    socio.Nacionalidad = new Pais(bd.Lector.GetInt32(14), bd.Lector.GetString(15));
                if (!bd.Lector.IsDBNull(16))
                    socio.Tutor = new Tutor(bd.Lector.GetInt32(16), bd.Lector.GetString(17), bd.Lector.GetString(18), bd.Lector.GetInt32(19), bd.Lector.GetString(20), bd.Lector.GetString(21), bd.Lector.GetString(22), new Localidad(bd.Lector.GetInt32(23), bd.Lector.GetString(8), new Provincia(bd.Lector.GetInt32(9), bd.Lector.GetString(10))), bd.Lector.GetString(24), bd.Lector.GetString(25), bd.Lector.GetDateTime(26), new Pais(bd.Lector.GetInt32(27), bd.Lector.GetString(15)));
                else
                    socio.Tutor = null;
            }
            else
                socio = null;
            bd.Lector.Close();
            bd.desconectar();
            return socio;
        }

        public Socio obtenerSocioPorId(int id)
        {
            Socio socio = new Socio();
            bd.consultarBD("select * from vw_listaSocios where id = " + id);
            if (bd.Lector.Read())
            {
                if (!bd.Lector.IsDBNull(0))
                    socio.Id = bd.Lector.GetInt32(0);
                if (!bd.Lector.IsDBNull(1))
                    socio.Nombre = bd.Lector.GetString(1);
                if (!bd.Lector.IsDBNull(2))
                    socio.Apellido = bd.Lector.GetString(2);
                if (!bd.Lector.IsDBNull(3))
                    socio.IdSexo = bd.Lector.GetInt32(3);
                if (!bd.Lector.IsDBNull(4))
                    socio.Sexo = bd.Lector.GetString(4);
                if (!bd.Lector.IsDBNull(5))
                    socio.Dni = bd.Lector.GetString(5);
                if (!bd.Lector.IsDBNull(6))
                    socio.Domicilio = bd.Lector.GetString(6);
                if (!bd.Lector.IsDBNull(7))
                    socio.Localidad = new Localidad(bd.Lector.GetInt32(7), bd.Lector.GetString(8), new Provincia(bd.Lector.GetInt32(9), bd.Lector.GetString(10)));
                if (!bd.Lector.IsDBNull(11))
                    socio.Telefono = bd.Lector.GetString(11);
                if (!bd.Lector.IsDBNull(12))
                    socio.Email = bd.Lector.GetString(12);
                if (!bd.Lector.IsDBNull(13))
                    socio.FechaNacimiento = bd.Lector.GetDateTime(13);
                if (!bd.Lector.IsDBNull(14))
                    socio.Nacionalidad = new Pais(bd.Lector.GetInt32(14), bd.Lector.GetString(15));
                if (!bd.Lector.IsDBNull(16))
                    socio.Tutor = new Tutor(bd.Lector.GetInt32(16), bd.Lector.GetString(17), bd.Lector.GetString(18), bd.Lector.GetInt32(19), bd.Lector.GetString(20), bd.Lector.GetString(21), bd.Lector.GetString(22), new Localidad(bd.Lector.GetInt32(23), bd.Lector.GetString(8), new Provincia(bd.Lector.GetInt32(9), bd.Lector.GetString(10))), bd.Lector.GetString(24), bd.Lector.GetString(25), bd.Lector.GetDateTime(26), new Pais(bd.Lector.GetInt32(27), bd.Lector.GetString(15)));
                else
                    socio.Tutor = null;
            }
            else
                socio = null;
            bd.Lector.Close();
            bd.desconectar();
            return socio;
        }

        public bool agregarSocio(Socio s)
        {
            try
            {
                bd.actualizarBD("insert into Socio values(@nombre, @apellido, @idSexo, @dni, @domicilio, @localidad, @telefono, @email, @fechaNacimiento, @nacionalidad, @tutor)");
                bd.Comando.Parameters.Add(new SqlParameter("@nombre", s.Nombre));
                bd.Comando.Parameters.Add(new SqlParameter("@apellido", s.Apellido));
                bd.Comando.Parameters.Add(new SqlParameter("@idSexo", s.IdSexo));
                bd.Comando.Parameters.Add(new SqlParameter("@dni", s.Dni));
                bd.Comando.Parameters.Add(new SqlParameter("@domicilio", s.Domicilio));
                bd.Comando.Parameters.Add(new SqlParameter("@localidad", s.Localidad.Id));
                bd.Comando.Parameters.Add(new SqlParameter("@telefono", s.Telefono));
                bd.Comando.Parameters.Add(new SqlParameter("@email", s.Email));
                bd.Comando.Parameters.Add(new SqlParameter("@fechaNacimiento", s.FechaNacimiento));
                bd.Comando.Parameters.Add(new SqlParameter("@nacionalidad", s.Nacionalidad.Id));
                if (s.Tutor == null)
                    bd.Comando.Parameters.Add(new SqlParameter("@tutor", DBNull.Value));
                else
                    bd.Comando.Parameters.Add(new SqlParameter("@tutor", s.Tutor.Id));
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

        public bool modificarSocio(Socio s)
        {
            try
            {
                bd.actualizarBD("update socio set nombre = @nombre, apellido = @apellido, sexo = @idSexo, dni = @dni, domicilio = @domicilio, localidad = @localidad, telefono = @telefono, email = @email, fechaNacimiento = @fechaNacimiento, nacionalidad = @nacionalidad, tutor = @tutor where id = @id");
                bd.Comando.Parameters.Add(new SqlParameter("@nombre", s.Nombre));
                bd.Comando.Parameters.Add(new SqlParameter("@apellido", s.Apellido));
                bd.Comando.Parameters.Add(new SqlParameter("@idSexo", s.IdSexo));
                bd.Comando.Parameters.Add(new SqlParameter("@dni", s.Dni));
                bd.Comando.Parameters.Add(new SqlParameter("@domicilio", s.Domicilio));
                bd.Comando.Parameters.Add(new SqlParameter("@localidad", s.Localidad.Id));
                bd.Comando.Parameters.Add(new SqlParameter("@telefono", s.Telefono));
                bd.Comando.Parameters.Add(new SqlParameter("@email", s.Email));
                bd.Comando.Parameters.Add(new SqlParameter("@fechaNacimiento", s.FechaNacimiento));
                bd.Comando.Parameters.Add(new SqlParameter("@nacionalidad", s.Nacionalidad.Id));
                if (s.Tutor == null)
                    bd.Comando.Parameters.Add(new SqlParameter("@tutor", DBNull.Value));
                else
                    bd.Comando.Parameters.Add(new SqlParameter("@tutor", s.Tutor.Id));
                bd.Comando.Parameters.Add(new SqlParameter("@id", s.Id));
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

        public bool eliminarSocio(Socio s)
        {
            try
            {
                bd.actualizarBD("delete socio where id = @id");
                bd.Comando.Parameters.Add(new SqlParameter("@id", s.Id));
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
