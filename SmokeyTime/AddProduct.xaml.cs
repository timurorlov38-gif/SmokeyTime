using System.Windows;

namespace SmokeyTime
{
    public partial class AddProductWindow : Window
    {
        public AddProductWindow()
        {
            InitializeComponent();
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            // Валидация полей
            if (string.IsNullOrWhiteSpace(ProductNameTextBox.Text))
            {
                MessageBox.Show("Введите название товара", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(BarcodeTextBox.Text))
            {
                MessageBox.Show("Введите штрихкод", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            MessageBox.Show("Товар успешно добавлен", "Успешно", MessageBoxButton.OK, MessageBoxImage.Information);
            this.Close();
        }
    }
}