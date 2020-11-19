using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory_Work_2.Flyweight.Model
{
    class CrockPotSpaghetti : PastaModel
    {
        public CrockPotSpaghetti()
        {
            Name = "Crock-Pot Spaghetti";
            PastaType = "linguine";
            Topping = "freshly chopped parsley";
            Garnish = "crushed red pepper flakes";
            Price = 60;
        }
        public override void Display(int orderTotal)
        {
            Console.WriteLine($"Pasta # {orderTotal} : {Name}" +
                $" with {PastaType} and {Topping}, {Garnish} as garnish. Total price is {Price}");
        }

    }
}
