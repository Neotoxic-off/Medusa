using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Immunity.Engine
{
    public class Item
    {
        public string type = null;
        public string option = null;
        public object value = 0;

        public Item(string input_type, string input_option, object input_value)
        {
            type = input_type;
            option = input_option;
            value = input_value;
        }
    }
}
