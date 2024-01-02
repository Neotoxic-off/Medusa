using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Reflection.Metadata;
using System.Reflection.PortableExecutable;
using System.Reflection.Emit;
using System.Reflection;

namespace Dies_Irae.Emma
{
    public class Emma
    {
        public class Editor
        {
            [Serializable]
            public class Item
            {
                public int offset = -1;
                public List<byte> content = null;

                public Item(int input_offset, List<byte> input_content)
                {
                    offset = input_offset;
                    content = input_content;
                }
            }

            public class Strings
            {
                public int minimum_size = 1;
            }

            public class Magic
            {
                public int size = 2;
            }

            public class Settings
            {
                public Strings strings = new Strings();
                public Magic magic = new Magic();
            }

            [Serializable]
            public class Dump
            {
                public List<Item> strings = new List<Item>();
                public List<Item> magic = new List<Item>();
                public List<Item> machine = new List<Item>();
                public List<Item> header = new List<Item>();
                public List<Item> sections = new List<Item>();
                public List<Item> timestamp = new List<Item>();
                public List<Item> symbols = new List<Item>();
                public List<Item> version = new List<Item>();
            }

            public class Buffers
            {
                public List<byte> strings = new List<byte>();
                public List<byte> magic = new List<byte>();
                public List<byte> machine = new List<byte>();
                public List<byte> sections = new List<byte>();
                public List<byte> timestamp = new List<byte>();
                public List<byte> symbols = new List<byte>();
                public List<byte> version = new List<byte>();
            }

            public class Scan
            {
                private Settings settings = new Settings();
                public Dump dump = new Dump();
                private Buffers buffers = new Buffers();
                private int buffer_offset = -1;
                private int offset = 0;

                public Scan(Profile.Settings.Rootobject input_profile, List<byte> bytes)
                {
                    parse_profile(input_profile);
                    iterator(bytes);
                }

                public Scan()
                {

                }

                private void parse_profile(Profile.Settings.Rootobject input_profile)
                {
                    settings.strings.minimum_size = (int)input_profile.data.numeric_string_minimum_size;
                    settings.magic.size = (int)input_profile.data.numeric_magic;
                }

                private void iterator(List<byte> bytes)
                {
                    for (; offset < bytes.Count; offset++)
                    {
                        search_string(bytes[offset]);
                        search_magic(bytes[offset]);
                        search_machine(bytes[offset]);
                        search_sections(bytes[offset]);
                        search_timestamp(bytes[offset]);
                        search_symbols(bytes[offset]);
                        search_version(bytes[offset]);
                    }
                }

                private List<byte> copyer(List<byte> data)
                {
                    List<byte> sender = new List<byte>();

                    foreach (byte current in data)
                        sender.Add(current);

                    return (sender);
                }

                private void update_offset()
                {
                    if (buffer_offset == -1)
                    {
                        buffer_offset = offset;
                    }
                }

                private void search_machine(byte current_byte)
                {
                    byte start = 0x00000084;
                    byte end = 0x00000085;

                    if (offset >= start && offset <= end)
                    {
                        buffers.machine.Add(current_byte);
                    }
                    else if (offset > end && dump.machine.Count == 0)
                    {
                        dump.machine.Add(new Item(start, buffers.machine));
                    }
                }

                private void search_sections(byte current_byte)
                {
                    byte start = 0x00000086;
                    byte end = 0x00000087;

                    if (offset >= start && offset <= end)
                    {
                        buffers.sections.Add(current_byte);
                    }
                    else if (offset > end && dump.sections.Count == 0)
                    {
                        dump.sections.Add(new Item(start, buffers.sections));
                    }
                }

                private void search_timestamp(byte current_byte)
                {
                    byte start = 0x00000088;
                    byte end = 0x0000008B;

                    if (offset >= start && offset <= end)
                    {
                        buffers.timestamp.Add(current_byte);
                    }
                    else if (offset > end && dump.timestamp.Count == 0)
                    {
                        dump.timestamp.Add(new Item(start, buffers.timestamp));
                    }
                }

                private void search_symbols(byte current_byte)
                {
                    byte start = 0x00000090;
                    byte end = 0x00000090;

                    if (offset >= start && offset <= end)
                    {
                        buffers.symbols.Add(current_byte);
                    }
                    else if (offset > end && dump.symbols.Count == 0)
                    {
                        dump.symbols.Add(new Item(start, buffers.symbols));
                    }
                }

                private void search_version(byte current_byte)
                {
                    int major = 0x00004A2C;
                    int minor = 0x00004A2E;
                    int extra = 0x00004A30;

                    if (offset == major || offset == minor || offset == extra)
                    {
                        dump.version.Add(new Item(offset, get_bytes($"{current_byte}")));
                    }
                }


                private void search_string(byte current_byte)
                {
                    byte minimum = 32;
                    byte maximum = 126;

                    update_offset();
                    if (current_byte >= minimum && current_byte <= maximum)
                    {
                        buffers.strings.Add(current_byte);
                    }
                    else
                    {
                        if (buffers.strings.Count >= settings.strings.minimum_size)
                        {
                            dump.strings.Add(new Item(buffer_offset, copyer(buffers.strings)));
                            buffer_offset = -1;
                            buffers.strings.Clear();
                        }
                        else
                        {
                            buffers.strings.Clear();
                        }
                    }
                }

                public string get_string(List<byte> bytes)
                {
                    string buffer = "";

                    foreach (byte data in bytes)
                    {
                        buffer += $"0x{data}";
                    }

                    return (buffer);
                }

                public string decode_string(List<byte> bytes)
                {
                    string buffer = "";

                    foreach (byte data in bytes)
                    {
                        buffer += (char)data;
                    }

                    return (buffer);
                }

                public byte decode_byte(string bytes)
                {
                    bytes = bytes.Replace("0x", "");

                    return ((byte)Int32.Parse(bytes));
                }

                public string beautify_magic(List<byte> bytes)
                {
                    string magic = "";

                    foreach (byte data in bytes)
                    {
                        magic += reverse(data.ToString("X2"));
                    }

                    return ($"0x{reverse(magic)}");
                }

                private string reverse(string data)
                {
                    string reversed = "";

                    for (int i = (data.Length - 1); i >= 0; i--)
                    {
                        reversed += data[i];
                    }

                    return (reversed);
                }

                public List<byte> get_bytes(string data)
                {
                    List<byte> bytes = new List<byte>();

                    for (int i = 0; i < data.Length; i++)
                    {
                        bytes.Add((byte)data[i]);
                    }

                    return (bytes);
                }

                public string get_offset(int offset)
                {
                    return ($"0x{offset.ToString("X8")}");
                }

                private void search_magic(byte current_byte)
                {
                    byte start = 0x00000000;

                    if (offset >= start && offset < settings.magic.size)
                    {
                        buffers.magic.Add(current_byte);
                    }
                    else if (offset > settings.magic.size && dump.magic.Count == 0)
                    {
                        dump.magic.Add(new Item(start, buffers.magic));
                    }
                }

                private string format(Item item)
                {
                    return ($"{get_offset(item.offset)}: {get_string(item.content)}");
                }
            }
        }
    }
}
