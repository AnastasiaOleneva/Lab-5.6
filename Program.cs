using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5._5
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Введите количество элементов массива :\t ");
            int elements = int.Parse(Console.ReadLine());
            int[,] array = new int[elements, elements];
            Random random = new Random();
            
            for (int i = 0; i < array.GetLength(0); i++)

            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = random.Next(0, 1);
                  
                }
          
            }
            for (int i = 0; i < array.GetLength(0); i++)

            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if ((i + j) % 2 == 1)
                    {
                        array[i, j] = 0;
                    }
                    else
                    {
                        array[i, j] = 1;

                    }
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }

    }     
}
