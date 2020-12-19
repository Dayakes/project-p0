using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;
using PizzaWorld.Domain.Abstracts;
using PizzaWorld.Domain.Models;

namespace PizzaWorld.Domain.Singletons
{
    public class ClientSingleton
    {
        private const string _path = @"pizzaworld.xml";
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
        //using STORES
        public List<Store> Stores { get; set; }
        private ClientSingleton() //constructor
        {
            Read();
            //GetToppings();
        }

        public void MakeStore()
        {
            Stores.Add(new Store());
            Save();
        }

        /*public bool TryParse2(string y,out int x)
        {
            x = 0;
            try
            {
               x =  int.Parse(y);
               return true;
            }
            catch
            {
                return false;
            }
        }*/

        public Store SelectStore()
        {
            int.TryParse(Console.ReadLine(), out int input); // 0 or the actual selection
            //Stores.FirstOrDefault(s => s == input); //unique property, custoemr entered correct information     wants us to use this
            return Stores.ElementAtOrDefault(input);
            //Stores[input]; //exception
        }
        public List<APizzaModel> SelectPizzas()
        {
            bool Leave = false;
            while(Leave == false)
            {
                System.Console.WriteLine("Select a pizza, enter 9 to finish selecting");
            }
        }

        private void Save()
        {
            var file = new StreamWriter(_path);
            var xml = new XmlSerializer(typeof(List<Store>));

            xml.Serialize(file, Stores);
        }

        private void Read()
        {
            if (File.Exists(_path))
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
        //private List<string> Toppings = GetToppings();
        /*private List<string> GetToppings()
        {
            return 
        }*/
    }
}