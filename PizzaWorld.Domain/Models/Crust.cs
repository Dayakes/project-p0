using PizzaWorld.Domain.Abstracts;

namespace PizzaWorld.Domain.Models
{
    public class Crust 
    {
        public string Name { get; set; }
        public long CrustId { get; set; }
        public Crust()
        {
        }
        public Crust(string name)
        {
            Name = name;
        }
    }
}