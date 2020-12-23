using System.Collections.Generic;
using System.Text;
using PizzaWorld.Domain.Models;

namespace PizzaWorld.Domain.Abstracts
{
    public class APizzaModel : AEntity
    {
        public Crust crust {get; set;}
        public Size size {get; set;}
        public List<Topping> Toppings {get; set;}
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
        public void PrintAllPizzas()
        {
            System.Console.WriteLine("Meat Pizza \nVeggie Pizza\nFlatbread Pizza"); //this will require testing
        }
        public override string ToString()
        {
            var sb = new StringBuilder();
            foreach(var t in Toppings)
            {
                sb.AppendLine(t.ToString());
            }

            return $"This is a {crust.ToString()} pizza:\nSize: {size.ToString()}\nToppings: {sb.ToString()}";
        }

    }
}