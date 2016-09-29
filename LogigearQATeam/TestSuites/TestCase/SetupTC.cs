using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using LogigearQATeam.Common;

namespace LogigearQATeam.TestSuites.TestCase
{
    [Binding]
    class SetupTC:CommonAC
    {
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
