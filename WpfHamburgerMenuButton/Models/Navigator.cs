using System.Windows.Input;
using WpfHamburgerMenuButton.Commands;

namespace WpfHamburgerMenuButton.Models
{
    public class Navigator : ObservableObject
    {
        private bool _displayCollapsed = false;
        public bool DisplayCollapsed { 
            get { return _displayCollapsed; } 
            set {
                _displayCollapsed = value;
                OnPropertyChanged(nameof(DisplayCollapsed));
            } 
        }
        
        private int _navigationWidth = 320;
        public int NavigationWidth { 
            get { return _navigationWidth; } 
            set {
                _navigationWidth = value;
                OnPropertyChanged(nameof(NavigationWidth));
            } 
        }

        public Navigator() {
            ToggleCollapsedCommand = new RelayCommand(ToggleCollapsedFunction);
        }

        private void ToggleCollapsedFunction(object parameter)
        {
            DisplayCollapsed = !DisplayCollapsed;
            NavigationWidth = DisplayCollapsed ? 40 : 320;
        }

        public ICommand ToggleCollapsedCommand { get; set; }
    }
}
