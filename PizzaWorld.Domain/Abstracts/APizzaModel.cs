using System.Collections.Generic;

namespace PizzaWorld.Domain.Abstracts
{
    public abstract class APizzaModel
    {
        public string Crust {get; set;}
        public string Size {get; set;}
        public List<string> Toppings {get; set;}
        protected APizzaModel()
        {
            AddCrust();
            AddSize();
            AddToppings();
            SetPrice();
        }
        protected virtual void AddCrust(){}
        protected virtual void AddSize(){}
        protected virtual void AddToppings(){}
        protected virtual void SetPrice(){}
        protected void PrintAllPizzas()
        {
            System.Console.WriteLine("Meat Pizza /nVeggie Pizza/nFlatbread Pizza"); //this will require testing
        }

    }
}