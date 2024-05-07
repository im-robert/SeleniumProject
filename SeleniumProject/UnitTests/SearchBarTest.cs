using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumProject.UnitTests
{
    public class SearchBarTest
    {
        public static void SearchBarTesting(IWebDriver driver)
        {
            //Realizando el logeo a la pagina
            LoginTesting.loginTest(driver);

            //Segunda prueba unitaria. Campo de busqueda
            IWebElement search = driver.FindElement(By.CssSelector("input[placeholder='Search Facebook']"));
            search.SendKeys("ITLA");

            Thread.Sleep(8000);

            Screenshot screenshot = ((ITakesScreenshot)driver).GetScreenshot();
            screenshot.SaveAsFile(Credenciales.screenshotPath + "Searching.png");

            search.SendKeys(Keys.Enter);

            Thread.Sleep(8000);

            IWebElement search2 = driver.FindElement(By.CssSelector("input[placeholder='Search Facebook']"));
            search2.SendKeys(" universidad");

            Thread.Sleep(8000);

            search.SendKeys(Keys.Enter);

            Thread.Sleep(10000);
            driver.Quit();
        }

    }
}
