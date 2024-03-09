using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiMPLabwork2
{
    public class MenuBuilder
    {
        public void BuildMenu(MenuStrip menuStrip, List<MenuItem> menuItems)
        {
            foreach (MenuItem menuItem in menuItems)
            {
                ToolStripMenuItem toolStripMenuItem = new ToolStripMenuItem(menuItem.Name);
                toolStripMenuItem.Click += (sender, e) =>
                {
                    Console.WriteLine($"Clicked on menu item: {menuItem.MethodName}");
                };

                if (menuItem.SubItems.Count > 0)
                {
                    AddSubMenuItems(toolStripMenuItem, menuItem.SubItems);
                }

                menuStrip.Items.Add(toolStripMenuItem);
            }
        }

        private void AddSubMenuItems(ToolStripMenuItem parentItem, List<MenuItem> subItems)
        {
            foreach (MenuItem subItem in subItems)
            {
                ToolStripMenuItem toolStripMenuItem = new ToolStripMenuItem(subItem.Name);
                toolStripMenuItem.Name = subItem.MethodName;
                toolStripMenuItem.Click += MenuItem_Click;

                if (subItem.SubItems.Count > 0)
                {
                    AddSubMenuItems(toolStripMenuItem, subItem.SubItems);
                }

                parentItem.DropDownItems.Add(toolStripMenuItem);
            }
        }

        private void MenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem menuItem = (ToolStripMenuItem)sender;

            MessageBox.Show($"You clicked on '{menuItem.Text}' with method '{menuItem.Name}'.");
        }
    }

    
}
