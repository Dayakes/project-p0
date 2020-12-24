using System.Collections.Generic;
using PizzaWorld.Domain.Abstracts;

namespace PizzaWorld.Domain.Models
{
    public class FlatbreadPizza : APizzaModel
    {
        private Crust crust;
        private Size size;
        private List<Topping> toppings;
        public FlatbreadPizza()
        {
          AddCrust();
          AddSize();
          AddToppings();
        }

        protected void AddCrust()
        {
          this.crust = new Crust("flatbread");
        }

        protected void AddSize()
        {
          this.size = new Size("medium");
        }

        protected void AddToppings()
        {
          this.toppings = new List<Topping>(){
            new Topping("cheese"),
            new Topping("peppers"),
            new Topping("olives")
          };
        }
    }
}