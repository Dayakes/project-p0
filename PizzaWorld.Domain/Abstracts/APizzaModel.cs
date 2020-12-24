using System.Collections.Generic;
using System.Text;
using PizzaWorld.Domain.Models;

namespace PizzaWorld.Domain.Abstracts
{
    public class APizzaModel : AEntity
    {
        public Crust crust {get; set;}
        public Size size {get; set;}
        public List<Topping> Toppings {get; set;}
        protected APizzaModel()
        {
            crust = new Crust();
            size = new Size();
            Toppings = new List<Topping>(){
                new Topping(),
                new Topping()
            };
            AddCrust();
            AddSize();
            AddToppings();
            SetPrice();
        }
        protected virtual void AddCrust(){}
        protected virtual void AddSize(){}
        protected virtual void AddToppings(){}
        protected virtual void SetPrice(){}
        public void PrintAllPizzas()
        {
            System.Console.WriteLine("Meat Pizza \nVeggie Pizza\nFlatbread Pizza"); //this will require testing
        }
        

    }
}