using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfBrowser
{
    public class WebUtils
    {
        JsonSerializerSettings settings;
        public WebUtils()
        {
            settings = new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.All
            };
        }

        public bool StoreDataObject(string serializedObject)
        {
            var result = JsonConvert.DeserializeObject(serializedObject, settings);

            if (result is MutualFund)
            {
                //do something with the object
                return true;
            }
            else
            {
                //generate an alarm
                return false;
            }
        }
    }
}
