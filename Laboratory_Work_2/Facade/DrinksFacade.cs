using Laboratory_Work_2.Facade.Providers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory_Work_2.Facade
{
    class DrinksFacade
    {
        private IJuice _juiceProvider;
        private ICocktail _cocktailProvider;

        public DrinksFacade()
        {
            _juiceProvider = new JuiceProvider();
            _cocktailProvider = new CocktailProvider();
        }
        public void GetAlcoholCocktailList()
        {
            _cocktailProvider.AlcoholCocktail();
        }
        public void GetNonAlcoholCocktailList()
        {
            _cocktailProvider.NonAlcoholCocktail();
        }
        public void GetFruitJuiceList()
        {
            _juiceProvider.FruitJuice();
        }
        public void GetVegetableJuiceList()
        {
            _juiceProvider.VegetableJuice();
        }
    }
}
