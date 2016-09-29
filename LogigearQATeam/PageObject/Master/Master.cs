using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogigearQATeam.PageObject.Master
{
    public class Master:Common.CommonAC
    {
        Login.LoginAC LG = new Login.LoginAC();
        public void demo()
        {
            LG.ClickLoginBTN();
        }
    }
}
