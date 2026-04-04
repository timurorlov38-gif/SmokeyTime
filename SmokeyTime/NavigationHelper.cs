using System.Windows;
using System.Windows.Controls;

namespace SmokeyTime
{
    public static class NavigationHelper
    {
        public static void NavigateToWindow(Window currentWindow, Window newWindow)
        {
            if (newWindow != null)
            {
                newWindow.Show();
                currentWindow.Close();
            }
        }

        public static void HandleNavigation(Button button, Window currentWindow)
        {
            string buttonContent = button.Content as string;

            Window targetWindow = null;

            if (buttonContent == "Панель управления")
            {
                targetWindow = new MainWindow();
            }
            else if (buttonContent == "Касса")
            {
                targetWindow = new POSWindow();
            }
            else if (buttonContent == "Склад")
            {
                targetWindow = new WarehouseWindow();
            }
            else if (buttonContent == "Отчёты")
            {
                targetWindow = new ReportsWindow();
            }
            else if (buttonContent == "Настройки")
            {
                targetWindow = new SettingsWindow();
            }

            if (targetWindow != null && targetWindow.GetType() != currentWindow.GetType())
            {
                NavigateToWindow(currentWindow, targetWindow);
            }
        }
    }
}