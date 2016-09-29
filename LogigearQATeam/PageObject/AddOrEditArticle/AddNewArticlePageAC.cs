using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogigearQATeam.PageObject.ArticleManagerPage;

namespace LogigearQATeam.PageObject.AddOrEditArticle
{
    class AddNewArticlePageAC:Common.CommonAC
    {
        #region Interface
        private string Title_TBX = ".//input[@id='jform_title']";
        private string FrameID = "jform_articletext_ifr";
        private string Content_TBX = ".//*[@id='tinymce']";
        private string Category_List = "//div[@class='controls'][select[@id='jform_catid']]/div[@id='jform_catid_chzn']";
        private string SaveClose_BTN = ".//div[@id='toolbar-save']/button";
        private string selectvalue_xpath = ".//*[@id='jform_catid_chzn']/div/ul/li[contains(text(),'{0}')]";
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
            string selectvalue = string.Format(selectvalue_xpath, categoryvalue);
            SelectDropdownList(Category_List, selectvalue);
        }

        public ArticleManagerPageAC ClickSaveCloceButton()
        {
            ClickElement(SaveClose_BTN);
            return new ArticleManagerPageAC();
        }
        #endregion
    }
}
