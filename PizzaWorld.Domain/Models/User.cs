using System.Collections.Generic;
using System.Linq;
using System.Text;
using PizzaWorld.Domain.Abstracts;

namespace PizzaWorld.Domain.Models
{
    public class User
    {
        /*
        [required] must be able to view/list its order history
        [required] must be able to only order from 1 location in a 24-hour period with no reset
        [required] must be able to only order once every 2-hour period
        */
        public List<Order> Orders { get; set; }
        public long UserId { get; set; }


        public User()
        {
            Orders = new List<Order>();
            UserId = System.DateTime.Now.Ticks;
        }

        // public override string ToString()
        // {
        //     var sb = new StringBuilder();

        //     foreach (var p in SelectedPizzas)
        //     {
        //         sb.AppendLine(p.ToString());
        //     }
        //     return $"You have selected this store: {SelectedStore} and ordered these pizzas: {sb.ToString()}"; //string interpolation using the $
        // }
    }
}