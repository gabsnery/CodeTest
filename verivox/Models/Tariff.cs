using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace verivox.Models
{
    public class Tariff
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double AnnualCosts { get; set; }

        public void CalculateAnnualCosts(double value)
        {
            switch (Name)
            {
                case "Basic electricity tariff":
                    AnnualCosts = value * 0.22  >60 ? value * 0.22 : 60;
                    break;

                case "Packaged tariff":
                    AnnualCosts = value < 4000 ? 800 : ((800)+((value - 4000)*.30));
                    break;
                default:
                    AnnualCosts = 0;
                    break;
            }

        }

    }
}
