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
            BadClass bad = new BadClass();

            try
            {
                bad.BadMethod();
            }
            catch (NotImplementedException ex) when (bad!=null)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }
    }
}
