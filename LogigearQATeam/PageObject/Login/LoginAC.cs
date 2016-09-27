using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace LogigearQATeam.PageObject.Login
{
    class LoginAC:Common.CommonAC
    {
        #region Interface
        private string Username_TBX = ".//input[@id='mod-login-username']";
        private string Password_TBX = ".//input[@id='mod-login-password']";
        private string Login_BTN = ".//div[@class='btn-group']/button";
        //private string Username_TBX { get; set; }
        #endregion 
        #region Method

        //public string ReadLoginINFile()
        //{
        //    var JsonLoginIN = File.ReadAllText("LoginIN.json");
        //    var objects = JsonArrayAttribute.GetCustomAttributes(JsonLoginIN);
        //}
        public void EnterIntoUsername(string username)
        {
            WaitToPageLoad(Username_TBX);
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
