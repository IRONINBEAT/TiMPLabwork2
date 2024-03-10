using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiMPLabwork2
{
    public class MenuManager
    {
        private List<MenuItem> menuItems;

        public MenuManager(string filename = "menu.txt")
        {
            menuItems = new List<MenuItem>();
            LoadMenuFromFile(filename);
        }

        private void LoadMenuFromFile(string filename)
        {
            try
            {
                using (StreamReader sr = new StreamReader(filename))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        bool flag = false;
                        string[] parts = line.Split(' ');
                        int level = int.Parse(parts[0]);
                        string name = parts[1];
                        int status = int.Parse(parts[2]);
                        string methodName = parts.Length > 3 ? parts[3] : null;

                        MenuItem menuItem = new MenuItem(level, name, status, methodName);


                        if (level != 0)
                        {
                            var parent = FindParentItem(menuItems, menuItem.Level - 1);
                            parent.SubItems.Add(menuItem);
                            flag = true;
                        }
                        if (flag)
                            continue;
                        else
                            menuItems.Add(menuItem);

                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("An error occurred while reading the file: " + e.Message);
            }
        }

        public void DisplayMenu()
        {
            DisplayMenuItems(menuItems);
        }

        public List<MenuItem> GetMenuItems()
        {
            return menuItems;
        }

        private void DisplayMenuItems(List<MenuItem> items)
        {
            foreach (var item in items)
            {
                if (item.Status == 2)
                    continue;

                Console.WriteLine(item.Level + " " + item.Name + " " + item.Status + " " + item.MethodName);

                // if (item.SubItems.Count > 0)
                // {
                //     DisplayMenuItems(item.SubItems, level + 1);
                // }
            }
        }

        private MenuItem FindParentItem(List<MenuItem> menuItems, int level)
        {
            MenuItem foundItem = null;

            foreach (MenuItem item in menuItems)
            {
                if (item.Level == level)
                {
                    foundItem = item;
                }

                if (item.SubItems != null)
                {
                    MenuItem subFoundItem = FindParentItem(item.SubItems, level);
                    if (subFoundItem != null)
                    {
                        foundItem = subFoundItem;
                    }
                }
            }

            return foundItem;
        }

        public static void BuildMenu(User user, List<MenuItem> menuItems, ToolStripItemCollection parentItems)
        {
            foreach (MenuItem item in menuItems)
            {
                foreach (var userItem in user.MenuItems)
                    if (userItem.Name == item.Name)
                        item.Status = userItem.Status;
                ToolStripMenuItem toolStripItem = new ToolStripMenuItem(item.Name);
                if (item.MethodName != "")
                    toolStripItem.Click += (sender, e) =>
                    {
                        MessageBox.Show($"Вы нажали на {item.Name}, вызвался метод {item.MethodName}");
                    };
                if (item.Status == 2) toolStripItem.Visible = false;
                if (item.Status == 1) toolStripItem.Enabled = false;
                parentItems.Add(toolStripItem);

                if (item.SubItems != null)
                {
                    BuildMenu(user, item.SubItems, toolStripItem.DropDownItems);
                }
            }
        }

        private static void HandleMenuItemClick(object sender, EventArgs e)
        {
            if (sender is ToolStripMenuItem menuItem)
            {
                string methodName = menuItem.Text.Split().Last();
                MessageBox.Show(methodName);
            }
        }

    }

    
}
