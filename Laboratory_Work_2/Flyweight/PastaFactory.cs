using Laboratory_Work_2.Flyweight.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory_Work_2.Flyweight
{
    class PastaFactory
    {
        private Dictionary<char, PastaModel> _sliders;
        int orderTotal;

        public PastaFactory(string comandOrder)
        {
            _sliders = new Dictionary<char, PastaModel>();

            char[] chars = comandOrder.ToCharArray();
            orderTotal = 0;
            foreach (char c in chars)
            {
                orderTotal++;
                PastaModel character = GetPasta(c);
                character.Display(orderTotal);
            }
        }
        public PastaModel GetPasta(char key)
        {
            PastaModel pasta = null;

            if (_sliders.ContainsKey(key))
            {
                pasta = _sliders[key];
            }
            else
            {
                switch (key)
                {
                    case 'A': pasta = new Carbonara(); break;
                    case 'R': pasta = new CrockPotSpaghetti(); break;
                    case 'S': pasta = new ShrimpFettuccineAlfredo(); break;
                }
                _sliders.Add(key, pasta);
            }
            return pasta;
        }
    }
}
