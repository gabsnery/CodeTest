using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using verivox.Controllers;
using verivox.Models;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Tariffs_ShouldReturnAllTariffs()
        {
            TariffsController newTest = new TariffsController();
            newTest.Tariffs = GetTestTariffs();
            var result = newTest.Get();
            Assert.AreEqual(newTest.Tariffs.Count, result.Count);
        }
        [TestMethod]
        public void Tariffs_ShouldReturnFilteredTariffs()
        {
            TariffsController newTest = new TariffsController();
            newTest.Tariffs = GetTestTariffs();
            var result = newTest.Get1("electricity");
            Assert.AreEqual(1, result.Count);
            Assert.AreEqual(result[0].Name, "Basic electricity tariff");
            result = newTest.Get1("tariff");
            Assert.AreEqual(2, result.Count);

        }
        [TestMethod]
        public void Tariffs_ShouldReturnCalculatedTariffs()
        {
            TariffsController newTest = new TariffsController();
            newTest.Tariffs = GetTestTariffs();
            var result = newTest.CalculateTariffs("ConsumptionkWhYear", 3500);
            Assert.AreEqual(result[0].AnnualCosts, 770);
            Assert.AreEqual(result[1].AnnualCosts, 800);
            var result2 = newTest.CalculateTariffs("ConsumptionkWhYear", 4500);
            Assert.AreEqual(result2[0].AnnualCosts, 950);
            Assert.AreEqual(result2[1].AnnualCosts, 990);
            var result3 = newTest.CalculateTariffs("ConsumptionkWhYear", 6000);
            Assert.AreEqual(result3[0].AnnualCosts, 1320);
            Assert.AreEqual(result3[1].AnnualCosts, 1400);
        }

        private List<Tariff> GetTestTariffs()
        {
            var testTariffs = new List<Tariff>();
            testTariffs.Add(new Tariff { Name = "Basic electricity tariff", Description = "base costs per month 5 € + consumption costs 22 cent/kWh" });
            testTariffs.Add(new Tariff { Name = "Packaged tariff", Description = "800 € for up to 4000 kWh/year and above 4000 kWh/year additionally 30" });

            return testTariffs;
        }

    }
}
