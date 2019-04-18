using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theme1
{
    class Program
    {
        static int[,] Array = new int[,] { { 1, 2, 3, 4, 5 }, 
                                           { 5, 3, 7, 1, 5 } };

        static void getElement1(int row, int column, int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                        Console.Write(arr[i, j]);
                
                }
                Console.WriteLine();
            }
            Console.WriteLine("Значение, возвращеннное методом getElement1:");
            Console.WriteLine(Array[ row,column ]);

        }

        static void getElement2(int row, int column, int [,] arr)
        {
            arr[0,0] = arr[row, column];
            Console.WriteLine("Значение первого параметра после выполнения метода getElement2:");
            Console.WriteLine(arr[0, 0]);
        }

        static int[,] Array2= new int[,] { { 1, 2, 3, 4, 5 },
                                           { 5, 3, 7, 1, 5 } };

        static void getElement3(int FoundRow, int FoundColumn, int[,] arr, int element)
        {
            var found =
                from num in Array2
                where (num == element)
                select num;   
            //пишем код
        }
        static void Main(string[] args)
        {
            getElement1(0, 1, Array);
            Console.WriteLine('\n');
            Console.WriteLine('\n');
            Console.WriteLine('\n');
            getElement2(1,1,Array);
            Console.ReadLine();
        }
    }
}

