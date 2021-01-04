using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using PizzaWorld.Domain.Models;

namespace PizzaWorld.Testing
{
    public class ToppingTests
    {
        [Fact]
        private void Test_ToppingExists()
        {
            var sut = new Topping();

            var actual = sut;

            Assert.IsType<Topping>(actual);
            Assert.NotNull(actual);
        }
        [Fact]
        private void Test_Hasinfo()
        {
            var sut = new Topping();

            var actual = sut;

            Assert.NotNull(actual.Name);
        }
    }
}
