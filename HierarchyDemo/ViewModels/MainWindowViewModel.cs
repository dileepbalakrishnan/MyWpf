using System.Windows.Input;
using HierarchyDemo.Commands;

namespace HierarchyDemo.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private readonly CustomerListViewModel _customerListViewModel = new CustomerListViewModel();
        private readonly OrderViewModel _orderViewModel = new OrderViewModel();

        private BindableBase _currentView;

        public MainWindowViewModel()
        {
            NavigationCommand = new HierarchyCommand<string>(OnNavigation);
        }

        public BindableBase CurrentView
        {
            get => _currentView;
            set => SetProperty(ref _currentView, value);
        }

        public ICommand NavigationCommand { get; set; }

        public void OnNavigation(string commandParameter)
        {
            switch (commandParameter)
            {
                case HierarchyCommands.CustomerListView:
                    CurrentView = _customerListViewModel;
                    break;
                case HierarchyCommands.OderView:
                    CurrentView = _orderViewModel;
                    break;
            }
        }
    }

    public static class HierarchyCommands
    {
        public const string CustomerListView = "CustomerListView";
        public const string OderView = "OrderView";
    }
}