namespace Library;

public class Service
{
    public string Name { get; set; }
    public Employee employee { get; }

    public double Price { get; set; }
    public bool Availability { get; set; }
    public Service(string Name, Employee employee, double Price, bool Availability)
    {
        this.Name = Name;
        this.employee = employee;
        this.Price = Price;
        this.Availability = Availability;
    }

    public void SetAvailability()
    {

    }

}