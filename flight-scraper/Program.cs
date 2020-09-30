using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace flight_scraper
{
    class Program
    {
        static void Main(string[] args)
        {
            // Using Firefox Developer Edition you need to pass the location of the exe file
            // Selenium has a default location folder for common Firefox and if you don't pass the path it'll throw an Exception
            FirefoxOptions options = new FirefoxOptions();
            options.BrowserExecutableLocation = ("C:\\Users\\nsbt\\AppData\\Local\\Firefox Developer Edition\\firefox.exe");

            IWebDriver driver = new FirefoxDriver(options);
            WebDriverWait webDriverWait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            driver.Navigate().GoToUrl("https://www.qwant.com/");
            Thread.Sleep(2000);
            driver.Manage().Window.Maximize();
            driver.FindElement(By.Name("q")).SendKeys("american airlines brasil" + Keys.Enter);
            Thread.Sleep(3000);
            IWebElement querry = driver.FindElement(By.ClassName("result__url"));
            querry.Click();

            driver.Quit();
        }
    }
}
