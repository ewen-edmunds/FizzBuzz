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
                string phrase = GetPhraseForNumber(i);
                PrintPhrase(phrase);
            }
        }
        
        static string GetPhraseForNumber(int number)
        {
            string phrase = "";
            string[] wordsToSay = ApplyRulesToNumber(number); 
            
            foreach (string word in wordsToSay)
            {
                phrase += word;
            }

            //If the number triggered no rules, return just the number
            if (phrase == "")
            {
                phrase = number.ToString();
            }

            return phrase;
        }
        
        static string[] ApplyRulesToNumber(int i)
        {
            //Keep track of what rules/words this number has triggered, and the order the words should be spoken in
            string[] wordsToSay = {"", "", "", "", ""};
            
            if (i % 3 == 0)
            {
                wordsToSay[0] = "Fizz";
            }
            if (i % 13 == 0)
            {
                wordsToSay[1] = "Fezz";
            }
            if (i % 5 == 0)
            {
                wordsToSay[2] = "Buzz";
            }
            if (i % 7 == 0)
            {
                wordsToSay[3] = "Bang";
            }
            if (i % 11 == 0)
            {
                wordsToSay[0] = "";
                wordsToSay[2] = "";
                wordsToSay[3] = "Bong";
            }
            if (i % 17 == 0)
            {
                Array.Reverse(wordsToSay);
            }

            return wordsToSay;
        }
        
        static void PrintPhrase(string phrase)
        {
            Console.WriteLine(phrase);
        }
    }
}
