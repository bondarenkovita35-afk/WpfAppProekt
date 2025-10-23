using System.Windows;
using WpfAppProekt.ViewModels;

namespace WpfAppProekt
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainViewModel();
        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }

        private void ProductFormView_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }    
}
