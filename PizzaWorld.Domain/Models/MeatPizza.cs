using System.Collections.Generic;
using PizzaWorld.Domain.Abstracts;

namespace PizzaWorld.Domain.Models
{
    public class MeatPizza : APizzaModel
    {
        private Crust crust;
        private Size size;
        private List<Topping> toppings;
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
    }
}