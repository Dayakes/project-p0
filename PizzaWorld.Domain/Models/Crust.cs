using PizzaWorld.Domain.Abstracts;

namespace PizzaWorld.Domain.Models
{
    public class Crust
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public Crust()
        {
            Name = "";
            Price = 0;
        }
        public Crust(string name)
        {
            Name = name;
            if(Name.Equals("Flatbread"))
            {
                Price = 5;
            }
            else if(Name.Equals("Regular"))
            {
                Price = 6;
            }
            else if(Name.Equals("Stuffed"))
            {
                Price = 8;
            }
        }
    }
}