using System;
using System.Collections.Generic;
using System.Linq;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            var enabledRules = new string[] {"3", "5", "7", "11", "13", "17"}.Intersect(args);
            
            Console.WriteLine("Enter a maximum number to FizzBuzz up to: ");
            int maxNumber = PromptUserForPositiveInteger()+1;
            
            Console.WriteLine("\nCommencing FizzBuzz:");
            for (int i = 1; i < maxNumber; i++)
            {
                string phrase = GetPhraseForNumber(i, enabledRules);
                PrintPhrase(phrase);
            }
        }

        static int PromptUserForPositiveInteger()
        {
            int integerToReturn;
            string consoleInput;
            
            do
            {
                consoleInput = Console.ReadLine();
            } while (Int32.TryParse(consoleInput, out integerToReturn) == false || integerToReturn <= 0);

            return integerToReturn;
        }
        
        static string GetPhraseForNumber(int number, IEnumerable<string> rules)
        {
            string phrase = "";
            List<string> wordsToSay = ApplyRulesToNumber(number, rules); 
            
            foreach (string word in wordsToSay)
            {
                phrase += word;
            }

            if (phrase == "")
            {
                phrase = number.ToString();
            }

            return phrase;
        }
        
        static List<string> ApplyRulesToNumber(int i, IEnumerable<string> rules)
        {
            List<string> wordsToSay = new List<string>();

            bool isApplicableRule(int i, int divider)
            {
                return i % divider == 0 && rules.Contains(divider.ToString());
            }
            
            if (isApplicableRule(i,3))
            {
                wordsToSay.Add("Fizz");
            }
            if (isApplicableRule(i,13))
            {
                wordsToSay.Add("Fezz");
            }
            if (isApplicableRule(i,5))
            {
                wordsToSay.Add("Buzz");
            }
            if (isApplicableRule(i,7))
            {
                wordsToSay.Add("Bang");
            }
            if (isApplicableRule(i,11))
            {
                wordsToSay.RemoveAll(word => word != "Fezz");
                wordsToSay.Add("Bong");
            }
            if (isApplicableRule(i,17))
            {
                wordsToSay.Reverse();
            }

            return wordsToSay;
        }
        
        static void PrintPhrase(string phrase)
        {
            Console.WriteLine(phrase);
        }
    }
}
