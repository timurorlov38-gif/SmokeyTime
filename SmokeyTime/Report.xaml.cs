using System.Windows;

namespace SmokeyTime
{
    public partial class ReportsWindow : Window
    {
        public ReportsWindow()
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
            // Уже в отчётах
        }

        private void SettingsButton_Click(object sender, RoutedEventArgs e)
        {
            var settingsWindow = new SettingsWindow();
            settingsWindow.Show();
            this.Close();
        }
    }
}