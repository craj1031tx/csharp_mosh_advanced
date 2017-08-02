using System.Collections.Generic;

namespace csharp_mosh_advanced
{
    public class BookRepository
    {
        public List<Book> GetBooks()
        {
            return new List<Book>
            {
                new Book() {Title="Book A", Price = 5},
                new Book() {Title="Book B", Price = 10},
                new Book() {Title="Book C", Price = 12}
            };
        }
    }
}