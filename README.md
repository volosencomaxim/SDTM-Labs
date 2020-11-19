# SDTM-Labs
Topic: Structural Design Patterns

Author : Volosenco Maxim

Introduction :
1. studied the following structural design patterns:

Adapter
Bridge
Composite
Decorator
Facade
Flyweight
Proxy

2. implemented 3 tructural design patterns :

Adapter
Facade
Flyweight


Implementation : 
---- I used Adapter Method for Cosmopolitan, Margarita and Old_Fashioned classes. It allows to visualize information about specific drink.

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
    
    
---- I used Facade Method for Juices and Cocktails. It allows easy to visualize bar menu.

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
    
---- I used Flyweight Method for creating menu based on preferences. Only the pasta menu is available :D.

    class PastaFactory
    {
        private Dictionary<char, PastaModel> _sliders;
        int orderTotal;

        public PastaFactory(string comandOrder)
        {
            _sliders = new Dictionary<char, PastaModel>();

            char[] chars = comandOrder.ToCharArray();
            orderTotal = 0;
            foreach (char c in chars)
            {
                orderTotal++;
                PastaModel character = GetPasta(c);
                character.Display(orderTotal);
            }
        }
        public PastaModel GetPasta(char key)
        {
            PastaModel pasta = null;

            if (_sliders.ContainsKey(key))
            {
                pasta = _sliders[key];
            }
            else
            {
                switch (key)
                {
                    case 'A': pasta = new Carbonara(); break;
                    case 'R': pasta = new CrockPotSpaghetti(); break;
                    case 'S': pasta = new ShrimpFettuccineAlfredo(); break;
                }
                _sliders.Add(key, pasta);
            }
            return pasta;
        }
    }

