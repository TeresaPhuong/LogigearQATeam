using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace LogigearQATeam.TestSuites.ArticleFeature
{
    [Binding]
    public sealed class TestCase1
    {
        [Given(@"I naviate to Joomla site: (.*)")]
        public void GivenINaviateToJoomlaSite(string URL)
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"I enter username: (.*)")]
        public void GivenIEnterUsernamePhuong_Thi_Tran(string username)
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"I enter password: (.*)")]
        public void GivenIEnterPassword(int password)
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"I click Login button")]
        public void GivenIClickLoginButton()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I click New Article button")]
        public void WhenIClickNewArticleButton()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I enter title: (.*)")]
        public void WhenIEnterTitleUsingBranchesIntoTitleTextbox(string title)
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I enter content: (.*)")]
        public void WhenIEnterContentThisTutorialIsAComprehensiveIntroductionToGitBranches_IntoContentTextbox(string content)
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I select value: (.*) of Category list")]
        public void WhenISelectValueImagesOfCategoryList(string category)
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I click Save and Close button")]
        public void WhenIClickSaveAndCloseButton()
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
