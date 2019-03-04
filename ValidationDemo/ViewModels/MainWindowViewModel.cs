using System.Windows.Input;
using ValidationDemo.Commands;

namespace ValidationDemo.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private readonly CustomerListViewModel _customerListViewModel = new CustomerListViewModel();
        private readonly OrderViewModel _orderViewModel = new OrderViewModel();
        private readonly AddEditCustomerViewModel _addEditCustomerViewModel = new AddEditCustomerViewModel();
        private BindableBase _currentView;

        public MainWindowViewModel()
        {
            NavigationCommand = new HierarchyCommand(OnNavigation);
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
                case HierarchyCommands.AddEditCustomerView:
                    CurrentView = _addEditCustomerViewModel;
                    break;
            }
        }
    }

    public static class HierarchyCommands
    {
        public const string CustomerListView = "CustomerListView";
        public const string OderView = "OrderView";
        public const string AddEditCustomerView = "AddEditCustomerView";
    }
}