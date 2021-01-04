using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PizzaWorld.Domain.Abstracts;

namespace PizzaWorld.Domain.Models
{
    public class Topping
    {
        public string Name { get; set; }

        public Topping() 
        {
            Name = "";
        }
        public Topping(string name)
        {
            Name = name;
        }
    }
}
