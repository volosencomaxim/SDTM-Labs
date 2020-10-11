using Laboratory_Work_1.AbstractFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory_Work_1.Models
{
    public class Spotter : IAcrylicBrush
    {
        private string _thickness = "2f";
        private string _number = "2B";
        public string GetDetails()
        {
            return $"Thickness: {_thickness}\nNumber: {_number}\n";
        }
    }
}
