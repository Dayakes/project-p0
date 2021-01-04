using PizzaWorld.Domain.Abstracts;

namespace PizzaWorld.Domain.Models
{
    public class Size
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Size() 
        {
            Name = "";
            Price = 0;
        }
        public Size(string name)
        {
            Name = name;
            if(Name.Equals("Small"))
            {
                Price = 5;
            }
            else if(Name.Equals("Medium"))
            {
                Price = 6;
            }
            else if(Name.Equals("Large"))
            {
                Price = 7;
            }
        }
    }
}