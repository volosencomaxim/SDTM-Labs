using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory_Work_2.Adapter
{
    class Old_Fashioned
    {
        public float Bourbon { get; set; }
        public float Angostura { get; set; }
        public float Sugar { get; set; }
        public bool OrangeTwist { get; set; }

        public Old_Fashioned()
        {
            Bourbon = 2f;
            Angostura = 2f;
            Sugar = 1f;
            OrangeTwist = true;
        }

        public string GetRecipe()
        {
            string recipe = $"\n\t- {Bourbon} oz bourbon or rye whiskey" +
                            $"\n\t- {Angostura} dashes Angostura bitters" +
                            $"\n\t- {Sugar} sugar cube or {Sugar} tsp sugar" +
                            $"\n\t-Orange twist garnish = {OrangeTwist}";

            return recipe;
        }
    }
}
