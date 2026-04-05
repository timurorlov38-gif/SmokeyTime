using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace SmokeyTime
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            // Загружаем панель управления по умолчанию
            MainFrame.Content = new DashboardView();
        }
        private void TabButton_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            if (button == null || button.Tag == null) return;
            int tabIndex = int.Parse(button.Tag.ToString());
            // Обновляем стили кнопок
            UpdateButtonStyles(button);
            // Переключаем содержимое в зависимости от вкладки
            switch (tabIndex)
            {
                case 0: // Панель управления
                    MainFrame.Content = new DashboardView();
                    break;
                case 1: // Касса
                    MainFrame.Content = new POSView();
                    break;
                case 2: // Склад
                    MainFrame.Content = new WarehouseView();
                    break;
                case 3: // Отчёты
                    MainFrame.Content = new ReportsView();
                    break;
                case 4: // Настройки
                    MainFrame.Content = new SettingsView();
                    break;
            }
        }
        private void UpdateButtonStyles(Button activeButton)
        {
            // Находим все кнопки в панели навигации
            var navigationPanel = FindName("NavigationPanel") as StackPanel;
            if (navigationPanel == null) return;

            foreach (var child in navigationPanel.Children)
            {
                if (child is Button btn)
                {
                    if (btn == activeButton)
                    {
                        btn.Background = (Brush)colorConverter.ConvertFromString("#374151");
                        btn.Foreground = (Brush)brushConverter.ConvertFromString("White");
                        btn.FontWeight = FontWeights.SemiBold;
                    }
                    else
                    {
                        btn.Background = Brushes.Transparent;
                        btn.Foreground = (Brush)brushConverter.ConvertFromString("#d1d5db");
                        btn.FontWeight = FontWeights.Normal;
                    }
                }
            }
        }
    }
}