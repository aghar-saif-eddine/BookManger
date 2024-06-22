using Microsoft.Extensions.Hosting;
using System.Net.Sockets;

namespace BookManager.Models
{
    public class Author
    {
       
        public int AuthorId { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }

        public ICollection<Book> Books { get; } = new List<Book>();
    }

}
