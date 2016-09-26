using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using LogigearQATeam.PageObject;
using LogigearQATeam.PageObject.Login;
using LogigearQATeam.PageObject.AddOrEditArticle;
using LogigearQATeam.PageObject.ArticleManagerPage;

namespace LogigearQATeam.TestSuites.ArticleFeature
{
    [Binding]
    public sealed class TestCase1:Common.CommonAC
    {
        LoginAC LP = new LoginAC();
        HomePageAC HP = new HomePageAC();
        AddNewArticlePage ANP = new AddNewArticlePage();
        ArticleManagerPageAC AMP = new ArticleManagerPageAC();

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
            ANP = HP.ClickNewArticleBTN();
        }

        [When(@"I enter title: (.*)")]
        public void EnterTitle(string title)
        {
            ANP.EnterTitleIntoTitleTBX(title);
        }

        [When(@"I enter content: (.*)")]
        public void EnterContent(string content)
        {
            ANP.EnterContentIntoContentTBX(content);
        }

        [When(@"I select value: (.*) of Category list")]
        public void SelectCategory(string category)
        {
            ANP.SelectCategory(category);
        }

        [When(@"I click Save and Close button")]
        public void ClickSaveAndCloseButton()
        {
            AMP = ANP.ClickSaveCloceButton();
        }

        [Then(@"The successful message: (.*) displays")]
        public void SuccessfulMessageDisplays(string messagecontent)
        {
            AMP.IsSuccessMessageDisplay(messagecontent);
        }

        [Then(@"The new article: (.*) displays in Article Manage table")]
        public bool ThenTheNewArticleDisplaysInArticleManageTable(string checkedtitle)
        {
            return AMP.IsNewArticleDisplay(checkedtitle);
        }

    }
}
