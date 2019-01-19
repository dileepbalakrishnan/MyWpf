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
using System.Xml.Linq;

namespace BinaryResourceAccessInCode
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

        private void ButtonBase_OnClick1(object sender, RoutedEventArgs e)
        {
            var binResourceStream = Application.GetResourceStream(new Uri("ResourceBooks.xml", UriKind.Relative));
            if (binResourceStream != null)
            {
                var bookStream = XElement.Load(binResourceStream.Stream);
                var bookList = bookStream.Elements("Book").OrderBy(b => (string) b.Attribute("Author")).Select(b =>
                    new
                    {
                        Name = (string) b.Attribute("Name"),
                        Author = (string) b.Attribute("Author")
                    });
                foreach (var book in bookList)
                {
                    textBox1.Text += book.Name + " (" + book.Author + ")" + Environment.NewLine;
                }
            }
        }

        private void ButtonBase_OnClick2(object sender, RoutedEventArgs e)
        {
            var binContentStream = Application.GetContentStream(new Uri("ContentBooks.xml", UriKind.Relative));
            if (binContentStream != null)
            {
                var bookStream = XElement.Load(binContentStream.Stream);
                var bookList = bookStream.Elements("Book").OrderBy(b => (string)b.Attribute("Author")).Select(b =>
                    new
                    {
                        Name = (string)b.Attribute("Name"),
                        Author = (string)b.Attribute("Author")
                    });
                foreach (var book in bookList)
                {
                    textBox2.Text += book.Name + " (" + book.Author + ")" + Environment.NewLine;
                }
            }
        }
    }
}
