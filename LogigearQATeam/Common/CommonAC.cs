﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.IO;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using TechTalk.SpecFlow;
using OpenQA.Selenium.Chrome;

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
            FindElement(element).Click();
            //new WebDriverWait(driver, TimeSpan.FromSeconds(30)).Until(ExpectedConditions.ElementIsVisible(By.XPath(selectvalue)));
            FindElement(selectvalue).Click();
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

        public bool IsCorrectMessageDisplay(string messagexpath, string messagecontent)
        {
            Console.WriteLine(FindElement(messagexpath).Text);
            if (FindElement(messagexpath).Text == messagecontent)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        [Before]
        public void SetUp()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(30));
        }
        [After]
        public void Postcondition()
        {
            driver.Quit();
        }
    }
    
}
