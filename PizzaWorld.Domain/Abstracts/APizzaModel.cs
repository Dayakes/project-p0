using System.Collections.Generic;
using System.Text;
using PizzaWorld.Domain.Models;

namespace PizzaWorld.Domain.Abstracts
{
    public class APizzaModel 
    {
        public Crust Crust {get; set;}
        public Size Size {get; set;}
        public ICollection<Topping> Toppings {get; set;}
        public double price { get; set; }
        public long PizzaId { get; set; }
        public long OrderId { get; set; }
        public string Name { get; set; }
        protected APizzaModel()
        {
            AddCrust();
            AddSize();
            AddToppings();
            SetPrice();
            AddName();
        }
        protected virtual void AddCrust(){}
        protected virtual void AddSize(){}
        protected virtual void AddToppings(){}
        protected virtual void SetPrice(){}
        protected virtual void AddName(){}

        public override string ToString()
        {
            var sb = new StringBuilder();
            foreach (var t in Toppings)
            {
                sb.AppendLine(t.Name);
            }
            return $"This is a {Name} for ${price}:\nCrust: {Crust.Name}\nSize: {Size.Name}\nToppings: {sb.ToString()}";
        }

        

    }
}