using PalindromeExercise;
using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("tenet", true)]
        [InlineData("kayak", true)]
        [InlineData("street", false)]
        [InlineData("beach", false)]
        [InlineData("racecar", true)]
        [InlineData("mars", false)]
        public void Test1(string word, bool expected)
        {
            //Assert
            var test = new WordSmith();

            //Act
            var actual = test.IsAPalindrome(word);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
