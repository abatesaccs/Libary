namespace Library.Models
{
    public class AuthorBook
    {
        public int AuthorBookId {get; set;}
        public int BookId {get; set;}
        public int AuthorId {get; set;}
        public string AuthorName {get; set;}
        public string BookName {get; set;}
        public Author Author {get; set;}
        public Book Book {get; set;}
    }
}