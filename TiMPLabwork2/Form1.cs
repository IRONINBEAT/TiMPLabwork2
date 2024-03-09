using System.Reflection;

namespace TiMPLabwork2;

public partial class Form1 : Form
{
    System.Windows.Forms.Timer formTimer = new System.Windows.Forms.Timer();
    private readonly UserManager userManager;
    Assembly assembly = Assembly.GetExecutingAssembly();


    public Form1()
    {
        InitializeComponent();
        userManager = new UserManager();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        formTimer.Interval = 500;
        formTimer.Start();
        formTimer.Tick += new EventHandler(FormTimer_Tick);
        label4.Text = "������: " + assembly.GetName().Version.ToString();
    }


    private void FormTimer_Tick(object sender, EventArgs e)
    {
        CapsLockFlagLabel.Text = (Console.CapsLock ? "������� CapsLock ������" : "");
        if (InputLanguage.CurrentInputLanguage.LayoutName == "���")
            CurrentLanguageLabel.Text = "���� ����� ����������";
        else if (InputLanguage.CurrentInputLanguage.LayoutName == "�������")
            CurrentLanguageLabel.Text = "���� ����� �������";
    }

    private void Form1_KeyDown(object sender, KeyEventArgs e)
    {
        CapsLockFlagLabel.Text = (Console.CapsLock ? "������� CapsLock ������" : "");
        if (InputLanguage.CurrentInputLanguage.LayoutName == "���")
            CurrentLanguageLabel.Text = "���� ����� ����������";
        else if (InputLanguage.CurrentInputLanguage.LayoutName == "�������")
            CurrentLanguageLabel.Text = "���� ����� �������";
    }

    private void EnterButton_Click(object sender, EventArgs e)
    {

    }

    private void CloseButton_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }

    private void btnLogin_Click(object sender, EventArgs e)
    {
        string username = UserName.Text.Trim();
        string password = Password.Text.Trim();

        User user = userManager.Authenticate(username, password);

        if (user != null)
        {
            Menu menu = new Menu(user); 
            menu.Show();
            Hide();
        }
        else
        {
            MessageBox.Show("������������ ����� ��� ������.");
        }
    }

    private bool IsValidLogin(string username, string password)
    {
        string filePath = "C:\\Users\\IRONIN\\RiderProjects\\TestLogic\\TestLogic\\bin\\Debug\\net7.0\\USERS.txt"; // ���� � ����� � ������� � �������������

        // ��������� ������������� �����
        if (!File.Exists(filePath))
        {
            MessageBox.Show("���� � ������� ������������� �� ������.");
            return false;
        }

        // ��������� ������ �� �����
        string[] lines = File.ReadAllLines(filePath);

        // �������� �� ������ ������ �����
        for (int i = 0; i < lines.Length; i++)
        {
            // ������� ������, ������������ � "#", ������� �������� ����� � ������
            if (lines[i].StartsWith("#"))
            {
                string[] parts = lines[i].Substring(1).Split(' ');
                if (parts[0] == username && parts[1] == password)
                    return true;
            }
        }

        // ���� �� ������� ���������������� ������������
        return false;
    }

}