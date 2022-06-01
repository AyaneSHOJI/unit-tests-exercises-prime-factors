using Xunit;
using PrimeFactors;

namespace PrimeFactorsUnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            //arrange
            int number = 10;
            string expected = "5 x 2";

            //act
            string actual = Primes.PrimeFactors(number);

            //assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Test2()
        {
            //arrange
            int number = 50;
            string expected = "3 x 5 x 2";

            //act
            string actual = Primes.PrimeFactors(number);

            //assert
            Assert.Equal(expected, actual);
        }
    }
}