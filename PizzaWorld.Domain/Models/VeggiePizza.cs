using System.Collections.Generic;
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
            this.crust = new Crust("regular");
            this.size = new Size("medium");
            this.toppings = new List<Topping>(){
                new Topping("cheese"),
                new Topping("peppers"),
                new Topping("onion"),
                new Topping("olives")
            };
        }
        protected override void AddCrust()
        {
            
        }

        protected override void AddSize()
        {
            
        }

        protected override void AddToppings()
        {
        }
    }
}