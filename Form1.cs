using Microsoft.Win32;

namespace HW_WF_02_10_2024
{
    public partial class Form1 : Form
    {
        private const string RegistryKeyPath = @"HKEY_CURRENT_USER\Software\UserSettingsRegistryApp";
        public Form1()
        {
            InitializeComponent();
            outPutTextBox.ReadOnly = true;
            textBox1.ReadOnly = true;
        }
        private void LoadUserData()
        {
            string savedText = (string)Registry.GetValue(RegistryKeyPath, "Field2", string.Empty);
            inputTextBox.Text = savedText;
            outPutTextBox.Text = savedText;
        }

        private void SaveUserData()
        {
            Registry.SetValue(RegistryKeyPath, "Field2", inputTextBox.Text);
        }
        private void loadButton_Click(object sender, EventArgs e)
        {
            LoadUserData();
            MessageBox.Show("Данные загружены.");
        }

        private void apllyButton_Click(object sender, EventArgs e)
        {
            SaveUserData();
            MessageBox.Show("Данные сохранены.");
        }

    }
}
