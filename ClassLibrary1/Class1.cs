using System;
using Xunit;

namespace ClassLibrary1
{
    public class Class1
    {


     

        public int factorial(int n)
        {
            if (n == 0 || n == 1)
            {
                return 1;
            }
            else
            {
                return n * factorial(n - 1);
            }
        }
        public int countDigits(int num)
        {
            int temp = num;
            int count = 0;
            while (num > 0)
            {
                int rem = num % 10;
                if (temp % rem == 0)
                    count++;
                num /= 10;
            }
            return count;
        }
    
        public int heightChecker(int[] heights)
        {
            int n = heights.Length;
            int count = 0;
            for (int i = 0; i < n - 1; i++)
            {
                if (heights[i] >= heights[i + 1])
                {
                    count++;
                }
            }
            return count;
        }
        public bool JudgeCircle(string moves)
        {
            long countU = CountOfChar(moves, 'U');
            long countR = CountOfChar(moves, 'R');
            long countD = CountOfChar(moves, 'D');
            long countL = CountOfChar(moves, 'L');

            return countD == countU && countR == countL;
        }

        public static long CountOfChar(string moves, char ch)
        {
            return moves.Count(c => c == ch);
        }
        public bool SquareIsWhite(string coordinates)
        {
            char lit = coordinates[0];
            int value = int.Parse(coordinates.Substring(1));

            if ((lit == 'a' || lit == 'c' || lit == 'e' || lit == 'g') && value % 2 == 0)
            {
                return true;
            }
            else if ((lit == 'b' || lit == 'd' || lit == 'f' || lit == 'h') && value % 2 != 0)
            {
                return true;
            }

            return false;
        }

    }

}
