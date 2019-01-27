﻿using System.Diagnostics;
using System.Windows;

namespace DataTemplateSelectorDemo
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
    }
}