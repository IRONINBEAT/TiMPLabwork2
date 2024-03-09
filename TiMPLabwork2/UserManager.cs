using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiMPLabwork2
{
    public class UserManager
    {
        private List<User> users;

        public UserManager(string filename = "C:\\Users\\IRONIN\\RiderProjects\\TestLogic\\TestLogic\\bin\\Debug\\net7.0\\USERS.txt")
        {
            users = new List<User>();
            LoadUsersFromFile(filename);
        }

        private void LoadUsersFromFile(string filename)
        {
            try
            {
                using (StreamReader sr = new StreamReader(filename))
                {
                    string line;
                    User currentUser = null;
                    while ((line = sr.ReadLine()) != null)
                    {
                        if (line.StartsWith("#"))
                        {
                            string[] userInfo = line.Substring(1).Split(' ');
                            currentUser = new User(userInfo[0], userInfo[1]);
                            users.Add(currentUser);
                        }
                        else
                        {
                            string[] menuItemInfo = line.Split(' ');
                            MenuItem mi = new MenuItem(menuItemInfo[0], int.Parse(menuItemInfo[1]));
                            currentUser.MenuItems.Add(mi);
                            //string[] menuItemInfo = line.Split(' ');
                            //currentUser.MenuAccess.Add(menuItemInfo[0], int.Parse(menuItemInfo[1]));
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("An error occurred while reading the file: " + e.Message);
            }
        }

        public User Authenticate(string username, string password)
        {
            return users.FirstOrDefault(u => u.Username == username && u.Password == password);
        }
    }
}
