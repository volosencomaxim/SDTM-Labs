using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory_Work_1.Builder
{
    interface IShopBuilder
    {
        void SetColor();
        void SetThickness();
        void SetNumber();
        void SetShade();
        Supplie GetSupplie();

    }
}
