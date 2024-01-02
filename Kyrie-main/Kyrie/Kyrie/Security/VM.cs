using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Management;

namespace Kyrie.Security
{
    public class VM
    {
        public bool status = false;

        public VM()
        {
            check();
        }

        private void check()
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("Select * from Win32_ComputerSystem");
            ManagementObjectCollection items = searcher.Get();

            foreach (ManagementBaseObject item in items)
            {
                if (check_items(item) == true)
                {
                    status = true;
                }
            } 
        }

        private bool manufacturers(string manufacturer)
        {
            List<string> blacklist = new List<string>()
            {
                "microsoft",
                "vmware",
                "virtualbox"
            };

            foreach (string data in blacklist)
            {
                if (manufacturer.Contains(data) == true)
                {
                    return (true);
                }
            }

            return (false);
        }

        private bool check_items(ManagementBaseObject item)
        {
            List<string> blacklist = new List<string>()
            {
                "virtualbox",
                "virtual"
            };

            foreach (string data in blacklist)
            {
                if ($"{item["Model"]}".ToLower().Contains(data) == true)
                {
                    return (true);
                }
            }

            return (false);
        }
    }
}
