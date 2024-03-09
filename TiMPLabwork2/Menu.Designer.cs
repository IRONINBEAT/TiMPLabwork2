namespace TiMPLabwork2
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        //private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            contextMenuStrip1 = new ContextMenuStrip(components);
            toolStripComboBox1 = new ToolStripComboBox();
            menuStrip1 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripMenuItem();
            toolStripMenuItem4 = new ToolStripMenuItem();
            toolStripMenuItem5 = new ToolStripMenuItem();
            toolStripComboBox2 = new ToolStripMenuItem();
            toolStripComboBox3 = new ToolStripMenuItem();
            toolStripMenuItem7 = new ToolStripMenuItem();
            toolStripComboBox4 = new ToolStripMenuItem();
            toolStripComboBox6 = new ToolStripMenuItem();
            toolStripComboBox5 = new ToolStripMenuItem();
            toolStripComboBox7 = new ToolStripMenuItem();
            toolStripMenuItem6 = new ToolStripMenuItem();
            toolStripMenuItem8 = new ToolStripMenuItem();
            toolStripComboBox8 = new ToolStripMenuItem();
            toolStripComboBox9 = new ToolStripMenuItem();
            contextMenuStrip1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(32, 32);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { toolStripComboBox1 });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(182, 31);
            // 
            // toolStripComboBox1
            // 
            toolStripComboBox1.Name = "toolStripComboBox1";
            toolStripComboBox1.Size = new Size(121, 23);
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, toolStripMenuItem2, toolStripMenuItem3, toolStripMenuItem4, toolStripMenuItem5, toolStripMenuItem6, toolStripMenuItem8 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1668, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "Справка";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(57, 20);
            toolStripMenuItem1.Text = "Разное";
            toolStripMenuItem1.Click += Others_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(85, 20);
            toolStripMenuItem2.Text = "Сотрудники";
            toolStripMenuItem2.Click += Stuff_Click;
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(68, 20);
            toolStripMenuItem3.Text = "Приказы";
            toolStripMenuItem3.Click += Orders_Click;
            // 
            // toolStripMenuItem4
            // 
            toolStripMenuItem4.Name = "toolStripMenuItem4";
            toolStripMenuItem4.Size = new Size(82, 20);
            toolStripMenuItem4.Text = "Документы";
            toolStripMenuItem4.Click += Docs_Click;
            // 
            // toolStripMenuItem5
            // 
            toolStripMenuItem5.DropDownItems.AddRange(new ToolStripItem[] { toolStripComboBox2, toolStripComboBox3, toolStripMenuItem7 });
            toolStripMenuItem5.Name = "toolStripMenuItem5";
            toolStripMenuItem5.Size = new Size(87, 20);
            toolStripMenuItem5.Text = "Справочник";
            // 
            // toolStripComboBox2
            // 
            toolStripComboBox2.Name = "toolStripComboBox2";
            toolStripComboBox2.Size = new Size(137, 22);
            toolStripComboBox2.Text = "Отделы";
            toolStripComboBox2.Click += Departs_Click;
            // 
            // toolStripComboBox3
            // 
            toolStripComboBox3.Name = "toolStripComboBox3";
            toolStripComboBox3.Size = new Size(137, 22);
            toolStripComboBox3.Text = "Города";
            toolStripComboBox3.Click += Towns_Click;
            // 
            // toolStripMenuItem7
            // 
            toolStripMenuItem7.DropDownItems.AddRange(new ToolStripItem[] { toolStripComboBox4, toolStripComboBox6, toolStripComboBox5, toolStripComboBox7 });
            toolStripMenuItem7.Name = "toolStripMenuItem7";
            toolStripMenuItem7.Size = new Size(137, 22);
            toolStripMenuItem7.Text = "Должности";
            // 
            // toolStripComboBox4
            // 
            toolStripComboBox4.Name = "toolStripComboBox4";
            toolStripComboBox4.Size = new Size(140, 22);
            toolStripComboBox4.Text = "Основатели";
            toolStripComboBox4.Click += Founders_Click;
            // 
            // toolStripComboBox6
            // 
            toolStripComboBox6.Name = "toolStripComboBox6";
            toolStripComboBox6.Size = new Size(140, 22);
            toolStripComboBox6.Text = "Инженеры";
            toolStripComboBox6.Click += Engineers_Click;
            // 
            // toolStripComboBox5
            // 
            toolStripComboBox5.Name = "toolStripComboBox5";
            toolStripComboBox5.Size = new Size(140, 22);
            toolStripComboBox5.Text = "Строители";
            toolStripComboBox5.Click += Builders_Click;
            // 
            // toolStripComboBox7
            // 
            toolStripComboBox7.Name = "toolStripComboBox7";
            toolStripComboBox7.Size = new Size(140, 22);
            toolStripComboBox7.Text = "Другие";
            toolStripComboBox7.Click += Other_Click;
            // 
            // toolStripMenuItem6
            // 
            toolStripMenuItem6.Name = "toolStripMenuItem6";
            toolStripMenuItem6.Size = new Size(48, 20);
            toolStripMenuItem6.Text = "Окно";
            toolStripMenuItem6.Click += Window_Click;
            // 
            // toolStripMenuItem8
            // 
            toolStripMenuItem8.DropDownItems.AddRange(new ToolStripItem[] { toolStripComboBox8, toolStripComboBox9 });
            toolStripMenuItem8.Name = "toolStripMenuItem8";
            toolStripMenuItem8.Size = new Size(65, 20);
            toolStripMenuItem8.Text = "Справка";
            // 
            // toolStripComboBox8
            // 
            toolStripComboBox8.Name = "toolStripComboBox8";
            toolStripComboBox8.Size = new Size(151, 22);
            toolStripComboBox8.Text = "Оглавление";
            toolStripComboBox8.Click += Content_Click;
            // 
            // toolStripComboBox9
            // 
            toolStripComboBox9.Name = "toolStripComboBox9";
            toolStripComboBox9.Size = new Size(151, 22);
            toolStripComboBox9.Text = "О_программе";
            toolStripComboBox9.Click += About_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1668, 790);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "АИС Отдел Кадров";
            FormClosing += Menu_FormClosing;
            contextMenuStrip1.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion


        private ToolStripMenuItem toolStripComboBox2;
        private ToolStripMenuItem toolStripComboBox3;
        private ToolStripMenuItem toolStripComboBox4;
        private ToolStripMenuItem toolStripComboBox5;
        private ToolStripMenuItem toolStripComboBox6;
        private ToolStripMenuItem toolStripComboBox7;
        private ToolStripMenuItem toolStripComboBox8;
        private ToolStripMenuItem toolStripComboBox9;
    }
}