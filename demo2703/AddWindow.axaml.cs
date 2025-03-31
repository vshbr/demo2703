using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using demo2703.Models;

namespace demo2703;

public partial class AddWindow : Window
{
    private Partner _partner;
    public AddWindow()
    {
        InitializeComponent();

        _partner = new Partner(); 
        TypeComboBox.ItemsSource = Helper.Context.Partners; 
        PartnerPanel.DataContext = _partner;
    }

    public void Button_OnClick_Back(object? sender, RoutedEventArgs e) 
    {
        MainWindow MainWindow = new MainWindow();
        MainWindow.Show(); 
        Close(); 
    }

    public void Button_Click_Save(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        if (_partner.Partnersid == 0) 
        { 
            Helper.Context.Partners.Add(_partner); 
            Helper.Context.SaveChanges(); 
        } 
        else 
        { 
            Helper.Context.Partners.Update(_partner); 
            Helper.Context.SaveChanges(); 
        }

        MainWindow MainWindow = new MainWindow();
        MainWindow.Show();
        Close();
    }
}
