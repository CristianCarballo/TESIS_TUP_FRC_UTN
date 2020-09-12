namespace CDVU.Clases.Lugares
{
    class Provincia
    {
        int id;
        string nombre;

        public Provincia()
        {
        }

        public Provincia(int id, string nombre)
        {
            this.id = id;
            this.nombre = nombre;
        }

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }

        public override string ToString()
        {
            return nombre;
        }
    }
}
