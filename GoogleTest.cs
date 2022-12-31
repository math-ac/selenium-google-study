using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Xunit;

public class GoogleTest : IDisposable {
    IWebDriver Driver;
    public GoogleTest() {
        Driver = new ChromeDriver();
    }

    public void Dispose() {
        if (Driver != null) {
            Driver.Quit();
            //Driver = null;
        }
    }

    [Fact]
    public void VerifyGoogleSite() {
        /* Acesso ao site do Google */
        Driver.Navigate().GoToUrl("https://www.google.com");

        /* Verificar o título do site */
        Assert.Contains("Google", Driver.Title);
    }

    [Fact]
    public void SearchDogImage() {
        /* Acesso ao site do Google */
        Driver.Navigate().GoToUrl("https://www.google.com/");

        /* Insere o termo de busca */
        Driver.FindElement(By.Name("q")).SendKeys("Cachorro");

        /* Aciona a busca */
        Driver.FindElement(By.Name("q")).SendKeys(Keys.Enter);

        /* Clique na aba de imagens */
        Driver.FindElement(By.LinkText("Imagens")).Click();
    }
}