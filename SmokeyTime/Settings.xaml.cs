using System.Windows;

namespace SmokeyTime
{
    public partial class SettingsWindow : Window
    {
        public SettingsWindow()
        {
            InitializeComponent();
        }

        private void DashboardButton_Click(object sender, RoutedEventArgs e)
        {
            var mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void POSButton_Click(object sender, RoutedEventArgs e)
        {
            var posWindow = new POSWindow();
            posWindow.Show();
            this.Close();
        }

        private void WarehouseButton_Click(object sender, RoutedEventArgs e)
        {
            var warehouseWindow = new WarehouseWindow();
            warehouseWindow.Show();
            this.Close();
        }

        private void ReportsButton_Click(object sender, RoutedEventArgs e)
        {
            var reportsWindow = new ReportsWindow();
            reportsWindow.Show();
            this.Close();
        }

        private void SettingsButton_Click(object sender, RoutedEventArgs e)
        {
            // Уже в настройках
        }

        private void SaveSettingsButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Настройки сохранены", "Успешно", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void ChangePasswordButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Пароль успешно изменён", "Успешно", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}