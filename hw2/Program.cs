using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace hw2
{
    class Program
    {
        /*
            Написать программу, которая обращается к элементам массива по индексу и выходит за его пределы. 
		    После обработки исключения вывести в финальном блоке сообщение о завершении обработки массива.
         */
        static void Main(string[] args)
        {
            int[] mas = { 1, 3, 6, 8, 13, 356, 125 };

            try
            {
                for(int i = 0; i < 10; i++)
                {
                    Console.Write(mas[i] + "\t");
                }
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine();
                Console.WriteLine("Выход за границы массива!");
            }
            finally
            {
                Console.WriteLine("Обработка массива завершена!");
            }

            Console.ReadLine();
;        }
    }
}
