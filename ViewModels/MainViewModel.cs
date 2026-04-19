// This is the "Brain" of the app. It connects the UI to the Repository. It uses INotifyPropertyChanged to update the UI instantly.
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Threading.Tasks;
using Telecom-Prefix-Locator.Models;
using Telecom-Prefix-Locator.Data;

namespace Telecom-Prefix-Locator.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private readonly PlanRepository _repo = new PlanRepository();
        private string _searchText;
        
        public ObservableCollection<TelecomPlan> Results { get; set; } = new ObservableCollection<TelecomPlan>();

        public string SearchText
        {
            get => _searchText;
            set {
                _searchText = value;
                OnPropertyChanged("SearchText");
                var t = ExecuteSearch(); // Trigger async search as user types
            }
        }

        private async Task ExecuteSearch()
        {
            var data = await _repo.SearchPlansAsync(_searchText);
            Results.Clear();
            foreach (var item in data) Results.Add(item);
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string name) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}
