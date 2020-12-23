using PizzaWorld.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaWorld.Domain.Factories
{
    public class GenericCrustFactory
    {
        public T Make<T>() where T : Crust, new()
        {
            return new T();
        }
    }
}
