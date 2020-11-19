using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory_Work_2.Flyweight.Model
{
    class ShrimpFettuccineAlfredo : PastaModel
    {
        public ShrimpFettuccineAlfredo()
        {
            Name = "Shrimp Fettuccine Alfredo";
            PastaType = "pappardelle";
            Topping = "butter sause";
            Garnish = "freshly grated Parmesan";
            Price = 34;
        }
        public override void Display(int orderTotal)
        {
            Console.WriteLine($"Pasta # {orderTotal} : {Name}" +
                $" with {PastaType} and {Topping}, {Garnish} as garnish. Total price is {Price}");
        }
    }
}
