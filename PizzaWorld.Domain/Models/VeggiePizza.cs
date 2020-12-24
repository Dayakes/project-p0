using System.Collections.Generic;
using System.Text;
using PizzaWorld.Domain.Abstracts;

namespace PizzaWorld.Domain.Models
{
    public class VeggiePizza : APizzaModel
    {
        private Crust crust;
        private Size size;
        private List<Topping> toppings;
        public double price;
        public VeggiePizza()
        {
            AddCrust();
            AddSize();
            AddToppings();
        }
        protected override void AddCrust()
        {
            this.crust = new Crust("regular");
        }

        protected override void AddSize()
        {
            this.size = new Size("medium");
        }

        protected override void AddToppings()
        {
            this.toppings = new List<Topping>(){
                new Topping("cheese"),
                new Topping("peppers"),
                new Topping("onion"),
                new Topping("olives")
            };
        }
        public override string ToString()
        {
            var sb = new StringBuilder();
            foreach (var t in Toppings)
            {
                sb.AppendLine(t.Name);
            }
            return $"This is a {crust.Name} pizza:\nSize: {size.Name}\nToppings: {sb.ToString()}";
        }
    }
}