using PizzaWorld.Domain.Models;
using Xunit;

namespace PizzaWorld.Testing
{
    public class StoreTests
    {
        [Fact]
        private void Test_StoreExists()
        {
            var sut = new Store();

            var actual = sut;

            Assert.IsType<Store>(actual);
            Assert.NotNull(actual);
        }
        [Fact]
        private void Test_HasOrders()
        {
            var sut = new Store();

            var actual = sut;

            Assert.IsType<Order>(actual.Orders);
            
        }
    }
}