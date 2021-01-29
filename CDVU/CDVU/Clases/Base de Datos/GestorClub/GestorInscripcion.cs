using CDVU.Clases.Club;
using CDVU.Clases.Lugares;
using CDVU.Personas;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace CDVU.Clases.Base_de_Datos.GestorClub
{
    class GestorInscripcion
    {
        AccesoBD bd;

        public GestorInscripcion()
        {
            bd = new AccesoBD();
        }

        public List<Inscripcion> listaInscripcion()
        {
            List<Inscripcion> lista = new List<Inscripcion>();
            bd.consultarBD("select * from vw_listaInscripcion order by idInscripcion");
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

                lista.Add(i);
            }
            bd.Lector.Close();
            bd.desconectar();
            return lista;
        }

        public List<Inscripcion> listaInscripcionSegunIdSocio(int idSocio)
        {
            List<Inscripcion> lista = new List<Inscripcion>();
            bd.consultarBD("select * from vw_listaInscripcion where idSocio = " + idSocio + " and estaSaldado = 0");
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

                lista.Add(i);
            }
            bd.Lector.Close();
            bd.desconectar();
            return lista;
        }

        public List<Inscripcion> listaInscripcionCompletaSegunIdSocio(int idSocio)
        {
            List<Inscripcion> lista = new List<Inscripcion>();
            bd.consultarBD("select * from vw_listaInscripcion where idSocio = " + idSocio);
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

                lista.Add(i);
            }
            bd.Lector.Close();
            bd.desconectar();
            return lista;
        }

        public Inscripcion ultimaInscripcionGenerada()
        {
            Inscripcion i = new Inscripcion();
            bd.consultarBD("select top(1)* from vw_listaInscripcion i order by i.idInscripcion desc");
            while (bd.Lector.Read())
            {
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
            }
            bd.Lector.Close();
            bd.desconectar();
            return i;
        }

        public Inscripcion obtenerInscripcionPorId(int id)
        {
            Inscripcion i = new Inscripcion();
            bd.consultarBD("select * from vw_listaInscripcion where id = " + id);
            while (bd.Lector.Read())
            {
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
            }
            bd.Lector.Close();
            bd.desconectar();
            return i;
        }

        public Inscripcion obtenerInscripcionPorIdRecibo(int id)
        {
            Inscripcion i = new Inscripcion();
            bd.consultarBD("select idInscripcion, idSocio, nombreSocio, apellidoSocio, idSexoSocio, sexoSocio, dniSocio, domicilioSocio, idLocalidad, nombreLocalidad, idProvincia, nombreProvincia, telefonoSocio, emailSocio, fechaNacimientoSocio, idNacionalidad, nacionalidadSocio, idTutor, nombreTutor, apellidoTutor, idSexoTutor, sexoTutor, dniTutor, domicilioTutor, idLocalidadTutor, telefonoTutor, emailTutor, fechaNacimientoTutor, idNacionalidadTutor, idEntrenamiento, idDeporte, nombreDeporte, id_clasificacion, tipoDeporte, idPredio, li.descripcion, precioMensual, precioMatricula, cantidadCuotas, li.fecha fechaInscripcion, li.estaSaldado from vw_listaInscripcion li join Pago p on li.idInscripcion = p.inscripcion join Detalle_Recibo dr on dr.pago = p.id join Recibo r on r.id = dr.recibo where r.id = " + id + " group by idInscripcion, idSocio, nombreSocio, apellidoSocio, idSexoSocio, sexoSocio, dniSocio, domicilioSocio, idLocalidad, nombreLocalidad, idProvincia, nombreProvincia, telefonoSocio, emailSocio, fechaNacimientoSocio, idNacionalidad, nacionalidadSocio, idTutor, nombreTutor, apellidoTutor, idSexoTutor,sexoTutor, dniTutor, domicilioTutor, idLocalidadTutor, telefonoTutor, emailTutor, fechaNacimientoTutor, idNacionalidadTutor, idEntrenamiento, idDeporte, nombreDeporte, id_clasificacion, tipoDeporte, idPredio, li.descripcion, precioMensual, precioMatricula, cantidadCuotas, li.fecha, li.estaSaldado");
            while (bd.Lector.Read())
            {
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
            }
            bd.Lector.Close();
            bd.desconectar();
            return i;
        }

        public bool agregarInscripcion(Inscripcion i)
        {
            try
            {
                bd.actualizarBD("insert into inscripcion values(@idSocio, @idEntrenamiento, @fecha, @estaSaldado)");
                bd.Comando.Parameters.Add(new SqlParameter("@idSocio", i.Socio.Id));
                bd.Comando.Parameters.Add(new SqlParameter("@idEntrenamiento", i.Entrenamiento.Id));
                bd.Comando.Parameters.Add(new SqlParameter("@fecha", i.Fecha));
                bd.Comando.Parameters.Add(new SqlParameter("@estaSaldado", false));
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

        //public bool modificarInscripcion(Inscripcion i)
        //{
        //    try
        //    {
        //        return true;
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex);
        //        return false;
        //    }
        //    finally
        //    {
        //        bd.desconectar();
        //    }
        //}

        public bool eliminarInscripcion(Inscripcion i)
        {
            try
            {
                bd.actualizarBD("delete inscripcion where id = @id");
                bd.Comando.Parameters.Add(new SqlParameter("@id", i.Id));
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
