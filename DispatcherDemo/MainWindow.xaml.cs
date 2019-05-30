using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
using System.Windows.Threading;

namespace DispatcherDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnCalculate_Click(object sender, RoutedEventArgs e)
        {
            var from = int.Parse(txtFrom.Text);
            var to = int.Parse(txtTo.Text);
            btnCalculate.IsEnabled = false;
            var sc = SynchronizationContext.Current;
            ThreadPool.QueueUserWorkItem( (obj)=>
            {
                var primesCount = CountPrimes(from, to);
                //Dispatcher.BeginInvoke(new Action(() =>
                //{
                //    txtBlCount.Text = string.Format($"Number of primes : {primesCount}");
                //    btnCalculate.IsEnabled = true;
                //}));
                sc.Post(delegate
                {
                    txtBlCount.Text = string.Format($"Number of primes : {primesCount}");
                    btnCalculate.IsEnabled = true;
                }, null);
            });
        }

        private int CountPrimes(int from, int to)
        {
            int total = 0;
            for (int i = from; i <= to; i++)
            {
                bool isPrime = true;
                int limit = (int)Math.Sqrt(i);
                for (int j = 2; j <= limit; j++)
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                if (isPrime)
                    total++;
            }
            return total;
        }

    }
}
