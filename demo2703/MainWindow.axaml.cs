using Avalonia.Controls;
using demo2703.Models;
using demo2703.Context;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace demo2703
{
    public partial class MainWindow : Window
    {
        public List<Partner> Partner = Helper.Context.Partners.ToList();
        public MainWindow()
        {
            InitializeComponent();
            PartnerListBox.ItemsSource = Partner;
        }

        private void Button_Click_History(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            HistoryWindow  historyWindow =  new HistoryWindow();
            historyWindow.Show();
            Close();
        }

        private void Button_Click_Add(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            AddWindow addWindow = new AddWindow();
            addWindow.Show();
            Close();
        }
    }
}