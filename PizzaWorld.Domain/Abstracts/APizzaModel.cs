using System.Collections.Generic;
using System.Text;
using PizzaWorld.Domain.Models;

namespace PizzaWorld.Domain.Abstracts
{
    public class APizzaModel
    {
        public Crust Crust { get; set; }
        public Size Size { get; set; }
        public ICollection<Topping> Toppings { get; set; }
        public double Price { get; set; }
        public long PizzaId { get; set; }
        public long OrderId { get; set; }
        public string Name { get; set; }
        protected APizzaModel()
        {

        }
        public override string ToString()
        {
            var sb = new StringBuilder();
            
            foreach (var t in Toppings)
            {
                sb.AppendLine(t.Name);
            }
            return $"This is a {Name} for ${Price}:\nCrust: {Crust.Name}\nSize: {Size.Name}\nToppings: {sb.ToString()}";
        }
        public virtual void ComputePrice()
        {
            Price = Crust.Price + Size.Price;
        }



    }
}