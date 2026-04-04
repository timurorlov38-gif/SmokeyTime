using System.Windows;

namespace SmokeyTime
{
    public partial class WarehouseWriteOffWindow : Window
    {
        public WarehouseWriteOffWindow()
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

        private void WriteOffProductButton_Click(object sender, RoutedEventArgs e)
        {
            var result = MessageBox.Show("Вы уверены, что хотите списать товар?", "Подтверждение",
                MessageBoxButton.YesNo, MessageBoxImage.Warning);
            if (result == MessageBoxResult.Yes)
            {
                MessageBox.Show("Товар успешно списан", "Успешно", MessageBoxButton.OK, MessageBoxImage.Information);
                var warehouseWindow = new WarehouseWindow();
                warehouseWindow.Show();
                this.Close();
            }
        }
    }
}