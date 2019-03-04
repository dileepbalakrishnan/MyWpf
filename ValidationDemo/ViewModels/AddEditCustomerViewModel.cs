using System;
using ValidationDemo.Commands;
using ValidationDemo.Models;

namespace ValidationDemo.ViewModels
{
    public class AddEditCustomerViewModel : BindableBase
    {
        private SimpleEditableCustomer _Customer;

        private bool _EditMode;

        public AddEditCustomerViewModel()
        {
            CancelCommand = new MyICommand(OnCancel);
            SaveCommand = new MyICommand(OnSave, CanSave);
            Customer = new SimpleEditableCustomer();
        }

        public MyICommand CancelCommand { get; }
        public MyICommand SaveCommand { get; }

        public bool EditMode
        {
            get => _EditMode;
            set => SetProperty(ref _EditMode, value);
        }

        public SimpleEditableCustomer Customer
        {
            get => _Customer;
            set => SetProperty(ref _Customer, value);
        }

        private void RaiseCanExecuteChanged(object sender, EventArgs e)
        {
            SaveCommand.RaiseCanExecuteChanged();
        }

        private bool CanSave()
        {
            return !Customer.HasErrors;
        }

        private void OnSave()
        {
        }

        private void OnCancel()
        {
        }
    }
}