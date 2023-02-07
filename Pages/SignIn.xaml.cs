using System.Windows;
using System.Windows.Controls;

namespace AirportManagementSystem.Pages;

public partial class SignIn : Page
{
    public SignIn()
    {
        InitializeComponent();
    }

    private void EnterBtn_OnClick(object sender, RoutedEventArgs e)
    {
        PageManager.mainFrame.NavigationService.Navigate(new GridViewPage());
    }
}