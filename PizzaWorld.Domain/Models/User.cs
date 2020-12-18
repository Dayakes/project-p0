using System.Collections.Generic;

namespace PizzaWorld.Domain.Models
{
    public class User
    {
        /*
        [required] must be able to view/list its order history
        [required] must be able to only order from 1 location in a 24-hour period with no reset
        [required] must be able to only order once every 2-hour period
        */
        public List<Order> Orders {get; set;}
        public Store SelectedStore { get; set; }
        
        public override string ToString()
        {
            return $"I have selected this store: {SelectedStore}"; //string interpolation using the $
        }
    }
}