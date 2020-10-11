using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory_Work_1.Builder
{
    class SupplieCreator
    {
        private IShopBuilder _shopBuilder;
        public SupplieCreator(IShopBuilder shopBuilder)
        {
            _shopBuilder = shopBuilder;
        }

        public void CreateSupplie()
        {
            _shopBuilder.SetColor();
            _shopBuilder.SetNumber();
            _shopBuilder.SetShade();
            _shopBuilder.SetThickness();
        }
        public Supplie GetSupplie()
        {
            return _shopBuilder.GetSupplie();
        }
    }
}
