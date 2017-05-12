using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyChallenge198E
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Compare("cause", "because"));
            Console.WriteLine();
            Console.WriteLine(Compare("hello", "below"));
            Console.WriteLine();
            Console.WriteLine(Compare("hit", "miss"));
            Console.WriteLine();
            Console.WriteLine(Compare("rekt", "pwn"));
            Console.WriteLine();
            Console.WriteLine(Compare("combo", "jumbo"));
            Console.WriteLine();
            Console.WriteLine(Compare("critical", "optical"));
            Console.WriteLine();
            Console.WriteLine(Compare("isoenzyme", "apoenzyme"));
            Console.WriteLine();
            Console.WriteLine(Compare("tribesman", "brainstem"));
            Console.WriteLine();
            Console.WriteLine(Compare("blames", "nimble"));
            Console.WriteLine();
            Console.WriteLine(Compare("yakuza", "wizard"));
            Console.WriteLine();
            Console.WriteLine(Compare("longbow", "blowup"));
            Console.WriteLine();

            Console.ReadLine();
        }

        static string Compare(string inputFirstWord, string inputSecondWord)
        {
            if (inputFirstWord.Contains(inputSecondWord))
            {
                string fResult = inputFirstWord.Replace(inputSecondWord, "");
                return string.Format("{0} vs. {1}\nExtra letters: {2}\nLeft side wins, {3} to 0", inputFirstWord, inputSecondWord, fResult, fResult.Length);
            }

            if (inputSecondWord.Contains(inputFirstWord))
            {
                string sResult = inputSecondWord.Replace(inputFirstWord, "");
                return string.Format("{0} vs. {1}\nExtra letters: {2}\nRight side wins, 0 to {3}", inputFirstWord, inputSecondWord, sResult, sResult.Length);
            }

            var firstWord = inputFirstWord.ToList();
            var secondWord = inputSecondWord.ToList();
            var originalFirst = inputFirstWord;
            var originalSecond = inputSecondWord;

            foreach (var letter in originalFirst)
            {
                if (inputSecondWord.Contains(letter))
                {
                    firstWord.Remove(letter);
                    inputFirstWord = string.Join("", firstWord);
                    secondWord.Remove(letter);
                    inputSecondWord = string.Join("", secondWord);
                }
            }         

            string firstResult = string.Join("", firstWord);
            string secondResult = string.Join("", secondWord);

            if (firstResult.Length > secondResult.Length)            
                return string.Format("{0} vs. {1}\nExtra letters: {2}\nLeft side wins, {3} to {4}", originalFirst, originalSecond, firstResult+secondResult, firstResult.Length, secondResult.Length);
            
            if (firstResult.Length < secondResult.Length)
                return string.Format("{0} vs. {1}\nExtra letters: {2}\nRight side wins, {3} to {4}", originalFirst, originalSecond, firstResult + secondResult, firstResult.Length, secondResult.Length);

            return string.Format("{0} vs. {1}\nExtra letters: {2} \nTie, {3} to {4}", originalFirst, originalSecond, firstResult + secondResult, firstResult.Length, secondResult.Length);
        }
    }
}
