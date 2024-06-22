using System.ComponentModel.DataAnnotations.Schema;

namespace BookManager.Models
{
    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public string country { get; set; }

        public int AuthorId { get; set; }
        public Author? Author { get; set; }



    }
}
