using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiMPLabwork2
{
    public class MenuItem
    {
        public int Level { get; set; }
        public string Name { get; set; }
        public int Status { get; set; }
        public string MethodName { get; set; }
        public List<MenuItem> SubItems { get; set; }

        public MenuItem(int level, string name, int status, string methodName)
        {
            Level = level;
            Name = name;
            Status = status;
            MethodName = methodName;
            SubItems = new List<MenuItem>();
        }

        public MenuItem(string name, int status)
        {
            Name = name;
            Status = status;
        }
    }
}
