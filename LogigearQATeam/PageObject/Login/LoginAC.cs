using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace LogigearQATeam.PageObject.Login
{
    class LoginAC:Common.CommonAC
    {
        #region Interface
        private string Username_TBX = ".//input[@id='mod-login-username']";
        private string Password_TBX = ".//input[@id='mod-login-password']";
        private string Login_BTN = ".//div[@class='btn-group']/button";
        #endregion
        #region Method
        public void EnterIntoUsername(string username)
        {
            EnterText(Username_TBX, username);
        }

        public void EnterIntoPassword(string password)
        {
            EnterText(Password_TBX, password);
        }

        public HomePageAC ClickLoginBTN()
        {
            ClickElement(Login_BTN);
            return new HomePageAC();
        }

        public HomePageAC Login(string username, string password)
        {
            EnterIntoUsername(username);
            EnterIntoPassword(password);
            ClickLoginBTN();
            return new HomePageAC();
        }
        #endregion
    }
}
