namespace Bookstore.Data
{
    public class Author
    {
        public int Id { get; set; }
        public string Tittle { get; set; }

        public IList<Book> BooksList { get; set; }
         public IList<Genre> GenreList { get; set; }

    }
}
