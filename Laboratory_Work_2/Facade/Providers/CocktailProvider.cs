using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory_Work_2.Facade.Providers
{
    public class CocktailProvider : ICocktail
    {
        public void AlcoholCocktail()
        {
            Console.WriteLine("Choose from the list what you would like to drink: ");
            Console.WriteLine($"\n\t Sakurá" +
                                $"\n\t Sato" +
                                $"\n\t Sonti" +
                                $"\n\t Tepache" +
                                $"\n\t Tiswin" +
                                $"\n\t Tonto" +
                                $"\n\t Wine");
        }

        public void NonAlcoholCocktail()
        {
            Console.WriteLine("Choose from the list what you would like to drink: ");
            Console.WriteLine($"\n\t Citrus peach cooler" +
                                $"\n\t Pomegranate mojito mocktail" +
                                $"\n\t Smoothies" +
                                $"\n\t Mulled apple juice" +
                                $"\n\t Non-alcoholic tropical fizz" +
                                $"\n\t Apple, elderflower & mint sparkle" +
                                $"\n\t Homemade lemonade and limeade");
        }
    }
}
