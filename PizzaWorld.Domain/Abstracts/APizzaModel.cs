using System.Collections.Generic;
using System.Text;
using PizzaWorld.Domain.Models;

namespace PizzaWorld.Domain.Abstracts
{
    public class APizzaModel 
    {
        public Crust crust {get; set;}
        public Size size {get; set;}
        public ICollection<Topping> toppings {get; set;}
        // public List<OrderAPizzaModel> OrderAPizzaModels { get; set; }
        public double price { get; set; }
        public long PizzaId { get; set; }
        public long OrderId { get; set; }
        protected APizzaModel()
        {
            // crust = new Crust();
            // size = new Size();
            // toppings = new List<Topping>(){
            //     new Topping(),
            //     new Topping()
            // };
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
        public override string ToString()
        {
            var sb = new StringBuilder();
            foreach (var t in toppings)
            {
                sb.AppendLine(t.Name);
            }
            return $"This is a {crust.Name} pizza for ${price}:\nSize: {size.Name}\nToppings: {sb.ToString()}";
        }

        

    }
}