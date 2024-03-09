using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiMPLabwork2
{
    public class MenuReader
    {
        string filePath;
        public List<MenuItem> MenuItems { get; set; }

        public MenuReader(string filePath)
        {
            this.filePath = filePath;
            MenuItems = new List<MenuItem>();
            ReadMenuFromFile();
        }


        //public List<MenuItem> ReadMenuFromFile()
        //{
        //    List<MenuItem> menuItems = new List<MenuItem>();
        //    MenuItem prevItem = null;

        //    foreach (string line in File.ReadLines(filePath))
        //    {
        //        string[] parts = line.Split(' ');
        //        if (parts.Length >= 4)
        //        {
        //            int level = Convert.ToInt32(parts[0]);
        //            string name = parts[1];
        //            int status = Convert.ToInt32(parts[2]);
        //            string methodName = parts[3];

        //            MenuItem menuItem = new MenuItem(level, name, status, methodName);

        //            if (level == 0)
        //            {
        //                menuItems.Add(menuItem);
        //                prevItem = menuItem;
        //            }
        //            else
        //            {
        //                if (prevItem != null)
        //                {
        //                    if (level > prevItem.Level)
        //                    {
        //                        prevItem.SubItems.Add(menuItem);
        //                    }
        //                    else
        //                    {
        //                        MenuItem parent = FindParentItem(menuItems, level - 1);
        //                        if (parent != null)
        //                        {
        //                            parent.SubItems.Add(menuItem);
        //                        }
        //                    }
        //                    //prevItem = menuItem;
        //                }
        //            }
        //        }
        //    }
        //    return menuItems;
        //}


        private void ReadMenuFromFile()
        {
            Dictionary<int, MenuItem> menuItemsByLevel = new Dictionary<int, MenuItem>();

            foreach (string line in File.ReadLines(filePath))
            {
                string[] parts = line.Split(' ');

                int level = Convert.ToInt32(parts[0]);
                string name = parts[1];
                int status = Convert.ToInt32(parts[2]);
                string methodName = parts[3];

                MenuItem menuItem = new MenuItem(level, name, status, methodName);

                if (parts[parts.Length - 1] != " ")
                {
                    menuItemsByLevel[level] = menuItem;
                }
                else
                {
                    int parentLevel = level - 1;
                    menuItemsByLevel[parentLevel].SubItems.Add(menuItem);
                    menuItemsByLevel[level] = menuItem;
                }

                if (level == 0)
                {
                    MenuItems.Add(menuItem);
                }
            }
        }


        private MenuItem FindParentItem(List<MenuItem> menuItems, int level)
        {
            foreach (MenuItem item in menuItems)
            {
                if (item.Level == level)
                {
                    return item;
                }
            }
            return null;
        }
    }
}
