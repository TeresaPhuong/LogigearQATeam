using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using LogigearQATeam.PageObject.AddOrEditArticle;

namespace LogigearQATeam.TestSuites.TestCase
{
    [Binding]
    class AddNewArticlePageTC:AddNewArticlePageAC
    {
        [When(@"I enter title: (.*)")]
        public void EnterTitle(string title)
        {
            EnterTitleIntoTitleTBX(title);
        }

        [When(@"I enter content: (.*)")]
        public void EnterContent(string content)
        {
            EnterContentIntoContentTBX(content);
        }

        [When(@"I select value: (.*) of Category list")]
        public void SelectCategoryField(string category)
        {
            SelectCategory(category);
        }

        [When(@"I click Save and Close button")]
        public void ClickSaveAndCloseButton()
        {
            ClickSaveCloceButton();
        }
        
    }
}
