using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using LogigearQATeam.Common;

namespace LogigearQATeam.TestSuites.TestCase
{
    [Binding]
    class CommonTC:CommonAC
    {
        [Given(@"I naviate to Joomla site: (.*)")]
        public void NaviateToJoomlaSite(string URL)
        {
            NavigateTo(URL);
        }
    }
}
