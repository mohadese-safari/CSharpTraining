using System;

namespace Q1
{
    class ConvertStringToInteger
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer number:");
            string num = Console.ReadLine();
            int numericValue = StringToNumber(num);
            Console.WriteLine(numericValue);
        }

        static int StringToNumber(string num)
        {
            int i = (num[0] == '+' || num[0] == '-') ? 1 : 0;
            int sign = num[0] == '-' ? -1 : 1;
            int numericValue = 0 ;
            int digit;
            for (; i < num.Length; i++)
            {
                digit = num[i] - '0';
                numericValue = numericValue * 10 + CharToInt(num[i]);
            }
            numericValue *= sign;
            return numericValue;
        }

        static int CharToInt(char ch)
        {
            if (ch < '0' || ch > '9')
            {
                throw new Exception("Not a valid integer");
            }
            return ch - '0';
        }
    }


}
