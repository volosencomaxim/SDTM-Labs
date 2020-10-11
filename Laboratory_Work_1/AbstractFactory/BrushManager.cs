using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory_Work_1.AbstractFactory
{
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
}
