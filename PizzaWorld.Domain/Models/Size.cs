using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaWorld.Domain.Models
{
    public class Size
    {
        private int size;
        private double price;
        public double GetPrice()
        {
            return this.price;
        }
        public void MakeSmall()
        {
            this.size = 1;
            this.price = 1;
        }
        public void MakeMedium()
        {
            this.size = 2;
            this.price = 2;
        }
        public void MakeLarge()
        {
            this.size = 3;
            this.price = 3;
        }
        public override string ToString()
        {
            if(this.size == 1)
            {
                return "small";
            }
            else if(this.size == 2)
            {
                return "medium";
            }
            else if(this.size == 3)
            {
                return "large";
            }
            else { return "Unable to get size"; }
            
        }
    }
}
