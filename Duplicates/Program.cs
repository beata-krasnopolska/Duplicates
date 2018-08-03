using System;

namespace Duplicates
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 2, 1, 3, 5, 3, 2 };
         
            //int firstDuplicate(int[]a)
            //{
            for (int i = 0; i < a.Length; i++)
            {
                bool appear = false;                

                for (int j = 0; j < a.Length; j++)
                {
                    if (a[i] == a[j])
                    {
                        appear = true;                        
                    }
                    else if (a[i] != a[j])
                    {
                        appear = false;
                    }
                }
                if (appear == true)
                {
                    Console.WriteLine("The number {1} appears in {0} place in the array", i, a[i]);
                }
                else
                {
                    Console.WriteLine("-1");
                }
                Console.ReadKey();
            }
        }
    }
}
