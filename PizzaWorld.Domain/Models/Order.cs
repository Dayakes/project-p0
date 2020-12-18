using System.Collections.Generic;
using PizzaWorld.Domain.Factories;

namespace PizzaWorld.Domain.Models
{
    public class Order
    {
        /*
        [required] each order must be able to view/list/edit its collection of pizzas
        [required] each order must be able to compute its pricing                      pizza.cost in a for loop need to have a check in Order to see 
        [required] each order must be limited to a total pricing of no more than $250       if the total would go over $250
        [required] each order must be limited to a collection of pizzas of no more than 50
        */
        private GenericPizzaFactory _pizzaFactory = new GenericPizzaFactory();
        private List<Pizza> Pizzas; //need crud for this

        public void MakeMeatPizza()
        {
            Pizzas.Add(_pizzaFactory.Make<MeatPizza>());
        }
    }
}