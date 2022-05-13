using HT8_BDD_DDT.PageObjects;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HT8_BDD_DDT.BusinessObject
{
    class MakeSearch
    {
        public void makeSearchByKeyword(IWebDriver driver, string Keyword)
        {
            BasePage basePage = new BasePage(driver);
            basePage.makeSearchByKeyword(Keyword);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
        }
    }
}
