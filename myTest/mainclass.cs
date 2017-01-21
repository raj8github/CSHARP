using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using System.IO;

namespace myTest
{
    class mainclass
    {
        static void Main(string[] args)
        {
            IWebDriver driverc = new ChromeDriver();
            driverc.Url = "http://automationpractice.com/index.php?controller=authentication&back=my-account";
            driverc.Navigate();
            driverc.FindElement(By.Id("email")).SendKeys("raj8aus@gmail.com");
            driverc.FindElement(By.Id("passwd")).SendKeys("Test123");
            driverc.FindElement(By.Id("SubmitLogin")).Submit();
            driverc.Quit();

            IWebDriver driverf = new FirefoxDriver();
            driverf.Url = "http://automationpractice.com/index.php?controller=authentication&back=my-account";
            driverf.Navigate();
            driverf.FindElement(By.Id("email")).SendKeys("raj8aus@gmail.com");
            driverf.FindElement(By.Id("passwd")).SendKeys("Test123");
            driverf.FindElement(By.Id("SubmitLogin")).Submit();
            driverf.Quit();

            IWebDriver drivere = new EdgeDriver();
            drivere.Url = "http://automationpractice.com/index.php?controller=authentication&back=my-account";
            drivere.Navigate();
            drivere.FindElement(By.Id("email")).SendKeys("raj8aus@gmail.com");
            drivere.FindElement(By.Id("passwd")).SendKeys("Test123");
            drivere.FindElement(By.Id("SubmitLogin")).Submit();
            drivere.Quit();

        }
    }
}
