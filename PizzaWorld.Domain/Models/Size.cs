using PizzaWorld.Domain.Abstracts;

namespace PizzaWorld.Domain.Models
{
    public class Size : AEntity
    {
        public string Name { get; set; }

        public Size() { }
        public Size(string name)
        {
            Name = name;
        }
    }
}