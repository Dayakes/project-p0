using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaWorld.Domain.Models
{
    public class Topping
    {
        public double Price { get; set; }
        public string Name { get; set; }
        //need a read method to get all the toppings from the DB
    }
}
