using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kyrie.Constants
{
    public class Errors
    {
        public class Item
        {
            public string title = null;
            public string message = null;

            public Item(string input_title, string input_message)
            {
                title = input_title;
                message = input_message;
            }
        }

        Messages messages = new Messages();
        Paths paths = new Paths();

        public Item missing_file = null;
        public Item missing_folder = null;
        public Item profile_error = null;
        public Item vm_error = null;
        public Item display_logs = null;

        public Errors()
        {
            missing_file = new Item(
                "Requirement missing",
                "Oh well, this is embarasing, a required file is missing. Make sure you extracted the archive and downloaded Kyrie from Elevatia's server"
            );
            missing_folder = new Item(
                "Requirement missing",
                "Oh well, this is embarasing, a required folder is missing. Make sure you extracted the archive and downloaded Kyrie from Elevatia's server"
            );
            profile_error = new Item(
                "Profile error",
                "Hum, something is really wrong with your profile. Make sure you don't have any proxy running and make sure you extracted the archive and downloaded Kyrie from Elevatia's server"
            );
            vm_error = new Item(
                "Virtual Machine error",
                "Hum hum, you are really trying to access to my cheats with a vm ?"
            );
            display_logs = new Item(
                "Changelogs",
                messages.get_logs(paths.changelogs)
            );
        }
    }
}
