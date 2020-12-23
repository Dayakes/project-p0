using System.Collections.Generic;
using PizzaWorld.Domain.Abstracts;

namespace PizzaWorld.Domain.Models
{
  public class FlatbreadPizza : APizzaModel
  {
        private Crust crust;
        private Size size;
        private List<Topping> toppings;
    protected void AddCrust(int selection)
    {
      if(selection == 1)
            {
                crust.MakeRegular();
            }
      else if(selection == 2)
            {
                crust.MakeFlatbread();
            }
      else if(selection == 3)
            {
                crust.MakeStuffed();
            }
    }

    protected void AddSize(int selection)
    {
            if (selection == 1)
            {
                size.MakeSmall();
            }
            else if (selection == 2)
            {
                size.MakeMedium();
            }
            else if (selection == 3)
            {
                size.MakeLarge();
            }
    }

    protected void AddToppings()
    {
      
    }
  }
}