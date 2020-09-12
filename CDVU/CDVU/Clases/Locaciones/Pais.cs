namespace CDVU.Clases.Lugares
{
    class Pais
    {
        int id;
        string nombre;

        public Pais(int id, string nombre)
        {
            this.id = id;
            this.nombre = nombre;
        }

        public Pais()
        {
        }

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }

        public override string ToString()
        {
            return nombre;
        }
    }
}
