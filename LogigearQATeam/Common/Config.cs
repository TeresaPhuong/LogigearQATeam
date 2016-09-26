﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace LogigearQATeam.Common
{
    class Config:CommonAC
    {
        //public void OpenChrome()
        //{
        //    driver = new ChromeDriver();
        //}
        //public void OpenFirefox()
        //{
        //    driver = new FirefoxDriver();
        //}
        //public void OpenIE()
        //{
        //    driver = new InternetExplorerDriver();
        //}

        //public void OpenBrowser(string browser)
        //{
        //    switch (browser)
        //    {
        //        case "Chrome":
        //        case "chrome":
        //            OpenChrome();
        //            break;
        //        case "firefox":
        //        case "Firefox":
        //            OpenFirefox();
        //            break;
        //        case "IE":
        //            OpenIE();
        //            break;
        //    }
        //    driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(30));
        //}
        [Before]
        public void Precondition()
        {
            driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(30));
        }
        [After]
        public void Postcondition()
        {
            driver.Quit();
        }
    }
}
