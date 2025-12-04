namespace BibliotecaApi.Models
{
    public class Author
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public DateTime BirthDate { get; set; }
        public string Nationality { get; set; } = null!;

        // Navegacion
        public List<Book> Books { get; set; } = new();
    }
}
