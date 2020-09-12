using CDVU.Clases.Lugares;
using CDVU.Personas;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace CDVU.Clases.Base_de_Datos.GestorPersonas
{
    class GestorTutor
    {
        AccesoBD bd;

        public GestorTutor()
        {
            bd = new AccesoBD();
        }

        public List<Tutor> listaTutores()
        {
            List<Tutor> lista = new List<Tutor>();
            bd.consultarBD("select * from vw_listaTutores order by id");
            while (bd.Lector.Read())
            {
                Tutor tutor = new Tutor();
                if (!bd.Lector.IsDBNull(0))
                    tutor.Id = bd.Lector.GetInt32(0);
                if (!bd.Lector.IsDBNull(1))
                    tutor.Nombre = bd.Lector.GetString(1);
                if (!bd.Lector.IsDBNull(2))
                    tutor.Apellido = bd.Lector.GetString(2);
                if (!bd.Lector.IsDBNull(3))
                    tutor.IdSexo = bd.Lector.GetInt32(3);
                if (!bd.Lector.IsDBNull(4))
                    tutor.Sexo = bd.Lector.GetString(4);
                if (!bd.Lector.IsDBNull(5))
                    tutor.Dni = bd.Lector.GetString(5);
                if (!bd.Lector.IsDBNull(6))
                    tutor.Domicilio = bd.Lector.GetString(6);
                if (!bd.Lector.IsDBNull(7))
                    tutor.Localidad = new Localidad(bd.Lector.GetInt32(7), bd.Lector.GetString(8), new Provincia(bd.Lector.GetInt32(9), bd.Lector.GetString(10)));
                if (!bd.Lector.IsDBNull(11))
                    tutor.Telefono = bd.Lector.GetString(11);
                if (!bd.Lector.IsDBNull(12))
                    tutor.Email = bd.Lector.GetString(12);
                if (!bd.Lector.IsDBNull(13))
                    tutor.FechaNacimiento = bd.Lector.GetDateTime(13);
                if (!bd.Lector.IsDBNull(14))
                    tutor.Nacionalidad = new Pais(bd.Lector.GetInt32(14), bd.Lector.GetString(15));
                lista.Add(tutor);
            }
            bd.Lector.Close();
            bd.desconectar();
            return lista;
        }

        public Tutor obtenerTutorPorId(int id)
        {
            Tutor tutor = new Tutor();
            bd.consultarBD("select * from vw_listaTutores where id = " + id);
            if (bd.Lector.Read())
            {
                if (!bd.Lector.IsDBNull(0))
                    tutor.Id = bd.Lector.GetInt32(0);
                if (!bd.Lector.IsDBNull(1))
                    tutor.Nombre = bd.Lector.GetString(1);
                if (!bd.Lector.IsDBNull(2))
                    tutor.Apellido = bd.Lector.GetString(2);
                if (!bd.Lector.IsDBNull(3))
                    tutor.IdSexo = bd.Lector.GetInt32(3);
                if (!bd.Lector.IsDBNull(4))
                    tutor.Sexo = bd.Lector.GetString(4);
                if (!bd.Lector.IsDBNull(5))
                    tutor.Dni = bd.Lector.GetString(5);
                if (!bd.Lector.IsDBNull(6))
                    tutor.Domicilio = bd.Lector.GetString(6);
                if (!bd.Lector.IsDBNull(7))
                    tutor.Localidad = new Localidad(bd.Lector.GetInt32(7), bd.Lector.GetString(8), new Provincia(bd.Lector.GetInt32(9), bd.Lector.GetString(10)));
                if (!bd.Lector.IsDBNull(11))
                    tutor.Telefono = bd.Lector.GetString(11);
                if (!bd.Lector.IsDBNull(12))
                    tutor.Email = bd.Lector.GetString(12);
                if (!bd.Lector.IsDBNull(13))
                    tutor.FechaNacimiento = bd.Lector.GetDateTime(13);
                if (!bd.Lector.IsDBNull(14))
                    tutor.Nacionalidad = new Pais(bd.Lector.GetInt32(14), bd.Lector.GetString(15));
            }
            bd.Lector.Close();
            bd.desconectar();
            return tutor;
        }

        public Tutor obtenerTutorPorDNI(string dni)
        {
            Tutor tutor = new Tutor();
            bd.consultarBD("select * from vw_listaTutores where dni like '" + dni + "'");
            if (bd.Lector.Read())
            {
                if (!bd.Lector.IsDBNull(0))
                    tutor.Id = bd.Lector.GetInt32(0);
                if (!bd.Lector.IsDBNull(1))
                    tutor.Nombre = bd.Lector.GetString(1);
                if (!bd.Lector.IsDBNull(2))
                    tutor.Apellido = bd.Lector.GetString(2);
                if (!bd.Lector.IsDBNull(3))
                    tutor.IdSexo = bd.Lector.GetInt32(3);
                if (!bd.Lector.IsDBNull(4))
                    tutor.Sexo = bd.Lector.GetString(4);
                if (!bd.Lector.IsDBNull(5))
                    tutor.Dni = bd.Lector.GetString(5);
                if (!bd.Lector.IsDBNull(6))
                    tutor.Domicilio = bd.Lector.GetString(6);
                if (!bd.Lector.IsDBNull(7))
                    tutor.Localidad = new Localidad(bd.Lector.GetInt32(7), bd.Lector.GetString(8), new Provincia(bd.Lector.GetInt32(9), bd.Lector.GetString(10)));
                if (!bd.Lector.IsDBNull(11))
                    tutor.Telefono = bd.Lector.GetString(11);
                if (!bd.Lector.IsDBNull(12))
                    tutor.Email = bd.Lector.GetString(12);
                if (!bd.Lector.IsDBNull(13))
                    tutor.FechaNacimiento = bd.Lector.GetDateTime(13);
                if (!bd.Lector.IsDBNull(14))
                    tutor.Nacionalidad = new Pais(bd.Lector.GetInt32(14), bd.Lector.GetString(15));
            }
            bd.Lector.Close();
            bd.desconectar();
            return tutor;
        }

        public List<Socio> listaSociosACargoDelTutor(int idTutor)
        {
            List<Socio> lista = new List<Socio>();
            bd.consultarBD("select * from vw_listaSocios where idTutor = " + idTutor);
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

        public bool agregarTutor(Tutor t)
        {
            try
            {
                bd.actualizarBD("insert into tutor values(@nombre, @apellido, @idSexo, @dni, @domicilio, @localidad, @telefono, @email, @fechaNacimiento, @nacionalidad)");
                bd.Comando.Parameters.Add(new SqlParameter("@nombre", t.Nombre));
                bd.Comando.Parameters.Add(new SqlParameter("@apellido", t.Apellido));
                bd.Comando.Parameters.Add(new SqlParameter("@idSexo", t.IdSexo));
                bd.Comando.Parameters.Add(new SqlParameter("@dni", t.Dni));
                bd.Comando.Parameters.Add(new SqlParameter("@domicilio", t.Domicilio));
                bd.Comando.Parameters.Add(new SqlParameter("@localidad", t.Localidad.Id));
                bd.Comando.Parameters.Add(new SqlParameter("@telefono", t.Telefono));
                bd.Comando.Parameters.Add(new SqlParameter("@email", t.Email));
                bd.Comando.Parameters.Add(new SqlParameter("@fechaNacimiento", t.FechaNacimiento));
                bd.Comando.Parameters.Add(new SqlParameter("@nacionalidad", t.Nacionalidad.Id));
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

        public bool modificarTutor(Tutor t)
        {
            try
            {
                bd.actualizarBD("update tutor set nombre = @nombre, apellido = @apellido, sexo = @idSexo, dni = @dni, domicilio = @domicilio, localidad = @localidad, telefono = @telefono, email = @email, fechaNacimiento = @fechaNacimiento, nacionalidad = @nacionalidad where id = @id");
                bd.Comando.Parameters.Add(new SqlParameter("@nombre", t.Nombre));
                bd.Comando.Parameters.Add(new SqlParameter("@apellido", t.Apellido));
                bd.Comando.Parameters.Add(new SqlParameter("@idSexo", t.IdSexo));
                bd.Comando.Parameters.Add(new SqlParameter("@dni", t.Dni));
                bd.Comando.Parameters.Add(new SqlParameter("@domicilio", t.Domicilio));
                bd.Comando.Parameters.Add(new SqlParameter("@localidad", t.Localidad.Id));
                bd.Comando.Parameters.Add(new SqlParameter("@telefono", t.Telefono));
                bd.Comando.Parameters.Add(new SqlParameter("@email", t.Email));
                bd.Comando.Parameters.Add(new SqlParameter("@fechaNacimiento", t.FechaNacimiento));
                bd.Comando.Parameters.Add(new SqlParameter("@nacionalidad", t.Nacionalidad.Id));
                bd.Comando.Parameters.Add(new SqlParameter("@id", t.Id));
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

        public bool eliminarTutor(Tutor t)
        {
            try
            {
                bd.actualizarBD("delete tutor where id = @id");
                bd.Comando.Parameters.Add(new SqlParameter("@id", t.Id));
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
