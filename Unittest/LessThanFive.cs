using EuromonitorAssesment;
using System;
using Xunit;

namespace Unittest
{
    public class LessThanFive
    {
        Logic _logic = new Logic();
        [Fact]
        public void Test1()
        {
            int input = 1;
            int expected = 4;

            //Range
            var result = _logic.CalcuteDifference(input);

            // Assert            
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Test2()
        {
            int input = 2;
            int expected = 3;

            //Range
            var result = _logic.CalcuteDifference(input);

            // Assert            
            Assert.Equal(expected, result);

        }

        [Fact]
        public void Test3()
        {
            int input = 3;
            int expected = 2;

            //Range
            var result = _logic.CalcuteDifference(input);

            // Assert            
            Assert.Equal(expected, result);

        }
    }
}
