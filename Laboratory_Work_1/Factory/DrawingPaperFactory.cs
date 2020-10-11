using Laboratory_Work_1.Factory.Abstract;
using Laboratory_Work_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory_Work_1.Factory
{
    class DrawingPaperFactory : ShopFactory
    {
        private string _material;
        private int _length;
        private int _width;
        private int _price;
        public DrawingPaperFactory(string material, int length, int width, int price)
        {
            _material = material;
            _length = length;
            _width = width;
            _price = price;
        }

        public override ArtItem Item()
        {
            return new DrawingPaper(_material, _length, _width, _price);
        }
    }
}
