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
        private readonly string _path = @"//PizzaWorld.Client//pizzaworld.xml"; //waiting for DB
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
            var veggie = new VeggiePizza();
            var flat = new HawaiianPizza();
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
                //need to make a select size and select crust method that return a size and a crust respectively
                switch (input)
                {
                    case 1:
                        {
                            Pizzas.Add(_factory.Make<MeatPizza>());
                            break;
                        }
                    case 2:
                        {
                            Pizzas.Add(_factory.Make<VeggiePizza>());
                            break;
                        }
                    case 3:
                        {
                            Pizzas.Add(_factory.Make<HawaiianPizza>());
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

        private void Save()
        {
            var file = new StreamWriter(_path);
            var xml = new XmlSerializer(typeof(List<Store>));

            xml.Serialize(file, Stores);
        }

        private void Read()
        {
            if (!File.Exists(_path))
            {
                var file = new StreamReader(_path);
                var xml = new XmlSerializer(typeof(List<Store>));

                Stores = xml.Deserialize(file) as List<Store>;
            }
            else
            {
                Stores = new List<Store>();
            }

        }
    }
}