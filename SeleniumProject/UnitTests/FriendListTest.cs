using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace SeleniumProject.UnitTests
{
    public class FriendListTest
    {
        public static void lookFriendList(IWebDriver driver)
        {
            Screenshot screenshot = ((ITakesScreenshot)driver).GetScreenshot();

            //Realziando el logeo a la pagina
            LoginTesting.loginTest(driver);


           //Quinta prueba unitaria. Visualizacion de lista de amigos
           IWebElement searchFriends = driver.FindElement(By.XPath("//span[contains(text(), 'Buscar amigos')]"));
           IJavaScriptExecutor js = (IJavaScriptExecutor)driver;

           Thread.Sleep(5000);

           js.ExecuteScript("arguments[0].click();", searchFriends);


           Thread.Sleep(5000);

           IWebElement friendRequest = driver.FindElement(By.XPath("//span[contains(text(), 'Solicitudes de amistad')]"));
           friendRequest.Click();

           Thread.Sleep(8000);

           IWebElement goBack = driver.FindElement(By.XPath("//a[contains(@aria-label, 'Atrás')]"));
           goBack.Click();

           Thread.Sleep(6000);

           IWebElement allFriends = driver.FindElement(By.XPath("//span[contains(text(), 'Todos los amigos')]"));
           allFriends.Click();

           screenshot.SaveAsFile(Credenciales.screenshotPath + "FriendList.png");
           Thread.Sleep(10000);

           IWebElement lookForAFriend = driver.FindElement(By.XPath("//input[@placeholder='Buscar amigos']"));
           lookForAFriend.Click();
           lookForAFriend.SendKeys("Daniel Lachapelle");

           Thread.Sleep(10000);
           //driver.Quit();
        }
    }
}
