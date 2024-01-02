using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dies_Irae.Popup
{
    public partial class Editor : Form
    {
        private BackgroundWorker loader = new BackgroundWorker();
        private Controler.Manager manager = new Controler.Manager();
        private Emma.Emma.Editor.Dump content = null;
        private Dictionary<string, string> result = new Dictionary<string, string>();
        private List<string> types = new List<string>();
        private Emma.Emma.Editor.Scan emma = new Emma.Emma.Editor.Scan();

        public Editor(Emma.Emma.Editor.Dump input_content)
        {
            InitializeComponent();
            InitializeWorkers();

            Region = Region.FromHrgn(Controler.Ui.CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            content = input_content;
        }

        private void InitializeWorkers()
        {
            loader.DoWork += new DoWorkEventHandler(load);
        }

        private void load(object sender, EventArgs e)
        {
            load_strings();
            load_symbols();
            load_timestamp();
            load_magic();
            load_machine();
            load_version();
            load_sections();
        }

        private void load_magic()
        {
            foreach (Emma.Emma.Editor.Item item in content.magic)
            {
                manager.set_textbox(box_magic_number, emma.beautify_magic(item.content));
            }
        }

        private void load_strings()
        {
            foreach (Emma.Emma.Editor.Item item in content.strings)
            {
                manager.add_listview(box_view_data, emma.get_offset(item.offset), emma.decode_string(item.content));
            }
        }

        private void load_machine()
        {
            foreach (Emma.Emma.Editor.Item item in content.machine)
            {
                manager.set_textbox(box_machine, emma.beautify_magic(item.content));
            }
        }

        private void load_sections()
        {
            foreach (Emma.Emma.Editor.Item item in content.sections)
            {
                manager.set_textbox(box_sections, emma.beautify_magic(item.content));
            }
        }

        private void load_timestamp()
        {
            foreach (Emma.Emma.Editor.Item item in content.timestamp)
            {
                manager.set_textbox(box_timestamp, emma.beautify_magic(item.content));
            }
        }

        private void load_symbols()
        {
            foreach (Emma.Emma.Editor.Item item in content.symbols)
            {
                manager.set_textbox(box_symbols, emma.get_string(item.content));
            }
        }

        private void load_version()
        {
            foreach (Emma.Emma.Editor.Item item in content.version)
            {
                manager.add_listview(view_version, emma.get_offset(item.offset), emma.decode_string(item.content));
            }
        }

        private void Editor_Shown(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            box_view_data.Visible = false;
            loader.RunWorkerAsync();

            while (loader.IsBusy == true)
            {
                Application.DoEvents();
            }
            box_view_data.Visible = true;
            Cursor.Current = Cursors.Default;
        }

        private void button_exit_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
