using System.Collections.Generic;
using System.Text;
using PizzaWorld.Domain.Abstracts;

namespace PizzaWorld.Domain.Models
{
    public class MeatPizza : APizzaModel
    {
        public MeatPizza()
        {
            price = 13;
        }
        protected override void AddCrust()
        {
            crust = new Crust("stuffed");
        }

        protected override void AddSize()
        {
            size = new Size("large");
        }

        protected override void AddToppings()
        {
            toppings = new List<Topping>(){
            new Topping("cheese"),
            new Topping("bacon"),
            new Topping("ham"),
            new Topping("sausage")
          };
        }
        protected override void AddName()
        {
            Name = "Meat Pizza";
        }
    }
}