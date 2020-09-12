namespace CDVU.Clases.Club
{
    class Deporte
    {
        int id;
        string nombre;
        ClasificacionDeporte clasificacion;

        public Deporte()
        {
            id = 0;
            nombre = "";
            clasificacion = new ClasificacionDeporte();
        }

        public Deporte(int id, string nombre, ClasificacionDeporte clasificacion)
        {
            this.id = id;
            this.nombre = nombre;
            this.clasificacion = clasificacion;
        }

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public ClasificacionDeporte Clasificacion { get => clasificacion; set => clasificacion = value; }

        public override string ToString()
        {
            return nombre;
        }
    }
}
