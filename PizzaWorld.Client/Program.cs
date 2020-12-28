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
            NewOrReturning();
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
        static void NewOrReturning()
        {
            System.Console.WriteLine("Are you a New (n) or Returning (r) user?");
            var input = System.Console.ReadLine();
            if(input == "n")
            {
                //enter new name
                System.Console.WriteLine("Please enter your name with no capital letters:");
                var name = System.Console.ReadLine().ToLower();
                User user = new User(name);
                _sql.AddUser(user);
                _sql.Update();
                UserView(user);
            }
            else if(input == "r")
            {
                //ask for name for login
                System.Console.WriteLine("please enter your name for login:");
                var name = System.Console.ReadLine();
                User user = _sql.GetUser(name);
                UserView(user);
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
                    //_sql.AttachOrder(SelectedStore.Orders.Last()); //testing attach
                    
                    _sql.SaveOrder(user.Orders.Last()); //save new order to context
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
    }
}
