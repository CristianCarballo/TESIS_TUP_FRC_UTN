using CDVU.Clases.Lugares;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDVU.Clases.Base_de_Datos
{
    class GestorLocaciones
    {
        AccesoBD bd;

        public GestorLocaciones()
        {
            bd = new AccesoBD();
        }

        public List<Localidad> listaLocalidadSegunIdProvincia(int idProvincia)
        {
            List<Localidad> lista = new List<Localidad>();
            bd.consultarBD("SELECT id, nombre from localidad where id_provincia = " + idProvincia);
            while (bd.Lector.Read())
            {
                Localidad local = new Localidad();
                if (!bd.Lector.IsDBNull(0))
                    local.Id = bd.Lector.GetInt32(0);
                if (!bd.Lector.IsDBNull(1))
                    local.Nombre = bd.Lector.GetString(1);
                lista.Add(local);
            }
            bd.Lector.Close();
            bd.desconectar();
            return lista;
        }

        public List<Localidad> listaLocalidad()
        {
            List<Localidad> lista = new List<Localidad>();
            bd.consultarBD("SELECT id, nombre from localidad");
            while (bd.Lector.Read())
            {
                Localidad local = new Localidad();
                if (!bd.Lector.IsDBNull(0))
                    local.Id = bd.Lector.GetInt32(0);
                if (!bd.Lector.IsDBNull(1))
                    local.Nombre = bd.Lector.GetString(1);
                lista.Add(local);
            }
            bd.Lector.Close();
            bd.desconectar();
            return lista;
        }

        public List<Provincia> listaProvincia()
        {
            List<Provincia> lista = new List<Provincia>();
            bd.consultarBD("SELECT id, nombre from provincia");
            while (bd.Lector.Read())
            {
                Provincia provincia = new Provincia();
                if (!bd.Lector.IsDBNull(0))
                    provincia.Id = bd.Lector.GetInt32(0);
                if (!bd.Lector.IsDBNull(1))
                    provincia.Nombre = bd.Lector.GetString(1);
                lista.Add(provincia);
            }
            bd.Lector.Close();
            bd.desconectar();
            return lista;
        }

        public List<Pais> listaPais()
        {
            List<Pais> lista = new List<Pais>();
            bd.consultarBD("SELECT id, nombre from pais");
            while (bd.Lector.Read())
            {
                Pais pais = new Pais();
                if (!bd.Lector.IsDBNull(0))
                    pais.Id = bd.Lector.GetInt32(0);
                if (!bd.Lector.IsDBNull(1))
                    pais.Nombre = bd.Lector.GetString(1);
                lista.Add(pais);
            }
            bd.Lector.Close();
            bd.desconectar();
            return lista;
        }
    }
}
