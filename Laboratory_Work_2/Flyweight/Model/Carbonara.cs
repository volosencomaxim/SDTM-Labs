using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory_Work_2.Flyweight.Model
{
    class Carbonara : PastaModel
    {
        public Carbonara()
        {
            Name = "Carbonara";
            PastaType = "bucatini";
            Topping = "freshly grated Parmesan";
            Garnish = "extra-virgin olive oil, freshly chopped parsley";
            Price = 31;
        }
        public override void Display(int orderTotal)
        {
            Console.WriteLine($"Pasta # {orderTotal} : {Name}" +
                $" with {PastaType} and {Topping}, {Garnish} as garnish. Total price is {Price}");
        }
    }
}
