namespace BibliotecaApi.Models
{
    public class Book
    {
        public Guid Id { get; set; }
        public string Title { get; set; } = null!;
        public string ISBN { get; set; } = null!;
        public DateTime YearPublication { get; set; }
        public string Genero { get; set; } = null!;
        public int numberPages { get; set; }
        public string Stock {  get; set; }

        // Para Borrado lógico
        public bool EstaActivo { get; set; } = true;
        public DateTime fechaCreacion { get; set; } = DateTime.Now;

        // Claves foráneas y navegación
        public int AuthorForeignKey { get; set; }
        public required Author Author { get; set; } = null!;
    }
}
