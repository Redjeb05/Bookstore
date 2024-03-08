namespace Bookstore.Data
{
    public class Author
    {
        public Author()
        {
             BooksList = new List<Book>();
            GenreList = new List<Genre>();
        }
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; } 
        public List<Book> BooksList { get; set; }
         public List<Genre> GenreList { get; set; }

    }
}
