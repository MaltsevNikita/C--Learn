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

        static void getElement(int row, int column, int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                        Console.Write(arr[i, j]);
                
                }
                Console.WriteLine();
            }

            Console.WriteLine(Array[ row,column ]);

        }

        static void getElement2(int row, int column, int [,] arr)
        {
            arr[0,0] = arr[row, column];
            Console.WriteLine(arr[0, 0]);
        }

        static void Main(string[] args)
        {
            getElement(0, 1, Array);
            Console.WriteLine('\n');
            Console.WriteLine('\n');
            Console.WriteLine('\n');
            getElement2(1,1,Array);
            Console.ReadLine();
        }
    }
}

