using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 101; i++)
            {
                //Keep track of what rules/words this number has triggered
                string toPrint = "";

                if (i % 3 == 0)
                {
                    toPrint += "Fizz";
                }
                if (i % 5 == 0)
                {
                    toPrint += "Buzz";
                }
                
                //If the number triggered no rules, print just the number
                if (toPrint == "")
                {
                    toPrint = i.ToString();
                }
                
                Console.WriteLine(toPrint);
            }
        }
    }
}
