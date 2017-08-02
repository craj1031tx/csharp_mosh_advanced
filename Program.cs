using System;

namespace csharp_mosh_advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            var execute = new PhotoProcessor();
            var filters = new PhotoFilters();
            Action<Photo> filterHandler = filters.ApplyBrightness;
            filterHandler += filters.ApplyContrast;
            filterHandler += RemoveRedEyeFilter;

            execute.Process("photo.jpg", filterHandler);
        }

        static void RemoveRedEyeFilter(Photo photo)
        {
            System.Console.WriteLine("Applying Remove Red Eye...");
        }
    }
}