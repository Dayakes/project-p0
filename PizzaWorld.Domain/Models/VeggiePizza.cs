using System.Collections.Generic;
using PizzaWorld.Domain.Abstracts;

namespace PizzaWorld.Domain.Models
{
  public class VeggiePizza : APizzaModel
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
        "peppers",
        "onion"
      };
    }
  }
}