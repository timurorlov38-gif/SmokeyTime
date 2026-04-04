using System;
using System.Windows;
using System.Windows.Controls;

namespace SmokeyTime
{
    public partial class POSView : UserControl
    {
        private int _cartItemsCount = 0;
        private decimal _cartTotal = 0;

        public POSView()
        {
            InitializeComponent();
            SessionInfoText.Text = $"Смена открыта: {DateTime.Now:dd.MM.yyyy, HH:mm:ss}";
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
    }
}
