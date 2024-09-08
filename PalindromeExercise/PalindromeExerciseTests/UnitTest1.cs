using System;
using PalindromeExercise;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("curtains", false)]
        public void Test1(string word, bool expected)
        {
            var test = new Wordsmith();
            var actual = test.IsAPalindrome(word);
            Assert.Equal(expected, actual);
        }
    }
}
