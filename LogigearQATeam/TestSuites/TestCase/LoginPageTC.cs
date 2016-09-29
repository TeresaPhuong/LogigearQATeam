using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using LogigearQATeam.PageObject.Login;


namespace LogigearQATeam.TestSuites.TestCase
{
    [Binding]
    class LoginPageTC:LoginAC
    {
        [Given(@"I enter username: (.*)")]
        public void EnterUsername(string username)
        {
            EnterIntoUsername(username);
        }

        [Given(@"I enter password: (.*)")]
        public void EnterPassword(string password)
        {
            EnterIntoPassword(password);
        }

        [Given(@"I click Login button")]
        public void ClickLoginButton()
        {
            ClickLoginBTN();
        }
    }
}
