using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stabbed.components
{
    class Manager
    {
        public void label(Control controller, string data)
        {
            controller.Invoke(new MethodInvoker(delegate
            {
                controller.Text = data;
            }));
        }

        public void listview(ListView controller, ImageList images, List<string> items)
        {
            controller.Invoke(new MethodInvoker(delegate
            {
                controller.Enabled = false;
                if (items != null)
                {
                    for (int i = 0; i < items.Count; i++)
                    {
                        if (items[i] != string.Empty)
                            controller.Items.Add(items[i], i);
                    }
                }
                else
                {
                    controller.Items.Clear();
                }
                controller.LargeImageList = images;
                controller.Enabled = true;
            }));
        }

        public void combobox(ComboBox controller, List<string> items)
        {
            controller.Invoke(new MethodInvoker(delegate
            {
                controller.Enabled = false;
                if (items != null)
                {
                    for (int i = 0; i < items.Count; i++)
                    {
                        if (items[i] != string.Empty)
                            controller.Items.Add(items[i]);
                    }
                }
                else
                {
                    controller.Items.Clear();
                }
                controller.Enabled = true;
            }));
        }

        public object get_combobox(ComboBox controller)
        {
            object result = null;

            controller.Invoke(new MethodInvoker(delegate
            {
                result = controller.SelectedItem;
            }));

            return (result);
        }

        public void check(CheckBox controller, bool checked_value)
        {
            controller.Invoke(new MethodInvoker(delegate
            {
                controller.Checked = checked_value;
            }));
        }

        public bool switch_button(Bunifu.UI.WinForms.BunifuToggleSwitch controller)
        {
            bool checked_status = false;

            controller.Invoke(new MethodInvoker(delegate
            {
                checked_status = controller.Checked;
            }));

            return (checked_status);
        }
    }
}
