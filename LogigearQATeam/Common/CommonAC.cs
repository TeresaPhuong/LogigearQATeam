using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.IO;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Newtonsoft.Json;

namespace LogigearQATeam.Common
{
    public class CommonAC
    {
        public static IWebDriver driver;

        public IWebElement FindElement(string element)
        {
            return driver.FindElement(By.XPath(element));
        }

        public void ClickElement(string element)
        {
            FindElement(element).Click();
        }

        public void EnterText(string element, string text)
        {
            FindElement(element).SendKeys(text);
        }

        public void SelectDropdownList(string element, string selectvalue)
        {
            string value = "*" + selectvalue;
            new SelectElement(FindElement(element)).SelectByText(value);
        }

        public void WaitToPageLoad(string ElementToCheck)
        {
            new WebDriverWait(driver, TimeSpan.FromSeconds(30)).Until(ExpectedConditions.ElementExists((By.XPath(ElementToCheck))));
        }

        public void NavigateTo(string url)
        {
            driver.Navigate().GoToUrl(url);
        }

        public void SwitchFrame(string FrameID)
        {
            driver.SwitchTo().Frame(FrameID);
        }
        
        public void OutOfFrame()
        {
            driver.SwitchTo().DefaultContent();
        }

        //public void ReadJsonFile()
        //{
        //    string json = File.ReadAllText(@"C: \Users\phuong.thi.tran\documents\visual studio 2015\Projects\LogigearQATeam\LogigearQATeam\PageObject\Login\LoginIN.json");
            
        //}
    }
}
