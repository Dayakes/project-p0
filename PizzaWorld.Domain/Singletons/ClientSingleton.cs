using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;
using PizzaWorld.Domain.Abstracts;
using PizzaWorld.Domain.Factories;
using PizzaWorld.Domain.Models;

namespace PizzaWorld.Domain.Singletons
{
    public class ClientSingleton
    {
        // private readonly string _path = @"//PizzaWorld.Client//pizzaworld.xml"; //waiting for DB
        private static ClientSingleton _instance;
        public static ClientSingleton Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ClientSingleton();
                }
                return _instance;

            }
        }
        public List<Store> Stores { get; set; }
        public List<APizzaModel> Pizzas { get; set; }
        private ClientSingleton() 
        {
            Stores = new List<Store>();
        }

        public Store SelectStore()
        {
            int.TryParse(Console.ReadLine(), out int input);
            return Stores.ElementAtOrDefault(input);
        }
        public void PrintAllPizzas()
        {
            var meat = new MeatPizza();
            var veg = new VeggiePizza();
            var flat = new HawaiianPizza();
            // var cust = new CustomPizza();
            System.Console.WriteLine("Here are the pizzas this store offers:");
            System.Console.WriteLine(meat.Name);
            System.Console.WriteLine(veg.Name);
            System.Console.WriteLine(flat.Name);
            // System.Console.WriteLine(cust.Name);
        }
        public List<APizzaModel> SelectPizzas()
        {
            bool Leave = true;
            List<APizzaModel> Pizzas = new List<APizzaModel>();
            APizzaModel test = new MeatPizza();
            GenericPizzaFactory _factory = new GenericPizzaFactory();

            do
            {
                PrintAllPizzas();
                System.Console.WriteLine("Select a pizza, enter 9 to finish selecting");
                int.TryParse(Console.ReadLine(), out int input);
                switch (input)
                {
                    case 1:
                        {
                            var pizza = _factory.Make<MeatPizza>();
                            pizza.AddSize(SelectSize());
                            pizza.AddCrust(SelectCrust());
                            Pizzas.Add(pizza);
                            break;
                        }
                    case 2:
                        {
                            var pizza = _factory.Make<VeggiePizza>();
                            pizza.AddSize(SelectSize());
                            pizza.AddCrust(SelectCrust());
                            Pizzas.Add(pizza);
                            break;
                        }
                    case 3:
                        {
                            var pizza = _factory.Make<HawaiianPizza>();
                            pizza.AddSize(SelectSize());
                            pizza.AddCrust(SelectCrust());
                            Pizzas.Add(pizza);
                            break;
                        }
                    case 4:
                        {
                            // var pizza = _factory.Make<CustomPizza>();
                            // pizza.AddSize(SelectSize());
                            // pizza.AddCrust(SelectCrust());
                            // Pizzas.Add(pizza);
                            break;
                        }
                    case 9:
                        {
                            Leave = false;
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Please enter a valid choice");
                            break;
                        }



                }

            } while (Leave);
            return Pizzas;
        }
        public Crust SelectCrust()
        {
            while (true)
            {
                System.Console.WriteLine("what kind of crust would you like? \n1: Flatbread\n2: Regular\n3: Stuffed");
                int.TryParse(System.Console.ReadLine(), out int input);
                switch(input)
                {
                    case 1:
                    {
                        Crust crust = new Crust("Flatbread");
                        return crust;
                    }
                    case 2:
                    {
                        Crust crust = new Crust("Regular");
                        return crust;
                    }
                    case 3:
                    {
                        Crust crust = new Crust("Stuffed");
                        return crust;
                    }
                    default :
                    {
                        System.Console.WriteLine("Invalid entry please try again");
                        break;
                    }
                }
            }
        }
        public Size SelectSize()
        {
            while (true)
            {
                System.Console.WriteLine("what size would you like? \n1: Small\n2: Medium\n3: Large");
                int.TryParse(System.Console.ReadLine(), out int input);
                switch(input)
                {
                    case 1:
                    {
                        Size size = new Size("Small");
                        return size;
                    }
                    case 2:
                    {
                        Size size = new Size("Medium");
                        return size;
                    }
                    case 3:
                    {
                        Size size = new Size("Large");
                        return size;
                    }
                    default :
                    {
                        System.Console.WriteLine("Invalid entry please try again");
                        break;
                    }
                }
            }
        }
    }
}