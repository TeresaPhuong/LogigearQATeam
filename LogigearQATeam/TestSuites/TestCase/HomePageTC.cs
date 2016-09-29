using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace LogigearQATeam.TestSuites.TestCase
{
    [Binding]
    class HomePageTC:LogigearQATeam.PageObject.HomePageAC
    {
        [When(@"I navigate to Article Manager page")]
        public void NavigateToArticleManagerPage()
        {
            ClickArticlesButton();
        }
    }
}
