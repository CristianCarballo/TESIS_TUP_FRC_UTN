using System.Data;
using System.Data.SqlClient;

namespace CDVU.Clases.Base_de_Datos
{
    class AccesoBD
    {
        SqlConnection conexion;
        SqlCommand comando;
        SqlDataReader lector;
        SqlTransaction transaccion;
        const string cadenaConexion = @"Server=CRISTIAN\EQUIPO;Database=CDVU_database;User Id=sa;Password=sa;";

        public SqlDataReader Lector { get => lector; set => lector = value; }
        public SqlCommand Comando { get => comando; set => comando = value; }
        public SqlTransaction Transaccion { get => transaccion; set => transaccion = value; }

        public AccesoBD()
        {
        }

        public void conectarTransaccion()
        {
            conexion = new SqlConnection(cadenaConexion);
            comando = new SqlCommand();
            lector = null;
            conexion.Open();
            transaccion = conexion.BeginTransaction("InicioTransacción");
            comando.Transaction = transaccion;
            comando.Connection = conexion;
            comando.CommandType = CommandType.Text;
        }

        public void conectarProcAlm()
        {
            conexion = new SqlConnection(cadenaConexion);
            comando = new SqlCommand();
            lector = null;
            conexion.Open();
            comando.Connection = conexion;
            comando.CommandType = CommandType.StoredProcedure;
        }

        public void conectar()
        {
            conexion = new SqlConnection(cadenaConexion);
            comando = new SqlCommand();
            lector = null;
            conexion.Open();
            comando.Connection = conexion;
            comando.CommandType = CommandType.Text;
        }

        public void desconectar()
        {
            conexion.Close();
            conexion.Dispose();
        }

        public DataTable buscarBD(string SQL_select) //Select que devuelve la tabla de resultado de la consulta
        {
            DataTable tabla = new DataTable();
            conectar();
            comando.CommandText = SQL_select;
            tabla.Load(Comando.ExecuteReader());
            desconectar();
            return tabla;
        }

        public void consultarBD(string SQL_select) //Select
        {
            conectar();
            comando.CommandText = SQL_select;
            Lector = Comando.ExecuteReader();
        }

        public void actualizarBD(string SQL_ins_upd_del) //Insert, update y delete
        {
            conectar();
            comando.CommandText = SQL_ins_upd_del;
        }

        public void actualizarConTransaccion(string SQL_ins_upd_del) //Transacciones
        {
            conectarTransaccion();
            comando.CommandText = SQL_ins_upd_del;
        }
    }
}