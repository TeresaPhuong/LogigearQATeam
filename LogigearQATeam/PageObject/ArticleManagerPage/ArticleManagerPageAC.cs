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
        private string titletocheck_xpath = ".//a[contains(text(),'[0]')]";
        private string New_btn = ".//div[@id='toolbar-new']/button";
        #endregion
        #region Method
        public bool IsSuccessMessageDisplay(string messagecontent)
        {
            WaitToPageLoad(New_btn);
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
        #endregion
    }
}
