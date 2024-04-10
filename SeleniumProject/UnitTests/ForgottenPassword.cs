using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;


namespace SeleniumProject.UnitTests
{
    class ForgottenPassword
    {
        public static void ForgottenPasswordTest(IWebDriver driver)
        {
            Screenshot screenshot = ((ITakesScreenshot)driver).GetScreenshot();

            //Tercera prueba unitaria. Contraseña olvidada y metodos de recuperacion
            driver.Navigate().GoToUrl("https://www.facebook.com/");
            driver.Manage().Window.Maximize();

            IWebElement btnForgottenPassword = driver.FindElement(By.LinkText("¿Olvidaste tu contraseña?"));
            btnForgottenPassword.Click();

            Thread.Sleep(9000);

            IWebElement btnIdentifyEmail = driver.FindElement(By.Id("identify_email"));
            btnIdentifyEmail.SendKeys(Credenciales.Email);

            Thread.Sleep(10000);

            IWebElement btnSubmitEmail = driver.FindElement(By.Id("did_submit"));
            btnSubmitEmail.Click();

            Thread.Sleep(10000);

            IWebElement forgottenPasswordMethods = driver.FindElement(By.CssSelector("a[role='button']"));
            forgottenPasswordMethods.Click();


            screenshot.SaveAsFile(Credenciales.screenshotPath + "ForgottenPassword.png");

            Thread.Sleep(8000);
            driver.Quit();
        }
    }
}