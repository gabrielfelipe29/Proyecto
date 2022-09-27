using System.Collections.Generic;
namespace Library;

public class Employee : IPerson
{
    public string Name { get; set; }
    public string UserName { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public int PhoneNumber { get; set; }
    public Location Location { get; set; }
    public List<Request> RequestList { get; set; }
    public void Register()
    {

    }
    public void Login()
    {

    }
    public Service CreateService()
    {
        //sale error porque falta el valor a retornar (de tipo Service)
        return new Service("", new Employee(), 0.0, true);
    }
    public double GetRatingAverage()
    {
        //sale error porque falta el valor a retornar (un double)
        return 0.0;
    }
    public void AddRequest()
    {

    }

}