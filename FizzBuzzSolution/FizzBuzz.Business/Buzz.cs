using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.Business
{
    public class Buzz : IDivisibility
    {
        public bool Divide(int number)
        {
            return number % 5 == 0;
        }
    }
}
