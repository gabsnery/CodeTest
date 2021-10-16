using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using verivox.Models;
namespace verivox.Controllers
{
    [ApiController]
    [Route("Tariffs")]
    public class TariffsController : Controller
    {
        public List<Tariff> Tariffs = new List<Tariff>()
        { 
            new Tariff{Name="Basic electricity tariff",Description="base costs per month 5 € + consumption costs 22 cent/kWh"},
            new Tariff{Name="Basic electrsssicity tariff",Description="base costs per month 5 € + consumption costs 22 cent/kWh"},
            new Tariff{Name="Packaged tariff",Description="800 € for up to 4000 kWh/year and above 4000 kWh/year additionally 30"}
        };
  

        [HttpGet]
        public List<Tariff> Get()
        {
            return Tariffs.OrderBy(o => o.Name).ToList();
        }
        [HttpGet("Tariff/{value}")]

        public List<Tariff> Get1(string value)
        {
            return Tariffs.Where(o=>o.Name.Contains(value)).ToList();
        }

        [HttpGet("calc/{field}/{value}")]
        public List<Tariff> CalculateTariffs(string field, double value)
        {
            switch (field)
            {
                case "ConsumptionkWhYear":
                    foreach (Tariff item in Tariffs)
                    {
                        item.CalculateAnnualCosts(value);
                    }
                    break;
            }
            List<Tariff> SortedTariff = Tariffs.Where(x=>x.AnnualCosts!=0).OrderBy(o => o.AnnualCosts).ToList();
            return SortedTariff;

        }
    }
}
