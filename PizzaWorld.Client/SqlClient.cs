using System.Collections.Generic;
using System.Linq;
using PizzaWorld.Domain.Models;

namespace PizzaWorld.Client
{
    public class SqlClient
    {
        private readonly PizzaWorldContext _db = new PizzaWorldContext();
        public SqlClient()
        {
            if (ReadStores().Count() == 0)
            {
                CreateStore();
            }
        }

        public IEnumerable<Store> ReadStores()
        {
            return _db.Stores;
        }
        public Store ReadOne(string name)
        {
            return _db.Stores.FirstOrDefault(s => s.Name == name);
        }
        public void Save(Store store)
        {
            _db.Add(store);
            _db.SaveChanges();
        }
        public void CreateStore()
        {
            Store store = new Store();
            store.Name = "Dominos";
            Save(store);

        }
    }
}
