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
    [Route("[controller]")]
    public class TariffController : Controller
    {
        public List<Tariff> Tariffs = new List<Tariff>()
        { 
            new Tariff{Name="Basic electricity tariff",AnnualCosts=0},
            new Tariff{Name="Packaged tariff",AnnualCosts=0}
        };


        public IActionResult Index()
        {
            return View();
        }
        [HttpGet("calc/{field}/{value}")]
        public List<Tariff> CalculateTariffs(string field, double value)
        {
            if (field == "ConsumptionkWhYear)")
            {
                foreach (Tariff item in Tariffs)
                {
                    item.CalculateAnnualCosts(value);
                }
            }
            List<Tariff> SortedTariff = Tariffs.OrderBy(o => o.AnnualCosts).ToList();
            return SortedTariff;

        }
    }
}
