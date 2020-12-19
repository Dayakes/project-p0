using System.Collections.Generic;
using PizzaWorld.Domain.Abstracts;

namespace PizzaWorld.Domain.Models
{
  public class FlatbreadPizza : APizzaModel
  {
    protected override void AddCrust()
    {
      Crust = "flatbread";
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
        "tomato"
      };
    }
  }
}