using CDVU.Clases.Base_de_Datos.GestorClub;
using CDVU.Clases.Club;
using CDVU.Clases.Lugares;
using CDVU.Personas;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace CDVU.Clases.Base_de_Datos.GestorPersonas
{
    class GestorProfesor
    {
        AccesoBD bd;
        GestorDeporte gd;

        public GestorProfesor()
        {
            bd = new AccesoBD();
            gd = new GestorDeporte();
        }

        public List<DeporteProfesor> listaProfesor()
        {
            List<DeporteProfesor> lista = new List<DeporteProfesor>();
            bd.consultarBD("select * from vw_listaProfesores order by apellido");
            while (bd.Lector.Read())
            {
                Profesor profesor = new Profesor();
                if (!bd.Lector.IsDBNull(0))
                    profesor.Id = bd.Lector.GetInt32(0);
                if (!bd.Lector.IsDBNull(1))
                    profesor.Nombre = bd.Lector.GetString(1);
                if (!bd.Lector.IsDBNull(2))
                    profesor.Apellido = bd.Lector.GetString(2);
                if (!bd.Lector.IsDBNull(3))
                    profesor.IdSexo = bd.Lector.GetInt32(3);
                if (!bd.Lector.IsDBNull(4))
                    profesor.Sexo = bd.Lector.GetString(4);
                if (!bd.Lector.IsDBNull(5))
                    profesor.Dni = bd.Lector.GetString(5);
                if (!bd.Lector.IsDBNull(6))
                    profesor.Domicilio = bd.Lector.GetString(6);
                if (!bd.Lector.IsDBNull(7))
                    profesor.Localidad = new Localidad(bd.Lector.GetInt32(7), bd.Lector.GetString(8), new Provincia(bd.Lector.GetInt32(9), bd.Lector.GetString(10)));
                if (!bd.Lector.IsDBNull(11))
                    profesor.Telefono = bd.Lector.GetString(11);
                if (!bd.Lector.IsDBNull(12))
                    profesor.Email = bd.Lector.GetString(12);
                if (!bd.Lector.IsDBNull(13))
                    profesor.FechaNacimiento = bd.Lector.GetDateTime(13);
                if (!bd.Lector.IsDBNull(14))
                    profesor.Nacionalidad = new Pais(bd.Lector.GetInt32(14), bd.Lector.GetString(15));
                if (!bd.Lector.IsDBNull(16))
                    profesor.Matricula = bd.Lector.GetString(16);
                DeporteProfesor dp = new DeporteProfesor();
                dp.Profesor = profesor;
                lista.Add(dp);
            }
            bd.Lector.Close();
            bd.desconectar();
            return lista;
        }

        public List<Profesor> listaProfesorSegunIdDeporte(int idDeporte)
        {
            List<Profesor> lista = new List<Profesor>();
            bd.consultarBD("select * from vw_listaProfesoresPorDeporte where deporte = " + idDeporte);
            while (bd.Lector.Read())
            {
                Profesor profesor = new Profesor();
                if (!bd.Lector.IsDBNull(0))
                    profesor.Id = bd.Lector.GetInt32(0);
                if (!bd.Lector.IsDBNull(1))
                    profesor.Nombre = bd.Lector.GetString(1);
                if (!bd.Lector.IsDBNull(2))
                    profesor.Apellido = bd.Lector.GetString(2);
                if (!bd.Lector.IsDBNull(3))
                    profesor.IdSexo = bd.Lector.GetInt32(3);
                if (!bd.Lector.IsDBNull(4))
                    profesor.Sexo = bd.Lector.GetString(4);
                if (!bd.Lector.IsDBNull(5))
                    profesor.Dni = bd.Lector.GetString(5);
                if (!bd.Lector.IsDBNull(6))
                    profesor.Domicilio = bd.Lector.GetString(6);
                if (!bd.Lector.IsDBNull(7))
                    profesor.Localidad = new Localidad(bd.Lector.GetInt32(7), bd.Lector.GetString(8), new Provincia(bd.Lector.GetInt32(9), bd.Lector.GetString(10)));
                if (!bd.Lector.IsDBNull(11))
                    profesor.Telefono = bd.Lector.GetString(11);
                if (!bd.Lector.IsDBNull(12))
                    profesor.Email = bd.Lector.GetString(12);
                if (!bd.Lector.IsDBNull(13))
                    profesor.FechaNacimiento = bd.Lector.GetDateTime(13);
                if (!bd.Lector.IsDBNull(14))
                    profesor.Nacionalidad = new Pais(bd.Lector.GetInt32(14), bd.Lector.GetString(15));
                if (!bd.Lector.IsDBNull(16))
                    profesor.Matricula = bd.Lector.GetString(16);
                lista.Add(profesor);
            }
            bd.Lector.Close();
            bd.desconectar();
            return lista;
        }

        public Profesor obtenerProfesorPorId(int id)
        {
            Profesor profesor = new Profesor();
            bd.consultarBD("select * from vw_listaProfesores where id = " + id);
            if (bd.Lector.Read())
            {
                if (!bd.Lector.IsDBNull(0))
                    profesor.Id = bd.Lector.GetInt32(0);
                if (!bd.Lector.IsDBNull(1))
                    profesor.Nombre = bd.Lector.GetString(1);
                if (!bd.Lector.IsDBNull(2))
                    profesor.Apellido = bd.Lector.GetString(2);
                if (!bd.Lector.IsDBNull(3))
                    profesor.IdSexo = bd.Lector.GetInt32(3);
                if (!bd.Lector.IsDBNull(4))
                    profesor.Sexo = bd.Lector.GetString(4);
                if (!bd.Lector.IsDBNull(5))
                    profesor.Dni = bd.Lector.GetString(5);
                if (!bd.Lector.IsDBNull(6))
                    profesor.Domicilio = bd.Lector.GetString(6);
                if (!bd.Lector.IsDBNull(7))
                    profesor.Localidad = new Localidad(bd.Lector.GetInt32(7), bd.Lector.GetString(8), new Provincia(bd.Lector.GetInt32(9), bd.Lector.GetString(10)));
                if (!bd.Lector.IsDBNull(11))
                    profesor.Telefono = bd.Lector.GetString(11);
                if (!bd.Lector.IsDBNull(12))
                    profesor.Email = bd.Lector.GetString(12);
                if (!bd.Lector.IsDBNull(13))
                    profesor.FechaNacimiento = bd.Lector.GetDateTime(13);
                if (!bd.Lector.IsDBNull(14))
                    profesor.Nacionalidad = new Pais(bd.Lector.GetInt32(14), bd.Lector.GetString(15));
                if (!bd.Lector.IsDBNull(16))
                    profesor.Matricula = bd.Lector.GetString(16);
            }
            else
                profesor = null;
            bd.Lector.Close();
            bd.desconectar();
            return profesor;
        }

        public Profesor obtenerProfesorPorDNI(string dni)
        {
            Profesor profesor = new Profesor();
            bd.consultarBD("select * from vw_listaProfesores where dni like '" + dni + "'");
            if (bd.Lector.Read())
            {
                if (!bd.Lector.IsDBNull(0))
                    profesor.Id = bd.Lector.GetInt32(0);
                if (!bd.Lector.IsDBNull(1))
                    profesor.Nombre = bd.Lector.GetString(1);
                if (!bd.Lector.IsDBNull(2))
                    profesor.Apellido = bd.Lector.GetString(2);
                if (!bd.Lector.IsDBNull(3))
                    profesor.IdSexo = bd.Lector.GetInt32(3);
                if (!bd.Lector.IsDBNull(4))
                    profesor.Sexo = bd.Lector.GetString(4);
                if (!bd.Lector.IsDBNull(5))
                    profesor.Dni = bd.Lector.GetString(5);
                if (!bd.Lector.IsDBNull(6))
                    profesor.Domicilio = bd.Lector.GetString(6);
                if (!bd.Lector.IsDBNull(7))
                    profesor.Localidad = new Localidad(bd.Lector.GetInt32(7), bd.Lector.GetString(8), new Provincia(bd.Lector.GetInt32(9), bd.Lector.GetString(10)));
                if (!bd.Lector.IsDBNull(11))
                    profesor.Telefono = bd.Lector.GetString(11);
                if (!bd.Lector.IsDBNull(12))
                    profesor.Email = bd.Lector.GetString(12);
                if (!bd.Lector.IsDBNull(13))
                    profesor.FechaNacimiento = bd.Lector.GetDateTime(13);
                if (!bd.Lector.IsDBNull(14))
                    profesor.Nacionalidad = new Pais(bd.Lector.GetInt32(14), bd.Lector.GetString(15));
                if (!bd.Lector.IsDBNull(16))
                    profesor.Matricula = bd.Lector.GetString(16);
            }
            else
                profesor = null;
            bd.Lector.Close();
            bd.desconectar();
            return profesor;
        }

        public Profesor obtenerProfesorPorMatricula(string matricula)
        {
            Profesor profesor = new Profesor();
            bd.consultarBD("select * from vw_listaProfesores where matricula like '" + matricula + "'");
            if (bd.Lector.Read())
            {
                if (!bd.Lector.IsDBNull(0))
                    profesor.Id = bd.Lector.GetInt32(0);
                if (!bd.Lector.IsDBNull(1))
                    profesor.Nombre = bd.Lector.GetString(1);
                if (!bd.Lector.IsDBNull(2))
                    profesor.Apellido = bd.Lector.GetString(2);
                if (!bd.Lector.IsDBNull(3))
                    profesor.IdSexo = bd.Lector.GetInt32(3);
                if (!bd.Lector.IsDBNull(4))
                    profesor.Sexo = bd.Lector.GetString(4);
                if (!bd.Lector.IsDBNull(5))
                    profesor.Dni = bd.Lector.GetString(5);
                if (!bd.Lector.IsDBNull(6))
                    profesor.Domicilio = bd.Lector.GetString(6);
                if (!bd.Lector.IsDBNull(7))
                    profesor.Localidad = new Localidad(bd.Lector.GetInt32(7), bd.Lector.GetString(8), new Provincia(bd.Lector.GetInt32(9), bd.Lector.GetString(10)));
                if (!bd.Lector.IsDBNull(11))
                    profesor.Telefono = bd.Lector.GetString(11);
                if (!bd.Lector.IsDBNull(12))
                    profesor.Email = bd.Lector.GetString(12);
                if (!bd.Lector.IsDBNull(13))
                    profesor.FechaNacimiento = bd.Lector.GetDateTime(13);
                if (!bd.Lector.IsDBNull(14))
                    profesor.Nacionalidad = new Pais(bd.Lector.GetInt32(14), bd.Lector.GetString(15));
                if (!bd.Lector.IsDBNull(16))
                    profesor.Matricula = bd.Lector.GetString(16);
            }
            else
                profesor = null;
            bd.Lector.Close();
            bd.desconectar();
            return profesor;
        }

        public bool agregarDeporteProfesor(DeporteProfesor dp)
        {
            try
            {
                bd.actualizarConTransaccion("insert into profesor values(@nombre, @apellido, @idSexo, @dni, @domicilio, @localidad, @telefono, @email, @fechaNacimiento, @nacionalidad, @matricula); select SCOPE_IDENTITY()");
                bd.Comando.Parameters.Clear();
                bd.Comando.Parameters.AddWithValue("@nombre", dp.Profesor.Nombre);
                bd.Comando.Parameters.AddWithValue("@apellido", dp.Profesor.Apellido);
                bd.Comando.Parameters.AddWithValue("@idSexo", dp.Profesor.IdSexo);
                bd.Comando.Parameters.AddWithValue("@dni", dp.Profesor.Dni);
                bd.Comando.Parameters.AddWithValue("@domicilio", dp.Profesor.Domicilio);
                bd.Comando.Parameters.AddWithValue("@localidad", dp.Profesor.Localidad.Id);
                bd.Comando.Parameters.AddWithValue("@telefono", dp.Profesor.Telefono);
                bd.Comando.Parameters.AddWithValue("@email", dp.Profesor.Email);
                bd.Comando.Parameters.AddWithValue("@fechaNacimiento", dp.Profesor.FechaNacimiento);
                bd.Comando.Parameters.AddWithValue("@nacionalidad", dp.Profesor.Nacionalidad.Id);
                bd.Comando.Parameters.AddWithValue("@matricula", dp.Profesor.Matricula);
                dp.Profesor.Id = Convert.ToInt32(bd.Comando.ExecuteScalar());
                foreach (Deporte d in dp.ListaDeporte)
                {
                    bd.Comando.CommandText = "insert into Deporte_Profesor values(@idDeporte, @idProfesor)";
                    bd.Comando.Parameters.Clear();
                    bd.Comando.Parameters.AddWithValue("@idDeporte", d.Id);
                    bd.Comando.Parameters.AddWithValue("@idProfesor", dp.Profesor.Id);
                    bd.Comando.ExecuteNonQuery();
                }
                bd.Comando.Transaction.Commit();
                return true;
            }
            catch (Exception ex)
            {
                bd.Comando.Transaction.Rollback();
                Console.WriteLine(ex);
                return false;
            }
            finally
            {
                bd.desconectar();
            }
        }        

        public bool modificarDeporteProfesor(DeporteProfesor dp)
        {
            try
            {
                bd.actualizarConTransaccion("update profesor set nombre = @nombre, apellido = @apellido, sexo = @idSexo, dni = @dni, domicilio = @domicilio, localidad = @localidad, telefono = @telefono, email = @email, fechaNacimiento = @fechaNacimiento, nacionalidad = @nacionalidad, matricula = @matricula where id = @idProfesor");
                bd.Comando.Parameters.Clear();
                bd.Comando.Parameters.AddWithValue("@nombre", dp.Profesor.Nombre);
                bd.Comando.Parameters.AddWithValue("@apellido", dp.Profesor.Apellido);
                bd.Comando.Parameters.AddWithValue("@idSexo", dp.Profesor.IdSexo);
                bd.Comando.Parameters.AddWithValue("@dni", dp.Profesor.Dni);
                bd.Comando.Parameters.AddWithValue("@domicilio", dp.Profesor.Domicilio);
                bd.Comando.Parameters.AddWithValue("@localidad", dp.Profesor.Localidad.Id);
                bd.Comando.Parameters.AddWithValue("@telefono", dp.Profesor.Telefono);
                bd.Comando.Parameters.AddWithValue("@email", dp.Profesor.Email);
                bd.Comando.Parameters.AddWithValue("@fechaNacimiento", dp.Profesor.FechaNacimiento);
                bd.Comando.Parameters.AddWithValue("@nacionalidad", dp.Profesor.Nacionalidad.Id);
                bd.Comando.Parameters.AddWithValue("@matricula", dp.Profesor.Matricula);
                bd.Comando.Parameters.AddWithValue("@idProfesor", dp.Profesor.Id);
                bd.Comando.ExecuteNonQuery();

                bd.Comando.CommandText = "delete deporte_profesor where profesor = " + dp.Profesor.Id;
                bd.Comando.ExecuteNonQuery();

                foreach (Deporte d in dp.ListaDeporte)
                {
                    bd.Comando.CommandText = "insert into Deporte_Profesor values(@idDeporte, @idProfesor)";
                    bd.Comando.Parameters.Clear();
                    bd.Comando.Parameters.AddWithValue("@idDeporte", d.Id);
                    bd.Comando.Parameters.AddWithValue("@idProfesor", dp.Profesor.Id);
                    bd.Comando.ExecuteNonQuery();
                }
                bd.Comando.Transaction.Commit();
                return true;
            }
            catch (Exception ex)
            {
                bd.Comando.Transaction.Rollback();
                Console.WriteLine(ex);
                return false;
            }
            finally
            {
                bd.desconectar();
            }
        }

        public bool eliminarProfesor(DeporteProfesor dp)
        {
            try
            {
                bd.actualizarBD("delete profesor where id = @id");
                bd.Comando.Parameters.Add(new SqlParameter("@id", dp.Profesor.Id));
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
