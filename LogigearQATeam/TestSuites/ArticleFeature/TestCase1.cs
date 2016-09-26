using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using LogigearQATeam.PageObject;
using LogigearQATeam.PageObject.Login;
using LogigearQATeam.PageObject.AddOrEditArticle;

namespace LogigearQATeam.TestSuites.ArticleFeature
{
    [Binding]
    public sealed class TestCase1:Common.CommonAC
    {
        LoginAC LP = new LoginAC();
        HomePageAC HP = new HomePageAC();
        AddNewArticlePage AddP = new AddNewArticlePage();

        [Given(@"I naviate to Joomla site: (.*)")]
        public void NaviateToJoomlaSite(string URL)
        {
            NavigateTo(URL);
        }

        [Given(@"I enter username: (.*)")]
        public void EnterUsername(string username)
        {
            LP.EnterIntoUsername(username);
        }

        [Given(@"I enter password: (.*)")]
        public void EnterPassword(string password)
        {
            LP.EnterIntoPassword(password);
        }

        [Given(@"I click Login button")]
        public void ClickLoginButton()
        {
            HP = LP.ClickLoginBTN();
        }

        [When(@"I click New Article button")]
        public void ClickNewArticleButton()
        {
            AddP = HP.ClickNewArticleBTN();
        }

        [When(@"I enter title: (.*)")]
        public void EnterTitle(string title)
        {
            AddP.EnterTitleIntoTitleTBX(title);
        }

        [When(@"I enter content: (.*)")]
        public void EnterContent(string content)
        {
            AddP.EnterContentIntoContentTBX(content);
        }

        [When(@"I select value: (.*) of Category list")]
        public void SelectCategory(string category)
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I click Save and Close button")]
        public void ClickSaveAndCloseButton()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"The successful message displays")]
        public void ThenTheSuccessfulMessageDisplays()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"The new article displays in Article Manage table")]
        public void ThenTheNewArticleDisplaysInArticleManageTable()
        {
            ScenarioContext.Current.Pending();
        }

    }
}
