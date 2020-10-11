using Laboratory_Work_1.Factory;
using Laboratory_Work_1.Factory.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory_Work_1
{
    class ArtStore
    {
        static void Main()
        {
            ShopFactory[] factories = new ShopFactory[2];

            factories[0] = new CanvasFactory("cloth", 14, 12, 100);
            factories[1] = new DrawingPaperFactory("Cardboard", 30, 30, 15);

            foreach (ShopFactory factory in factories)
            {
                Console.WriteLine("\n" + factory.GetType().Name + );
            }

            Console.ReadLine();

        }
    }
}
