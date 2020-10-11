using Laboratory_Work_1.Factory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory_Work_1.Models
{
    public class Canvas : IItemInfo
    {
        public string Material { get; set; }
        public int Thickness { get; set; }
        public int Length { get; set; }
        public int Width { get; set; }
        public bool HasFrame { get; set; }
        public int Price { get; set; }

        public string GetInfo()
        {
            return string.Format($"Convas info : {Material}, {Thickness}, {Length}, {Width}, {HasFrame}, {Price}");
        }
    }
}
