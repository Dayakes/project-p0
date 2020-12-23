using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaWorld.Domain.Abstracts
{
    public class Crust : AEntity
    {//I CAN DO THIS BY MAKING A FACTORY AND MAKING THEM THEIR OWN CLASSES
        private int crust;
        private double price;
        public double GetPrice()
        {
            return this.price;
        }

        public void MakeRegular()
        {
            this.crust = 1;
            this.price = 4;
        }
        public void MakeFlatbread()
        {
            this.crust = 2;
            this.price = 3;
        }
        public void MakeStuffed()
        {
            this.crust = 3;
            this.price = 6;
        }
        public override string ToString()
        {
            if(this.crust == 1)
            {
                return "regular";
            }
            else if(this.crust == 2)
            {
                return "flatbread";
            }
            else if(this.crust == 3)
            {
                return "stuffed";
            }
            else { return "Unable to get Crust"; }
        }
    }
}
