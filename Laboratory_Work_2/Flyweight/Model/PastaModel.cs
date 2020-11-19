using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory_Work_2.Flyweight.Model
{
    abstract class PastaModel
    {
        protected string Name { get; set; }
        protected string PastaType { get; set; }
        protected string Topping { get; set; }
        protected string Garnish { get; set; }
        protected int Price { get; set; }
        public abstract void Display(int orderTotal);
    }
}
