using CDVU.Clases.Club;
using CDVU.Clases.Lugares;
using CDVU.Clases.Tesorería;
using CDVU.Personas;
using System;
using System.Collections.Generic;
using System.Threading;

namespace CDVU.Clases.Base_de_Datos.GestorClub
{
    class GestorTesoreria
    {
        AccesoBD bd;

        public GestorTesoreria()
        {
            bd = new AccesoBD();
        }

        public Recibo ultimoReciboGenerado()
        {
            Recibo recibo = new Recibo();
            bd.consultarBD("select top(1)r.id idRecibo, ls.id idSocio, nombre, apellido, idSexoSocio, sexoSocio, dni, domicilio, idLocalidad, nombreLocalidad, idProvincia, nombreProvincia, telefono, email, fechaNacimiento, idNacionalidad, nombrePais, idTutor, nombreTutor, apellidoTutor, idSexoTutor, sexoTutor, dniTutor, domicilioTutor, idLocalidadTutor, telefonoTutor, emailTutor, fechaNacimientoTutot, idNacionalidadTutor, fecha, montoTotal from Recibo r join vw_listaSocios ls on r.socio = ls.id order by r.id desc");
            if (bd.Lector.Read())
            {
                if (!bd.Lector.IsDBNull(0))
                    recibo.Id = bd.Lector.GetInt32(0);

                Socio socio = new Socio();
                if (!bd.Lector.IsDBNull(1))
                    socio.Id = bd.Lector.GetInt32(1);
                if (!bd.Lector.IsDBNull(2))
                    socio.Nombre = bd.Lector.GetString(2);
                if (!bd.Lector.IsDBNull(3))
                    socio.Apellido = bd.Lector.GetString(3);
                if (!bd.Lector.IsDBNull(4))
                    socio.IdSexo = bd.Lector.GetInt32(4);
                if (!bd.Lector.IsDBNull(5))
                    socio.Sexo = bd.Lector.GetString(5);
                if (!bd.Lector.IsDBNull(6))
                    socio.Dni = bd.Lector.GetString(6);
                if (!bd.Lector.IsDBNull(7))
                    socio.Domicilio = bd.Lector.GetString(7);
                if (!bd.Lector.IsDBNull(8))
                    socio.Localidad = new Localidad(bd.Lector.GetInt32(8), bd.Lector.GetString(9), new Provincia(bd.Lector.GetInt32(10), bd.Lector.GetString(11)));
                if (!bd.Lector.IsDBNull(12))
                    socio.Telefono = bd.Lector.GetString(12);
                if (!bd.Lector.IsDBNull(13))
                    socio.Email = bd.Lector.GetString(13);
                if (!bd.Lector.IsDBNull(14))
                    socio.FechaNacimiento = bd.Lector.GetDateTime(14);
                if (!bd.Lector.IsDBNull(15))
                    socio.Nacionalidad = new Pais(bd.Lector.GetInt32(15), bd.Lector.GetString(16));
                if (!bd.Lector.IsDBNull(17))
                    socio.Tutor = new Tutor(bd.Lector.GetInt32(17), bd.Lector.GetString(18), bd.Lector.GetString(19), bd.Lector.GetInt32(20), bd.Lector.GetString(21), bd.Lector.GetString(22), bd.Lector.GetString(23), new Localidad(bd.Lector.GetInt32(24), bd.Lector.GetString(9), new Provincia(bd.Lector.GetInt32(10), bd.Lector.GetString(11))), bd.Lector.GetString(25), bd.Lector.GetString(26), bd.Lector.GetDateTime(27), new Pais(bd.Lector.GetInt32(28), bd.Lector.GetString(16)));
                else
                    socio.Tutor = null;

                recibo.Socio = socio;

                if (!bd.Lector.IsDBNull(29))
                    recibo.Fecha = bd.Lector.GetDateTime(29);
                if (!bd.Lector.IsDBNull(30))
                    recibo.MontoTotal = bd.Lector.GetDouble(30);
            }
            else
                recibo = null;
            bd.Lector.Close();
            bd.desconectar();
            return recibo;
        }

        public List<Recibo> listaReciboSegunIdSocio(int idSocio)
        {
            List<Recibo> lista = new List<Recibo>();
            bd.consultarBD("SELECT r.id, s.id, s.nombre, s.apellido, s.sexo idSexoSocio, se.nombre sexoSocio,s.dni, s.domicilio, s.localidad idLocalidad, l.nombre nombreLocalidad, l.id_provincia idProvincia, pr.nombre nombreProvincia, s.telefono, s.email, s.fechaNacimiento, s.nacionalidad idNacionalidad, p.nombre nombrePais, s.tutor idTutor, t.nombre nombreTutor, t.apellido apellidoTutor, t.sexo idSexoTutor, se.nombre sexoTutor, t.dni dniTutor, t.domicilio domicilioTutor, t.localidad idLocalidadTutor, t.telefono telefonoTutor, t.email emailTutor, t.fechaNacimiento fechaNacimientoTutot, t.nacionalidad idNacionalidadTutor, r.fecha, r.montoTotal from Socio s left join Tutor t on t.id = s.tutor join Localidad l on l.id = s.localidad join Provincia pr on pr.id = l.id_provincia join Pais p on p.id = s.nacionalidad join Sexo se on se.id = s.sexo join recibo r on r.socio = s.id where s.id = " + idSocio);
            while (bd.Lector.Read())
            {
                Recibo recibo = new Recibo();

                if (!bd.Lector.IsDBNull(0))
                    recibo.Id = bd.Lector.GetInt32(0);

                Socio socio = new Socio();
                if (!bd.Lector.IsDBNull(1))
                    socio.Id = bd.Lector.GetInt32(1);
                if (!bd.Lector.IsDBNull(2))
                    socio.Nombre = bd.Lector.GetString(2);
                if (!bd.Lector.IsDBNull(3))
                    socio.Apellido = bd.Lector.GetString(3);
                if (!bd.Lector.IsDBNull(4))
                    socio.IdSexo = bd.Lector.GetInt32(4);
                if (!bd.Lector.IsDBNull(5))
                    socio.Sexo = bd.Lector.GetString(5);
                if (!bd.Lector.IsDBNull(6))
                    socio.Dni = bd.Lector.GetString(6);
                if (!bd.Lector.IsDBNull(7))
                    socio.Domicilio = bd.Lector.GetString(7);
                if (!bd.Lector.IsDBNull(8))
                    socio.Localidad = new Localidad(bd.Lector.GetInt32(8), bd.Lector.GetString(9), new Provincia(bd.Lector.GetInt32(10), bd.Lector.GetString(11)));
                if (!bd.Lector.IsDBNull(12))
                    socio.Telefono = bd.Lector.GetString(12);
                if (!bd.Lector.IsDBNull(13))
                    socio.Email = bd.Lector.GetString(13);
                if (!bd.Lector.IsDBNull(14))
                    socio.FechaNacimiento = bd.Lector.GetDateTime(14);
                if (!bd.Lector.IsDBNull(15))
                    socio.Nacionalidad = new Pais(bd.Lector.GetInt32(15), bd.Lector.GetString(16));
                if (!bd.Lector.IsDBNull(17))
                    socio.Tutor = new Tutor(bd.Lector.GetInt32(17), bd.Lector.GetString(18), bd.Lector.GetString(19), bd.Lector.GetInt32(20), bd.Lector.GetString(21), bd.Lector.GetString(22), bd.Lector.GetString(23), new Localidad(bd.Lector.GetInt32(24), bd.Lector.GetString(9), new Provincia(bd.Lector.GetInt32(10), bd.Lector.GetString(11))), bd.Lector.GetString(25), bd.Lector.GetString(26), bd.Lector.GetDateTime(27), new Pais(bd.Lector.GetInt32(28), bd.Lector.GetString(16)));
                else
                    socio.Tutor = null;

                recibo.Socio = socio;

                if (!bd.Lector.IsDBNull(29))
                    recibo.Fecha = bd.Lector.GetDateTime(29);
                if (!bd.Lector.IsDBNull(30))
                    recibo.MontoTotal = bd.Lector.GetDouble(30);

                lista.Add(recibo);
            }
            bd.Lector.Close();
            bd.desconectar();
            return lista;
        }

        public List<Pago> listaPagoSegunRecibo(int idRecibo)
        {
            List<Pago> lista = new List<Pago>();
            bd.consultarBD("select idInscripcion, idSocio, nombreSocio, apellidoSocio, idSexoSocio, sexoSocio, dniSocio, domicilioSocio, idLocalidad, nombreLocalidad, idProvincia, nombreProvincia, telefonoSocio, emailSocio, fechaNacimientoSocio, idNacionalidad, nacionalidadSocio, idTutor, nombreTutor, apellidoTutor, idSexoTutor, sexoTutor, dniTutor, domicilioTutor, idLocalidadTutor, telefonoTutor, emailTutor, fechaNacimientoTutor, idNacionalidadTutor, idEntrenamiento, idDeporte, nombreDeporte, id_clasificacion, tipoDeporte, idPredio, li.descripcion, precioMensual, precioMatricula, cantidadCuotas, li.fecha, li.estaSaldado, p.id idPago, p.descripcion descripcionPago, p.monto montoPago, p.numeroCuota numeroCuotaPagada from vw_listaInscripcion li right join Pago p on li.idInscripcion = p.inscripcion join Detalle_Recibo dr on dr.pago = p.id join Recibo r on r.id = dr.recibo where r.id = " + idRecibo);      
            while (bd.Lector.Read())
            {
                Inscripcion i = new Inscripcion();
                if (!bd.Lector.IsDBNull(0))
                    i.Id = bd.Lector.GetInt32(0);

                Socio socio = new Socio();
                if (!bd.Lector.IsDBNull(1))
                    socio.Id = bd.Lector.GetInt32(1);
                if (!bd.Lector.IsDBNull(2))
                    socio.Nombre = bd.Lector.GetString(2);
                if (!bd.Lector.IsDBNull(3))
                    socio.Apellido = bd.Lector.GetString(3);
                if (!bd.Lector.IsDBNull(4))
                    socio.IdSexo = bd.Lector.GetInt32(4);
                if (!bd.Lector.IsDBNull(5))
                    socio.Sexo = bd.Lector.GetString(5);
                if (!bd.Lector.IsDBNull(6))
                    socio.Dni = bd.Lector.GetString(6);
                if (!bd.Lector.IsDBNull(7))
                    socio.Domicilio = bd.Lector.GetString(7);
                if (!bd.Lector.IsDBNull(8))
                    socio.Localidad = new Localidad(bd.Lector.GetInt32(8), bd.Lector.GetString(9), new Provincia(bd.Lector.GetInt32(10), bd.Lector.GetString(11)));
                if (!bd.Lector.IsDBNull(12))
                    socio.Telefono = bd.Lector.GetString(12);
                if (!bd.Lector.IsDBNull(13))
                    socio.Email = bd.Lector.GetString(13);
                if (!bd.Lector.IsDBNull(14))
                    socio.FechaNacimiento = bd.Lector.GetDateTime(14);
                if (!bd.Lector.IsDBNull(15))
                    socio.Nacionalidad = new Pais(bd.Lector.GetInt32(15), bd.Lector.GetString(16));
                if (!bd.Lector.IsDBNull(17))
                    socio.Tutor = new Tutor(bd.Lector.GetInt32(17), bd.Lector.GetString(18), bd.Lector.GetString(19), bd.Lector.GetInt32(20), bd.Lector.GetString(21), bd.Lector.GetString(22), bd.Lector.GetString(23), new Localidad(bd.Lector.GetInt32(24), bd.Lector.GetString(9), new Provincia(bd.Lector.GetInt32(10), bd.Lector.GetString(11))), bd.Lector.GetString(25), bd.Lector.GetString(26), bd.Lector.GetDateTime(27), new Pais(bd.Lector.GetInt32(28), bd.Lector.GetString(16)));
                else
                    socio.Tutor = null;

                i.Socio = socio;

                Entrenamiento entrenamiento = new Entrenamiento();
                if (!bd.Lector.IsDBNull(29))
                    entrenamiento.Id = bd.Lector.GetInt32(29);

                Deporte deporte = new Deporte();
                if (!bd.Lector.IsDBNull(30))
                    deporte.Id = bd.Lector.GetInt32(30);
                if (!bd.Lector.IsDBNull(31))
                    deporte.Nombre = bd.Lector.GetString(31);
                if (!bd.Lector.IsDBNull(32))
                    deporte.Clasificacion = new ClasificacionDeporte(bd.Lector.GetInt32(32), bd.Lector.GetString(33));

                Predio predio = new Predio();
                if (!bd.Lector.IsDBNull(34))
                    predio.Id = bd.Lector.GetInt32(34);
                if (!bd.Lector.IsDBNull(35))
                    predio.Descripcion = bd.Lector.GetString(35);

                entrenamiento.Deporte = deporte;
                entrenamiento.Predio = predio;

                if (!bd.Lector.IsDBNull(36))
                    entrenamiento.PrecioMensual = bd.Lector.GetDouble(36);
                if (!bd.Lector.IsDBNull(37))
                    entrenamiento.PrecioMatricula = bd.Lector.GetDouble(37);
                if (!bd.Lector.IsDBNull(38))
                    entrenamiento.CantidadCuotas = bd.Lector.GetInt32(38);

                i.Entrenamiento = entrenamiento;

                if (!bd.Lector.IsDBNull(39))
                    i.Fecha = bd.Lector.GetDateTime(39);
                if (!bd.Lector.IsDBNull(40))
                    i.EstaSaldado = bd.Lector.GetBoolean(40);

                Pago p = new Pago();
                if (!bd.Lector.IsDBNull(41))
                    p.Id = bd.Lector.GetInt32(41);

                p.Inscripcion = i;

                if (!bd.Lector.IsDBNull(42))
                    p.Descripcion = bd.Lector.GetString(42);
                if (!bd.Lector.IsDBNull(43))
                    p.Monto = bd.Lector.GetDouble(43);
                if (!bd.Lector.IsDBNull(44))
                    p.NumeroCuota = bd.Lector.GetInt32(44);

                lista.Add(p);
            }
            bd.Lector.Close();
            bd.desconectar();
            return lista;
        }

        public List<Pago> listaCuotaSinPagarPorIdInscripcion(int idInscripcion)
        {
            List<Pago> lista = new List<Pago>();
            bd.consultarBD("select idInscripcion, idSocio, nombreSocio, apellidoSocio, idSexoSocio, sexoSocio, dniSocio, domicilioSocio, idLocalidad, nombreLocalidad, idProvincia, nombreProvincia, telefonoSocio, emailSocio, fechaNacimientoSocio, idNacionalidad, nacionalidadSocio, idTutor, nombreTutor, apellidoTutor, idSexoTutor, sexoTutor, dniTutor, domicilioTutor, idLocalidadTutor, telefonoTutor, emailTutor, fechaNacimientoTutor, idNacionalidadTutor, idEntrenamiento, idDeporte, nombreDeporte, id_clasificacion, tipoDeporte, idPredio, li.descripcion, precioMensual, precioMatricula, cantidadCuotas, li.fecha, li.estaSaldado, li.cantidadCuotas - COUNT(p.id) 'cantidad de cuotas sin pagar', COUNT(p.id) 'cantidad de cuotas pagas' from vw_listaInscripcion li left join Pago p on li.idInscripcion = p.inscripcion where li.idInscripcion = " + idInscripcion + " group by idInscripcion, idSocio, nombreSocio, apellidoSocio, idSexoSocio, sexoSocio, dniSocio, domicilioSocio, idLocalidad, nombreLocalidad, idProvincia, nombreProvincia, telefonoSocio, emailSocio, fechaNacimientoSocio, idNacionalidad, nacionalidadSocio, idTutor, nombreTutor, apellidoTutor, idSexoTutor, sexoTutor, dniTutor, domicilioTutor, idLocalidadTutor, telefonoTutor, emailTutor, fechaNacimientoTutor, idNacionalidadTutor, idEntrenamiento, idDeporte, nombreDeporte, id_clasificacion, tipoDeporte, idPredio, li.descripcion, precioMensual, precioMatricula, cantidadCuotas, li.fecha, li.cantidadCuotas, li.estaSaldado");
            int cantCuotaSinPagar = 0;
            int cantCuotaPagadas = 0;
            while (bd.Lector.Read())
            {
                Inscripcion i = new Inscripcion();
                if (!bd.Lector.IsDBNull(0))
                    i.Id = bd.Lector.GetInt32(0);

                Socio socio = new Socio();
                if (!bd.Lector.IsDBNull(1))
                    socio.Id = bd.Lector.GetInt32(1);
                if (!bd.Lector.IsDBNull(2))
                    socio.Nombre = bd.Lector.GetString(2);
                if (!bd.Lector.IsDBNull(3))
                    socio.Apellido = bd.Lector.GetString(3);
                if (!bd.Lector.IsDBNull(4))
                    socio.IdSexo = bd.Lector.GetInt32(4);
                if (!bd.Lector.IsDBNull(5))
                    socio.Sexo = bd.Lector.GetString(5);
                if (!bd.Lector.IsDBNull(6))
                    socio.Dni = bd.Lector.GetString(6);
                if (!bd.Lector.IsDBNull(7))
                    socio.Domicilio = bd.Lector.GetString(7);
                if (!bd.Lector.IsDBNull(8))
                    socio.Localidad = new Localidad(bd.Lector.GetInt32(8), bd.Lector.GetString(9), new Provincia(bd.Lector.GetInt32(10), bd.Lector.GetString(11)));
                if (!bd.Lector.IsDBNull(12))
                    socio.Telefono = bd.Lector.GetString(12);
                if (!bd.Lector.IsDBNull(13))
                    socio.Email = bd.Lector.GetString(13);
                if (!bd.Lector.IsDBNull(14))
                    socio.FechaNacimiento = bd.Lector.GetDateTime(14);
                if (!bd.Lector.IsDBNull(15))
                    socio.Nacionalidad = new Pais(bd.Lector.GetInt32(15), bd.Lector.GetString(16));
                if (!bd.Lector.IsDBNull(17))
                    socio.Tutor = new Tutor(bd.Lector.GetInt32(17), bd.Lector.GetString(18), bd.Lector.GetString(19), bd.Lector.GetInt32(20), bd.Lector.GetString(21), bd.Lector.GetString(22), bd.Lector.GetString(23), new Localidad(bd.Lector.GetInt32(24), bd.Lector.GetString(9), new Provincia(bd.Lector.GetInt32(10), bd.Lector.GetString(11))), bd.Lector.GetString(25), bd.Lector.GetString(26), bd.Lector.GetDateTime(27), new Pais(bd.Lector.GetInt32(28), bd.Lector.GetString(16)));
                else
                    socio.Tutor = null;

                i.Socio = socio;

                Entrenamiento entrenamiento = new Entrenamiento();
                if (!bd.Lector.IsDBNull(29))
                    entrenamiento.Id = bd.Lector.GetInt32(29);

                Deporte deporte = new Deporte();
                if (!bd.Lector.IsDBNull(30))
                    deporte.Id = bd.Lector.GetInt32(30);
                if (!bd.Lector.IsDBNull(31))
                    deporte.Nombre = bd.Lector.GetString(31);
                if (!bd.Lector.IsDBNull(32))
                    deporte.Clasificacion = new ClasificacionDeporte(bd.Lector.GetInt32(32), bd.Lector.GetString(33));

                Predio predio = new Predio();
                if (!bd.Lector.IsDBNull(34))
                    predio.Id = bd.Lector.GetInt32(34);
                if (!bd.Lector.IsDBNull(35))
                    predio.Descripcion = bd.Lector.GetString(35);

                entrenamiento.Deporte = deporte;
                entrenamiento.Predio = predio;

                if (!bd.Lector.IsDBNull(36))
                    entrenamiento.PrecioMensual = bd.Lector.GetDouble(36);
                if (!bd.Lector.IsDBNull(37))
                    entrenamiento.PrecioMatricula = bd.Lector.GetDouble(37);
                if (!bd.Lector.IsDBNull(38))
                    entrenamiento.CantidadCuotas = bd.Lector.GetInt32(38);

                i.Entrenamiento = entrenamiento;

                if (!bd.Lector.IsDBNull(39))
                    i.Fecha = bd.Lector.GetDateTime(39);
                if (!bd.Lector.IsDBNull(40))
                    i.EstaSaldado = bd.Lector.GetBoolean(40);

                if (!bd.Lector.IsDBNull(41))
                    cantCuotaSinPagar = bd.Lector.GetInt32(41);
                if (!bd.Lector.IsDBNull(42))
                    cantCuotaPagadas = bd.Lector.GetInt32(42);

                
                if (entrenamiento.PrecioMatricula > 0)
                    cantCuotaSinPagar++;

                for (int j = 0; j < cantCuotaSinPagar; j++)
                {
                    Pago p = new Pago();
                    p.Inscripcion = i;
                    if (j == 0 && cantCuotaPagadas == 0 && entrenamiento.PrecioMatricula > 0)
                    {
                        p.NumeroCuota = 0;
                        p.Descripcion = "Pago de cuota N° 0 - Matrícula";
                        p.Monto = entrenamiento.PrecioMatricula;
                    }
                    else
                    {
                        if (j == 0 && entrenamiento.PrecioMatricula > 0)
                        {
                            p.NumeroCuota = cantCuotaPagadas;
                            p.Descripcion = "Pago de cuota N° " + p.NumeroCuota;
                            p.Monto = entrenamiento.PrecioMensual;
                        }
                        else
                        {
                            cantCuotaPagadas++;
                            p.NumeroCuota = cantCuotaPagadas;
                            p.Descripcion = "Pago de cuota N° " + p.NumeroCuota;
                            p.Monto = entrenamiento.PrecioMensual;
                        }
                    }
                    lista.Add(p);
                }
            }
            bd.Lector.Close();
            bd.desconectar();
            return lista;
        }

        public bool agregarPagoRecibo(PagoRecibo pg)
        {
            try
            {
                bd.actualizarConTransaccion("insert into recibo values(@fecha, @idSocio, @montoTotal); select SCOPE_IDENTITY()");
                bd.Comando.Parameters.Clear();
                bd.Comando.Parameters.AddWithValue("@fecha", pg.Recibo.Fecha);
                bd.Comando.Parameters.AddWithValue("@idSocio", pg.Recibo.Socio.Id);
                bd.Comando.Parameters.AddWithValue("@montoTotal", pg.Recibo.MontoTotal);
                pg.Recibo.Id = Convert.ToInt32(bd.Comando.ExecuteScalar());
                foreach (Pago p in pg.ListaPago)
                {
                    bd.Comando.CommandText = "insert into Pago values(@idInscripcion, @descripcion, @numCuota, @montoCuota); select SCOPE_IDENTITY()";
                    bd.Comando.Parameters.Clear();
                    bd.Comando.Parameters.AddWithValue("@idInscripcion", p.Inscripcion.Id);
                    bd.Comando.Parameters.AddWithValue("@descripcion", p.Descripcion);
                    bd.Comando.Parameters.AddWithValue("@numCuota", p.NumeroCuota);
                    bd.Comando.Parameters.AddWithValue("@montoCuota", p.Monto);

                    p.Id = Convert.ToInt32(bd.Comando.ExecuteScalar());

                    bd.Comando.CommandText = "insert into detalle_recibo values(@idPago, @idRecibo)";
                    bd.Comando.Parameters.Clear();
                    bd.Comando.Parameters.AddWithValue("@idPago", p.Id);
                    bd.Comando.Parameters.AddWithValue("@idRecibo", pg.Recibo.Id);
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
    }
}
