using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using LogigearQATeam.PageObject.ArticleManagerPage;
using NUnit.Framework;

namespace LogigearQATeam.TestSuites.TestCase
{
    [Binding]
    class ArticleManagerPageTC:ArticleManagerPageAC
    {
        [Scope(Tag = "ClickNewButton")]
        [When(@"I click New button")]
        public void IClickNewButton()
        {
            ClickNewButton();
        }
        
        [Then(@"The successful message: (.*) displays")]
        public void SuccessfulMessageDisplays(string messagecontent)
        {
            Console.WriteLine(messagecontent);
            Assert.IsTrue(IsSuccessMessageDisplay(messagecontent));
        }

        [Then(@"The new article: (.*) displays in Article Manage table")]
        public void NewArticleDisplays(string checkedtitle)
        {
            Assert.IsTrue(IsNewArticleDisplay(checkedtitle));
        }
        [BeforeStep("ClickNewButton")]
        public void precondition()
        {
            string title = []
            DeleteArticleWithTitle();
        }
    }
}
