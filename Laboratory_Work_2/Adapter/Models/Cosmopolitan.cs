using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory_Work_2.Adapter
{
    class Cosmopolitan
    {
        public float CitrusVodka { get; set; }
        public float Cointreau { get; set; }
        public float LimeJuice { get; set; }
        public float CranberryJuice { get; set; }
        public Cosmopolitan()
        {
            CitrusVodka = 1.5f;
            Cointreau = 1f;
            LimeJuice = 0.5f;
            CranberryJuice = 0.25f;
        }

        public string GetRecipe()
        {
            string recipe = $"\n\t- {CitrusVodka} oz citrus vodka" +
                            $"\n\t- {Cointreau} oz Cointreau" +
                            $"\n\t- {LimeJuice} oz lime juice" +
                            $"\n\t- {CranberryJuice} oz cranberry juice";

            return recipe;
        }
    }
}
