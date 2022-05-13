using NUnit.Framework;
using HT8_BDD_DDT.PageObjects;
using HT8_BDD_DDT.Utils;
using HT8_BDD_DDT.DataSource;
using HT8_BDD_DDT.BusinessObject;
using OpenQA.Selenium.DevTools;
using Serilog;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

[assembly: LevelOfParallelism(3)]

namespace HT8_BDD_DDT.Tests
{
    [TestFixture]
    [FixtureLifeCycle(LifeCycle.InstancePerTestCase)]


    class CardSummCheckTest : BaseTest
    { 

        [Parallelizable(scope: ParallelScope.All)]
        [TestCaseSource(typeof(DataProvider), nameof(DataProvider.TestData))]
        public void Test1(Filter filter)
        {
            MakeSearch makeSearch = new();
            makeSearch.makeSearchByKeyword(Driver, filter.item);
            MakeOrder makeOrder = new();
            makeOrder.selectProducerAndFilters(Driver, filter.producer, filter.sort);
            makeOrder.buyProduct(Driver);
            CheckSumm checkSumm = new();
            int total = checkSumm.checkSumm(Driver);
            Assert.That(total, Is.LessThan(filter.price));
        }

    }
}
