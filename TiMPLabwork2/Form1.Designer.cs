namespace TiMPLabwork2;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        panel1 = new Panel();
        CapsLockFlagLabel = new Label();
        CurrentLanguageLabel = new Label();
        CloseButton = new Button();
        EnterButton = new Button();
        pictureBox1 = new PictureBox();
        label5 = new Label();
        label4 = new Label();
        label3 = new Label();
        Password = new TextBox();
        UserName = new TextBox();
        label2 = new Label();
        label1 = new Label();
        panel1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        SuspendLayout();
        // 
        // panel1
        // 
        panel1.BackColor = SystemColors.ActiveCaption;
        panel1.Controls.Add(CapsLockFlagLabel);
        panel1.Controls.Add(CurrentLanguageLabel);
        panel1.Controls.Add(CloseButton);
        panel1.Controls.Add(EnterButton);
        panel1.Controls.Add(pictureBox1);
        panel1.Controls.Add(label5);
        panel1.Controls.Add(label4);
        panel1.Controls.Add(label3);
        panel1.Controls.Add(Password);
        panel1.Controls.Add(UserName);
        panel1.Controls.Add(label2);
        panel1.Controls.Add(label1);
        panel1.Dock = DockStyle.Fill;
        panel1.Location = new Point(0, 0);
        panel1.Margin = new Padding(2);
        panel1.Name = "panel1";
        panel1.Size = new Size(795, 509);
        panel1.TabIndex = 0;
        // 
        // CapsLockFlagLabel
        // 
        CapsLockFlagLabel.Font = new Font("Microsoft Sans Serif", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
        CapsLockFlagLabel.Location = new Point(402, 484);
        CapsLockFlagLabel.Margin = new Padding(2, 0, 2, 0);
        CapsLockFlagLabel.Name = "CapsLockFlagLabel";
        CapsLockFlagLabel.Size = new Size(386, 27);
        CapsLockFlagLabel.TabIndex = 13;
        CapsLockFlagLabel.Text = "Нажата клавиша caps lock";
        // 
        // CurrentLanguageLabel
        // 
        CurrentLanguageLabel.Font = new Font("Microsoft Sans Serif", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
        CurrentLanguageLabel.Location = new Point(7, 484);
        CurrentLanguageLabel.Margin = new Padding(2, 0, 2, 0);
        CurrentLanguageLabel.Name = "CurrentLanguageLabel";
        CurrentLanguageLabel.Size = new Size(379, 27);
        CurrentLanguageLabel.TabIndex = 12;
        CurrentLanguageLabel.Text = "Язык ввода английский";
        // 
        // CloseButton
        // 
        CloseButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
        CloseButton.Location = new Point(646, 406);
        CloseButton.Margin = new Padding(2);
        CloseButton.Name = "CloseButton";
        CloseButton.Size = new Size(115, 39);
        CloseButton.TabIndex = 11;
        CloseButton.Text = "Отмена";
        CloseButton.UseVisualStyleBackColor = true;
        CloseButton.Click += CloseButton_Click;
        // 
        // EnterButton
        // 
        EnterButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
        EnterButton.Location = new Point(69, 406);
        EnterButton.Margin = new Padding(2);
        EnterButton.Name = "EnterButton";
        EnterButton.Size = new Size(106, 39);
        EnterButton.TabIndex = 10;
        EnterButton.Text = "Вход";
        EnterButton.UseVisualStyleBackColor = true;
        EnterButton.Click += btnLogin_Click;
        // 
        // pictureBox1
        // 
        pictureBox1.Location = new Point(11, 61);
        pictureBox1.Margin = new Padding(2);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new Size(193, 188);
        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        pictureBox1.TabIndex = 8;
        pictureBox1.TabStop = false;
        // 
        // label5
        // 
        label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        label5.BackColor = Color.Bisque;
        label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
        label5.Location = new Point(11, 61);
        label5.Margin = new Padding(2, 0, 2, 0);
        label5.Name = "label5";
        label5.Size = new Size(769, 46);
        label5.TabIndex = 7;
        label5.Text = "АИС Отдел кадров";
        label5.TextAlign = ContentAlignment.MiddleRight;
        // 
        // label4
        // 
        label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        label4.BackColor = Color.Gold;
        label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
        label4.Location = new Point(11, 132);
        label4.Margin = new Padding(2, 0, 2, 0);
        label4.Name = "label4";
        label4.Size = new Size(769, 46);
        label4.TabIndex = 6;
        label4.TextAlign = ContentAlignment.MiddleRight;
        // 
        // label3
        // 
        label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        label3.BackColor = Color.AliceBlue;
        label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
        label3.Location = new Point(11, 203);
        label3.Margin = new Padding(2, 0, 2, 0);
        label3.Name = "label3";
        label3.Size = new Size(769, 46);
        label3.TabIndex = 5;
        label3.Text = "Введите иля пользователя и пароль";
        label3.TextAlign = ContentAlignment.MiddleRight;
        // 
        // Password
        // 
        Password.Location = new Point(234, 352);
        Password.Margin = new Padding(2);
        Password.Multiline = true;
        Password.Name = "Password";
        Password.PasswordChar = '*';
        Password.Size = new Size(547, 36);
        Password.TabIndex = 4;
        // 
        // UserName
        // 
        UserName.Location = new Point(234, 296);
        UserName.Margin = new Padding(2);
        UserName.Multiline = true;
        UserName.Name = "UserName";
        UserName.Size = new Size(547, 36);
        UserName.TabIndex = 2;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
        label2.Location = new Point(41, 365);
        label2.Margin = new Padding(2, 0, 2, 0);
        label2.Name = "label2";
        label2.Size = new Size(67, 20);
        label2.TabIndex = 1;
        label2.Text = "Пароль";
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
        label1.Location = new Point(41, 308);
        label1.Margin = new Padding(2, 0, 2, 0);
        label1.Name = "label1";
        label1.Size = new Size(153, 20);
        label1.TabIndex = 0;
        label1.Text = "Имя пользователя";
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(795, 509);
        Controls.Add(panel1);
        Margin = new Padding(2);
        Name = "Form1";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Form1";
        Load += Form1_Load;
        KeyDown += Form1_KeyDown;
        panel1.ResumeLayout(false);
        panel1.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        ResumeLayout(false);
    }

    private Panel panel1;
    private Label label3;
    private TextBox Password;
    private TextBox UserName;
    private Label label2;
    private Label label1;
    private PictureBox pictureBox1;
    private Label label5;
    private Label label4;
    private Button CloseButton;
    private Button EnterButton;
    private Label CapsLockFlagLabel;
    private Label CurrentLanguageLabel;
}