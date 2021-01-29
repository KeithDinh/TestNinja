using NUnit.Framework;
using TestNinja.Fundamentals;


namespace TestNinja.UnitTests
{
    [TestFixture]
    public class MathTests
    {
        private Math _math;
        
        // SetUp
        [SetUp]
        public void SetUp()
        {
            _math = new Math();
        }
        
        [Test]
        [Ignore("This will ignore the test function")]
        public void Add_WhenCalled_ReturnTheSumOfArguments()
        {
            var result = _math.Add(1, 2);
            
            Assert.That(result, Is.EqualTo(3));
        }

        // Arguments from TestCase will be passed to the test function
        [Test]
        [TestCase(2,1,2)] 
        [TestCase(1,2,2)]
        [TestCase(1,1,1)]
        public void Max_WhenCalled_ReturnTheGreaterArgument(int input1, int input2, int expectedResult)
        {
            var result = _math.Max(input1, input2);
            
            Assert.That(result,Is.EqualTo(expectedResult));
        }
        
        // [Test]
        // public void Max_SecondArgumentIsGreater_ReturnTheFirstArgument()
        // {
        //     var result = _math.Max(1, 2);
        //     
        //     Assert.That(result,Is.EqualTo(2));
        // }
        //
        // [Test]
        // public void Max_ArgumentsAreEqual_ReturnTheFirstArgument()
        // {
        //     var result = _math.Max(1, 1);
        //     
        //     Assert.That(result,Is.EqualTo(1));
        // }
    }
}