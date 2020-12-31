using System.Collections.Generic;
using System.Text;
using PizzaWorld.Domain.Abstracts;

namespace PizzaWorld.Domain.Models
{
    public class HawaiianPizza : APizzaModel
    {
        public HawaiianPizza(Size size,Crust crust)
        {
            Name = "Hawaiian Pizza";
            Size = size;
            Crust = crust;
            ComputePrice();
        }
        public HawaiianPizza()
        {
            Name = "Hawaiian Pizza";
        }

        public void AddCrust(Crust crust)
        {
            Crust = crust;
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
            new Topping("olives")
          };
        }
        protected override void AddName()
        {
            Name = "Hawaiian Pizza";
        }
    }
}