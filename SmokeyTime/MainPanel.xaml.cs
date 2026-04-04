using System.Windows;
using System.Windows.Controls;

namespace SmokeyTime
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void NavButton_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            if (button == null) return;

            string target = button.Content.ToString();
            Window newWindow = null;

            // Старый синтаксис if-else для совместимости
            if (target == "Панель управления")
            {
                newWindow = null; // Уже на главной
            }
            else if (target == "Касса")
            {
                newWindow = new POSWindow();
            }
            else if (target == "Склад")
            {
                newWindow = new WarehouseWindow();
            }
            else if (target == "Отчёты")
            {
                newWindow = new ReportsWindow();
            }
            else if (target == "Настройки")
            {
                newWindow = new SettingsWindow();
            }

            if (newWindow != null)
            {
                newWindow.Show();
                this.Close();
            }
        }

        private void OpenCashRegisterButton_Click(object sender, RoutedEventArgs e)
        {
            var posWindow = new POSWindow();
            posWindow.Show();
            this.Close();
        }

        private void WarehouseManagementButton_Click(object sender, RoutedEventArgs e)
        {
            var warehouseWindow = new WarehouseWindow();
            warehouseWindow.Show();
            this.Close();
        }

        private void ReportsAnalyticsButton_Click(object sender, RoutedEventArgs e)
        {
            var reportsWindow = new ReportsWindow();
            reportsWindow.Show();
            this.Close();
        }
    } // ← Закрывающая скобка класса должна быть ЗДЕСЬ
}