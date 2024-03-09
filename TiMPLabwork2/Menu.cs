using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TiMPLabwork2
{
    public partial class Menu : Form
    {
        private ContextMenuStrip contextMenuStrip1;
        private IContainer components;
        private ToolStripComboBox toolStripComboBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripMenuItem toolStripMenuItem4;
        private ToolStripMenuItem toolStripMenuItem6;
        private ToolStripMenuItem toolStripMenuItem8;
        private ToolStripMenuItem toolStripMenuItem5;
        private ToolStripMenuItem toolStripMenuItem7;

        private readonly User user;

        public Menu()
        {
            InitializeComponent();
        }

        public Menu(User user)
        {
            InitializeComponent();
            this.user = user;
            GenerateMenu();
        }

        private void GenerateMenu()
        {
            foreach (var menuItem in user.MenuAccess.Where(kv => kv.Value != 2))
            {
                ToolStripMenuItem menuItemControl = new ToolStripMenuItem(menuItem.Key);
                menuItemControl.Click += MenuItem_Click;
                menuStrip1.Items.Add(menuItemControl);
            }
        }

        private void MenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem menuItem = (ToolStripMenuItem)sender;
            string methodName = user.MenuAccess[menuItem.Text] == 0 ? "MenuItemHandler" : null;
            MessageBox.Show($"You clicked on '{menuItem.Text}' with method '{methodName}'.");
        }

        private void Others_Click(object sender, EventArgs e) => MessageBox.Show("Вызвался метод Others", "Вызов функции", MessageBoxButtons.OK, MessageBoxIcon.Information);
        private void Stuff_Click(object sender, EventArgs e) => MessageBox.Show("Вызвался метод Stuff", "Вызов функции", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        private void Orders_Click(object sender, EventArgs e) => MessageBox.Show("Вызвался метод Orders", "Вызов функции", MessageBoxButtons.OK, MessageBoxIcon.Error);
        private void Docs_Click(object sender, EventArgs e) => MessageBox.Show("Вызвался метод Docs", "Вызов функции", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        private void Licenses_Click(object sender, EventArgs e) => MessageBox.Show("Вызвался метод Licenses", "Вызов функции", MessageBoxButtons.OK, MessageBoxIcon.Question);
        private void Departs_Click(object sender, EventArgs e) => MessageBox.Show("Вызвался метод Departs", "Вызов функции", MessageBoxButtons.OK, MessageBoxIcon.Question);
        private void Towns_Click(object sender, EventArgs e) => MessageBox.Show("Вызвался метод Towns", "Вызов", MessageBoxButtons.OK, MessageBoxIcon.Information);
        private void Founders_Click(object sender, EventArgs e) => MessageBox.Show("Вызвался метод Founders", "Вызов функции", MessageBoxButtons.OK, MessageBoxIcon.Question);
        private void Engineers_Click(object sender, EventArgs e) => MessageBox.Show("Вызвался метод Engineers", "Вызов функции", MessageBoxButtons.OK, MessageBoxIcon.Information);
        private void Builders_Click(object sender, EventArgs e) => MessageBox.Show("Вызвался метод Builders", "Вызов функции", MessageBoxButtons.OK, MessageBoxIcon.Question);
        private void Other_Click(object sender, EventArgs e) => MessageBox.Show("Вызвался метод Other", "Вызов функции", MessageBoxButtons.OK, MessageBoxIcon.Error);
        private void Content_Click(object sender, EventArgs e) => MessageBox.Show("Вызвался метод Content", "Вызов", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        private void About_Click(object sender, EventArgs e) => MessageBox.Show("Вызвался метод About", "Вызов функции", MessageBoxButtons.OK, MessageBoxIcon.Information);
        private void Window_Click(object sender, EventArgs e) => MessageBox.Show("Вызвался метод Window", "Вызов функции", MessageBoxButtons.OK, MessageBoxIcon.Information);

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
