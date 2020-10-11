using Laboratory_Work_1.Factory.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory_Work_1.Models
{
    public class Canvas : ArtItem
    {
        private string _material;
        private int _length;
        private int _width;
        private int _price;

        public Canvas(string material, int length, int width, int price)
        {
            _material = material;
            _length = length;
            _width = width;
            _price = price;
        }

        public override string Material
        {
            get => _material;
            set => _material = value;
        }

        public override int Length 
        { 
            get => _length; 
            set => _length = value; 
        }
        public override int Width
        {
            get => _width;
            set => _width = value;
        }
        public override int Price
        {
            get => _price;
            set => _price = value;
        }

    }
}
