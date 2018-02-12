using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.Business
{
    public interface IFizzBuzzRepository
    {
        IEnumerable<string> DisplayList(int input);
        
    }
}
