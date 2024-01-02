using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stabbed.splash
{
    class Required
    {
        public bool folders(List<string> folders_data)
        {
            foreach (string folder in folders_data)
            {
                if (Directory.Exists(folder) == false)
                    return (false);
            }

            return (true);
        }

        public bool files(List<string> files_data)
        {
            foreach (string file in files_data)
            {
                if (File.Exists(file) == false)
                    return (false);
            }

            return (true);
        }
    }
}
