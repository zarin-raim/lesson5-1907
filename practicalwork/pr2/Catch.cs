using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace pr2
{
    public class Catch
    {
        Error error = new Error();

        public Catch()
        {
            error.ThrowError();
        }
    }
}
