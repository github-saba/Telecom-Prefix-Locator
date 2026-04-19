using System.Windows;
using TelecomLocator.ViewModels;

namespace TelecomLocator
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
            // This connects the UI to the ViewModel
            this.DataContext = new MainViewModel();
        }
    }
}
