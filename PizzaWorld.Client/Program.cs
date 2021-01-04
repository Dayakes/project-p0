using System.Collections.Generic;
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
            UserOrStore();
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


        static void UserView(User user)
        {
            System.Console.Clear();
            var stay = true;
            do
            {
                System.Console.WriteLine("would you like to view your history (h), place an order (o), or logout (x)?");
                var select = System.Console.ReadLine();
                if (select.Equals("h"))
                {
                    System.Console.Clear();
                    foreach (var o in user.Orders)
                    {
                        System.Console.WriteLine(o.ToString());
                    }
                }
                else if (select.Equals("o"))
                {   
                    System.Console.WriteLine("Please select a store by typing its name :");
                    PrintAllStoresWithEF();

                    var SelectedStore = _sql.SelectStore();
                    List<APizzaModel> SelectedPizzas = _client.SelectPizzas();

                    System.Console.Clear();

                    SelectedStore.CreateOrder(SelectedPizzas);
                    user.Orders.Add(SelectedStore.Orders.Last());

                    _sql.SaveOrder(user.Orders.Last());
                    _sql.Update();

                    System.Console.WriteLine("Here are all the pizzas you ordered::");
                    foreach (var p in SelectedPizzas)
                    {
                        System.Console.WriteLine(p.ToString());
                    }
                    System.Console.WriteLine("::: END OF ORDER :::");
                }
                else if (select.Equals("x"))
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
        static void UserOrStore()
        {
            bool login = true;
            do
            {
                System.Console.WriteLine("Are you logging in as a User (u) or a Store (s) or would you like to quit (q)?");
                var input = System.Console.ReadLine();
                if (input.Equals("u"))
                {
                    NewOrReturningUser();
                }
                else if (input.Equals("s"))
                {
                    StoreView();
                }
                else if(input.Equals("q"))
                {
                    login = false;
                }
                else
                {
                    System.Console.WriteLine("Invalid entry please try again");
                }
            } while (login);
        }
        static void NewOrReturningUser()
        {
            System.Console.WriteLine("Are you a New (n) or Returning (r) user?");
            var input = System.Console.ReadLine();
            if (input.Equals("n"))
            {
                System.Console.WriteLine("Please enter your name with no capital letters:");
                var name = System.Console.ReadLine().ToLower();
                User user = new User(name);
                _sql.AddUser(user);
                _sql.Update();
                UserView(user);
            }
            else if (input.Equals("r"))
            {
                bool NoUser = true;
                do
                {
                    System.Console.WriteLine("please enter your name for login:");
                    var name = System.Console.ReadLine();

                    User user = _sql.GetUser(name);

                    if (user != null)
                    {
                        NoUser = false;
                        UserView(user);
                    }
                    else
                    {
                        System.Console.WriteLine("Invalid user name entered");
                    }
                } while (NoUser);
            }
        }
         static void StoreView()
        {
            System.Console.Clear();
            System.Console.WriteLine("Which store would you like to check?");
            PrintAllStoresWithEF();
            Store store = _sql.SelectStore();
            store.Orders = _sql.ReadStoreOrders(store.StoreId).ToList<Order>();
            double total = 0;

            foreach(Order o in store.Orders)
            {
                o.ComputePrice();
                System.Console.WriteLine(o.ToString());
                total = total + o.TotalPrice;
            }
            
            System.Console.WriteLine($"Total price of all orders: {total}");
            total = 0;
            
            
        }
    }
}
