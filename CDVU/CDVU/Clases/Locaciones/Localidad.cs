namespace CDVU.Clases.Lugares
{
    class Localidad
    {
        int id;
        string nombre;
        Provincia provincia;

        public Localidad(int id, string nombre, Provincia provincia)
        {
            this.id = id;
            this.nombre = nombre;
            this.provincia = provincia;
        }

        public Localidad()
        {
        }

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public Provincia Provincia { get => provincia; set => provincia = value; }

        public override string ToString()
        {
            return nombre;
        }
    }
}
