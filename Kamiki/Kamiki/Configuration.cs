using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONFIGURATION
{
    class configuration
    {
        public class Rootobject
        {
            public SURVIVORS SURVIVORS { get; set; }
            public KILLERS KILLERS { get; set; }
        }

        public class SURVIVORS
        {
            public string[] ITEMS { get; set; }
            public string[] ADDONS { get; set; }
            public string[] OFFERINGS { get; set; }
        }

        public class KILLERS
        {
            public string[] ADDONS { get; set; }
            public string[] OFFERINGS { get; set; }
        }

        public bool GIS(string item, Rootobject _content_)
        {
            string _item_ = null;
            
            for (int i = 0; i < _content_.SURVIVORS.ITEMS.Length; i++) {
                _item_ = _content_.SURVIVORS.ITEMS[i].ToLower();
                
                if (_item_.Contains(item.ToLower()) == true && _item_.Split(',')[1] == "true")
                    return (true);
            }
            return (false);
        }

        public bool GAS(string addon, Rootobject _content_)
        {
            string _addon_ = null;

            for (int i = 0; i < _content_.SURVIVORS.ADDONS.Length; i++)
            {
                _addon_ = _content_.SURVIVORS.ADDONS[i].ToLower();

                if (_addon_.Contains(addon.ToLower()) == true && _addon_.Split(',')[1] == "true")
                    return (true);
            }
            return (false);
        }

        public bool GOS(string offering, Rootobject _content_)
        {
            string _offering_ = null;

            for (int i = 0; i < _content_.SURVIVORS.OFFERINGS.Length; i++)
            {
                _offering_ = _content_.SURVIVORS.OFFERINGS[i].ToLower();

                if (_offering_.Contains(offering.ToLower()) == true && _offering_.Split(',')[1] == "true")
                    return (true);
            }
            return (false);
        }

        public bool GAK(string addon, Rootobject _content_)
        {
            string _addon_ = null;

            for (int i = 0; i < _content_.KILLERS.ADDONS.Length; i++)
            {
                _addon_ = _content_.KILLERS.ADDONS[i].ToLower();

                if (_addon_.Contains(addon.ToLower()) == true && _addon_.Split(',')[1] == "true")
                    return (true);
            }
            return (false);
        }

        public bool GOK(string offering, Rootobject _content_)
        {
            string _offering_ = null;

            for (int i = 0; i < _content_.KILLERS.OFFERINGS.Length; i++)
            {
                _offering_ = _content_.KILLERS.OFFERINGS[i].ToLower();

                if (_offering_.Contains(offering.ToLower()) == true && _offering_.Split(',')[1] == "true")
                    return (true);
            }
            return (false);
        }
    }
}
