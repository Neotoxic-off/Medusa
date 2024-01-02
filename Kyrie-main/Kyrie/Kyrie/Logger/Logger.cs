using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kyrie.Logger
{
    public class Logger
    {
        private List<string> logs = new List<string>();

        public void add(string log)
        {
            logs.Add($"[{DateTime.Now.ToString("h:mm:ss tt")}] | {log}");
        }

        public void dump()
        {
            string output = "";
        }
    }
}
