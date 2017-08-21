using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace pr3
{
    class Program
    {
        static void Main(string[] args)
        {
            Array array = new Array(3);

            array.Fill();
            array.Print();

            array.Add(34, 0);
            array.Add(23, 5);
            array.Add(65, 5);
            array.Print();

            array.Remove(65);
            array.Print();

            Console.WriteLine("On position 4: " + array.Get(4));

            Console.ReadLine();
        }
    }
}
