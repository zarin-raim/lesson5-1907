using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace hw1
{
    class Program
    {
        /*
            Перехватить исключение запроса к несуществующему веб ресурсу и вывести сообщение о том, что произошла ошибка. 
     	    Программа должна завершиться без ошибок.
        */

        static void Main(string[] args)
        {
            Console.Write("Input url: ");
            string url = Console.ReadLine();

            try
            {
                Uri uri = new Uri(url);
                Console.WriteLine("Absoulute path: " + uri.AbsolutePath);
            }
            catch (UriFormatException ex)
            {
                Console.WriteLine("Invalid url format");
            }

            Console.ReadLine();
        }
    }
}
