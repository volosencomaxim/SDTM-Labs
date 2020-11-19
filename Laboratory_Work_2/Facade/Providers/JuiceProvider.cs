using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory_Work_2.Facade
{
    class JuiceProvider : IJuice
    {
        public void FruitJuice()
        {
            Console.WriteLine("Choose from the list what you would like to drink: ");
            Console.WriteLine($"\n\t Apple juice" +
                                $"\n\t Cherry juice" +
                                $"\n\t Strawberry juice" +
                                $"\n\t Banana juice" +
                                $"\n\t Tejuino");
        }

        public void VegetableJuice()
        {
            Console.WriteLine("Choose from the list what you would like to drink: ");
            Console.WriteLine($"\n\t Aloe vera juice" +
                                $"\n\t Beet juice" +
                                $"\n\t Carrot juice" +
                                $"\n\t Jungle juice" +
                                $"\n\t Şalgam");
        }
    }
}
