namespace Library;


public class Request
{

    public bool Status { get; set;}

    public Service Service { get;}
    public Employer Employer { get; set;}
    public Employee Employee { get; set;}
    public Rating EmployeeRating { get; }
    public Rating EmployerRating { get;}



    public Request(bool Status, Service Service,Employer Employer, Employee Employee,Rating EmployeeRating,Rating EmployerRating)
    {
        this.Status = Status;
        this.Service = Service;
        this.Employer = Employer;
        this.Employee = Employee;
        this.EmployeeRating = EmployeeRating;
        this.EmployerRating = EmployerRating;

    }
    public void SetAvailability()
    {
    }
}