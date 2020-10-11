using Laboratory_Work_1.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory_Work_1.Models
{
    public class Pencil : IShopBuilder
    {
        Supplie supplie = new Supplie();
        private string _color;
        private int _thickness;
        private int _number;
        private int _shade;
        public Pencil(string color, int thickness, int number, int shade)
        {
            _color = color;
            _thickness = thickness;
            _number = number;
            _shade = shade;

        }


        public void SetColor()
        {
            supplie.Color = _color;
        }

        public void SetNumber()
        {
            supplie.Number = _number;
        }

        public void SetShade()
        {
            supplie.Shade = _shade;
        }

        public void SetThickness()
        {
            supplie.Thickness = _thickness;
        }
        public Supplie GetSupplie()
        {
            return supplie;
        }
    }
}
