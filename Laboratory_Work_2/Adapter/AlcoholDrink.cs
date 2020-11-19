using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory_Work_2.Adapter
{
    class AlcoholDrink
    {
        protected string DrinkName;
        protected int AlcoholPercentage;
        protected float MillilitersQuantity;
        protected float OZQuantity;
        protected string Recipe;

        public AlcoholDrink(string drinkName)
        {
            this.DrinkName = drinkName;
        }

        public virtual void PrintData()
        {
            Console.WriteLine($"\nCocktail choosen : {DrinkName} ----");
        }
    }
}
