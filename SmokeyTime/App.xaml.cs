using System.Windows;

namespace SmokeyTime
{
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            // Создаём и показываем только окно авторизации
            var loginWindow = new LoginWindow();
            loginWindow.Show();
        }
    }
}