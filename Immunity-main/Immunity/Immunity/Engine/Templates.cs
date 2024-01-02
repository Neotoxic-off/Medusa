using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Immunity.Engine
{
    public class Templates
    {
        public class Variables
        {
            public string path = "templates.itf";
            public string[] lines = null;
        }

        private Variables variables = new Variables();

        public Templates()
        {
            if (check() == true)
            {
                load();
            }
        }

        private bool check()
        {
            return (File.Exists(variables.path));
        }

        private void load()
        {
            variables.lines = File.ReadAllLines(variables.path);
        }
    }
}
