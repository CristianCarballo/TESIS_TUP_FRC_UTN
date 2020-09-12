namespace CDVU.Clases.Club
{
    class Predio
    {
        int id;
        string descripcion;

        public Predio()
        {
        }

        public Predio(int id, string descripcion)
        {
            this.id = id;
            this.descripcion = descripcion;
        }

        public int Id { get => id; set => id = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }

        public override string ToString()
        {
            return descripcion;
        }
    }
}
