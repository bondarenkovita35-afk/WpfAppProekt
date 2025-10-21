using System.Windows;

namespace WpfApp1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // Обработчик нажатия кнопки
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string name = NameInput.Text.Trim();

            if (string.IsNullOrEmpty(name))
            {
                OutputText.Text = "Пожалуйста, введите имя.";
            }
            else
            {
                OutputText.Text = $"Привет, {name}!";
            }
        }
    }
}
