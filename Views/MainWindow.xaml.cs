using System.Windows;
using Telecom-Prefix-Locator.ViewModels;

namespace Telecom-Prefix-Locator
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
