using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Nana
{
    public class configuration
    {
        [XmlIgnore]
        [JsonIgnore]
        public List<string> Exclusions { get; set; }
        public List<string> FilterExclusions { get; set; }

        public configuration()
        {
            Exclusions = new List<string>();
            FilterExclusions = new List<string>();
        }
    }
}
