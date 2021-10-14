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
        public double AnnualCosts { get; set; }

        public void CalculateAnnualCosts(double input)
        {
            switch (Name)
            {
                case "Basic electricity tariff":
                    AnnualCosts = input * 0.22  >60 ? input * 0.22 : 60;
                    break;

                case "Packaged tariff":
                    AnnualCosts = input < 4000 ? 800 : ((800)+((input - 4000)*.30));
                    break;

                default:
                    Console.WriteLine($"Measured value i; too low.");
                    break;
            }

        }

    }
}
