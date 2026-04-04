using System.Windows;
using System.Windows.Controls;

namespace SmokeyTime
{
    public partial class SettingsView : UserControl
    {
        public SettingsView()
        {
            InitializeComponent();
        }

        private void SaveSettingsButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Настройки успешно сохранены!", "Успешно", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void ChangePasswordButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Пароль успешно изменён!", "Успешно", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
