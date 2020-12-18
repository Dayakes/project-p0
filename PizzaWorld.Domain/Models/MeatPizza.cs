using System.Collections.Generic;
using PizzaWorld.Domain.Abstracts;

namespace PizzaWorld.Domain.Models
{
  public class MeatPizza : APizzaModel
  {
    protected override void AddCrust()
    {
      Crust = "regular";
    }

    protected override void AddSize()
    {
      Size = "medium";
    }

    protected override void AddToppings()
    {
      Toppings = new List<string>
      {
        "cheese",
        "tomato",
        "sausage",
        "bacon",
        "pepperoni"
      };
    }
  }
}