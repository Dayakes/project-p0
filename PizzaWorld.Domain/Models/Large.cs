using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaWorld.Domain.Models
{
    public class Large : Size
    {
        public Large()
        {
            this.MakeLarge();
        }
    }
}
