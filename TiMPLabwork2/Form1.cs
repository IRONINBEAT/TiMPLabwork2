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
        label4.Text = "Версия: " + assembly.GetName().Version.ToString();
    }


    private void FormTimer_Tick(object sender, EventArgs e)
    {
        CapsLockFlagLabel.Text = (Console.CapsLock ? "Клавиша CapsLock нажата" : "");
        if (InputLanguage.CurrentInputLanguage.LayoutName == "США")
            CurrentLanguageLabel.Text = "Язык ввода Английский";
        else if (InputLanguage.CurrentInputLanguage.LayoutName == "Русская")
            CurrentLanguageLabel.Text = "Язык ввода Русский";
    }

    private void Form1_KeyDown(object sender, KeyEventArgs e)
    {
        CapsLockFlagLabel.Text = (Console.CapsLock ? "Клавиша CapsLock нажата" : "");
        if (InputLanguage.CurrentInputLanguage.LayoutName == "США")
            CurrentLanguageLabel.Text = "Язык ввода Английский";
        else if (InputLanguage.CurrentInputLanguage.LayoutName == "Русская")
            CurrentLanguageLabel.Text = "Язык ввода Русский";
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
            MessageBox.Show("Неправильный логин или пароль.");
        }
    }

    private bool IsValidLogin(string username, string password)
    {
        string filePath = "C:\\Users\\IRONIN\\RiderProjects\\TestLogic\\TestLogic\\bin\\Debug\\net7.0\\USERS.txt"; // Путь к файлу с данными о пользователях

        // Проверяем существование файла
        if (!File.Exists(filePath))
        {
            MessageBox.Show("Файл с данными пользователей не найден.");
            return false;
        }

        // Считываем данные из файла
        string[] lines = File.ReadAllLines(filePath);

        // Проходим по каждой строке файла
        for (int i = 0; i < lines.Length; i++)
        {
            // Находим строку, начинающуюся с "#", которая содержит логин и пароль
            if (lines[i].StartsWith("#"))
            {
                string[] parts = lines[i].Substring(1).Split(' ');
                if (parts[0] == username && parts[1] == password)
                    return true;
            }
        }

        // Если не найдено соответствующего пользователя
        return false;
    }

}