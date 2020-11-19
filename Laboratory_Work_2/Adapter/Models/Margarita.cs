using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory_Work_2.Adapter
{
    class Margarita
    {
        public float SilverTequila { get; set; }
        public float Cointreau { get; set; }
        public float LimeJuice { get; set; }
        public bool SaltForTheRim { get; set; }
        public Margarita()
        {
            SilverTequila = 2f;
            Cointreau = 1f;
            LimeJuice = 1;
            SaltForTheRim = true;
        }

        public string GetRecipe()
        {
            string recipe = $"\n\t- {SilverTequila} oz silver tequila" +
                            $"\n\t- {Cointreau} oz Cointreau" +
                            $"\n\t- {LimeJuice} oz lime juice" +
                            $"\n\t- Salt for the rim - {SaltForTheRim}";
            return recipe;
        }
    }
}
