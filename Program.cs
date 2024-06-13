using System.Diagnostics.Metrics;
using System.Security.Principal;
using System.Threading.Channels;

namespace S1
{
    class s1
    {
        static void Main(string[] args)
        {

            int[,] a = { { 7, 3, 2 }, { 4, 9, 6 }, { 1, 8, 5 } };
            int[] digits = new int[a.Length];

            AddInArrayDigits(a, digits);
            PrintArray(digits);

            Array.Sort(digits);

            Console.WriteLine();

            PrintArray(digits);

            Console.WriteLine();

            RebuildArray(a, digits);

            Console.WriteLine();

            PrintArray(a);

            Console.WriteLine();

        }

        static void AddInArrayDigits(int[,] allArray, int[] arrayForAdd)
        {
            int account = 0;
            for (int i = 0; i < allArray.GetLength(0); i++)
                for (int j = 0; j < allArray.GetLength(1); j++)
                {
                    arrayForAdd[account] = allArray[i, j];
                    account++;
                }
        }

        static void PrintArray(int[] array) => Console.Write(string.Join(" ", array));

        static void PrintArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }
        }

        static void RebuildArray(int[,] rebuildArray, int[] additionArray)
        {
            int account = 0;
            for (int i = 0; i < rebuildArray.GetLength(0); i++)
                for (int j = 0; j < rebuildArray.GetLength(1); j++)
                {
                    rebuildArray[i, j] = additionArray[account];
                    account++;
                }
        }
    }
}
