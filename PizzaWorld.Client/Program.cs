﻿using System.Collections.Generic;
using System.Linq;
using PizzaWorld.Domain.Abstracts;
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
            var stay = true;
            do
            {
                System.Console.WriteLine("would you like to view your history (h), place an order (o), or exit the program (x)?");
                var select = System.Console.ReadLine();
                if (select == "h")
                {
                    //show their order history
                    foreach(var o in user.Orders)
                    {
                        foreach(var p in o.Pizzas)
                        {
                            p.ToString();
                        }
                    }
                }
                else if (select == "o")
                {
                    //still not updating things properly in the database
                    PrintAllStoresWithEF();

                    var SelectedStore = _sql.SelectStore();
                    

                    List<APizzaModel> SelectedPizzas = _client.SelectPizzas();
                    SelectedPizzas.ToString();
                    SelectedStore.CreateOrder(SelectedPizzas);
                    user.Orders.Add(SelectedStore.Orders.Last());
                    _sql.AttachOrder(SelectedStore.Orders.Last()); //testing attach

                    _sql.Update(); //update DB with the store with the new order

                    foreach (var p in SelectedPizzas)
                    {
                        System.Console.WriteLine(p.ToString());
                    }
                }
                else if (select == "x")
                {
                    stay = false;
                    System.Console.WriteLine("Have a nice day!");
                }
                else
                {
                    System.Console.WriteLine("No valid selection made, please try again");
                }
            } while (stay);
        }
    }
}
