using PizzaWorld.Domain.Abstracts;
using PizzaWorld.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace PizzaWorld.Testing
{
    public class SizeTests
    {
        [Fact]
        private void Test_PizzaExists()
        {
            var sut = new Size();

            var actual = sut;

            Assert.IsType<Size>(actual);
            Assert.NotNull(actual);
        }
        //private void Test_
    }
}
