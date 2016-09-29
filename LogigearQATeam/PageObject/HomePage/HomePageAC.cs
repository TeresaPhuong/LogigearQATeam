using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogigearQATeam.PageObject.AddOrEditArticle;
using LogigearQATeam.PageObject.ArticleManagerPage;

namespace LogigearQATeam.PageObject
{
    class HomePageAC:Common.CommonAC
    {
        #region Interface
        private string NewArticle_BTN = ".//*[@id='content']//a[span[contains(text(),'New Article')]]";
        private string Articles_BTN = ".//*[@id='content']//a[span[contains(text(),'Articles')]]";
        #endregion
        #region Method
        public AddNewArticlePageAC ClickNewArticleBTN()
        {
            WaitToPageLoad(NewArticle_BTN);
            ClickElement(NewArticle_BTN);
            return new AddNewArticlePageAC();
        }

        public ArticleManagerPageAC ClickArticlesButton()
        {
            ClickElement(Articles_BTN);
            return new ArticleManagerPageAC();
        }
        #endregion
    }
}
