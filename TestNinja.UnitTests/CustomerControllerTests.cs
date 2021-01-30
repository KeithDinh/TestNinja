// The number below indicates the order of learning this project
// 3

using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class CustomerControllerTests
    {
        [Test]
        public void GetCustomer_IdIsZero_ReturnNotFound()
        {
            var controller = new CustomerController();

            var result = controller.GetCustomer(0);
            
            // Exact type
            Assert.That(result, Is.TypeOf<NotFound>());
            
            // Either type or derivatives of types
            // Assert.That(result, Is.InstanceOf<NotFound>());
        }
        [Test]
        public void GetCustomer_IdIsNotZero_ReturnOk()
        {
            var controller = new CustomerController();

            var result = controller.GetCustomer(2);
            
            // Exact type
            Assert.That(result, Is.TypeOf<Ok>());
        }

    }
}