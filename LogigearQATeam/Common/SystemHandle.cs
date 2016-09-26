using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Web.Script.Serialization;

namespace LogigearQATeam.Common
{
    public class SystemHandle
    {
        public class control
        {
            public string controlName { get; set; }
            public string type { get; set; }
            public string value { get; set; }
        }

        public string GetControlValue(string nameControl, string pageName)
        {
            string path = Directory.GetParent(System.Reflection.Assembly.GetExecutingAssembly().Location).FullName;
            path = path.Replace("\\bin\\Debug", "");
            path = path + "\\" + pageName + "\\" + pageName + ".json";

            var result = new JavaScriptSerializer().Deserialize<List<control>>(path);
            string[] control = new string[2];
            foreach (var item in result)
            {
                if (item.controlName.Equals(nameControl))
                {
                    control[0] = item.type;
                    control[1] = item.value;
                    return control[1];
                }
            }
            return null;
        }
    }
}
