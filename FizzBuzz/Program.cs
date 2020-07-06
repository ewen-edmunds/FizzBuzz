using System;
using System.Collections.Generic;
using System.Linq;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a maximum number to FizzBuzz up to: ");
            int maxNumber = PromptUserForPositiveInteger()+1;
            
            Console.WriteLine("\nCommencing FizzBuzz:");
            
            for (int i = 1; i < maxNumber; i++)
            {
                string phrase = GetPhraseForNumber(i);
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
        
        static string GetPhraseForNumber(int number)
        {
            string phrase = "";
            List<string> wordsToSay = ApplyRulesToNumber(number); 
            
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
        
        static List<string> ApplyRulesToNumber(int i)
        {
            List<string> wordsToSay = new List<string>();
            
            if (i % 3 == 0)
            {
                wordsToSay.Add("Fizz");
            }
            if (i % 13 == 0)
            {
                wordsToSay.Add("Fezz");
            }
            if (i % 5 == 0)
            {
                wordsToSay.Add("Buzz");
            }
            if (i % 7 == 0)
            {
                wordsToSay.Add("Bang");
            }
            if (i % 11 == 0)
            {
                wordsToSay.RemoveAll(word => word != "Fezz");
                wordsToSay.Add("Bong");
            }
            if (i % 17 == 0)
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
