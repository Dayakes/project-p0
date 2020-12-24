﻿using System.Collections.Generic;
using System.Linq;
using PizzaWorld.Domain.Models;
using PizzaWorld.Domain.Singletons;

namespace PizzaWorld.Client
{
    class Program
    {
        private static readonly ClientSingleton _client = ClientSingleton.Instance;
        private static readonly SqlClient _sql = new SqlClient();
        static void Main(string[] args)
        {
            UserView();
        }

        static IEnumerable<Store> GetAllStores()
        {
            return _client.Stores;
        }

        static void PrintAllStores()
        {
            foreach (var store in _client.Stores)
            {
                System.Console.WriteLine(store);
            }
        }
        static void PrintAllStoresWithEF()
        {
            foreach (var store in _sql.ReadStores())
            {
                System.Console.WriteLine(store.Name);
            }
        }
        static void UserView()
        {
            var user = new User();

            PrintAllStoresWithEF();

            user.SelectedStore = _sql.SelectStore();
            user.SelectedPizzas = _client.SelectPizzas();
            user.SelectedPizzas.ToString();
            user.SelectedStore.CreateOrder(user.SelectedPizzas);
            user.Orders.Add(user.SelectedStore.Orders.Last());

            _sql.Update(user.SelectedStore); //update the store with the new order

            foreach (var p in user.SelectedPizzas)
            {
                System.Console.WriteLine(p.ToString());
            }
        }
    }
}
