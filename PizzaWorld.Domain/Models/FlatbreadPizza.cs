using System.Collections.Generic;
using System.Text;
using PizzaWorld.Domain.Abstracts;

namespace PizzaWorld.Domain.Models
{
    public class FlatbreadPizza : APizzaModel
    {
        public FlatbreadPizza(Size size,Crust crust)
        {
            price = 8;
        }

        protected void AddCrust(Crust crust)
        {
            Crust = crust;
        }

        protected void AddSize(Size size)
        {
            Size = size;
        }

        protected override void AddToppings()
        {
            Toppings = new List<Topping>(){
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