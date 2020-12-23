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
            if(ReadStores().Count() == 0) 
            {
                CreateStore();
            }
        }
        
        public IEnumerable<Store> ReadStores()
        {
           return _db.Stores;
        }
        public void Save(Store store)
        {
            _db.Add(store);
            _db.SaveChanges();
        }
        public void CreateStore()
        {
            private Store store = new Store();
            store.name = "banana";
            Save(store);
        }
    }
}