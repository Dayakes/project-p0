using System.Collections.Generic;
using System.Text;
using PizzaWorld.Domain.Abstracts;

namespace PizzaWorld.Domain.Models
{
    public class VeggiePizza : APizzaModel
    {
        public VeggiePizza(Size size, Crust crust)
        {
            price = 11;
            Name = "Veggie Pizza";
        }
        protected void AddCrust(Crust crust)
        {
            Crust = Crust;
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
                new Topping("onion"),
                new Topping("olives")
            };
        }
        protected override void AddName()
        {
            Name = "Veggie Pizza";
        }
    }
}