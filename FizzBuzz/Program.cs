using System;
using System.Linq;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 361; i++)
            {
                //Keep track of what rules/words this number has triggered, and the order the words should be spoken in
                string[] toPrintList = {"", "", "", "", ""};
                string toPrint = "";

                if (i % 3 == 0)
                {
                    toPrintList[0] = "Fizz";
                }
                if (i % 13 == 0)
                {
                    toPrintList[1] = "Fezz";
                }
                if (i % 5 == 0)
                {
                    toPrintList[2] = "Buzz";
                }
                if (i % 7 == 0)
                {
                    toPrintList[3] = "Bang";
                }
                if (i % 11 == 0)
                {
                    toPrintList[0] = "";
                    toPrintList[2] = "";
                    toPrintList[3] = "Bong";
                }
                if (i % 17 == 0)
                {
                    Array.Reverse(toPrintList);
                }
               
                foreach (string word in toPrintList)
                {
                    toPrint += word;
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
