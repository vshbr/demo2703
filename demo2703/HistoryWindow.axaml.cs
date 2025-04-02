using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using demo2703.Models;
using System.Collections.Generic;
using System.Linq;

namespace demo2703;

public partial class HistoryWindow : Window
{
    public List<HistorySale> HistorySale = Helper.Context.HistorySales.ToList();
    public HistoryWindow()
    {
        InitializeComponent();
        HistoryListBox.ItemsSource = HistorySale;
    }

    public void Button_OnClick_Back(object? sender, RoutedEventArgs e)
    {
        MainWindow MainWindow = new MainWindow();
        MainWindow.Show();
        Close();
    }
}