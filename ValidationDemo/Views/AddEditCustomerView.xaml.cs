using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ValidationDemo.Models;
using ValidationDemo.ViewModels;

namespace ValidationDemo.Views
{
    /// <summary>
    /// Interaction logic for AddEditCustomerView.xaml
    /// </summary>
    public partial class AddEditCustomerView : UserControl
    {
        AddEditCustomerViewModel _addEditCustomerViewModel = new AddEditCustomerViewModel();
        public AddEditCustomerView()
        {
            //_addEditCustomerViewModel.Customer = new SimpleEditableCustomer { FirstName = "D", LastName = "B" };
            DataContext = _addEditCustomerViewModel;
            InitializeComponent();
        }
    }
}
