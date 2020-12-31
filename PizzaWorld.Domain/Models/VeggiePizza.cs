using System.Collections.Generic;
using System.Text;
using PizzaWorld.Domain.Abstracts;

namespace PizzaWorld.Domain.Models
{
    public class VeggiePizza : APizzaModel
    {
        public VeggiePizza(Size size, Crust crust)
        {
            Name = "Veggie Pizza";
            Size = size;
            Crust = crust;
            ComputePrice();
        }
        public VeggiePizza()
        {
            Name = "Veggie Pizza";
        }
        public void AddCrust(Crust crust)
        {
            Crust = Crust;
        }

        public void AddSize(Size size)
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