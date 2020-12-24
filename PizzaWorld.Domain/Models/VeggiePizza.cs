using System.Collections.Generic;
using System.Text;
using PizzaWorld.Domain.Abstracts;

namespace PizzaWorld.Domain.Models
{
    public class VeggiePizza : APizzaModel
    {
        public VeggiePizza()
        {
            AddCrust();
            AddSize();
            AddToppings();
            price = 11;
        }
        protected override void AddCrust()
        {
            crust = new Crust("regular");
        }

        protected override void AddSize()
        {
            size = new Size("medium");
        }

        protected override void AddToppings()
        {
            toppings = new List<Topping>(){
                new Topping("cheese"),
                new Topping("peppers"),
                new Topping("onion"),
                new Topping("olives")
            };
        }
        public override string ToString()
        {
            var sb = new StringBuilder();
            foreach (var t in toppings)
            {
                sb.AppendLine(t.Name);
            }
            return $"This is a {crust.Name} pizza:\nSize: {size.Name}\nToppings: {sb.ToString()}";
        }
    }
}