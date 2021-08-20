using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBPC.classes
{
    class permissions
    {
        public long get_value(string key)
        {
            Dictionary<string, long> data = new Dictionary<string, long>()
            {
                { "Administrator", 0x8 },
                { "Manage Channels", 0x10 },
                { "Manage Roles", 0x10000000 },
                { "Manage Emojis", 0x40000000 },
                { "View Audit Log", 0x80 },
                { "View Server Insights", 0x80000 },
                { "Manage Webhooks", 0x20000000 },
                { "Manage Server", 0x20 },
                { "Create Invite", 0x1 },
                { "Change Nickname", 0x4000000 },
                { "Manage Nicknames", 0x8000000 },
                { "Kick Members", 0x2 },
                { "Ban Members", 0x4 },
                { "Read Messages", 0x400 },
                { "Send Messages", 0x800 },
                { "Embed Links", 0x4000 },
                { "Attach Files", 0x8000 },
                { "Add Reactions", 0x40 },
                { "Use External Emojis", 0x40000 },
                { "Mention @everyone, @here, and All Roles", 0x20000 },
                { "Manage Messages", 0x2000 },
                { "Read Message History", 0x10000 },
                { "Send TTS Messages", 0x1000 },
                { "Use Slash Commands", 0x80000000 },
                { "View Channel", 0x400 },
                { "Connect", 0x100000 },
                { "Speak", 0x200000 },
                { "Video", 0x200 },
                { "Use Voice Activity", 0x2000000 },
                { "Priority Speaker", 0x100 },
                { "Mute Members", 0x400000 },
                { "Deafen Members", 0x800000 },
                { "Move Members", 0x1000000 },
                { "Request to Speak", 0x100000000 }
            };

            return (data[key]);
        }
    }
}
