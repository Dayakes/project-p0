using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using PizzaWorld.Domain.Abstracts;
using PizzaWorld.Domain.Models;

namespace PizzaWorld.Client
{
    public class SqlClient
    {
        private readonly PizzaWorldContext _db = new PizzaWorldContext();

        public void Update()
        {
            try
            {
                _db.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
        public IEnumerable<Store> ReadStores()
        {
            return _db.Stores;
        }
        public Store ReadOneStore(string name)
        {
            return _db.Stores.FirstOrDefault(s => s.Name == name);
        }
        public User ReadOneUser(string name)
        {
            return _db.Users.FirstOrDefault(u => u.Name == name);
        }
        public User GetUser(string name)
        {
            return _db.Users.FirstOrDefault(u => u.Name == name);
        }
        public List<APizzaModel> GetPizzas(Order o)
        {
            return _db.Pizzas.Where(p => p.OrderId == o.OrderId).ToList();
        }
        public void AddUser(User user)
        {
            _db.Users.Add(user);
            _db.SaveChanges();
        }
        public IEnumerable<Order> ReadOrders(long id) //i need to get the orders based on the users id
        {
            return _db.Orders.Where(o => o.UserId == id);
        }
        public void SaveOrder(Order o)
        {
            _db.Orders.Add(o);
        }
        public void Save(Store store)
        {
            _db.Add(store);
            _db.SaveChanges();
        }
        public Store SelectStore()
        {
            string input = Console.ReadLine();
            return ReadOneStore(input);
        }
    }
}
