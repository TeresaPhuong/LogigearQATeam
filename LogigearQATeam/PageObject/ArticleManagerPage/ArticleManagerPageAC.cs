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
        public void DeleteArticleWithTitle(string articletitle)
        {
            SearchArticleTitle(articletitle);
            FindElement(CheckBox).Click();
            ClickElement(Trash_BTN);
        }
        #endregion
    }
}
