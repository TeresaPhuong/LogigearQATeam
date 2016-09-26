using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogigearQATeam.PageObject.AddOrEditArticle
{
    class AddNewArticlePage:Common.CommonAC
    {
        #region Interface
        private string Title_TBX = ".//input[@id='jform_title']";
        private string FrameID = "jform_articletext_ifr";
        private string Content_TBX = ".//*[@id='tinymce']/p";
        private string Category_List = "//select[@id='jform_catid']";
        #endregion
        #region Method
        public void EnterTitleIntoTitleTBX(string title)
        {
            EnterText(Title_TBX, title);
        }

        public void EnterContentIntoContentTBX(string content)
        {
            SwitchFrame(FrameID);
            EnterText(Content_TBX, content);
            OutOfFrame();
        }

        public void SelectCategory(string categoryvalue)
        {
            SelectDropdownList(Category_List, categoryvalue);
        }
        #endregion
    }
}
