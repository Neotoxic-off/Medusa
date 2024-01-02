using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Immunity.Engine
{
    public class Builder
    {
        private List<string> result = new List<string>();

        public Builder(List<Item> items)
        {
            run(items);
        }

        private void run(List<Item> items)
        {
            foreach (Item item in items)
            {
                Console.WriteLine($"{item.type} {item.option} {item.value}");
            }
        }

        private void dump(string path)
        {
            File.WriteAllLines(path, result);
        }
    }
}
