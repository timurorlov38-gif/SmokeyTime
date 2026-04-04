using System.Windows;

namespace SmokeyTime
{
    public partial class WarehouseWindow : Window
    {
        public WarehouseWindow()
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
            // Уже на складе
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

        private void AddProductButton_Click(object sender, RoutedEventArgs e)
        {
            var addProductWindow = new AddProductWindow();
            addProductWindow.Owner = this;
            addProductWindow.ShowDialog();
        }

        private void AcceptanceTab_Click(object sender, RoutedEventArgs e)
        {
            var acceptanceWindow = new WarehouseAcceptanceWindow();
            acceptanceWindow.Show();
            this.Close();
        }

        private void WriteOffTab_Click(object sender, RoutedEventArgs e)
        {
            var writeOffWindow = new WarehouseWriteOffWindow();
            writeOffWindow.Show();
            this.Close();
        }

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Редактирование товара", "Инфо", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            var result = MessageBox.Show("Вы уверены, что хотите удалить товар?", "Подтверждение",
                MessageBoxButton.YesNo, MessageBoxImage.Warning);
            if (result == MessageBoxResult.Yes)
            {
                MessageBox.Show("Товар удалён", "Успешно", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
    }
}