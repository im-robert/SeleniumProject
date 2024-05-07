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
            //Realziando el loego a la pagina.
            LoginTesting.loginTest(driver);

            Thread.Sleep(6000);

            //Sexta prueba unitaria. Enviar mensaje de texto.
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
