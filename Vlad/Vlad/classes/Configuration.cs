using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vlad.classes
{
    class Configuration
    {
        public string env(string value)
        {
            Dictionary<string, string> data = new Dictionary<string, string>()
            {
                { "resources", "Resources" },
                { "characters", "Characters.json" },
                { "settings", "Settings.json" },
                { "perks", "Perks.json" }
            };

            return (data[value]);
        }
    }
}
