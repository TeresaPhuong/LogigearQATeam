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
        private string Search_TBX = ".//*[@id='filter_search']";
        private string CheckBox = ".//*[@id='articleList']//th[@class='center']/input";

        #region Menu Buttons
        private string Trash_BTN = ".//*[@id='toolbar-trash']/button";
        private string EmptyTrash_BTN = ".//div[@id='toolbar-delete']/button";
        private string New_btn = ".//div[@id='toolbar-new']/button";
        #endregion

        #region Search Buttons
        private string Search_BTN = ".//*[@id='j-main-container']//div[input[@id='filter_search']]/button";
        private string SearchTools_BTN = ".//button[@class='btn hasTooltip js-stools-btn-filter btn-primary']";
        private string SearchStatus_BTN = ".//*[@id='filter_published_chzn']/a";
        private string SearchCategory_BTN = ".//*[@id='filter_category_id_chzn']/a";
        private string SearchAccess_BTN = ".//*[@id='filter_access_chzn']/a";
        private string SearchLanguage_BTN = ".//*[@id='filter_language_chzn']/a";
        private string SearchTag_BTN = ".//*[@id='filter_tag_chzn']/a";
        private string SearchAuthor_BTN = ".//*[@id='filter_author_id_chzn']/a";
        private string SearchMaxLevels_BTN = ".//*[@id='filter_level_chzn']/a";
        #endregion

        #region Search Values
        private string StatusValue_Xpath = ".//*[@id='filter_published_chzn']/div/ul/li[contains(text(),'{0}')]";
        private string CategoryValue_Xpath = ".//*[@id='filter_category_id_chzn']//li[contains(text(),'{0}')]";
        private string AccessValue_Xpath = ".//div[@id='filter_access_chzn']//li[contains(text(),'{0}')]";
        private string LanguageValue_Xpath = ".//div[@id='filter_language_chzn']//li[contains(text(),'English')]";
        private string TagValue_Xpath = ".//div[@id='filter_tag_chzn']//li[contains(text(),'{0}')]";
        private string AuthorValue_Xpath = ".//div[@id='filter_author_id_chzn']//li[contains(text(),'Phuong')]";
        private string MaxLevelsValue_Xpath = ".//div[@id='filter_level_chzn']//li[contains(text(),'{0}')]";
        #endregion
        #endregion

        #region Method
        #region Enter Text
        public void EnterIntoSearchTBX(string searchvalue)
        {
            EnterText(Search_TBX, searchvalue);
        }
        #endregion

        #region Click Button
        public void ClickNewButton()
        {
            ClickElement(New_btn);
        }
        public void ClickTrashButton()
        {
            ClickElement(Trash_BTN);
        }
        public void ClickSearchButton()
        {
            ClickElement(Search_BTN);
        }
        public void ClickSearchToolsButton()
        {
            ClickElement(SearchTools_BTN);
        }
        public void ClickSearchStatusButton()
        {
            ClickElement(SearchStatus_BTN);
        }
        public void ClickSearchCategoryButton()
        {
            ClickElement(SearchCategory_BTN);
        }
        public void ClickSearchAccessButton()
        {
            ClickElement(SearchAccess_BTN);
        }
        public void ClickSearchLanguageButton()
        {
            ClickElement(SearchLanguage_BTN);
        }
        public void ClickSearchTagButton()
        {
            ClickElement(SearchTag_BTN);
        }
        public void ClickSearchAuthorButton()
        {
            ClickElement(SearchAuthor_BTN);
        }
        public void ClickSearchMaxLevelsButton()
        {
            ClickElement(SearchMaxLevels_BTN);
        }
        public void ClickEmptyTrashButton()
        {
            ClickElement(EmptyTrash_BTN);
        }
        #endregion

        #region Select Method
        public void SelectCheckboxCheckAll()
        {
            ClickElement(CheckBox);
        }
        public void SelectStatusValue(string status)
        {
            ClickSearchStatusButton();
            string statusvalue = string.Format(StatusValue_Xpath, status);
            ClickElement(statusvalue);
        }
        public void SelectCategoryValue(string category)
        {
            ClickSearchCategoryButton();
            string categoryvalue = string.Format(CategoryValue_Xpath, category);
            ClickElement(categoryvalue);
        }
        public void SelectAccessValue(string access)
        {
            ClickSearchAccessButton();
            string accessvalue = string.Format(AccessValue_Xpath, access);
            ClickElement(accessvalue);
        }
        public void SelectLanguageValue(string language)
        {
            ClickSearchLanguageButton();
            string languagevalue = string.Format(LanguageValue_Xpath, language);
            ClickElement(languagevalue);
        }
        public void SelectTagValue(string tag)
        {
            ClickSearchTagButton();
            string tagvalue = string.Format(CategoryValue_Xpath, tag);
            ClickElement(tagvalue);
        }
        public void SelectAuthorValue(string author)
        {
            ClickSearchAuthorButton();
            string authorvalue = string.Format(CategoryValue_Xpath, author);
            ClickElement(authorvalue);
        }
        public void SelectMaxLevelsValue(string level)
        {
            ClickSearchMaxLevelsButton();
            string levelvalue = string.Format(CategoryValue_Xpath, level);
            ClickElement(levelvalue);
        }
        #endregion

        #region Verify Method
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
        #endregion

        #region Search Method
        public void SearchArticleWithTitle(string articletitle)
        {
            EnterIntoSearchTBX(articletitle);
            ClickSearchButton();
        }
        public void SearchArticleWithStatus(string status)
        {
            ClickSearchToolsButton();
            SelectStatusValue(status);
        }

        public void SearchArticleWithCategory(string category)
        {
            ClickSearchToolsButton();
            SelectCategoryValue(category);
        }
        #endregion

        #region Article's action
        public void TrashedArticles(string titletotrash)
        {
            SearchArticleWithTitle(titletotrash);
            SelectCheckboxCheckAll();
            ClickTrashButton();
        }
        public void DeleteArticleWithTitle(string articletitle)
        {
            TrashedArticles(articletitle);
            SearchArticleWithStatus("Trashed");
            ClickEmptyTrashButton();
        }
        #endregion

        #endregion
    }
}
