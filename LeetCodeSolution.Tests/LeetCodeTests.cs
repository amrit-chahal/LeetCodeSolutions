using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCodeSolution;
using LeetCodeSolutions;
using Xunit;

namespace LeetCodeSolution.Tests
{
    public class LeetCodeTests
    {

        private static readonly LeetCode _leetCode = new LeetCode();

        #region Problem 28 TestCases

        [Theory]
        [InlineData("heystack", "needle", -1)]
        [InlineData("hello world", "oworld", -1)]
        [InlineData("heystac k", "ack", -1)]
        public void StrStr_ShouldReturnNegativeOne(string heystack, string needle, int expected)
        {
            int result = _leetCode.StrStr(heystack, needle);
            Assert.Equal(expected, result);



        }

        [Theory]
        [InlineData("needle in the heystack", "needle", 0)]
        [InlineData("hello world", "world", 6)]
        [InlineData("Tim tams", "tam", 4)]
        [InlineData("sadbutsad", "sad", 0)]

        public void StrStr_ShouldReturnZeroOrPositiveNumber(string heystack, string needle, int expected)
        {
            int result = _leetCode.StrStr(heystack, needle);
            Assert.Equal(expected, result);

        }

        #endregion


        #region Problem 29 TestCases      


        [Theory]
        [InlineData(8, 2, 4)]
        [InlineData(-8, -2, 4)]
        [InlineData(int.MaxValue, 1, int.MaxValue)]
        [InlineData(int.MinValue, -1, int.MaxValue)]

        public void Divide_ShouldReturnPositiveQuotient(int dividend, int divisor, int expected)
        {
            int result = _leetCode.Divide(dividend, divisor);
            Assert.Equal(expected, result);

        }

        [Theory]
        [InlineData(-8, 2, -4)]
        [InlineData(8, -2, -4)]
        [InlineData(int.MinValue, 1, int.MinValue)]
        [InlineData(int.MaxValue, -1, -int.MaxValue)]
        public void Divide_ShouldReturnNegativeQuotient(int dividend, int divisor, int expected)
        {
            int result = _leetCode.Divide(dividend, divisor);
            Assert.Equal(expected, result);
        }
        #endregion


        #region Problem 31 TestCases
        [Theory]
        [InlineData(new int[] { 1 }, new int[] { 1 })]
        [InlineData(new int[] { 1, 2 }, new int[] { 2, 1 })]
        [InlineData(new int[] { 3, 2, 1 }, new int[] { 1, 2, 3 })]
        [InlineData(new int[] { 1, 1, 5 }, new int[] { 1, 5, 1 })]
        [InlineData(new int[] { 1, 3, 2 }, new int[] { 2, 1, 3 })]
        [InlineData(new int[] { 1, 5, 8, 4 }, new int[] { 1, 8, 4, 5 })]
        public void NextPermutaions_ShouldReturnNextPermutation(int[] nums, int[] expected)
        {
            _leetCode.NextPermutation(nums);
            Assert.Equal(expected, nums);
        }
        #endregion
    }

}
