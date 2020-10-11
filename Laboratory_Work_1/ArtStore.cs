using Laboratory_Work_1.AbstractFactory;
using Laboratory_Work_1.Builder;
using Laboratory_Work_1.Factory;
using Laboratory_Work_1.Factory.Abstract;
using Laboratory_Work_1.Models;
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
            // factory
            var factories = new ShopFactory[2];

            factories[0] = new CanvasFactory("cloth", 14, 12, 100);
            factories[1] = new DrawingPaperFactory("Cardboard", 30, 30, 15);

            foreach (ShopFactory factory in factories)
            {
                Console.WriteLine(factory.GetType().Name );
            }
            Console.WriteLine("\n\n");
            // Builder
            var pencil = new SupplieCreator(new Pencil("red", 12, 2, 1));
            pencil.CreateSupplie();
            pencil.GetSupplie();

            var pastel = new SupplieCreator(new Pastel("black", 2, 4, 2));
            pastel.CreateSupplie();
            pastel.GetSupplie();

            //abstract factory
            IBrush standartBrush = new AngleBrush();
            BrushManager standartManag = new BrushManager(standartBrush);

            Console.WriteLine(standartManag.GetAngleBrushDelails());
            Console.WriteLine(standartManag.GetFlatBrushDetails());

            IBrush acrylicBrush = new FlatBrush();
            BrushManager acrylicManag = new BrushManager(acrylicBrush);

            Console.WriteLine(acrylicManag.GetAngleBrushDelails());
            Console.WriteLine(acrylicManag.GetFlatBrushDetails());

            Console.ReadLine();

        }
    }
}
