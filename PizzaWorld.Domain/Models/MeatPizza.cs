using System.Collections.Generic;
using System.Text;
using PizzaWorld.Domain.Abstracts;

namespace PizzaWorld.Domain.Models
{
    public class MeatPizza : APizzaModel
    {
        public MeatPizza()
        {
          AddCrust();
          AddSize();
          AddToppings();
          this.price = 13;
        }
        protected override void AddCrust()
        {
            this.crust = new Crust("stuffed");
        }

        protected override void AddSize()
        {
            this.size = new Size("large");
        }

        protected override void AddToppings()
        {
            this.toppings = new List<Topping>(){
            new Topping("cheese"),
            new Topping("bacon"),
            new Topping("ham"),
            new Topping("sausage")
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