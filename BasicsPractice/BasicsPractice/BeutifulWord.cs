using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsPractice
{
    public class BeutifulWord
    {
        static void MainVE(String[] args)
        {
            Dictionary<char, string> vowels = new Dictionary<char, string>();
            vowels.Add('a', "a");
            vowels.Add('e', "e");
            vowels.Add('i', "i");
            vowels.Add('o', "o");
            vowels.Add('u', "u");
            vowels.Add('y', "y");
            string w = Console.ReadLine();
            char prevChar = new char();
            var currentChar = new char();
            bool isBeautiful = false;
            foreach (var item in w)
            {
                prevChar = currentChar;
                currentChar = item;
                bool isPrevVowel = false;
                bool isCurrentVowel = false;
                if (vowels.ContainsKey(prevChar))
                {
                    isPrevVowel = true;
                }
                if (vowels.ContainsKey(currentChar))
                {
                    isCurrentVowel = true;
                }
                if (prevChar == currentChar || (isPrevVowel && isCurrentVowel))
                {
                    isBeautiful = true;
                    break;
                }
            }

            Console.WriteLine(isBeautiful ? "No" : "Yes");
        }
    }
}
