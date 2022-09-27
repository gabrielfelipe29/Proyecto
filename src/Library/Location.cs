using System; 
namespace Library;
public class Location
{

    public Location (string streetName, int doorNumber, double latitude, double longitude)
    {

        this.StreetName = streetName;
        this.DoorNumber = doorNumber;
        this.Latitude = latitude;
        this.Longitude = longitude;
       
    }

    
    public string StreetName { get; set; }
    public int DoorNumber { get; set; }
    public double Latitude { get; set; }
    public double Longitude  { get; set; }

    public void CalculateDistance() //Este método calcula la distancia entre el Employer y el Employee.
    {

    }
}