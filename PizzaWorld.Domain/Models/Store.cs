using System;
using System.Collections.Generic;

namespace PizzaWorld.Domain.Models
{
    public class Store
    {
        /*
        [required] there should exist at least 2 stores for a user to choose from
        [required] each store should be able to view/list any and all of their completed/placed orders
        [required] each store should be able to view/list any and all of their sales (amount of revenue weekly or monthly)
        */
        public List<Order> Orders {get; set;}
        public void CreateOrder()
        {
            Orders.Add(new Order());
        }
        bool DeleteOrder(Order order)
        {
            try
            {
                Orders.Remove(order);
                return true;
            }
            catch
            {
                return false;
            }            
        }
    }
}