﻿using System;
using System.Windows;

namespace Client.Views.MainPage
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainPage : Window
    {
        public MainPage()
        {
            InitializeComponent();
        }

        public void Tabelle()
        {
            CsvSpeichernFactorie csvSpeichernFactorie = new CsvSpeichernFactorie();
        }
    }
}
