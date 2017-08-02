using System;


namespace csharp_mosh_advanced
{
    public class Book : Product 
    {
        public string Isbn { get; set; }
        public string Title { get; set; }


        public void Display()
        {
            Console.WriteLine(Isbn);
        }
    }
}