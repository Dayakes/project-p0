using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using PizzaWorld.Domain.Models;

namespace PizzaWorld.Client
{
    public class SqlClient
    {
        private readonly PizzaWorldContext _db = new PizzaWorldContext();

        public IEnumerable<Store> ReadStores()
        {
            return _db.Stores;
        }
        public Store ReadOne(string name)
        {
            return _db.Stores.FirstOrDefault(s => s.Name == name);
        }
        public IEnumerable<Order> ReadOrders(Store store) //how to make this generic
        {
            var s = ReadOne(store.Name);
            return s.Orders;
        }
        public void Save(Store store)
        {
            _db.Add(store);
            _db.SaveChanges();
        }
        public void Update(Store store)
        {
            try
            {
                //    needs testing
                _db.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
        public Store SelectStore()
        {
            do
            {
                string input = Console.ReadLine();
                foreach (var s in _db.Stores)
                {
                    if (input == s.Name)
                    {
                        return ReadOne(input);
                    }
                }
                System.Console.WriteLine("No valid store selected, please try again");
            } while (true);
        }
    }
}
