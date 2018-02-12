using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.Business
{
    public class FizzBuzzRepository : IFizzBuzzRepository
    {
        IDivisibility _IFizzDivisibility;
        IDivisibility _IBuzzDivisibility;
        IDivisibility _IFizzBuzzDivisibility;
        public FizzBuzzRepository(IDivisibility IFizzDivisibility, IDivisibility IBuzzDivisibility, IDivisibility IFizzBuzzDivisibility)
    {
            _IFizzDivisibility = IFizzDivisibility;
            _IBuzzDivisibility = IBuzzDivisibility;
            _IFizzBuzzDivisibility = IFizzBuzzDivisibility;
    }

        public IEnumerable<string> DisplayList(int input)
        {
            Fizz objFizz = new Fizz();
            Buzz objBuzz = new Buzz(); 
            FizzBuzz objFizzBuzz = new FizzBuzz();

            _IFizzDivisibility = objFizz; 
            _IBuzzDivisibility = objBuzz; 
            _IFizzBuzzDivisibility = objFizzBuzz;

            DayOfWeek today = DateTime.Today.DayOfWeek;
            Console.WriteLine("Today is {0}",today);

            // Test current day of week.
           
            var NumberList =new  List<string>() ;
            if(today == DayOfWeek.Wednesday)
            {
                for (int i = 1; i <= input; i++)
                {
                    if (_IFizzBuzzDivisibility.Divide(i))
                        NumberList.Add("Wizz Wuzz");
                    else if (_IFizzDivisibility.Divide(i))
                        NumberList.Add("Wizz");
                    else if (_IBuzzDivisibility.Divide(i))
                        NumberList.Add("Wuzz");
                    else
                        NumberList.Add(i.ToString());

                }
            }
            else
            {
                for (int i = 1; i <= input; i++)
                {
                    if (_IFizzBuzzDivisibility.Divide(i))
                        NumberList.Add("Fizz Buzz");
                    else if (_IFizzDivisibility.Divide(i))
                        NumberList.Add("Fizz");
                    else if (_IBuzzDivisibility.Divide(i))
                        NumberList.Add("Buzz");
                    else
                        NumberList.Add(i.ToString());

                }
            }


            return NumberList;
        }
    }
}
