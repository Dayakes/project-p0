using PizzaWorld.Domain.Models;
using Xunit;

namespace PizzaWorld.Testing
{
    public class PizzaTests
    {
        [Fact]
        private void Test_PizzaExists()
        {
            var sut = new Pizza();

            var actual = sut;

            Assert.IsType<Pizza>(actual);
            Assert.NotNull(actual);
        }
    }
}