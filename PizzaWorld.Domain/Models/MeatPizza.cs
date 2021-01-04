using System.Collections.Generic;
using System.Text;
using PizzaWorld.Domain.Abstracts;

namespace PizzaWorld.Domain.Models
{
    public class MeatPizza : APizzaModel
    {
        public MeatPizza(Size size,Crust crust)
        {
            AddName("Meat Lovers Pizza");
            AddCrust(crust);
            AddSize(size);
            AddToppings();
            ComputePrice();
        }
        public MeatPizza()
        {
            Name = "Meat Lovers Pizza";
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
            new Topping("bacon"),
            new Topping("ham"),
            new Topping("sausage")
          };
        }
        protected void AddName(string name)
        {
            Name = name;
        }
    }
}