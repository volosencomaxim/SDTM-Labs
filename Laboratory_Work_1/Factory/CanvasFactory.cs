using Laboratory_Work_1.Factory.Abstract;
using Laboratory_Work_1.Models;

namespace Laboratory_Work_1.Factory
{
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
}
