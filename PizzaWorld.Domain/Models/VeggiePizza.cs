using System.Collections.Generic;
using PizzaWorld.Domain.Abstracts;

namespace PizzaWorld.Domain.Models
{
    public class VeggiePizza : APizzaModel
    {
        private Crust crust;
        private Size size;
        private List<Topping> toppings;
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