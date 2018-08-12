using System;
using System.Linq;

namespace Duplicates
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] b = Enumerable.Range(1, 100000).ToArray();
            b[b.Length - 2] = 1;
            int[] a = { 2, 1, 3, 5, 6, 3, 2 };

            var duplicateFinder = new DuplicateFinder();
            var result = duplicateFinder.Find(b);
            var result2 = duplicateFinder.FindHash(b);

            Console.WriteLine(result + " " + result2);

            Console.ReadKey();
        }
    }
}
