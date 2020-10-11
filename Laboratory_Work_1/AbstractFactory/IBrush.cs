using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory_Work_1.AbstractFactory
{
    public interface IBrush
    {
        IStandartBrush GetFlatBrush();
        IAcrylicBrush GetAngleBrush();
    }
}
