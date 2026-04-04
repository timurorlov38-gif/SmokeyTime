using System;
using System.Windows;
using System.Windows.Controls;

namespace SmokeyTime
{
    public partial class POSWindow : Window
    {
        private int _cartItemsCount = 0;
        private decimal _cartTotal = 0;

        public POSWindow()
        {
            InitializeComponent();
            UpdateSessionInfo();
        }

        private void UpdateSessionInfo()
        {
            SessionInfoText.Text = $"Смена открыта: {DateTime.Now:dd.MM.yyyy, HH:mm:ss}";
        }

        private void NavButton_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            if (button == null)
                return;

            string target = button.Content.ToString();
            Window newWindow = null;

            if (target == "Панель управления")
            {
                newWindow = new MainWindow();
            }
            else if (target == "Касса")
            {
                newWindow = null; // Уже в кассе
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

        private void AddToCartButton_Click(object sender, RoutedEventArgs e)
        {
            _cartItemsCount++;
            _cartTotal += 350;

            CartText.Text = $"Товаров: {_cartItemsCount}\nСумма: {_cartTotal} ₽";
            CheckoutButton.Visibility = Visibility.Visible;

            MessageBox.Show("Товар добавлен в чек", "Успешно", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void CheckoutButton_Click(object sender, RoutedEventArgs e)
        {
            var result = MessageBox.Show(
                $"Оплатить {_cartItemsCount} товаров на сумму {_cartTotal} ₽?",
                "Подтверждение оплаты",
                MessageBoxButton.YesNo,
                MessageBoxImage.Question);

            if (result == MessageBoxResult.Yes)
            {
                MessageBox.Show("Чек успешно оплачен!\nПечать чека...", "Оплата завершена", MessageBoxButton.OK, MessageBoxImage.Information);
                _cartItemsCount = 0;
                _cartTotal = 0;
                CartText.Text = "Корзина пуста";
                CheckoutButton.Visibility = Visibility.Collapsed;
            }
        }

        private void CloseSessionButton_Click(object sender, RoutedEventArgs e)
        {
            var result = MessageBox.Show(
                "Закрыть текущую смену?\nБудет сформирован Z-отчёт.",
                "Завершение смены",
                MessageBoxButton.YesNo,
                MessageBoxImage.Warning);

            if (result == MessageBoxResult.Yes)
            {
                MessageBox.Show("Смена закрыта.\nZ-отчёт сформирован.", "Смена завершена", MessageBoxButton.OK, MessageBoxImage.Information);
                var mainWindow = new MainWindow();
                mainWindow.Show();
                this.Close();
            }
        }
    }
}