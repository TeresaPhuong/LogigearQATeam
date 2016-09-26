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
        #endregion
        #region Method
        public bool IsSuccessMessageDisplay(string messagecontent)
        {
            return IsMessageDisplay(message_xpath, messagecontent);
        }
        #endregion
    }
}
