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

using AirportManagementSystem.Pages;

namespace AirportManagementSystem
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainFrame.NavigationService.Navigate(new SignIn());
            PageManager.mainFrame = MainFrame;

        }

        private void GoBack_OnClick(object sender, RoutedEventArgs e)
        {
            PageManager.mainFrame.NavigationService.GoBack();
        }

        private void CloseBtn_OnClick(object sender, RoutedEventArgs e)
        { this.Close();
        }
    }
}