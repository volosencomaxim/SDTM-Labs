# SDTM-Labs
Topic: Creational Design Patterns

Author : Volosenco Maxim

Introduction :
1. studied the following creational design patterns:

Singleton
Prototype
Factory Method
Abstract Factory
Builder
Object Pooling

2. implemented 3 creational design patterns :

Factory Method
Abstract Factory
Builder


Implementation : 
---- I implemented Builder Method for creating pencils. We can create 2 types of pencils: simple pencil and pastel.
Interface:

    interface IShopBuilder
    {
        void SetColor();
        void SetThickness();
        void SetNumber();
        void SetShade();
        Supplie GetSupplie();

    }

Supplie Creator:

     class SupplieCreator
        {
            private IShopBuilder _shopBuilder;
            public SupplieCreator(IShopBuilder shopBuilder)
            {
                _shopBuilder = shopBuilder;
            }

        public void CreateSupplie()
        {
            _shopBuilder.SetColor();
            _shopBuilder.SetNumber();
            _shopBuilder.SetShade();
            _shopBuilder.SetThickness();
        }
        public Supplie GetSupplie()
        {
            return _shopBuilder.GetSupplie();
        }
    }

Builder Example:

      var pencil = new SupplieCreator(new Pencil("red", 12, 2, 1));
      pencil.CreateSupplie();
      pencil.GetSupplie();

---- I implemented Factory Method for creating items from material section because we can create different types of materials.

Shop factory :

    abstract public class ShopFactory
    {
        public abstract ArtItem Item();
    }
    
    public class CanvasFactory : ShopFactory
    {
        private string _material;
        private int _length;
        private int _width;
        private int _price;
        public CanvasFactory(string material, int length, int width, int price)
        {
            _material = material;
            _length = length;
            _width = width;
            _price = price;
        }

        public override ArtItem Item()
        {
            return new Canvas(_material, _length, _width, _price);
        }

    }
    
Creating object:

            factories[0] = new CanvasFactory("cloth", 14, 12, 100);

---- I implemented Abstract Factory Method for creating brushes beacause brushes can be similar in some aspects but they can be differentiated by minor details.

Brush creator:

    public class BrushManager
    {
        IStandartBrush flatBrush;
        IAcrylicBrush angleBrush;
        public BrushManager(IBrush brush)
        {
            flatBrush = brush.GetFlatBrush();
            angleBrush = brush.GetAngleBrush();
        }

        public string GetFlatBrushDetails()
        {
            return flatBrush.GetDetails();
        }

        public string GetAngleBrushDelails()
        {
            return angleBrush.GetDetails();
        }

    }

Example: 

            IBrush acrylicBrush = new FlatBrush();
            BrushManager acrylicManag = new BrushManager(acrylicBrush);
