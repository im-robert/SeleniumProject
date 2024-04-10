using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumProject.UnitTests
{
    public class SendMessageTest
    {
        public static void SendMessage(IWebDriver driver)
        {

            //Sexta prueba unitaria. Enviar mensaje de texto
            driver.Navigate().GoToUrl("https://www.facebook.com/");
            driver.Manage().Window.Maximize();

            IWebElement email = driver.FindElement(By.Id("email"));
            email.SendKeys(Credenciales.Email);

            IWebElement pass = driver.FindElement(By.Id("pass"));
            pass.SendKeys(Credenciales.Password);

            IWebElement btnLogin = driver.FindElement(By.Name("login"));
            btnLogin.Click();

            Thread.Sleep(10000);

            IWebElement messengerBtn = driver.FindElement(By.CssSelector("div[aria-label='Messenger']"));
            messengerBtn.Click();

            Thread.Sleep(10000);

            IWebElement chatElement = driver.FindElement(By.XPath("//span[contains(text(), 'Junito')]"));
            chatElement.Click();

            Thread.Sleep(10000);

            IWebElement sendMessage = driver.FindElement(By.CssSelector("div[aria-describedby='Escribe a Junito']"));
            sendMessage.SendKeys("Hola amigo, como estas?");
            sendMessage.SendKeys(Keys.Enter);

            Screenshot screenshot = ((ITakesScreenshot)driver).GetScreenshot();
            screenshot.SaveAsFile(Credenciales.screenshotPath + "SentMessage.png");

            Thread.Sleep(9000);
            driver.Quit();
        }
    }
}
