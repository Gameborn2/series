
using System;

namespace serias
{
    class Program
    {
        public static void Main()
        {
            SeriesTasks seriesTasks = new SeriesTasks();
            int[] testArray = new int[] { 3, 4, 3, 3, 4, 3, 3, 2 };

            Console.WriteLine(seriesTasks.sum(testArray));
        }
    }

    class SeriesTasks
    {
        public int sum(int[] a)
        {
            int sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                sum += a[i];
            }
            return sum;
        }
    }
}
