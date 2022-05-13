using HT8_BDD_DDT.PageObjects;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HT8_BDD_DDT.BusinessObject
{
    class CheckSumm
    {
        public int checkSumm(IWebDriver driver)
        {
            CartPage cartPage = new CartPage(driver);
            cartPage.openCart();
            return cartPage.getTotal();
        }
    }
}
