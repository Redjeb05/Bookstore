using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bookstore.Data
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set;}
        public int AuthorId { get; set; }
        public DateTime ReleaseDate { get; set; }
        [ForeignKey("AuthorId")]
        public virtual Author? Author { get; set; }
        


    }
}