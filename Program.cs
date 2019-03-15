using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theme1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] Array1 =  { { 1, 2, 3, 4, 5 }, { 5, 3, 7, 1, 5 } };
            public void  GetElement(int row, int column, int [,] a)
            {
                for(int i = 0; i < row; i++)
                {
                    for (int j = 0; j < column; j++)
                    {
                        if (i == row && j == column)
                        {
                            Console.WriteLine( a[row, column] );
                        }
                    }
                }
                
             
            Console.ReadLine();

            }
    }
}
