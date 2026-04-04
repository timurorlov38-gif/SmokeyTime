using System.Windows;

namespace SmokeyTime
{
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            // Переход на главную панель
            var mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close(); // Закрываем окно авторизации
        }
    }
}