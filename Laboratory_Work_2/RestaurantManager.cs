using Laboratory_Work_2.Adapter;
using Laboratory_Work_2.Facade;
using Laboratory_Work_2.Flyweight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory_Work_2
{
    class RestaurantManager
    {
        static void Main()
        {
            // ######### Adapter Test
            var margarita = new DrinkDetails("Margarita");
            margarita.PrintData();

            var cosmopolitan = new DrinkDetails("Cosmopolitan");
            cosmopolitan.PrintData();

            var oldFashioned = new DrinkDetails("Old Fashioned");
            oldFashioned.PrintData();

            // ######## Facade Test 

            var drinksFacade = new DrinksFacade();

            drinksFacade.GetAlcoholCocktailList();

            drinksFacade.GetVegetableJuiceList();

            // ######## Flyweight Test

            var pastaOrder = new PastaFactory("ARRS");

            Console.ReadLine();

        }
    }
}