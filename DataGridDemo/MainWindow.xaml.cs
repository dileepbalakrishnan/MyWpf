﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace DataGridDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            DataContext = new List<PersonInfo> {
                new PersonInfo { FirstName = "Bart", LastName = "Simpson",
                    Email = "bart@runaway.com", IsEmployed = false,
                    Gender = Gender.Male,
                    Avatar = new Uri("Images/sun.png", UriKind.Relative) },
                new PersonInfo { FirstName = "Homer", LastName = "Simpson",
                    Email = "homer@springfield.com", IsEmployed = true,
                    Gender = Gender.Male, Avatar =
                        new Uri("Images/worker.png", UriKind.Relative) },
                new PersonInfo { FirstName = "Marge", LastName = "Simpson",
                    Email = "marge@desparatehousewives.com",
                    IsEmployed = false, Gender = Gender.Female,
                    Avatar = new Uri("Images/violin.png", UriKind.Relative) },
                new PersonInfo { FirstName = "Lisa", LastName = "Simpson",
                    Email = "lisa@musiclovers.com", IsEmployed = false,
                    Gender = Gender.Female, Avatar = new Uri(
                        "Images/woman.png", UriKind.Relative) },
                new PersonInfo { FirstName = "Maggie", LastName = "Simpson",
                    IsEmployed = false, Gender = Gender.Female,
                    Avatar = new Uri("Images/wine.png", UriKind.Relative) }
            };
        }

        private void DataGrid_OnAutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs e)
        {
            e.Cancel = e.PropertyName == "Avatar";
        }

        private void DataGrid_OnAutoGeneratedColumns(object sender, EventArgs e)
        {
            ((DataGrid) sender).Columns[0].DisplayIndex = 5;
        }
    }

    enum Gender
    {
        Unknown,
        Male,
        Female
    }

    class PersonInfo
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public Gender Gender { get; set; }
        public bool IsEmployed { get; set; }
        public Uri Avatar { get; set; }
    }
}