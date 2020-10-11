using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory_Work_1.Factory.Abstract
{
    public abstract class ArtItem
    {
        public abstract string Material { get; set; }
        public abstract int Length { get; set; }
        public abstract int Width { get; set; }
        public abstract int Price { get; set; }
    }
}
