using PizzaWorld.Domain.Models;
using Xunit;

namespace PizzaWorld.Testing
{
    public class UserTests
    {
        [Fact]
        private void Test_UserExists()
        {
            var sut = new User();

            var actual = sut;

            Assert.IsType<User>(actual);
            Assert.NotNull(actual);
        }
    }
}