using System;
using System.Collections.Generic;
using System.Linq;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 361; i++)
            {
                string phrase = GetPhraseForNumber(i);
                PrintPhrase(phrase);
            }
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
