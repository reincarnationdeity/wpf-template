using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Json;
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

namespace AirportManagementSystem.Pages
{
    /// <summary>
    /// Логика взаимодействия для BuyTicket.xaml
    /// </summary>
    /// 


    public partial class BuyTicket : Page
    {

        public static Plane route;
        private static readonly HttpClient client = new HttpClient();

        public BuyTicket()
        {
            InitializeComponent();
            ticketInfo.IsReadOnly = true;
            ticketInfo.Text += "\n" + "Number of route: " + route.icaoCode
                + "Departure point: " + route.departurePoint + "\n" +
                "Departure time: " + route.departureTime + "\n"+
                "Arrival point: " + route.arrivalPoint +
                "Arrival time: " + route.arrivalTime + "\n" + 
                "Carried by: " + route.company + ".";
                ;
            ticketInfo.VerticalScrollBarVisibility = ScrollBarVisibility.Visible;
        }

        private void buyButton_Click(object sender, RoutedEventArgs e)
        {
            PageManager.mainFrame.NavigationService.GoBack();
        }

        private void cancelButton_Click(object sender, RoutedEventArgs e)
        {
        }
    }
}
