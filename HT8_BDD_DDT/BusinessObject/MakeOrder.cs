﻿using HT8_BDD_DDT.PageObjects;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HT8_BDD_DDT.BusinessObject
{
    class MakeOrder
    {
        public void selectProducerAndFilters(IWebDriver driver, string producer, int sort)
        {
            SearchResultPage searchResultPage = new SearchResultPage(driver);
            searchResultPage.filterByProducer(producer);
            searchResultPage.changeSortingOrder(sort);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
        }

        public void buyProduct(IWebDriver driver)
        {
            SearchResultPage searchResultPage = new SearchResultPage(driver);
            searchResultPage.clickBuyButton();
        }
    }
}
