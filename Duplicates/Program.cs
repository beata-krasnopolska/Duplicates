using System;

namespace Duplicates
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 2, 1, 3, 5, 3, 2 };

            var duplicateFinder = new DuplicateFinder();
            var result = duplicateFinder.Find(a);

            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}
