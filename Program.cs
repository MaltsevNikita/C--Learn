using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theme1
{
    public struct ValueWithIndex
    {
        public int Item, X, Y;

        public ValueWithIndex(int item, int x, int y)
        {
            Item = item;
            X = x;
            Y = y;
        }
    }

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
            Console.WriteLine(Array[row, column]);

        }

        static void getElement2(int row, int column, int[,] arr)
        {
            arr[0, 0] = arr[row, column];
            Console.WriteLine("Значение первого параметра после выполнения метода getElement2:");
            Console.WriteLine(arr[0, 0]);
        }

        static int[,] A2 = new int[,] { { 1, 2, 3, 4, 5 },
                                       { 10, 2, 30, 40, 50} };

        public static IEnumerable<ValueWithIndex> Flatten(int[,] map)
        {
            for (int row = 0; row < map.GetLength(0); row++)
            {
                for (int col = 0; col < map.GetLength(1); col++)
                {
                    var item = map[row, col];
                    ValueWithIndex stct = new ValueWithIndex(item, row, col);
                    yield return stct;
                }
            }
        }
            static void getElement3(int x, int y, int[,] array, int value)
        {
            var item = Flatten(array).Where(val => val.Item == value).FirstOrDefault();
            x = item.X;
            y = item.Y;
            Console.WriteLine(item.Item);
            Console.WriteLine("индексы найденного элемента:");
            Console.WriteLine(x);
            Console.WriteLine(y);
            
        }
        static void Main(string[] args)
        {
            getElement1(0, 1, Array);
            Console.WriteLine('\n');
            Console.WriteLine('\n');
            Console.WriteLine('\n');
            getElement2(1, 1, Array);
            Console.WriteLine('\n');
            Console.WriteLine('\n');
            Console.WriteLine('\n');
            Console.WriteLine("Значение возвращаемое методом getElement3:");
            getElement3(1, 1, A2, 2);

            Console.ReadLine();
        }
    }
}

