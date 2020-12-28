using System.Collections.Generic;
using System.Text;
using PizzaWorld.Domain.Abstracts;

namespace PizzaWorld.Domain.Models
{
    public class FlatbreadPizza : APizzaModel
    {
        public FlatbreadPizza()
        {
            AddCrust();
            AddSize();
            AddToppings();
            AddName();
            price = 8;
        }

        protected override void AddCrust()
        {
            crust = new Crust("flatbread");
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
            new Topping("olives")
          };
        }
        protected override void AddName()
        {
            Name = "Flatbread Pizza";
        }
    }
}