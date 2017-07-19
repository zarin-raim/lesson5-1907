using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace pr2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Catch error = new Catch();
            }
            catch (NotImplementedException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }
    }
}
