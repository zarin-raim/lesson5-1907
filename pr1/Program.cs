using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace pr1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число: ");

            string possibleNumber = Console.ReadLine();

            try
            {
                int number = Int32.Parse(possibleNumber);
            }
            catch(FormatException fx)
            {
                Console.WriteLine(fx.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


            Console.ReadLine();
        }
    }
}
