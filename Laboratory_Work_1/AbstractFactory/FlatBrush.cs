using Laboratory_Work_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory_Work_1.AbstractFactory
{
    class FlatBrush : IBrush
    {
        public IAcrylicBrush GetAngleBrush()
        {
            return new Hake();
        }

        public IStandartBrush GetFlatBrush()
        {
            return new Sumi();
        }
    }
}
