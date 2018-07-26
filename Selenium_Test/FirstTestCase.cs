using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace Selenium_Test
{
    class FirstTestCase
    {
        static void Main(string[] args)
        {
           //Automation testing Limits
            IWebDriver driver = new ChromeDriver(@"C:\drive");
            driver.Url = "http://admin.xpgstaging.com";
            IWebElement email = driver.FindElement(By.Id("txtEMail"));
            IWebElement password = driver.FindElement(By.Id("txtPassword"));
            IWebElement Button = driver.FindElement(By.Id("btnLogin"));
           
            //LOGIN
            email.Clear();
            email.SendKeys("house@maxspin.com");
            password.Clear();
            password.SendKeys("tb68Dy@HFS#UnxXu");
            Button.Click();

            //Games list
            //IWebElement RG = driver.FindElement(By.XPath("//*[@id='SideMenu']/div[2]/div[2]/a[2]"));
            //RG.Click();
            //IWebElement BJG = driver.FindElement(By.XPath("//*[@id='SideMenu']/div[2]/div[2]/a[3]"));
            //BJG.Click();
            //IWebElement BG = driver.FindElement(By.XPath("//*[@id='SideMenu']/div[2]/div[2]/a[4]"));
           // BG.Click();
            //IWebElement SPG = driver.FindElement(By.XPath("//*[@id='SideMenu']/div[2]/div[2]/a[5]"));
           // SPG.Click();
           // IWebElement DTG= driver.FindElement(By.XPath("//*[@id='SideMenu']/div[2]/div[2]/a[6]"));
           // DTG.Click();
           // IWebElement SBG = driver.FindElement(By.XPath("//*[@id='SideMenu']/div[2]/div[2]/a[7]"));
           // SBG.Click();
           // IWebElement CPG = driver.FindElement(By.XPath("//*[@id='SideMenu']/div[2]/div[2]/a[8]"));
           // CPG.Click();
           // IWebElement WFG = driver.FindElement(By.XPath("//*[@id='SideMenu']/div[2]/div[2]/a[9]"));
          //  WFG.Click();
           // IWebElement ABG = driver.FindElement(By.XPath("//*[@id='SideMenu']/div[2]/div[2]/a[10]"));
           // ABG.Click();





            int counter = 0;
        
            for (int i=0;i<1500;i++)
            {
                Thread.Sleep(500);

                driver.FindElement(By.XPath("//*[@id='ctl00_ContentPlaceHolder1_lstLimits_chosen']/a")).Click();
                Thread.Sleep(500);
        
                driver.FindElements(By.XPath("//*[@id='ctl00_ContentPlaceHolder1_lstLimits_chosen']/div/ul/li"))[i].Click();
                counter++;
                Console.WriteLine(i);
            }

            Console.WriteLine(counter);
       

        }
    }
}
