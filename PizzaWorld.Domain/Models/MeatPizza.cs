using System.Collections.Generic;
using System.Text;
using PizzaWorld.Domain.Abstracts;

namespace PizzaWorld.Domain.Models
{
    public class MeatPizza : APizzaModel
    {
        public MeatPizza(Size size,Crust crust)
        {
            AddSize(size);
            AddCrust(crust);
            price = 13;
            Name = "Meat Lovers Pizza";
        }
        public MeatPizza()
        {
            Name = "Meat Lovers Pizza";
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