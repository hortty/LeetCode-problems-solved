// https://leetcode.com/problems/roman-to-integer/

public class Solution {
    public int RomanToInt(string s)
    {
        int integerValue = 0;

        for(int i=0;i<s.Length;i++)
        {
            switch(s[i])
            {
                case 'I':

                    if(ValidateLengthAndCompare(s, ref i, 'V'))
                        integerValue += 4;
                    else if(ValidateLengthAndCompare(s, ref i, 'X'))
                        integerValue += 9;
                    else
                        integerValue += 1;

                break;

                case 'V':

                    integerValue += 5;

                break;

                case 'X':

                    if(ValidateLengthAndCompare(s, ref i, 'L'))
                        integerValue += 40;
                    else if(ValidateLengthAndCompare(s, ref i, 'C'))
                        integerValue += 90;
                    else
                        integerValue += 10;

                break;

                case 'L':

                    integerValue += 50;

                break;

                case 'C':

                    if(ValidateLengthAndCompare(s, ref i, 'D'))
                        integerValue += 400;
                    else if(ValidateLengthAndCompare(s, ref i, 'M'))
                        integerValue += 900;
                    else
                        integerValue += 100;

                break;

                case 'D':

                    integerValue += 500;

                break;

                case 'M':

                    integerValue += 1000;

                break;
            }
        }

        return integerValue;
    }

    public bool ValidateLengthAndCompare(string s, ref int pos, char value)
    {
        if(pos + 1 < s.Length && s[pos + 1] == value)
        {
            pos++;
            return true;
        }
        return false;
    }
}
