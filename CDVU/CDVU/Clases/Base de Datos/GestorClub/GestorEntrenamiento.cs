using CDVU.Clases.Club;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace CDVU.Clases.Base_de_Datos.GestorClub
{
    class GestorEntrenamiento
    {
        AccesoBD bd;

        public GestorEntrenamiento()
        {
            bd = new AccesoBD();
        }

        public List<Turno> listaTurnoSegunIdEntrenamiento(int idEntrenamiento)
        {
            List<Turno> lista = new List<Turno>();
            bd.consultarBD("select t.id, convert(datetime,horaEntrada) horaEntrada, convert(datetime,horaSalida) horaSalida, dia idDia, d.nombre from Turno t join Turno_Entrenamiento te on t.id = te.turno join dia d on d.id = t.dia where te.entrenamiento = " + idEntrenamiento);
            while (bd.Lector.Read())
            {
                Turno t = new Turno();
                if (!bd.Lector.IsDBNull(0))
                    t.Id = bd.Lector.GetInt32(0);
                if (!bd.Lector.IsDBNull(1))
                    t.HoraEntrada = bd.Lector.GetDateTime(1);
                if (!bd.Lector.IsDBNull(2))
                    t.HoraSalida = bd.Lector.GetDateTime(2);
                if (!bd.Lector.IsDBNull(3))
                    t.IdDia = bd.Lector.GetInt32(3);
                if (!bd.Lector.IsDBNull(4))
                    t.Dia = bd.Lector.GetString(4);
                lista.Add(t);
            }
            bd.Lector.Close();
            bd.desconectar();
            return lista;
        }

        public List<Entrenamiento> listaEntrenamiento()
        {
            List<Entrenamiento> lista = new List<Entrenamiento>();
            bd.consultarBD("select * from vw_listaEntrenamiento order by idDeporte");
            while (bd.Lector.Read())
            {
                Entrenamiento entrenamiento = new Entrenamiento();
                if (!bd.Lector.IsDBNull(0))
                    entrenamiento.Id = bd.Lector.GetInt32(0);

                Deporte deporte = new Deporte();
                if (!bd.Lector.IsDBNull(1))
                    deporte.Id = bd.Lector.GetInt32(1);
                if (!bd.Lector.IsDBNull(2))
                    deporte.Nombre = bd.Lector.GetString(2);
                if (!bd.Lector.IsDBNull(3))
                    deporte.Clasificacion = new ClasificacionDeporte(bd.Lector.GetInt32(3), bd.Lector.GetString(4));

                Predio predio = new Predio();
                if (!bd.Lector.IsDBNull(5))
                    predio.Id = bd.Lector.GetInt32(5);
                if (!bd.Lector.IsDBNull(6))
                    predio.Descripcion = bd.Lector.GetString(6);

                entrenamiento.Deporte = deporte;
                entrenamiento.Predio = predio;

                if (!bd.Lector.IsDBNull(7))
                    entrenamiento.PrecioMensual = bd.Lector.GetDouble(7);
                if (!bd.Lector.IsDBNull(8))
                    entrenamiento.PrecioMatricula = bd.Lector.GetDouble(8);
                if (!bd.Lector.IsDBNull(9))
                    entrenamiento.CantidadCuotas = bd.Lector.GetInt32(9);

                lista.Add(entrenamiento);
            }
            bd.Lector.Close();
            bd.desconectar();
            return lista;
        }

        public List<Entrenamiento> listaEntrenamientoInscriptoSegunIdSocio(int idSocio)
        {
            List<Entrenamiento> lista = new List<Entrenamiento>();
            bd.consultarBD("select e.id idEntrenamiento, d.id idDeporte, d.nombre nombreDeporte, d.id_clasificacion, dc.nombre tipoDeporte, p.id idPredio, p.descripcion, e.precioMensual, e.precioMatricula, e.cantidadCuotas from Entrenamiento e join Deporte d on d.id = e.deporte join Deporte_Clasificacion dc on d.id_clasificacion = dc.id join Predio p on p.id = e.predio join Inscripcion i on i.entrenamiento = e.id where i.socio = " + idSocio);
            while (bd.Lector.Read())
            {
                Entrenamiento entrenamiento = new Entrenamiento();
                if (!bd.Lector.IsDBNull(0))
                    entrenamiento.Id = bd.Lector.GetInt32(0);

                Deporte deporte = new Deporte();
                if (!bd.Lector.IsDBNull(1))
                    deporte.Id = bd.Lector.GetInt32(1);
                if (!bd.Lector.IsDBNull(2))
                    deporte.Nombre = bd.Lector.GetString(2);
                if (!bd.Lector.IsDBNull(3))
                    deporte.Clasificacion = new ClasificacionDeporte(bd.Lector.GetInt32(3), bd.Lector.GetString(4));

                Predio predio = new Predio();
                if (!bd.Lector.IsDBNull(5))
                    predio.Id = bd.Lector.GetInt32(5);
                if (!bd.Lector.IsDBNull(6))
                    predio.Descripcion = bd.Lector.GetString(6);

                entrenamiento.Deporte = deporte;
                entrenamiento.Predio = predio;

                if (!bd.Lector.IsDBNull(7))
                    entrenamiento.PrecioMensual = bd.Lector.GetDouble(7);
                if (!bd.Lector.IsDBNull(8))
                    entrenamiento.PrecioMatricula = bd.Lector.GetDouble(8);
                if (!bd.Lector.IsDBNull(9))
                    entrenamiento.CantidadCuotas = bd.Lector.GetInt32(9);

                lista.Add(entrenamiento);
            }
            bd.Lector.Close();
            bd.desconectar();
            return lista;
        }

        public bool agregarTurnoEntrenamiento(TurnoEntrenamiento te)
        {
            try
            {
                bd.actualizarConTransaccion("insert into entrenamiento values(@idDeporte, @idPredio, @precioMensual, @precioMatricula, @cantidadCuotas); select SCOPE_IDENTITY()");
                bd.Comando.Parameters.Clear();
                bd.Comando.Parameters.AddWithValue("@idDeporte", te.Entrenamiento.Deporte.Id);
                bd.Comando.Parameters.AddWithValue("@idPredio", te.Entrenamiento.Predio.Id);
                bd.Comando.Parameters.AddWithValue("@precioMensual", te.Entrenamiento.PrecioMensual);
                bd.Comando.Parameters.AddWithValue("@precioMatricula", te.Entrenamiento.PrecioMatricula);
                bd.Comando.Parameters.AddWithValue("@cantidadCuotas", te.Entrenamiento.CantidadCuotas);
                te.Entrenamiento.Id = Convert.ToInt32(bd.Comando.ExecuteScalar());
                foreach (Turno t in te.ListaTurno)
                {
                    bd.Comando.CommandText = "insert into Turno values(@horaEntrada, @horaSalida, @idDia); select SCOPE_IDENTITY()";
                    bd.Comando.Parameters.Clear();
                    bd.Comando.Parameters.AddWithValue("@horaEntrada", t.HoraEntrada.TimeOfDay.ToString());
                    bd.Comando.Parameters.AddWithValue("@horaSalida", t.HoraSalida.TimeOfDay.ToString());
                    bd.Comando.Parameters.AddWithValue("@idDia", t.IdDia);
                    t.Id = Convert.ToInt32(bd.Comando.ExecuteScalar());

                    bd.Comando.CommandText = "insert into Turno_entrenamiento values(@idTurno, @idEntrenamiento)";
                    bd.Comando.Parameters.Clear();
                    bd.Comando.Parameters.AddWithValue("@idTurno", t.Id);
                    bd.Comando.Parameters.AddWithValue("@idEntrenamiento", te.Entrenamiento.Id);
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

        public bool modificarTurnoEntrenamiento(TurnoEntrenamiento te)
        {
            try
            {
                bd.actualizarConTransaccion("update entrenamiento set deporte = @idDeporte, predio = @idPredio, precioMensual = @precioMensual, precioMatricula = @precioMatricula, cantidadCuotas = @cantidadCuotas where id = @idEntrenamiento");
                bd.Comando.Parameters.Clear();
                bd.Comando.Parameters.AddWithValue("@idDeporte", te.Entrenamiento.Deporte.Id);
                bd.Comando.Parameters.AddWithValue("@idPredio", te.Entrenamiento.Predio.Id);
                bd.Comando.Parameters.AddWithValue("@precioMensual", te.Entrenamiento.PrecioMensual);
                bd.Comando.Parameters.AddWithValue("@precioMatricula", te.Entrenamiento.PrecioMatricula);
                bd.Comando.Parameters.AddWithValue("@cantidadCuotas", te.Entrenamiento.CantidadCuotas);
                bd.Comando.Parameters.AddWithValue("@idEntrenamiento", te.Entrenamiento.Id);
                bd.Comando.ExecuteNonQuery();

                bd.Comando.CommandText = "delete turno_entrenamiento where entrenamiento = " + te.Entrenamiento.Id;
                bd.Comando.ExecuteNonQuery();

                bd.Comando.CommandText = "delete t from turno t join turno_entrenamiento te on te.turno = t.id where te.entrenamiento = " + te.Entrenamiento.Id;
                bd.Comando.ExecuteNonQuery();

                foreach (Turno t in te.ListaTurno)
                {
                    bd.Comando.CommandText = "insert into Turno values(@horaEntrada, @horaSalida, @idDia); select SCOPE_IDENTITY()";
                    bd.Comando.Parameters.Clear();
                    bd.Comando.Parameters.AddWithValue("@horaEntrada", t.HoraEntrada.TimeOfDay.ToString());
                    bd.Comando.Parameters.AddWithValue("@horaSalida", t.HoraSalida.TimeOfDay.ToString());
                    bd.Comando.Parameters.AddWithValue("@idDia", t.IdDia);
                    t.Id = Convert.ToInt32(bd.Comando.ExecuteScalar());

                    bd.Comando.CommandText = "insert into Turno_entrenamiento values(@idTurno, @idEntrenamiento)";
                    bd.Comando.Parameters.Clear();
                    bd.Comando.Parameters.AddWithValue("@idTurno", t.Id);
                    bd.Comando.Parameters.AddWithValue("@idEntrenamiento", te.Entrenamiento.Id);
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

        public bool eliminarEntrenamiento(TurnoEntrenamiento te)
        {
            try
            {
                bd.actualizarBD("delete Entrenamiento where id = @id");
                bd.Comando.Parameters.Add(new SqlParameter("@id", te.Entrenamiento.Id));
                bd.Comando.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return false;
            }
            finally
            {
                bd.desconectar();
            }
        }

        public List<Predio> listaPredios()
        {
            List<Predio> lista = new List<Predio>();
            bd.consultarBD("select * from predio");
            while (bd.Lector.Read())
            {
                Predio predio = new Predio();
                if (!bd.Lector.IsDBNull(0))
                    predio.Id = bd.Lector.GetInt32(0);
                if (!bd.Lector.IsDBNull(1))
                    predio.Descripcion = bd.Lector.GetString(1);
                lista.Add(predio);
            }
            bd.Lector.Close();
            bd.desconectar();
            return lista;
        }

        public List<Predio> listaPredioSegunIdDeporte(int idDeporte)
        {
            List<Predio> lista = new List<Predio>();
            bd.consultarBD("select e.predio idPredio, p.descripcion from Entrenamiento e join Deporte d on e.deporte = d.id join Predio p on e.predio = p.id where e.deporte = " + idDeporte);
            while (bd.Lector.Read())
            {
                Predio predio = new Predio();
                if (!bd.Lector.IsDBNull(0))
                    predio.Id = bd.Lector.GetInt32(0);
                if (!bd.Lector.IsDBNull(1))
                    predio.Descripcion = bd.Lector.GetString(1);
                lista.Add(predio);
            }
            bd.Lector.Close();
            bd.desconectar();
            return lista;
        }

        public bool agregarPredio(Predio p)
        {
            try
            {
                bd.actualizarBD("insert into predio values(@descripcion)");
                bd.Comando.Parameters.Add(new SqlParameter("@descripcion", p.Descripcion));
                bd.Comando.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return false;
            }
            finally
            {
                bd.desconectar();
            }
        }

        public bool modificarPredio(Predio p)
        {
            try
            {
                bd.actualizarBD("update predio set descripcion = @descripcion where id = @id");
                bd.Comando.Parameters.Add(new SqlParameter("@descripcion", p.Descripcion));
                bd.Comando.Parameters.Add(new SqlParameter("@id", p.Id));
                bd.Comando.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return false;
            }
            finally
            {
                bd.desconectar();
            }
        }

        public bool eliminarPredio(Predio p)
        {
            try
            {
                bd.actualizarBD("delete predio where id = @id");
                bd.Comando.Parameters.Add(new SqlParameter("@id", p.Id));
                bd.Comando.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return false;
            }
            finally
            {
                bd.desconectar();
            }
        }
    }
}
