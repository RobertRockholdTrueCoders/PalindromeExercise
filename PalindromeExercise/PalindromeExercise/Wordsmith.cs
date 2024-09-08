using System;

namespace PalindromeExercise;

public class Wordsmith
{
    public bool IsAPalindrome(string word)
    {
        var reverse = "";
        for (int i = word.Length - 1; i >= 0; i--)
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