using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;

namespace DataTemplateSelectorDemo
{
    public class ProcessTemplateSelector : DataTemplateSelector
    {
        public string SystemProcessTemplate { get; set; }
        public string UserProcessTemplate { get; set; }

        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            var process = (Process) item;
            return ((FrameworkElement) container).FindResource
            (
                process.SessionId == 0 ? SystemProcessTemplate : UserProcessTemplate
            ) as DataTemplate;
        }
    }
}