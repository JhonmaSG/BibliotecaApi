namespace BibliotecaApi.Models
{
    public class Book
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string ISBN { get; set; }
        public string YearPublication { get; set; }
        public string AuthorId { get; set; }
        public string Stock {  get; set; }

    }
}
