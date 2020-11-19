using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory_Work_2.Adapter
{
    class DrinkDetails : AlcoholDrink
    {
        private CocktailsData _cocktailsData;

        public DrinkDetails(string name) : base(name)
        {
        }

        public override void PrintData()
        {
            _cocktailsData = new CocktailsData();

            AlcoholPercentage = _cocktailsData.GetAlcoholPercentage(DrinkName);
            MillilitersQuantity = _cocktailsData.GetAlcoholQuantity(DrinkName, UnitType.Milliliters);
            OZQuantity = _cocktailsData.GetAlcoholQuantity(DrinkName, UnitType.OS);
            Recipe = _cocktailsData.GetAlcoholIngredients(DrinkName);

            base.PrintData();

            Console.WriteLine($"{AlcoholPercentage} %");
            Console.WriteLine($"{MillilitersQuantity} ml");
            Console.WriteLine($"{OZQuantity} OZ");
            Console.WriteLine($"Recipe : {Recipe}");

        }
    }
}
