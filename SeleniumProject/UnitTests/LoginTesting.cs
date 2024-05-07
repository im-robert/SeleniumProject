using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Threading;
using SeleniumProject;
using SeleniumProject.UnitTests;

class LoginTesting
{
    public static void loginTest(IWebDriver driver)
    {
        Screenshot screenshot = ((ITakesScreenshot)driver).GetScreenshot(); 

        //Primera prueba unitaria. Inicio de sesion exitoso

        driver.Navigate().GoToUrl("https://www.facebook.com/");
        driver.Manage().Window.Maximize();

        IWebElement email = driver.FindElement(By.Id("email"));
        email.SendKeys(Credenciales.Email);

        IWebElement pass = driver.FindElement(By.Id("pass"));
        pass.SendKeys(Credenciales.Password);

        Thread.Sleep(5000);

        IWebElement btnLogin = driver.FindElement(By.Name("login"));
        btnLogin.Click();

        screenshot.SaveAsFile(Credenciales.screenshotPath + "LoginImage.png");

        Thread.Sleep(5000);
        //driver.Quit();
    }
}

