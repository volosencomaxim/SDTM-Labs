using Laboratory_Work_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory_Work_1.AbstractFactory
{
    public class AngleBrush : IBrush
    {
        public IAcrylicBrush GetAngleBrush()
        {
            return new Spotter();
        }

        public IStandartBrush GetFlatBrush()
        {
            return new Stencil();
        }
    }
}
