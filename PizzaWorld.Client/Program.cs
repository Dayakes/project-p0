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
            var stay = true;
            do
            {
                System.Console.WriteLine("would you like to view your history (h), place an order (o), or exit the program (x)?");
                var select = System.Console.ReadLine();
                if (select == "h")
                {
                    System.Console.Clear();
                    foreach (var o in user.Orders)
                    {
                        System.Console.WriteLine("::: START OF ORDER :::\n");
                        System.Console.WriteLine(o.ToString());
                        System.Console.WriteLine("\n::: END OF ORDER :::\n");
                    }
                }
                else if (select == "o")
                {
                    PrintAllStoresWithEF();

                    var SelectedStore = _sql.SelectStore();
                    List<APizzaModel> SelectedPizzas = _client.SelectPizzas();

                    SelectedPizzas.ToString();

                    SelectedStore.CreateOrder(SelectedPizzas);
                    user.Orders.Add(SelectedStore.Orders.Last());

                    _sql.SaveOrder(user.Orders.Last());
                    _sql.Update();

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
        static void UserOrStore()
        {
            do
            {
                System.Console.WriteLine("Are you logging in as a User (u) or a Store (s)?");
                var input = System.Console.ReadLine();
                if (input.Equals("u"))
                {
                    NewOrReturningUser();
                }
                else if (input.Equals("s"))
                {
                    NewOrReturningStore();
                }
                else
                {
                    System.Console.WriteLine("Invalid entry please try again");
                }
            } while (true);
        }
        static void NewOrReturningUser()
        {
            System.Console.WriteLine("Are you a New (n) or Returning (r) user?");
            var input = System.Console.ReadLine();
            if (input.Equals("n"))
            {
                //enter new name
                System.Console.WriteLine("Please enter your name with no capital letters:");
                var name = System.Console.ReadLine().ToLower();
                User user = new User(name);
                _sql.AddUser(user);
                _sql.Update();
                UserView(user);
            }
            else if (input.Equals("r"))
            {
                //ask for name for login
                bool NoUser = true;
                do
                {

                    System.Console.WriteLine("please enter your name for login:");
                    var name = System.Console.ReadLine();

                    User user = _sql.GetUser(name);

                    if (user != null)
                    {
                        NoUser = false;
                        user.Orders = _sql.ReadUserOrders(user.UserId).ToList();

                        foreach (Order o in user.Orders)
                        {
                            o.Pizzas = _sql.GetPizzas(o);
                        }
                        UserView(user);
                    }
                    else
                    {
                        System.Console.WriteLine("Invalid user name entered");
                    }
                } while (NoUser);


            }
        }
    }
}
