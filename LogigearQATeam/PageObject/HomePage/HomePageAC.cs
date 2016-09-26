using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogigearQATeam.PageObject.AddOrEditArticle;

namespace LogigearQATeam.PageObject
{
    class HomePageAC:Common.CommonAC
    {
        #region Interface
        private string NewArticle_BTN = ".//span[contains(text(),'New Article')]/..";
        #endregion
        #region Method
        public AddNewArticlePage ClickNewArticleBTN()
        {
            ClickElement(NewArticle_BTN);
            return new AddNewArticlePage();
        }
        #endregion
    }
}
