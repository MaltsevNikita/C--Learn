using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theme1
{
    class Program
    {
        static int[,] Array = new int[,] { { 1, 2, 3, 4, 5 }, { 5, 3, 7, 1, 5 } };

        static void GetElement(int row, int column, int[,] a)
        {
            for (int i = 0; i < Array.GetLength(0); i++)
            {
                for (int j = 0; j < Array.GetLength(1); j++)
                {
                        Console.Write(a[i, j]);
                
                }
                Console.WriteLine();
            }

            Console.WriteLine(Array[ row,column ]);

        }

        static void Main(string[] args)
        {
            GetElement(0, 1, Array);
            Console.ReadLine();
        }
    }
}

