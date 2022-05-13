using System;
using System.Threading;
using HT8_BDD_DDT.Decorators;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace HT8_BDD_DDT.PageObjects
{
    class BasePage
    {
        protected IWebDriver driver;

        public BasePage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//input[@name='search']")]
        IWebElement searchInput;

        [FindsBy(How = How.XPath, Using = "//button[@class='button button_color_green button_size_medium search-form__submit ng-star-inserted']")]
        IWebElement searchButton;


        public void makeSearchByKeyword(string Keyword)
        {
            searchInput.EnterText(Keyword, "search input");
            searchButton.ClickOnElement("search button");
            Thread.Sleep(3000);
        }

        public void enterSearchField(string item)
        {
            searchInput.SendKeys(item);
        }

        public void clickSearchButton()
        {
            searchButton.Click();
            Thread.Sleep(3000);
        }
    }
}
