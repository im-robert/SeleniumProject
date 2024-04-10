using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System.Threading.Tasks;

namespace SeleniumProject.UnitTests
{
    public class LoginFailed
    {
        public static void LoginFailedTest(IWebDriver driver)
        {
            Screenshot screenshot = ((ITakesScreenshot)driver).GetScreenshot();

            //Cuarta prueba unitaria. Login de usuario fallido
            driver.Navigate().GoToUrl("https://www.facebook.com/");
            driver.Manage().Window.Maximize();

            IWebElement email = driver.FindElement(By.Id("email"));
            email.SendKeys("IncorrectEmail");

            IWebElement pass = driver.FindElement(By.Id("pass"));
            pass.SendKeys("1234567890");

            Thread.Sleep(8000);

            IWebElement btnLogin = driver.FindElement(By.Name("login"));
            btnLogin.Click();


            screenshot.SaveAsFile(Credenciales.screenshotPath + "FailedLogin.png");

            Thread.Sleep(10000);

            IWebElement TryEmail = driver.FindElement(By.Id("email"));
            TryEmail.SendKeys("AntoherIncorrectEmail@gmail.com");

            IWebElement Trypass = driver.FindElement(By.Id("pass"));
            Trypass.SendKeys("0987654321");

            Thread.Sleep(8000);

            IWebElement TrybtnLogin = driver.FindElement(By.Name("login"));
            TrybtnLogin.Click();

            Thread.Sleep(10000);
            driver.Quit();
        }
    }
}

