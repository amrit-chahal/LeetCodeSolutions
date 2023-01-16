using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions
{
    public class LeetCode
    {

        /*Leet Code challenges and their solutions in C# along with their performance benchmarks */



        #region Problem 28

        /*
         * Problem 28: Find the Index of the First Occurrence in a String
         * Problem Details: Given two strings needle and haystack, return the index of the first occurrence of needle in haystack, 
         * or -1 if needle is not part of haystack.
        */

        /* Examples
         * Example 1: Input: haystack = "sadbutsad", needle = "sad"
                      Output: 0
                      Explanation: "sad" occurs at index 0 and 6.
                      The first occurrence is at index 0, so we return 0. 
         * Example 2: Input: haystack = "leetcode", needle = "leeto"
                      Output: -1
                      Explanation: "leeto" did not occur in "leetcode", so we return -1. 
        */

        /* Constraints
         * 1 <= haystack.length, needle.length <= 104
         * haystack and needle consist of only lowercase English characters.
        */

        /* Solution theory
         * Theory 1: We can use String.IndexOf() method to see if needle exist in heystack, if true return index else return -1
        */

        public int StrStr(string haystack, string needle)
        {
            int index = haystack.IndexOf(needle);

            return index;

        }
        #endregion

        #region Problem 29


        /*
         * Problem {number}: Divide Two Integers

         * Problem Details: Given two integers dividend and divisor, divide two integers without using multiplication,
         * division, and mod operator.

         * The integer division should truncate toward zero, which means losing its fractional part. For example,
            8.345 would be truncated to 8, and -2.7335 would be truncated to -2.

         * Return the quotient after dividing dividend by divisor.

         *  Note: Assume we are dealing with an environment that could only store integers within the 32-bit signed
            integer range: [−231, 231 − 1]. For this problem, if the quotient is strictly greater than 231 - 1, then return 231 - 1, and if the quotient is strictly less than -231, then return -231.
        */

        /* Examples
         * 
         * Example 1: Input: dividend = 10, divisor = 3
                      Output: 3
                      Explanation: 10/3 = 3.33333.. which is truncated to 3.

         * Example 2: Input: dividend = 7, divisor = -3
                      Output: -2
                      Explanation: 7/-3 = -2.33333.. which is truncated to -2.

        */

        /* Constraints: -231 <= dividend, divisor <= 231 - 1
                        divisor != 0
       */

        /* Solution theory
         * Theory 1 (Failure - doesn't pass the edge cases): We can loop over the divdend subtracting the divisor till the remainder is less than divisor and 
         * keep count of the subtractions we did.To determine whether to return positive or negative integer we can check if both
         * inputs are negative or positive we return positive integer and if either of the input is negative we return negative.
         * 
         * Theory 2: Use bitshifting method and find the highest exponent of 2 that when multiplied by the divisor is still less 
         * than the divisor. We repeat the process on remainder until remainder less than divisor while keeping track of the exponents
         * We also handle the edge cases using if conditions. Please create a pull request if there is a better way to solve this.
         * i.e if possible to get rid of if conditions and remove long casting.:)
        */



        public int Divide(int dividend, int divisor)
        {  // Check for the edge case where dividend is int.MinValue and divisor is -1
           // In this case, quotient is greater than int.MaxValue
            if (dividend == int.MinValue && divisor == -1) return int.MaxValue;
            if (dividend == int.MinValue && divisor == 1) return int.MinValue;
            if (dividend == divisor) return 1;

            // Check if quotient is positive
            bool isPositive = (dividend < 0 == divisor < 0);

            // Convert dividend and divisor to positive values
            uint positiveDividend = (uint)Math.Abs((long)dividend);
            uint positiveDivisor = (uint)Math.Abs((long)divisor);
            uint quotient = 0;

            // Use subtraction and bit shifting to divide the two integers
            while (positiveDividend >= positiveDivisor)
            {
                short powerOfTwo = 0;
                // Find the highest power of two that is less than or equal to positiveDividend
                while (positiveDividend > (positiveDivisor << (powerOfTwo + 1)))
                    powerOfTwo++;
                quotient += (uint)(1 << powerOfTwo);
                positiveDividend = positiveDividend - (positiveDivisor << powerOfTwo);
            }

            
            return isPositive ? (int)quotient : -(int)quotient;

        }
        #endregion




    }
}
