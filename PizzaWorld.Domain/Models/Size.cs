using PizzaWorld.Domain.Abstracts;

namespace PizzaWorld.Domain.Models
{
    public class Size
    {
        public string Name { get; set; }
        public long SizeId { get; set; }

        public Size() { }
        public Size(string name)
        {
            Name = name;
            SizeId = System.DateTime.Now.Ticks;
        }
    }
}