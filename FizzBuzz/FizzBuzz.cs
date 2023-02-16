using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class FizzBuzz
    { 
        public  FizzBuzz()
        {
            int userNunmber = GetUserNumber();

            if (userNunmber % 3 == 0 & userNunmber % 5 != 0)
            {
                Console.WriteLine("Fizz");
            }
            if (userNunmber % 5 == 0 & userNunmber % 3 != 0)
            {
                Console.WriteLine("Buzz");
            }
            if (userNunmber % 5 == 0 & userNunmber % 3 == 0)
            {
                Console.WriteLine("FizzBuzz");
            }
            else
            {
                
                Console.WriteLine($"{userNunmber.ToString()}");
            }
            /*if(userNunmber % 5 != 0 & userNunmber % 3 != 0)
            {
                Console.WriteLine($"{userNunmber.ToString()}");         
            }*/


            //jak na końcu jest if zamist else to działa dobrze,
            //przy else działa tylko przy komunukacie FizzBuzz,
            //przy Fizz i Buzz wyświetla jeszcze liczbe dodatkowa ( taj jakby z pod else)
            // Dlaczego tak jest?
        }   
        private int GetUserNumber()
        {
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out int number) || number < 0)
                {
                    Console.WriteLine("Podana wartośc jest nieprawidłowa");
                    continue;
                }
                return number;
            }
        }
    }
}
