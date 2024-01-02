using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kyrie.Constants
{
    public class Messages
    {
        public string get_logs(string path)
        {
            if (File.Exists(path) == true)
            {
                return (File.ReadAllText(path));
            }
            return (null);
        }
    }
}
