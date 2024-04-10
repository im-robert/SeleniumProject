using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using SeleniumProject.UnitTests;

namespace SeleniumProject
{
    public class FacebookUnitTestingcs
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();

            //Primera prueba unitaria. Login de usuario con éxito
            //LoginTesting.loginTest(driver);

            //Thread.Sleep(8000);

            //Segunda prueba unitaria. Búsqueda en la web
            //driver = new ChromeDriver();
            //SearchBarTest.SearchBarTesting(driver);

            //Thread.Sleep(8000);

            //Tercera prueba unitaria. Contraseña olvidada y metodos de recuperacion
            //driver = new ChromeDriver();
            //ForgottenPassword.ForgottenPasswordTest(driver);

            //Thread.Sleep(8000);

            //Cuarta prueba unitaria. Login de usuario fallido
            //driver = new ChromeDriver();
            //LoginFailed.LoginFailedTest(driver);

            //Thread.Sleep(8000);

            //Quinta prueba unitaria. Visualizacion de lista de amigos
            //driver = new ChromeDriver();
            //FriendListTest.lookFriendList(driver);

            //Sexta prueba unitaria. Enviar mensaje de texto
            //driver = new ChromeDriver();
            SendMessageTest.SendMessage(driver);
        }
    }
}
