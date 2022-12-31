using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Xunit;

public class GoogleTest : IDisposable {
    IWebDriver? Driver = null;
    public GoogleTest() {
        Driver = new ChromeDriver();
    }

    public void Dispose() {
        if (Driver != null) {
            Driver.Quit();
            Driver = null;
        }
    }

    [Fact]
    public void VerifyGoogleSite() {
        // Act
        Driver.Navigate().GoToUrl("https://www.google.com");

        // Assert
        Assert.Contains("Google", Driver.Title);
    }
}