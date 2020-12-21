using System.Collections.Generic;
using System.Text;

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

            return $"This is a {Crust} pizza:\nSize: {Size}\nToppings: {sb.ToString()}";
        }

    }
}