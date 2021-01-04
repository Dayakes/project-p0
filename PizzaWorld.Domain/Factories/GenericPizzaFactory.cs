using PizzaWorld.Domain.Abstracts;
using PizzaWorld.Domain.Models;

namespace PizzaWorld.Domain.Factories
{
    class GenericPizzaFactory
    {
        public T Make<T>() where T : APizzaModel, new()
        {
            return new T();
        }
    }
}