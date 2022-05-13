using HT8_BDD_DDT.PageObjects;
using HT8_BDD_DDT.Tests;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace HT8_BDD_DDT.StepDefinition
{
    [Binding]
    class CartTestsSteps : BaseTest
    {
        [Given(@"I have entered '(.*)' in search field")]
        public void IHaveEnteredSearchItemInSearchField(string item)
        {
            var basePage = new BasePage(Driver);
            basePage
                .enterSearchField(item);
        }

        [When(@"I press the search button")]
        public void IPressTheSearchButton()
        {
            var basePage = new BasePage(Driver);
            basePage
                .clickSearchButton();
        }


        [When(@"I choose the producer '(.*)'")]
        public void IChooseTheProducer(string producer)
        {
            var searchPage = new SearchResultPage(Driver);
            searchPage
                .filterByProducer(producer);
        }

        [When(@"I sort items from the most expensive to cheaper")]
        public void ISortItems()
        {
            var searchPage = new SearchResultPage(Driver);
            searchPage
                .changeSortingOrder(2);
        }

        [When(@"I click buy button")]
        public void IClickBuyButton()
        {
            var searchPage = new SearchResultPage(Driver);
            searchPage
                .clickBuyButton();
        }

        [When(@"I click cart button")]
        public void IClickCartButton()
        {
            var cartPage = new CartPage(Driver);
            cartPage
                .openCart();
        }

        [Then(@"I check if total amount in cart is less than '(.*)'")]
        public void ICheckIfTotalAmountIsLessThanTopAmount(int topAmount)
        {
            var cartPage = new CartPage(Driver);
            int total = cartPage.getTotal();
            Assert.That(total, Is.LessThan(topAmount));
        }
    }
}
