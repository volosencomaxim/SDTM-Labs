using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory_Work_2.Adapter
{

    public enum UnitType
    {
        Milliliters,
        OS
    }
    class CocktailsData
    {
        public int GetAlcoholPercentage(string drinkName)
        {
            switch (drinkName.ToLower())
            {
                case "margarita": return 23;
                case "old fashioned": return 32;
                case "cosmopolitan": return 27;

                default: return 0;
            }
        }

        public float GetAlcoholQuantity(string drinkName, UnitType unitType)
        {
            if (unitType == UnitType.Milliliters)
            {
                switch (drinkName.ToLower())
                {
                    case "margarita": return 118.34f;
                    case "old fashioned": return 118.34f;
                    case "cosmopolitan": return 95.875f;

                    default: return 0;
                }
            }
            else
            {
                switch (drinkName.ToLower())
                {
                    case "margarita": return 4f;
                    case "old fashioned": return 4f;
                    case "cosmopolitan": return 3.25f;

                    default: return 0;
                }
            }
        }

        public string GetAlcoholIngredients(string drinkName)
        {
            switch (drinkName.ToLower())
            {
                case "margarita": return new Margarita().GetRecipe();
                case "old fashioned": return new Old_Fashioned().GetRecipe();
                case "cosmopolitan": return new Cosmopolitan().GetRecipe();

                default: return "No recipe for given drink";
            }
        }
    }
}
