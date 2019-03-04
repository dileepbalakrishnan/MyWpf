using System;
using System.ComponentModel;
using System.Windows;

namespace SimpleMvvMDemo.Common
{
    public class VidewModelLocator : DependencyObject
    {
        public static readonly DependencyProperty AutoHookupViewModelProperty =
            DependencyProperty.RegisterAttached("AutoHookupViewModel", typeof(bool), typeof(VidewModelLocator),
                new PropertyMetadata(false, AutoHookupViewModelChanged));

        private static void AutoHookupViewModelChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (DesignerProperties.GetIsInDesignMode(d)) return;
            var viewType = d.GetType();
            var viewTypeName = viewType.FullName.Replace(".Views.", ".ViewModels.") + "Model";
            ((FrameworkElement) d).DataContext = Activator.CreateInstance(Type.GetType(viewTypeName));
        }

        public static bool GetAutoHookupViewModel(DependencyObject obj)
        {
            return (bool) obj.GetValue(AutoHookupViewModelProperty);
        }

        public static void SetAutoHookupViewModel(DependencyObject obj, bool value)
        {
            obj.SetValue(AutoHookupViewModelProperty, value);
        }
    }
}