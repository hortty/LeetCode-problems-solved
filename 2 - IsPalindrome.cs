// https://leetcode.com/problems/palindrome-number/

public class Solution
{
    public bool IsPalindrome(int x)
    {
        string numberParsed = x.ToString();
        int numberQtde = numberParsed.Length / 2;
        bool isPalindrome = true;

        for (int i = 0; i < numberQtde; i++)
        {
            if (numberParsed[i] != numberParsed[(numberParsed.Length - 1) - i])
            {
                isPalindrome = false;
            }
        }

        return isPalindrome;
    }
}