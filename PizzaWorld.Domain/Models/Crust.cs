using PizzaWorld.Domain.Abstracts;

namespace PizzaWorld.Domain.Models
{
    public class Crust 
    {
        public string Name { get; set; }
        public long CrustId { get; set; }
        public Crust()
        {
            CrustId = System.DateTime.Now.Ticks;
        }
        public Crust(string name)
        {
            Name = name;
        }
    }
}