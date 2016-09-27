using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogigearQATeam.PageObject.ArticleManagerPage
{
    class ArticleManagerPageAC:Common.CommonAC
    {
        #region Interface
        private string message_xpath = "//div[@class='alert-message']";
        private string titletocheck_xpath = ".//a[contains(text(),'{0}')]";
        //private string New_btn = ".//div[@id='toolbar-new']/button";
        private string Search_TBX = ".//*[@id='filter_search']";
        private string Search_BTN = ".//*[@id='j-main-container']//div[input[@id='filter_search']]/button";
        private string CheckBox = ".//*[@id='articleList']//th[@class='center']/input";
        private string Trash_BTN = ".//*[@id='toolbar-trash']/button";
        private string SearchTools_BTN = ".//button[@class='btn hasTooltip js-stools-btn-filter btn-primary']";
        private string SearchStatus_BTN = ".//*[@id='filter_published_chzn']/a";
        private string Status_BTN = ".//*[@id='filter_published_chzn']/div/ul/li[contains(text(),'{0}')]";
        #endregion
        #region Method
        public bool IsSuccessMessageDisplay(string messagecontent)
        {
            WaitToPageLoad(message_xpath);
            return IsCorrectMessageDisplay(message_xpath, messagecontent);
        }

        public bool IsNewArticleDisplay(string title)
        {
            try
            {
                string articletitle = string.Format(titletocheck_xpath, title);
                FindElement(articletitle);
                return true;
            }
            catch (NotSupportedException)
            {
                return false;
            }
        }
        public void SearchArticleTitle(string articletitle)
        {
            EnterText(Search_TBX,articletitle);
            ClickElement(Search_BTN);
        }

        public void SearchWithStatus(string status)
        {
            ClickElement(SearchTools_BTN);
            string statusvalue = string.Format(Status_BTN, status);
            ClickElement(statusvalue);
        }
        public void SelectArticle(string titletosearch)
        {
            SearchArticleTitle(titletosearch);
            ClickElement(CheckBox);
        }
        public void TrashedArticle(string titletotrash)
        {
            SearchArticleTitle(titletotrash);
            FindElement(CheckBox);
            ClickElement(Trash_BTN);
        }
        public void DeleteArticleWithTitle(string articletitle)
        {
            SelectArticle(articletitle);
            ClickElement(Trash_BTN);
        }
        #endregion
    }
}
