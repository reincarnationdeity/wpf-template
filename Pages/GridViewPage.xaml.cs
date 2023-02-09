using System.Collections.Generic;
using System.Windows.Controls;
using System.IO;
using System.Net;
using Newtonsoft.Json;
using ModernWpf.Controls;

namespace AirportManagementSystem.Pages;

public partial class GridViewPage : System.Windows.Controls.Page
{
    List<Plane> schedule;

    public GridViewPage()
    {

        InitializeComponent();
        string json = File.ReadAllText("Resources\\schedule.json");
        schedule = JsonConvert.DeserializeObject<List<Plane>>(json);
        planes_schedule_grid.ItemsSource = schedule;
    }

    public void setObject()
    {
        int index = planes_schedule_grid.SelectedIndex;
        BuyTicket.route = new Plane(schedule[index].departurePoint, schedule[index].arrivalPoint, schedule[index].departureTime, schedule[index].arrivalTime, schedule[index].icaoCode, schedule[index].company);
    }

    private void seeMoreBtn_Click(object sender, System.Windows.RoutedEventArgs e)
    {
        ContentDialog moreInformation = new ContentDialog();
        if (planes_schedule_grid.SelectedIndex != -1)
        {
            int index = planes_schedule_grid.SelectedIndex;
            moreInformation.Title = "Information about " + schedule[planes_schedule_grid.SelectedIndex].icaoCode + " route:";
            moreInformation.Content = "Departure Point: " + schedule[index].departurePoint + "\n" +
                "Departure time: " + schedule[index].departureTime + " UTC.\n" +
                "Arrival Point: " + schedule[index].arrivalPoint + "\n" +
                "Arrival Time: " + schedule[index].arrivalTime + " UTC.\n" +
                "Route carried by: " + schedule[index].company;
            moreInformation.CloseButtonText = "OK";
            moreInformation.PrimaryButtonText = "Buy ticket";
            moreInformation.PrimaryButtonClick += MoreInformation_PrimaryButtonClick; ;
            moreInformation.Visibility = System.Windows.Visibility.Visible;
            moreInformation.ShowAsync();
        }
        else
        {
            moreInformation.Title = "Error!";
            moreInformation.Content = "You didnt select any route in sheet. Please, try again!";
            moreInformation.CloseButtonText = "Ok, i'll try again";
            moreInformation.ShowAsync();

        }
    }

    private void MoreInformation_PrimaryButtonClick(ContentDialog sender, ContentDialogButtonClickEventArgs args)
    {
        setObject();
        PageManager.mainFrame.NavigationService.Navigate(new BuyTicket());
    }

}