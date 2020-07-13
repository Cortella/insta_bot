using OpenQA.Selenium;
using prmToolkit.Selenium;
using prmToolkit.Selenium.Enum;
using System;
using System.Threading;

namespace insta_bot
{
    class Program
    {

        static bool isNumber(string s , int i)
        {
            return int.TryParse(s, out i);
        }
        static void Main(string[] args)

        {
            string username, senha;

            //      Console.WriteLine("Digite seu id do instagram: ");
            username = "bnmachado";
            // Console.WriteLine("Digite sua senha: ");
            senha = "";

            Profile profile = Instagram.GetProfileByUser(username,senha);
            Random intervalo = new Random();
            string urlInstagram = @"https://instagram.com/" + username + "/";
            string urlLogin = @"https://www.instagram.com/accounts/login/";
            string urlAbacaxi = @"https://www.instagram.com/vaquinhabacashi/";

            if(profile.Descricao == "Descricao")
            {
                Console.WriteLine("Erro ao obter descricao confira o nome de usuario e rode novamente");
            }
            else
            {
                int numSeguidores = 0, numSeguindo = 0;
                string seguidores, seguindo;
                string descricao = profile.Descricao;
                descricao = descricao.Trim();
                descricao = descricao.Replace(",", "");
                int posicaoPrimeiroEspaco = descricao.IndexOf(" ");
                seguidores = descricao.Substring(0, posicaoPrimeiroEspaco);
                int po = descricao.IndexOf("Following");
                if(p2 == -1)
                {
                    Console.WriteLine("erro ao obter valor de seguidores");
                }

               
                Console.WriteLine(descricao);
            }
            
            /*
            IWebDriver webDriver = WebDriverFactory.CreateWebDriver(Browser.Chrome, @"C:\Cortella\Projetos\insta_bot\Driver");
            try
            {
                webDriver.LoadPage(TimeSpan.FromSeconds(10), urlLogin);
                Thread.Sleep(3000);
                webDriver.SetText(By.Name("username"),id);
                webDriver.SetText(By.Name("password"), senha);
                webDriver.Submit(By.TagName("button"));
                Thread.Sleep(5000);
               // webDriver.LoadPage(TimeSpan.FromSeconds(10), urlAbacaxi);
                //Thread.Sleep(5000);
                //webDriver.FindElement(By.XPath("//button[contains(text(), 'Seguir')]")).Click();
               // Thread.Sleep(3000);
               webDriver.LoadPage(TimeSpan.FromSeconds(10), (urlInstagram+id));
                Thread.Sleep(3000);
                webDriver.FindElement(By.XPath("//span[contains(text(), ' seguindo')]")).Click();
                Thread.Sleep(3000);
                Console.WriteLine("Tentando pegar conteudo da tag");
             //   IWebElement element = webDriver.FindElement(By.XPath("//button[contains(text(), 'seguindo')]"));
              //  string numSeguindo = element.ToString();
              //  Console.WriteLine(numSeguindo);
            }
            catch( Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            

            */

        }
    }
}
