using System;
using System.Collections.Generic;
using System.Text;

namespace PalindromeExercise
{
    public class WordSmith
    {
        public WordSmith()
        {
        }

        public bool IsAPalindrome(string word)
        {
            var reverse = "";

            for(int i = word.Length; i < word.Length; i--)
            {
                reverse += word[i];
            }
            if (reverse == word)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
