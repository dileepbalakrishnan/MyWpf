using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Data;
using System.Windows.Documents;

namespace SortingDemo
{
    /// <summary>
    ///     Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = Process.GetProcesses();
        }

        private void DoSort(object sender, RoutedEventArgs e)
        {
            var view = CollectionViewSource.GetDefaultView(DataContext);
            view.SortDescriptions.Clear();
            if (cmbSort.SelectedValue != null)
            {
                view.SortDescriptions.Add(new SortDescription((string)cmbSort.SelectedValue, chkDirection.IsChecked.Value ? ListSortDirection.Ascending : ListSortDirection.Descending));
            }
        }

        private void DoFilter(object sender, RoutedEventArgs e)
        {
            var view = CollectionViewSource.GetDefaultView(DataContext);
            if (string.IsNullOrEmpty(txtFilter.Text))
            {
                view.Filter = null;
            }
            else
            {
                view.Filter = o => ((Process) o).ProcessName.Contains(txtFilter.Text);
            }
        }
    }

    public class SortField
    {
        public string DisplayName { get; set; }
        public string PropertyName { get; set; }
    }

    public class  SortFieldList : List<SortField> { }
}