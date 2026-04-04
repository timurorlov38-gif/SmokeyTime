using System.Windows;

namespace SmokeyTime
{
    public partial class WarehouseAcceptanceWindow : Window
    {
        public WarehouseAcceptanceWindow()
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
            var settingsWindow = new SettingsWindow();
            settingsWindow.Show();
            this.Close();
        }

        private void AcceptProductButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Товар успешно принят", "Успешно", MessageBoxButton.OK, MessageBoxImage.Information);
            var warehouseWindow = new WarehouseWindow();
            warehouseWindow.Show();
            this.Close();
        }
    }
}