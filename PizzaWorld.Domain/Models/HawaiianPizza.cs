using System.Collections.Generic;
using System.Text;
using PizzaWorld.Domain.Abstracts;

namespace PizzaWorld.Domain.Models
{
    public class HawaiianPizza : APizzaModel
    {
        public HawaiianPizza(Size size,Crust crust)
        {
            AddName("Hawaiian Pizza");
            AddCrust(crust);
            AddSize(size);
            AddToppings();
            ComputePrice();
        }
        public HawaiianPizza()
        {
            Name = "Hawaiian Pizza";
            Crust = new Crust();
            Size = new Size();
            Toppings = new List<Topping>();
        }

        public void AddCrust(Crust crust)
        {
            Crust = crust;
        }

        public void AddSize(Size size)
        {
            Size = size;
        }

        protected void AddToppings()
        {
            Toppings = new List<Topping>(){
            new Topping("cheese"),
            new Topping("peppers"),
            new Topping("olives")
          };
        }
        protected void AddName(string name)
        {
            Name = name;
        }
    }
}