using System.Collections.Generic;
using System.Linq;
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
    }
}
