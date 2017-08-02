using System;


namespace csharp_mosh_advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            var newBook = new Book() { Isbn = "1111", Title = "csharp" };
            newBook.Display();
            var books = new Booklist();
            //books.Add(newBook);

            var numbers = new GenericList<int>();

            var dictionary = new GenericDictionary<string, Book>();
            dictionary.Add("1234", new Book());
        }
    }

    public class Booklist
    {
        public void Add(Book book)
        {
            throw new NotImplementedException();
        }

        public Book this[int index]
        {
            get { throw new NotImplementedException(); }
        }
    }

    public class GenericDictionary<TKey, TValue>
    {
        public void Add(TKey key, TValue value)
        {

        }
    }

    public class GenericList<T>
    {
        public void Add(T value)
        {

        }

        public T this[int index]
        {
            get { throw new NotImplementedException(); }
        }
    }
}