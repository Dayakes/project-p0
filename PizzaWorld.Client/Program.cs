using System.Collections.Generic;
using System.Linq;
using PizzaWorld.Domain.Models;
using PizzaWorld.Domain.Singletons;

namespace PizzaWorld.Client
{
    class Program
    {
        private static readonly ClientSingleton _client = ClientSingleton.Instance;
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
            foreach(var store in _client.Stores)
            {
                System.Console.WriteLine(store);
            }
        }
        static void UserView()
        {
            var user = new User();

            PrintAllStores();

            user.SelectedStore = _client.SelectStore();
            user.SelectedPizzas = _client.SelectPizzas();
            user.SelectedStore.CreateOrder();
            user.Orders.Add(user.SelectedStore.Orders.Last());
            user.SelectedPizzas = _client.SelectPizzas();
            foreach(var p in user.SelectedPizzas)
            {
                System.Console.WriteLine(p.ToString());
            }
            // while user.SelectPizza() get all pizzas from the user and then close loop and create order
            
            user.Orders.Last().MakeMeatPizza();
            user.Orders.Last().MakeVeggiePizza();
            user.Orders.Last().MakeFlatbreadPizza();
            

            System.Console.WriteLine(user.ToString());

        }
    }
}
