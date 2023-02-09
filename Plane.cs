using System.Windows.Media.TextFormatting;

namespace AirportManagementSystem;

public class Plane
{
    public string departurePoint { get; set; }
    public string arrivalPoint { get; set; }
    public string departureTime { get; set; }
    public string arrivalTime { get; set; }
    public string icaoCode { get; set; }
    public string company { get; set; }

    public Plane(string departurePoint, string arrivalPoint, string departureTime, string arrivalTime, string icaoCode, string company)
    {
        this.departurePoint = departurePoint;
        this.arrivalPoint = arrivalPoint;
        this.departureTime = arrivalTime;
        this.arrivalTime = arrivalTime;
        this.icaoCode = icaoCode;
        this.company = company;
    }
    
    
}