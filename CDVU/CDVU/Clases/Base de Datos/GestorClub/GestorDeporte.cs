using CDVU.Clases.Club;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace CDVU.Clases.Base_de_Datos.GestorClub
{
    class GestorDeporte
    {
        AccesoBD bd;

        public GestorDeporte()
        {
            bd = new AccesoBD();
        }

        public List<Deporte> listaDeporte()
        {
            List<Deporte> lista = new List<Deporte>();
            bd.consultarBD("select * from vw_listaDeportes order by nombre");
            while (bd.Lector.Read())
            {
                Deporte deporte = new Deporte();
                if (!bd.Lector.IsDBNull(0))
                    deporte.Id = bd.Lector.GetInt32(0);
                if (!bd.Lector.IsDBNull(1))
                    deporte.Nombre = bd.Lector.GetString(1);
                if (!bd.Lector.IsDBNull(2))
                    deporte.Clasificacion = new ClasificacionDeporte(bd.Lector.GetInt32(2), bd.Lector.GetString(3));
                lista.Add(deporte);
            }
            bd.Lector.Close();
            bd.desconectar();
            return lista;
        }

        public List<Deporte> listaDeporteSegunIdClasificacion(int idClasificacion)
        {
            List<Deporte> lista = new List<Deporte>();
            bd.consultarBD("select d.id, d.nombre, d.id_clasificacion, dc.nombre from Deporte d join Deporte_Clasificacion dc on d.id_clasificacion = dc.id where d.id_clasificacion = " + idClasificacion);
            while (bd.Lector.Read())
            {
                Deporte deporte = new Deporte();
                if (!bd.Lector.IsDBNull(0))
                    deporte.Id = bd.Lector.GetInt32(0);
                if (!bd.Lector.IsDBNull(1))
                    deporte.Nombre = bd.Lector.GetString(1);
                if (!bd.Lector.IsDBNull(2))
                    deporte.Clasificacion = new ClasificacionDeporte(bd.Lector.GetInt32(2), bd.Lector.GetString(3));
                lista.Add(deporte);
            }
            bd.Lector.Close();
            bd.desconectar();
            return lista;
        }

        public List<Deporte> listaDeporteSegunIdProfesor(int idProfesor)
        {
            List<Deporte> lista = new List<Deporte>();
            bd.consultarBD("select d.id, d.nombre, d.id_clasificacion, dc.nombre from Deporte d join Deporte_Clasificacion dc on d.id_clasificacion = dc.id join Deporte_Profesor dp on dp.deporte = d.id where dp.profesor = " + idProfesor);
            while (bd.Lector.Read())
            {
                Deporte deporte = new Deporte();
                if (!bd.Lector.IsDBNull(0))
                    deporte.Id = bd.Lector.GetInt32(0);
                if (!bd.Lector.IsDBNull(1))
                    deporte.Nombre = bd.Lector.GetString(1);
                if (!bd.Lector.IsDBNull(2))
                    deporte.Clasificacion = new ClasificacionDeporte(bd.Lector.GetInt32(2), bd.Lector.GetString(3));
                lista.Add(deporte);
            }
            bd.Lector.Close();
            bd.desconectar();
            return lista;
        }

        public List<ClasificacionDeporte> listaClasificacionDeporte()
        {
            List<ClasificacionDeporte> lista = new List<ClasificacionDeporte>();
            bd.consultarBD("select * from Deporte_Clasificacion");
            while (bd.Lector.Read())
            {
                ClasificacionDeporte tipo = new ClasificacionDeporte();
                if (!bd.Lector.IsDBNull(0))
                    tipo.Id = bd.Lector.GetInt32(0);
                if (!bd.Lector.IsDBNull(1))
                    tipo.Nombre = bd.Lector.GetString(1);
                lista.Add(tipo);
            }
            bd.Lector.Close();
            bd.desconectar();
            return lista;
        }

        public Deporte obtenerDeportePorId(int id)
        {
            Deporte deporte = new Deporte();
            bd.consultarBD("select * from vw_listaDeportes where id = " + id);
            if (bd.Lector.Read())
            {
                if (!bd.Lector.IsDBNull(0))
                    deporte.Id = bd.Lector.GetInt32(0);
                if (!bd.Lector.IsDBNull(1))
                    deporte.Nombre = bd.Lector.GetString(1);
                if (!bd.Lector.IsDBNull(2))
                    deporte.Clasificacion = new ClasificacionDeporte(bd.Lector.GetInt32(2), bd.Lector.GetString(3));
            }
            bd.Lector.Close();
            bd.desconectar();
            return deporte;
        }

        public bool agregarDeporte(Deporte d)
        {
            try
            {
                bd.actualizarBD("insert into deporte values(@nombre, @idClasificacion)");
                bd.Comando.Parameters.Add(new SqlParameter("@nombre", d.Nombre));
                bd.Comando.Parameters.Add(new SqlParameter("@idClasificacion", d.Clasificacion.Id));
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

        public bool modificarDeporte(Deporte d)
        {
            try
            {
                bd.actualizarBD("update deporte set nombre = @nombre, id_clasificacion = @idClasificacion where id = @id");
                bd.Comando.Parameters.Add(new SqlParameter("@nombre", d.Nombre));
                bd.Comando.Parameters.Add(new SqlParameter("@idClasificacion", d.Clasificacion.Id));
                bd.Comando.Parameters.Add(new SqlParameter("@id", d.Id));
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

        public bool eliminarDeporte(Deporte d)
        {
            try
            {
                bd.actualizarBD("delete deporte where id = @id");
                bd.Comando.Parameters.Add(new SqlParameter("@id", d.Id));
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
