using System.Collections.Generic;
using System.Text;
using PizzaWorld.Domain.Abstracts;

namespace PizzaWorld.Domain.Models
{
    public class HawaiianPizza : APizzaModel
    {
        public HawaiianPizza(Size size,Crust crust)
        {
            price = 8;
            Name = "Hawaiian Pizza";
        }
        public HawaiianPizza()
        {
            Name = "Hawaiian Pizza";
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